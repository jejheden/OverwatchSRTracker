namespace OverwatchTracker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAddWin = new System.Windows.Forms.Button();
            this.btnAddLoss = new System.Windows.Forms.Button();
            this.txtNewSR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCurrentSR = new System.Windows.Forms.TextBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.WinLoss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SRChange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatchDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoloTeam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsDgvData = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.insertRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblChange = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAvgVictory = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAvgLoss = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.lblWinRatio = new System.Windows.Forms.Label();
            this.lblGamesPlayed = new System.Windows.Forms.Label();
            this.lblGamesLost = new System.Windows.Forms.Label();
            this.lblGamesWon = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnTeam = new System.Windows.Forms.RadioButton();
            this.rbtnSolo = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblAvgDHero = new System.Windows.Forms.Label();
            this.cmboxHero = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblAvgVHero = new System.Windows.Forms.Label();
            this.lblVHeroLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmboxQueue = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.treeHeroes = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDatabaseTextfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddHero = new System.Windows.Forms.Button();
            this.txtNewHero = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnUpdateDatabase = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblDatafile = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.cmsDgvData.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddWin
            // 
            this.btnAddWin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddWin.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAddWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddWin.Location = new System.Drawing.Point(3, 3);
            this.btnAddWin.Name = "btnAddWin";
            this.btnAddWin.Size = new System.Drawing.Size(220, 51);
            this.btnAddWin.TabIndex = 0;
            this.btnAddWin.Text = "Victory";
            this.btnAddWin.UseVisualStyleBackColor = false;
            this.btnAddWin.Click += new System.EventHandler(this.btnAddWin_Click);
            // 
            // btnAddLoss
            // 
            this.btnAddLoss.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddLoss.BackColor = System.Drawing.Color.Pink;
            this.btnAddLoss.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLoss.Location = new System.Drawing.Point(3, 60);
            this.btnAddLoss.Name = "btnAddLoss";
            this.btnAddLoss.Size = new System.Drawing.Size(220, 51);
            this.btnAddLoss.TabIndex = 0;
            this.btnAddLoss.Text = "Defeat";
            this.btnAddLoss.UseVisualStyleBackColor = false;
            this.btnAddLoss.Click += new System.EventHandler(this.btnAddLoss_Click);
            // 
            // txtNewSR
            // 
            this.txtNewSR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewSR.Location = new System.Drawing.Point(116, 47);
            this.txtNewSR.Name = "txtNewSR";
            this.txtNewSR.Size = new System.Drawing.Size(82, 26);
            this.txtNewSR.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "New SR:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Current SR:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtCurrentSR
            // 
            this.txtCurrentSR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentSR.Location = new System.Drawing.Point(116, 13);
            this.txtCurrentSR.Name = "txtCurrentSR";
            this.txtCurrentSR.Size = new System.Drawing.Size(82, 26);
            this.txtCurrentSR.TabIndex = 1;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToResizeRows = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WinLoss,
            this.SR,
            this.SRChange,
            this.Hero,
            this.Class,
            this.MatchDate,
            this.SoloTeam});
            this.dgvData.ContextMenuStrip = this.cmsDgvData;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(393, 33);
            this.dgvData.Name = "dgvData";
            this.tableLayoutPanel1.SetRowSpan(this.dgvData, 3);
            this.dgvData.Size = new System.Drawing.Size(601, 441);
            this.dgvData.TabIndex = 3;
            this.dgvData.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellValueChanged);
            // 
            // WinLoss
            // 
            this.WinLoss.HeaderText = "Win/Loss";
            this.WinLoss.Name = "WinLoss";
            this.WinLoss.Width = 90;
            // 
            // SR
            // 
            this.SR.HeaderText = "SR";
            this.SR.Name = "SR";
            this.SR.Width = 70;
            // 
            // SRChange
            // 
            this.SRChange.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SRChange.HeaderText = "SR Change";
            this.SRChange.Name = "SRChange";
            this.SRChange.Width = 87;
            // 
            // Hero
            // 
            this.Hero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Hero.HeaderText = "Main Hero";
            this.Hero.Name = "Hero";
            this.Hero.Width = 81;
            // 
            // Class
            // 
            this.Class.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Class.HeaderText = "Class";
            this.Class.Name = "Class";
            this.Class.Width = 57;
            // 
            // MatchDate
            // 
            this.MatchDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MatchDate.HeaderText = "Date";
            this.MatchDate.Name = "MatchDate";
            this.MatchDate.Width = 55;
            // 
            // SoloTeam
            // 
            this.SoloTeam.HeaderText = "Solo/Team";
            this.SoloTeam.Name = "SoloTeam";
            this.SoloTeam.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SoloTeam.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cmsDgvData
            // 
            this.cmsDgvData.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertRowToolStripMenuItem,
            this.deleteRowToolStripMenuItem});
            this.cmsDgvData.Name = "cmsDgvData";
            this.cmsDgvData.Size = new System.Drawing.Size(147, 48);
            // 
            // insertRowToolStripMenuItem
            // 
            this.insertRowToolStripMenuItem.Name = "insertRowToolStripMenuItem";
            this.insertRowToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.insertRowToolStripMenuItem.Text = "Insert Row";
            this.insertRowToolStripMenuItem.Click += new System.EventHandler(this.insertRowToolStripMenuItem_Click);
            // 
            // deleteRowToolStripMenuItem
            // 
            this.deleteRowToolStripMenuItem.Name = "deleteRowToolStripMenuItem";
            this.deleteRowToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.deleteRowToolStripMenuItem.Text = "Delete Row(s)";
            this.deleteRowToolStripMenuItem.Click += new System.EventHandler(this.deleteRowToolStripMenuItem_Click);
            // 
            // lblChange
            // 
            this.lblChange.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblChange.AutoSize = true;
            this.lblChange.Location = new System.Drawing.Point(113, 131);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(10, 13);
            this.lblChange.TabIndex = 4;
            this.lblChange.Text = "-";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.Location = new System.Drawing.Point(19, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "From:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Avg. Victory gain:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAvgVictory
            // 
            this.lblAvgVictory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAvgVictory.AutoSize = true;
            this.lblAvgVictory.Location = new System.Drawing.Point(113, 156);
            this.lblAvgVictory.Name = "lblAvgVictory";
            this.lblAvgVictory.Size = new System.Drawing.Size(10, 13);
            this.lblAvgVictory.TabIndex = 4;
            this.lblAvgVictory.Text = "-";
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Avg. Defeat loss:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAvgLoss
            // 
            this.lblAvgLoss.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAvgLoss.AutoSize = true;
            this.lblAvgLoss.Location = new System.Drawing.Point(113, 181);
            this.lblAvgLoss.Name = "lblAvgLoss";
            this.lblAvgLoss.Size = new System.Drawing.Size(10, 13);
            this.lblAvgLoss.TabIndex = 4;
            this.lblAvgLoss.Text = "-";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 158F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 232F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvData, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAddHero, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtNewHero, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 2, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.71951F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.28049F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(997, 634);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tableLayoutPanel6);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(393, 480);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(601, 113);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Game Statistics";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 4;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.Controls.Add(this.lblWinRatio, 1, 3);
            this.tableLayoutPanel6.Controls.Add(this.lblGamesPlayed, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.lblGamesLost, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.lblGamesWon, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.label14, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label15, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.label16, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.label17, 0, 3);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 4;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(595, 94);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // lblWinRatio
            // 
            this.lblWinRatio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblWinRatio.AutoSize = true;
            this.lblWinRatio.Location = new System.Drawing.Point(151, 75);
            this.lblWinRatio.Name = "lblWinRatio";
            this.lblWinRatio.Size = new System.Drawing.Size(10, 13);
            this.lblWinRatio.TabIndex = 0;
            this.lblWinRatio.Text = "-";
            // 
            // lblGamesPlayed
            // 
            this.lblGamesPlayed.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblGamesPlayed.AutoSize = true;
            this.lblGamesPlayed.Location = new System.Drawing.Point(151, 5);
            this.lblGamesPlayed.Name = "lblGamesPlayed";
            this.lblGamesPlayed.Size = new System.Drawing.Size(10, 13);
            this.lblGamesPlayed.TabIndex = 0;
            this.lblGamesPlayed.Text = "-";
            // 
            // lblGamesLost
            // 
            this.lblGamesLost.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblGamesLost.AutoSize = true;
            this.lblGamesLost.Location = new System.Drawing.Point(151, 51);
            this.lblGamesLost.Name = "lblGamesLost";
            this.lblGamesLost.Size = new System.Drawing.Size(10, 13);
            this.lblGamesLost.TabIndex = 0;
            this.lblGamesLost.Text = "-";
            // 
            // lblGamesWon
            // 
            this.lblGamesWon.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblGamesWon.AutoSize = true;
            this.lblGamesWon.Location = new System.Drawing.Point(151, 28);
            this.lblGamesWon.Name = "lblGamesWon";
            this.lblGamesWon.Size = new System.Drawing.Size(10, 13);
            this.lblGamesWon.TabIndex = 0;
            this.lblGamesWon.Text = "-";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label14.AutoEllipsis = true;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(67, 5);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Games Played:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label15.AutoEllipsis = true;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(76, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Games Won:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label16.AutoEllipsis = true;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(79, 51);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Games Lost:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label17.AutoEllipsis = true;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(90, 75);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Win Rate:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnTeam);
            this.groupBox1.Controls.Add(this.rbtnSolo);
            this.groupBox1.Controls.Add(this.txtNewSR);
            this.groupBox1.Controls.Add(this.txtCurrentSR);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(161, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 109);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // rbtnTeam
            // 
            this.rbtnTeam.AutoSize = true;
            this.rbtnTeam.Checked = true;
            this.rbtnTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnTeam.Location = new System.Drawing.Point(129, 79);
            this.rbtnTeam.Name = "rbtnTeam";
            this.rbtnTeam.Size = new System.Drawing.Size(67, 24);
            this.rbtnTeam.TabIndex = 3;
            this.rbtnTeam.TabStop = true;
            this.rbtnTeam.Text = "Team";
            this.rbtnTeam.UseVisualStyleBackColor = true;
            // 
            // rbtnSolo
            // 
            this.rbtnSolo.AutoSize = true;
            this.rbtnSolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSolo.Location = new System.Drawing.Point(41, 79);
            this.rbtnSolo.Name = "rbtnSolo";
            this.rbtnSolo.Size = new System.Drawing.Size(59, 24);
            this.rbtnSolo.TabIndex = 3;
            this.rbtnSolo.Text = "Solo";
            this.rbtnSolo.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnAddWin, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAddLoss, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(161, 148);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(226, 114);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel4);
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(161, 271);
            this.groupBox2.Name = "groupBox2";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox2, 2);
            this.groupBox2.Size = new System.Drawing.Size(226, 322);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Statistics";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label11, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblAvgDHero, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.cmboxHero, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label9, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.lblAvgVHero, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.lblVHeroLabel, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 216);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(220, 103);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label10.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.label10, 2);
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(35, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 25);
            this.label10.TabIndex = 2;
            this.label10.Text = "Hero/Class Details";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(3, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 25);
            this.label11.TabIndex = 2;
            this.label11.Text = "Select Hero/Class:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAvgDHero
            // 
            this.lblAvgDHero.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAvgDHero.AutoSize = true;
            this.lblAvgDHero.Location = new System.Drawing.Point(113, 82);
            this.lblAvgDHero.Name = "lblAvgDHero";
            this.lblAvgDHero.Size = new System.Drawing.Size(10, 13);
            this.lblAvgDHero.TabIndex = 4;
            this.lblAvgDHero.Text = "-";
            // 
            // cmboxHero
            // 
            this.cmboxHero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmboxHero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxHero.FormattingEnabled = true;
            this.cmboxHero.Items.AddRange(new object[] {
            "--Offense--",
            "Genji",
            "McCree",
            "Pharah",
            "Reaper",
            "Soldier: 76",
            "Sombra",
            "Tracer",
            "--Defense--",
            "Bastion",
            "Hanzo",
            "Junkrat",
            "Mei",
            "Torbjörn",
            "Widowmaker",
            "--Tank--",
            "D.Va",
            "Orisa",
            "Reinhardt",
            "Roadhog",
            "Winston",
            "Zarya",
            "--Support--",
            "Ana",
            "Lúcio",
            "Mercy",
            "Symmetra",
            "Zenyatta"});
            this.cmboxHero.Location = new System.Drawing.Point(113, 28);
            this.cmboxHero.Name = "cmboxHero";
            this.cmboxHero.Size = new System.Drawing.Size(104, 21);
            this.cmboxHero.TabIndex = 7;
            this.cmboxHero.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(3, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 28);
            this.label9.TabIndex = 2;
            this.label9.Text = "Avg. Defeat loss:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAvgVHero
            // 
            this.lblAvgVHero.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAvgVHero.AutoSize = true;
            this.lblAvgVHero.Location = new System.Drawing.Point(113, 56);
            this.lblAvgVHero.Name = "lblAvgVHero";
            this.lblAvgVHero.Size = new System.Drawing.Size(10, 13);
            this.lblAvgVHero.TabIndex = 4;
            this.lblAvgVHero.Text = "-";
            // 
            // lblVHeroLabel
            // 
            this.lblVHeroLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVHeroLabel.Location = new System.Drawing.Point(3, 50);
            this.lblVHeroLabel.Name = "lblVHeroLabel";
            this.lblVHeroLabel.Size = new System.Drawing.Size(104, 25);
            this.lblVHeroLabel.TabIndex = 2;
            this.lblVHeroLabel.Text = "Avg. Victory gain:";
            this.lblVHeroLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.dtpTo, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.dtpFrom, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblAvgLoss, 1, 7);
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.lblAvgVictory, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.lblChange, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.label13, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.cmboxQueue, 1, 4);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 8;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(220, 200);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(113, 53);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(104, 20);
            this.dtpTo.TabIndex = 1;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(113, 28);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(104, 20);
            this.dtpFrom.TabIndex = 0;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "To:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.label3, 2);
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Overall Stats";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label12.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.label12, 2);
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(62, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 25);
            this.label12.TabIndex = 2;
            this.label12.Text = "Date Range";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "SR gain/loss:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Location = new System.Drawing.Point(3, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 25);
            this.label13.TabIndex = 5;
            this.label13.Text = "Queue:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmboxQueue
            // 
            this.cmboxQueue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmboxQueue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxQueue.FormattingEnabled = true;
            this.cmboxQueue.Items.AddRange(new object[] {
            "All",
            "Solo",
            "Team"});
            this.cmboxQueue.Location = new System.Drawing.Point(113, 103);
            this.cmboxQueue.Name = "cmboxQueue";
            this.cmboxQueue.Size = new System.Drawing.Size(104, 21);
            this.cmboxQueue.TabIndex = 6;
            this.cmboxQueue.SelectedIndexChanged += new System.EventHandler(this.cmboxQueue_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.treeHeroes);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 33);
            this.groupBox3.Name = "groupBox3";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox3, 4);
            this.groupBox3.Size = new System.Drawing.Size(152, 560);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select Hero";
            // 
            // treeHeroes
            // 
            this.treeHeroes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeHeroes.HideSelection = false;
            this.treeHeroes.Location = new System.Drawing.Point(3, 16);
            this.treeHeroes.Name = "treeHeroes";
            this.treeHeroes.Size = new System.Drawing.Size(146, 541);
            this.treeHeroes.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.menuStrip1, 3);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.databaseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(997, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewDatabaseToolStripMenuItem,
            this.selectDatabaseToolStripMenuItem,
            this.createBackupToolStripMenuItem,
            this.openDatabaseTextfileToolStripMenuItem,
            this.reloadDatabaseToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // createNewDatabaseToolStripMenuItem
            // 
            this.createNewDatabaseToolStripMenuItem.Name = "createNewDatabaseToolStripMenuItem";
            this.createNewDatabaseToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.createNewDatabaseToolStripMenuItem.Text = "Create New Database";
            this.createNewDatabaseToolStripMenuItem.Click += new System.EventHandler(this.createNewDatabaseToolStripMenuItem_Click);
            // 
            // selectDatabaseToolStripMenuItem
            // 
            this.selectDatabaseToolStripMenuItem.Name = "selectDatabaseToolStripMenuItem";
            this.selectDatabaseToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.selectDatabaseToolStripMenuItem.Text = "Select Database";
            this.selectDatabaseToolStripMenuItem.Click += new System.EventHandler(this.selectDatabaseToolStripMenuItem_Click);
            // 
            // createBackupToolStripMenuItem
            // 
            this.createBackupToolStripMenuItem.Name = "createBackupToolStripMenuItem";
            this.createBackupToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.createBackupToolStripMenuItem.Text = "Create Backup";
            this.createBackupToolStripMenuItem.Click += new System.EventHandler(this.createBackupToolStripMenuItem_Click);
            // 
            // openDatabaseTextfileToolStripMenuItem
            // 
            this.openDatabaseTextfileToolStripMenuItem.Name = "openDatabaseTextfileToolStripMenuItem";
            this.openDatabaseTextfileToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.openDatabaseTextfileToolStripMenuItem.Text = "Open Database Textfile";
            this.openDatabaseTextfileToolStripMenuItem.Click += new System.EventHandler(this.openDatabaseTextfileToolStripMenuItem_Click);
            // 
            // reloadDatabaseToolStripMenuItem
            // 
            this.reloadDatabaseToolStripMenuItem.Name = "reloadDatabaseToolStripMenuItem";
            this.reloadDatabaseToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.reloadDatabaseToolStripMenuItem.Text = "Reload Database";
            this.reloadDatabaseToolStripMenuItem.Click += new System.EventHandler(this.reloadDatabaseToolStripMenuItem_Click);
            // 
            // btnAddHero
            // 
            this.btnAddHero.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAddHero.Location = new System.Drawing.Point(161, 603);
            this.btnAddHero.Name = "btnAddHero";
            this.btnAddHero.Size = new System.Drawing.Size(110, 23);
            this.btnAddHero.TabIndex = 9;
            this.btnAddHero.Text = "Add New Hero";
            this.btnAddHero.UseVisualStyleBackColor = true;
            this.btnAddHero.Click += new System.EventHandler(this.btnAddHero_Click);
            // 
            // txtNewHero
            // 
            this.txtNewHero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewHero.Location = new System.Drawing.Point(3, 605);
            this.txtNewHero.Name = "txtNewHero";
            this.txtNewHero.Size = new System.Drawing.Size(152, 20);
            this.txtNewHero.TabIndex = 10;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.58823F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.41177F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel5.Controls.Add(this.btnUpdateDatabase, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblVersion, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblDatafile, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(393, 599);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(601, 32);
            this.tableLayoutPanel5.TabIndex = 11;
            // 
            // btnUpdateDatabase
            // 
            this.btnUpdateDatabase.Location = new System.Drawing.Point(3, 3);
            this.btnUpdateDatabase.Name = "btnUpdateDatabase";
            this.btnUpdateDatabase.Size = new System.Drawing.Size(160, 23);
            this.btnUpdateDatabase.TabIndex = 7;
            this.btnUpdateDatabase.Text = "Apply Changes to Database";
            this.btnUpdateDatabase.UseVisualStyleBackColor = true;
            this.btnUpdateDatabase.Click += new System.EventHandler(this.btnUpdateDatabase_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(582, 9);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(16, 13);
            this.lblVersion.TabIndex = 3;
            this.lblVersion.Text = "v.";
            // 
            // lblDatafile
            // 
            this.lblDatafile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDatafile.AutoSize = true;
            this.lblDatafile.Location = new System.Drawing.Point(328, 9);
            this.lblDatafile.Name = "lblDatafile";
            this.lblDatafile.Size = new System.Drawing.Size(41, 13);
            this.lblDatafile.TabIndex = 8;
            this.lblDatafile.Text = "label13";
            this.lblDatafile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 634);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 673);
            this.Name = "Form1";
            this.Text = "Overwatch SR Tracker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.cmsDgvData.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddWin;
        private System.Windows.Forms.Button btnAddLoss;
        private System.Windows.Forms.TextBox txtNewSR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCurrentSR;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAvgVictory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAvgLoss;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TreeView treeHeroes;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnUpdateDatabase;
        private System.Windows.Forms.ContextMenuStrip cmsDgvData;
        private System.Windows.Forms.ToolStripMenuItem insertRowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteRowToolStripMenuItem;
        private System.Windows.Forms.Label lblAvgVHero;
        private System.Windows.Forms.Label lblVHeroLabel;
        private System.Windows.Forms.ComboBox cmboxHero;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblAvgDHero;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createBackupToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem openDatabaseTextfileToolStripMenuItem;
        private System.Windows.Forms.Button btnAddHero;
        private System.Windows.Forms.TextBox txtNewHero;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.ToolStripMenuItem reloadDatabaseToolStripMenuItem;
        private System.Windows.Forms.Label lblDatafile;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn WinLoss;
        private System.Windows.Forms.DataGridViewTextBoxColumn SR;
        private System.Windows.Forms.DataGridViewTextBoxColumn SRChange;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatchDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoloTeam;
        private System.Windows.Forms.RadioButton rbtnTeam;
        private System.Windows.Forms.RadioButton rbtnSolo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmboxQueue;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblGamesPlayed;
        private System.Windows.Forms.Label lblGamesLost;
        private System.Windows.Forms.Label lblGamesWon;
        private System.Windows.Forms.Label lblWinRatio;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}

