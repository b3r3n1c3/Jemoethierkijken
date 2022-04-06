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

            //Add items to Datagrid 
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


        // Add new Person button was clicked
        private void AddNewTeamButton_Clicked(object sender, RoutedEventArgs e)
        {
            TB_Add_Error.Text = "";
            Update_Error_SY.Text = "";


            //Check if name is inserted
            if (String.IsNullOrEmpty(AddTeamName.Text))
            {
                TB_Add_Error.Text = "Please insert a name";
            }

            else
            {
                Update_Error_SY.Text = "";
                Team tempTeam = new Team();
                try
                {
                    tempTeam.StartYear = int.Parse(AddStartYear.Text);
                    tempTeam.TeamName = AddTeamName.Text;

                    // Add Team To the List _Teams
                    _Team.Add(tempTeam);
                    DataGrid1.Items.Add(tempTeam);
                    CB1.Items.Add(tempTeam.TeamName);
                    CB2.Items.Add(tempTeam.TeamName);
                }

                catch
                {
                    Update_Error_SY.Text = "Not a valid year inserted";
                }
            }
        }

        private void DeleteTeamButton_Click(object sender, RoutedEventArgs e)
        {
            // Here comes the program for deleting class instances 
            int tempIx = CB1.SelectedIndex;

            // check if index is available in the list to be deleted (-1 returned if not)
            if (tempIx == -1)
            {
                Update_Error_SY.Text = "Error while deleting team";
            }

            else
            {
                DataGrid1.Items.Remove(_Team[tempIx]);
                CB2.Items.Remove(CB1.SelectedValue);
                CB1.Items.Remove(CB1.SelectedValue);
                _Team.RemoveAt(tempIx);
                DataGrid1.Items.Refresh();
            }


        }

        private void TeamInfoButton_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to Window with team info 
            var newForm = new TeamInfo();
            newForm.Show();
            this.Close();
        }
        private void BT_PlayerInfo_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to Window with Player info 
            var newForm = new PlayerInfo();
            newForm.Show();
            this.Close();
        }


        // This is the code run when update button is pressed 
        private void UpdateTeamButton_Click(object sender, RoutedEventArgs e)
        {
            Update_Error_TN.Text = "";
            Update_Error_SY.Text = "";

            // Check if team is selected in Combobox
            if (string.IsNullOrEmpty(CB2.Text))
            {
                Update_Error_TN.Text = "No team selected.";
            }
            else
            {

                // Check if Year is inserted
                if (string.IsNullOrEmpty(TB_Update_SY.Text))
                {
                    Update_Error_SY.Text = "No year inserted,  start year not updated";
                }

                else
                {
                    // Update Team Name 
                    int tempIx = CB2.SelectedIndex;
                    // Check for valid value (int)
                    try
                    {
                        _Team[tempIx].StartYear = int.Parse(TB_Update_SY.Text);
                    }

                    catch
                    {
                        Update_Error_SY.Text = "Not a valid year inserted.";
                    }                  


                }

                // Check if Name is inserted
                if (string.IsNullOrEmpty(TB_Update_TN.Text))
                {
                    Update_Error_TN.Text = "No name inserted, Team Name not update";
                }
                else
                {
                    // Update Team Name 
                    int tempIx = CB2.SelectedIndex;
                    _Team[tempIx].TeamName = TB_Update_TN.Text;

                    // Remove from Delete Drop down menu, specified index
                    CB1.Items.Remove(CB2.SelectedValue);
                    CB1.Items.Insert(tempIx, _Team[tempIx].TeamName);

                    //Remove from update Drop down menu, specified index 
                    CB2.Items.Remove(CB2.SelectedValue);
                    CB2.Items.Insert(tempIx, _Team[tempIx].TeamName);
                }

                //Refresh Values
                DataGrid1.Items.Refresh();

            }


        }

        private void AddTeamName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
