using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;
using System.Xml.XPath;

namespace OverwatchTracker
{
    public partial class Form1 : Form
    {

        public List<string> DataList = new List<string>();
        public string DataPath;
        public string xmlPath;
        public string DataFileName;

        public Form1()
        {
            InitializeComponent();

        }

        private void btnAddWin_Click(object sender, EventArgs e)
        {
            AddMatch("Victory");
        }

        private void btnAddLoss_Click(object sender, EventArgs e)
        {
            AddMatch("Defeat");
        }

        private void AddMatch(string winLoss)
        {
            if (String.IsNullOrEmpty(txtCurrentSR.Text))
            {
                MessageBox.Show("Current SR field is missing");
                return;
            }
            if (String.IsNullOrEmpty(txtNewSR.Text))
            {
                MessageBox.Show("New SR field is missing");
                return;
            }

            int diff = int.Parse(txtNewSR.Text) - int.Parse(txtCurrentSR.Text);

            if (diff > 50 | diff < -50)
            {
                DialogResult drResult = MessageBox.Show("The SR change is over 50 points.\n\nAre you sure you want to add this?",
                    "1337 Warning", MessageBoxButtons.YesNo);
                if (drResult == DialogResult.No)
                {
                    return;
                }
            }

            string hero;
            string _class;

            try
            {
                hero = treeHeroes.SelectedNode.Text;
                _class = treeHeroes.SelectedNode.Parent.Text;
            }
            catch (Exception)
            {
                DialogResult mboxResult = MessageBox.Show("Sure you do not want to select your mained hero?", "Sure?", MessageBoxButtons.YesNo);
                if (mboxResult == DialogResult.Yes)
                {
                    hero = "-";
                    _class = "-";
                }
                else
                {
                    return;
                }
            }

            string soloTeam = "-";

            if (rbtnSolo.Checked)
            {
                soloTeam = "Solo";
            }
            else if(rbtnTeam.Checked)
            {
                soloTeam = "Team";
            }

            string toAdd = String.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}", winLoss, txtNewSR.Text, diff, hero, _class, DateTime.Now.ToLocalTime(), soloTeam);

            DataList.Add(toAdd);

            dgvData.Rows.Add(winLoss, txtNewSR.Text, diff, hero, _class, DateTime.Now.ToLocalTime(), soloTeam);

            if (winLoss == "Victory")
            {
                dgvData.Rows[dgvData.Rows.Count - 2].Cells[0].Style.BackColor = Color.PaleGreen;
            }
            else if (winLoss == "Defeat")
            {
                dgvData.Rows[dgvData.Rows.Count - 2].Cells[0].Style.BackColor = Color.Pink;
            }

            SaveToTextFile();

            txtCurrentSR.Text = txtNewSR.Text;
            txtNewSR.Text = "";
            GetOverallDetails();
            GetHeroDetails();

            dgvData.FirstDisplayedScrollingRowIndex = dgvData.RowCount - 1;

        }

        private void SaveToTextFile()
        {
            var sb = new StringBuilder();

            var headers = dgvData.Columns.Cast<DataGridViewColumn>();
            sb.AppendLine(string.Join("\t", headers.Select(column => column.HeaderText).ToArray()));

            foreach (DataGridViewRow row in dgvData.Rows)
            {
                if (!row.IsNewRow)
                {
                    var cells = row.Cells.Cast<DataGridViewCell>();
                    sb.AppendLine(string.Join("\t", cells.Select(cell => cell.Value).ToArray()));

                }
            }

            File.WriteAllText(DataPath, sb.ToString());
        }

        private void GetHeroDetails()
        {
            if (!String.IsNullOrEmpty(cmboxHero.Text))
            {
                Statistics stats = new Statistics(dgvData);
                string searchColumn;
                string hero;
                string Queue = cmboxQueue.Text;
                if (cmboxHero.Text.Substring(0, 2) == "--")
                {
                    searchColumn = "Class";
                    hero = cmboxHero.Text.Substring(2, cmboxHero.Text.Length - 4);
                }
                else
                {
                    searchColumn = "Hero";
                    hero = cmboxHero.Text;
                }

                lblAvgVHero.Text = stats.GetHeroAverage(hero, searchColumn, Queue, dtpFrom.Value, dtpTo.Value, "Victory", 2);
                lblAvgDHero.Text = stats.GetHeroAverage(hero, searchColumn, Queue, dtpFrom.Value, dtpTo.Value, "Defeat", 2);
            }
        }

        private void GetOverallDetails()
        {
            Statistics stats = new Statistics(dgvData);
            string Queue = cmboxQueue.Text;
            lblChange.Text = stats.GetOverallStats("Sum", "Overall", Queue, dtpFrom.Value, dtpTo.Value, 2);
            lblAvgVictory.Text = stats.GetOverallStats("Average", "Victory", Queue, dtpFrom.Value, dtpTo.Value, 2);
            lblAvgLoss.Text = stats.GetOverallStats("Average", "Defeat", Queue, dtpFrom.Value, dtpTo.Value, 2);
            lblGamesPlayed.Text = stats.GetGamesPlayed("Overall", Queue, dtpFrom.Value, dtpTo.Value);
            lblGamesWon.Text = stats.GetGamesPlayed("Victory", Queue, dtpFrom.Value, dtpTo.Value);
            lblGamesLost.Text = stats.GetGamesPlayed("Defeat", Queue, dtpFrom.Value, dtpTo.Value);

            decimal _winLoss = (lblGamesPlayed.Text != "0") ? decimal.Parse(lblGamesWon.Text) / decimal.Parse(lblGamesPlayed.Text) : 0;
            lblWinRatio.Text = _winLoss.ToString("P2");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //Add XML with hero list for tree view and add button for adding additional heroes
            //Also populate combobox with hero list from xml
            DataPath = Properties.Settings.Default.DataBasePath;

            if (!File.Exists(DataPath))
            {
                if (!String.IsNullOrEmpty(DataPath))
                {
                    MessageBox.Show(String.Format("Could not find your previous datafile at:\n\n {0}\n\nA " +
                        "new empty database will be created but you can still browse for an old database " +
                        "using the Select Database under the Database manu.", DataPath));
                }

                string orgDatabasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Overwatch SR Tracker",
                    "Data", "OverwatchTrackerDatabase.txt");

                if (!File.Exists(orgDatabasePath))
                {
                    if (!Directory.Exists(Path.GetDirectoryName(orgDatabasePath)))
                    {
                        Directory.CreateDirectory(Path.GetDirectoryName(orgDatabasePath));
                    }
                    File.WriteAllText(orgDatabasePath, "Win/Loss\tSR\tSR Change\tMain Hero\tClass\tDate\tSolo/Team");
                }

                Properties.Settings.Default.DataBasePath = orgDatabasePath;
                Properties.Settings.Default.Save();
                DataPath = orgDatabasePath;
            }

            cmboxQueue.SelectedIndex = 0;

            SetDatabaseLabel();
            lblVersion.Text = "v." + Application.ProductVersion;
            PopulateHeroes();
            LoadData();
        }

        private void SetDatabaseLabel()
        {
            DataFileName = Path.GetFileName(DataPath);

            lblDatafile.Text = "Loaded database:\n" + DataFileName;
        }

        private void LoadData()
        {
            try
            {
                DataList = new List<string>(GetDataArray(DataPath));

                SetDatabaseLabel();
                PopulateDataGridFromTxt();
                GetOverallDetails();
                GetHeroDetails();
                SetDataGridColors();
                DisableDataGridSorting();

                txtCurrentSR.Text = DataList.Last().Split('\t')[1].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Could not load data properly.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DisableDataGridSorting()
        {
            foreach (DataGridViewColumn column in dgvData.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void PopulateDataGridFromTxt()
        {
            dgvData.Rows.Clear();
            bool firstLine = true;
            foreach (string line in DataList)
            {
                if (firstLine)
                {
                    firstLine = false;
                }
                else
                {
                    string[] splitLine = line.Split('\t');
                    dgvData.Rows.Add(splitLine[0], splitLine[1], splitLine[2], splitLine[3], splitLine[4], splitLine[5], splitLine[6]);

                }
            }

            dgvData.FirstDisplayedScrollingRowIndex = dgvData.RowCount - 1;
        }

        private void SetDataGridColors()
        {
            foreach (DataGridViewRow row in dgvData.Rows)
            {
                if (!row.IsNewRow)
                {
                    if (row.Cells[0].Value.ToString() == "Victory")
                    {
                        row.Cells[0].Style.BackColor = Color.PaleGreen;
                    }
                    else if (row.Cells[0].Value.ToString() == "Defeat")
                    {
                        row.Cells[0].Style.BackColor = Color.Pink;
                    }
                }
            }
        }

        private void PopulateHeroes()
        {
            try
            {
                treeHeroes.Nodes.Clear();
                cmboxHero.Items.Clear();

                xmlPath = Path.Combine(Environment.CurrentDirectory, "XML", "Heroes.xml");
                XDocument xd = XDocument.Load(xmlPath);

                var heroList = xd.XPathSelectElements(@"//HeroList/Class");
                TreeNode classHeroNodes = new TreeNode();
                foreach (XElement heroClass in heroList)
                {
                    string className = heroClass.XPathSelectElement("Name").Value;
                    TreeNode ClassNode = new TreeNode(className);

                    cmboxHero.Items.Add("--" + className + "--");

                    foreach (XElement hero in heroClass.XPathSelectElements("Heroes/Hero"))
                    {
                        string heroInClass = hero.Value;
                        TreeNode heroNode = new TreeNode(heroInClass);
                        ClassNode.Nodes.Add(heroNode);

                        cmboxHero.Items.Add(heroInClass);

                    }
                    treeHeroes.Nodes.Add(ClassNode);
                }

                treeHeroes.ExpandAll();

            }
            catch (Exception)
            {
                MessageBox.Show("Could not load hero list.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string[] GetDataArray(string path)
        {
            return System.IO.File.ReadAllLines(path);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            GetOverallDetails();
            GetHeroDetails();
        }

        private void btnUpdateDatabase_Click(object sender, EventArgs e)
        {
            //Save changes to dtv to database 
            SaveToTextFile();
            MessageBox.Show("Database updated");
            GetHeroDetails();
            GetOverallDetails();
        }

        private void dgvData_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            GetOverallDetails();
            GetHeroDetails();
            SetDataGridColors();
        }

        private void insertRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dgvData.Rows.Insert(dgvData.SelectedRows[0].Index, "");

            }
            catch (Exception)
            {
                MessageBox.Show("First select the entire row");
            }
        }

        private void deleteRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgvRow in dgvData.SelectedRows)
            {
                dgvData.Rows.Remove(dgvRow);
            }

            List<string> UpdatedDataList = CreateListFromDataGrid();

            txtCurrentSR.Text = UpdatedDataList.Last().Split('\t')[1].ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetHeroDetails();
            GetOverallDetails();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetOverallDetails();
            GetHeroDetails();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void createNewDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

            saveFileDialog1.CreatePrompt = true;
            saveFileDialog1.OverwritePrompt = true;


            saveFileDialog1.FileName = "OverwatchTrackerDatabase";
            // DefaultExt is only used when "All files" is selected from 
            // the filter box and no extension is specified by the user.
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter =
                "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.InitialDirectory = Path.GetDirectoryName(DataPath);

            DialogResult result = saveFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, "Win/Loss\tSR\tSR Change\tMain Hero\tClass\tDate\tSolo/Team");
                Properties.Settings.Default.DataBasePath = saveFileDialog1.FileName;
                Properties.Settings.Default.Save();
                DataPath = saveFileDialog1.FileName;
                try
                {
                    LoadData();
                }
                catch (Exception)
                {

                }
            }
        }

        private void createBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string backupFilename = Path.Combine(Path.GetDirectoryName(Properties.Settings.Default.DataBasePath),
                Path.GetFileNameWithoutExtension(Properties.Settings.Default.DataBasePath) + "_" +
                GetSafeFilename(DateTime.Now.ToLocalTime().ToString() +
                Path.GetExtension(Properties.Settings.Default.DataBasePath)));
            try
            {
                File.Copy(Properties.Settings.Default.DataBasePath, backupFilename);
                MessageBox.Show("Backup created");
            }
            catch (Exception)
            {
                MessageBox.Show("Could not create a backup!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void selectDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Path.GetDirectoryName(DataPath);
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = false;
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.DataBasePath = openFileDialog1.FileName;
                Properties.Settings.Default.Save();
                DataPath = openFileDialog1.FileName;
                try
                {
                    LoadData();
                }
                catch (Exception)
                {

                }
            }
        }

        public string GetSafeFilename(string filename)
        {
            return string.Join("_", filename.Split(Path.GetInvalidFileNameChars()));
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void openDatabaseTextfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Settings.Default.DataBasePath);
        }

        private void btnAddHero_Click(object sender, EventArgs e)
        {

            string newHero = txtNewHero.Text;

            if (String.IsNullOrEmpty(newHero))
            {
                MessageBox.Show("Please name the new hero by entering a name in the textbox");
                return;
            }

            try
            {
                if (treeHeroes.SelectedNode.Parent != null)
                {
                    MessageBox.Show("Please select a class to add the new hero to in the hierarchy above");
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a class to add the new hero to in the hierarchy above");
                return;
            }

            string toClass = treeHeroes.SelectedNode.Text;

            XDocument xd = XDocument.Load(xmlPath);

            xd.XPathSelectElement("HeroList/Class/Name[text()='" + toClass + "']/../Heroes").Add(new XElement("Hero", newHero));
            xd.Save(xmlPath);

            PopulateHeroes();

            MessageBox.Show(String.Format("Added hero '{0}' to class '{1}'", newHero, toClass));

        }

        private void reloadDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            List<string> dgvList = CreateListFromDataGrid();
            DataList = new List<string>(GetDataArray(DataPath));

            var firstNotSecond = dgvList.Except(DataList).ToList();
            var secondNotFirst = DataList.Except(dgvList).ToList();

            bool result = !firstNotSecond.Any() && !secondNotFirst.Any();

            if (!result)
            {
                if (MessageBox.Show("There are unsaved changes in the data grid. Are you sure you want to quit?", "Unsaved changes",
                                                        MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }

        }

        private List<string> CreateListFromDataGrid()
        {
            List<string> dgvList = new List<string>
            {
                "Win/Loss\tSR\tSR Change\tMain Hero\tClass\tDate\tSolo/Team"
            };
            foreach (DataGridViewRow dgvRow in dgvData.Rows)
            {
                if (!dgvRow.IsNewRow)
                {
                    string rowData = "";
                    for (int i = 0; i < dgvData.Columns.Count; i++)
                    {
                        if (i < dgvData.Columns.Count - 1)
                        {
                            rowData += dgvRow.Cells[i].Value + "\t";

                        }
                        else
                        {
                            rowData += dgvRow.Cells[i].Value;
                        }
                    }
                    dgvList.Add(rowData);
                }
            }

            return dgvList;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveToTextFile();
            GetHeroDetails();
            GetOverallDetails();
        }

        private void cmboxQueue_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetHeroDetails();
            GetOverallDetails();
        }
    }
}
