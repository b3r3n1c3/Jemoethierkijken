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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
            // Create a new Team Record 
            // Instatiate a new Team Record and give it information
            Team Navi = new Team();

            // Add Some Details about Team
            Navi.TeamName = "Natus Vincere";
            Navi.StartYear = 2009;

            DataGrid1.Items.Add(Navi);


            Team Nip = new Team();
            Nip.TeamName = "Ninjas in Pyjama's";
            Nip.StartYear = 2000;

            DataGrid1.Items.Add(Nip);

            Team Astralis = new Team();
            Astralis.TeamName = "Astralis";
            Astralis.StartYear = 2016;

            DataGrid1.Items.Add(Astralis);

            // Add items to Combobox (Dropdown)
            string var;
            var = CB1.Text;
            CB1.Items.Add(Astralis.TeamName);
            CB1.Items.Add(Nip.TeamName);
            CB1.Items.Add(Navi.TeamName); 
        }

        public class Person
        {
            public int PersonId { get; set; }
            public string Name { get; set; }
            public string LastName { get; set; }
            public string Profession { get; set; }

        }

        public class Team
        {
            public string TeamName { get; set; }
            public int StartYear { get; set; }
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
            // tempPerson.LastName = AddPersonLastName.Text;
            // tempPerson.Profession = AddPersonProfession.Text;

            DataGrid1.Items.Add(tempTeam);
            CB1.Items.Add(tempTeam.TeamName);

        }

        private void DeleteTeamButton_Click(object sender, RoutedEventArgs e)
        {
            // Here comes the program for deleting class instances 
;
            CB1.Items.Remove(CB1.SelectedItem); 

        }
    }
}
