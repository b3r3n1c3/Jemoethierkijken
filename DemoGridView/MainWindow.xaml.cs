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


namespace DemoGridView
{

    public partial class MainWindow : Window
    {
        public List<Team> _Team;

        public MainWindow()
        {
            InitializeComponent();
            // Create a new Team Record 
            // Instatiate a new Team Record and give it information
            // Add Some Details about Team
            Team Navi = new Team();
            Navi.TeamName = "Natus Vincere";
            Navi.StartYear = 2009;

            Team Nip = new Team();
            Nip.TeamName = "Ninjas in Pyjama's";
            Nip.StartYear = 2000;

            Team Astralis = new Team();
            Astralis.TeamName = "Astralis";
            Astralis.StartYear = 2016;

            // Add a list with classes
            _Team = new List<Team>();
            _Team.Add(Navi);
            _Team.Add(Nip);
            _Team.Add(Astralis);


            DataGrid1.Items.Add(_Team[0]);
            DataGrid1.Items.Add(_Team[1]);
            DataGrid1.Items.Add(_Team[2]);

            // Add items to Combobox for Delete (Dropdown)

            CB1.Items.Add(_Team[0].TeamName);
            CB1.Items.Add(_Team[1].TeamName);
            CB1.Items.Add(_Team[2].TeamName);

            //Add items to combobox for Update (Dropdown)
            CB2.Items.Add(_Team[0].TeamName);
            CB2.Items.Add(_Team[1].TeamName);
            CB2.Items.Add(_Team[2].TeamName);



        }



        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        // Add new Person button was clicked
        private void AddNewTeamButton_Clicked(object sender, RoutedEventArgs e)
        {
            Team tempTeam = new Team();
            tempTeam.StartYear =  int.Parse(AddStartYear.Text);
            tempTeam.TeamName = AddTeamName.Text;

            // Add Team To the List _Teams
            _Team.Add(tempTeam);
            DataGrid1.Items.Add(tempTeam);
            CB1.Items.Add(tempTeam.TeamName);
            CB2.Items.Add(tempTeam.TeamName);


        }

        private void DeleteTeamButton_Click(object sender, RoutedEventArgs e)
        {
            // Here comes the program for deleting class instances 

            int tempIx = CB1.SelectedIndex;

            DataGrid1.Items.Remove(_Team[tempIx]);
            CB1.Items.Remove(CB1.SelectedValue);

        }

        private void TeamInfoButton_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to Window with teeam info 
            var newForm = new TeamInfo();
            newForm.Show();
            this.Close(); 
        }
    }
}
