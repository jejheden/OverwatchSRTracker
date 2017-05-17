using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;
using System.Xml.XPath;

namespace OverwatchTrackerWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PopulateHeroes();
            dgvData.ItemsSource = Helper.DataTableFromTextFile(@"C:\Users\Jens Ejheden\Dropbox\_dev\C#.NET\PROD\OverwatchTracker\OverwatchTrackerSolution\OverwatchTrackerWPF\Data\Example data.txt").DefaultView;
            //C:\Users\Jens Ejheden\Dropbox\_dev\C#.NET\PROD\OverwatchTracker\OverwatchTrackerSolution\OverwatchTrackerWPF\Data\Example data.txt
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void PopulateHeroes()
        {
            try
            {

                treeHeroes.Items.Clear();
                //treeHeroes.Items.Add("something");


                string xmlPath = System.IO.Path.Combine(Environment.CurrentDirectory, "XML", "Heroes.xml");
                XDocument xd = XDocument.Load(xmlPath);

                var heroList = xd.XPathSelectElements(@"//HeroList/Class");
                var classHeroNodes = new TreeViewItem();
                foreach (XElement heroClass in heroList)
                {
                    string className = heroClass.XPathSelectElement("Name").Value;
                    var ClassNode = new TreeViewItem();
                    ClassNode.Header = className;
                    
                    //cmboxHero.Items.Add("--" + className + "--");

                    foreach (XElement hero in heroClass.XPathSelectElements("Heroes/Hero"))
                    {
                        string heroInClass = hero.Value;
                        var heroNode = new TreeViewItem();
                        heroNode.Header = heroInClass;
                        ClassNode.Items.Add(heroNode);


                        //cmboxHero.Items.Add(heroInClass);

                    }
                    treeHeroes.Items.Add(ClassNode);
                }

            }
            catch (Exception)
            {
                //MessageBox.Show("Could not load hero list.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
