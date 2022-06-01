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

        public  MainWindow()
        {
            InitializeComponent();
            // Create a new Team Record 
            // Instatiate a new Team Record and give it information
            // Add Some Details about Team

            AllSingleton SingletonInstance = AllSingleton.GetInstance();
            List<Team> AllTeams = SingletonInstance.GetSingletonTeamList();
            List<TeamMember> AllTeamMembers = SingletonInstance.GetSingletonTeamMemberList();
            List<Coach> AllCoaches = SingletonInstance.GetSingletonCoachList();

            foreach (Team i in AllTeams)
            {
                // Add item to datagrid
                DataGrid1.Items.Add(i);

                // Add items to Combobox for Delete (Dropdown)
                CB1.Items.Add(i.TeamName);

                //Add items to combobox for Update (Dropdown)
                CB2.Items.Add(i.TeamName);
            }

        }

        // Add new Person button was clicked
        private void AddNewTeamButton_Clicked(object sender, RoutedEventArgs e)
        {
            AllSingleton SingletonInstance = AllSingleton.GetInstance();
            List<Team> AllTeams = SingletonInstance.GetSingletonTeamList();
            List<TeamMember> AllTeamMembers = SingletonInstance.GetSingletonTeamMemberList();

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

                // Try to make a team, fail if incorrect year is inserted
                try
                {
                    // Add Team To the Singleton
                    Team tempTeam = new Team(AddTeamName.Text, int.Parse(AddStartYear.Text));
                    SingletonInstance.AddTeam(tempTeam);


                    DataGrid1.Items.Add(tempTeam);
                    CB1.Items.Add(tempTeam.TeamName);
                    CB2.Items.Add(tempTeam.TeamName);                    
                }

                catch
                {
                    Update_Error_SY.Text = "Not a valid year inserted";
                }
            }
            //Refresh items
            DataGrid1.Items.Refresh();
        }

        private void DeleteTeamButton_Click(object sender, RoutedEventArgs e)
        {
            AllSingleton SingletonInstance = AllSingleton.GetInstance();
            List<Team> AllTeams = SingletonInstance.GetSingletonTeamList();
            List<TeamMember> AllTeamMembers = SingletonInstance.GetSingletonTeamMemberList();


            // Here comes the program for deleting class instances 
            int tempIx = CB1.SelectedIndex;

            // check if index is available in the list to be deleted (-1 returned if not)
            if (tempIx == -1)
            {
                Update_Error_SY.Text = "Error while deleting team";
            }

            else
            {
                DataGrid1.Items.Remove(AllTeams[tempIx]);
                CB2.Items.Remove(CB1.SelectedValue);
                CB1.Items.Remove(CB1.SelectedValue);
                SingletonInstance.DeleteTeam(AllTeams[tempIx]);
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
            AllSingleton SingletonInstance = AllSingleton.GetInstance();
            List<Team> AllTeams = SingletonInstance.GetSingletonTeamList();
            List<TeamMember> AllTeamMembers = SingletonInstance.GetSingletonTeamMemberList();
            List<Coach> AllCoaches = SingletonInstance.GetSingletonCoachList();

            Update_Error_TN.Text = "";
            Update_Error_SY.Text = "";

            int tempIx = CB2.SelectedIndex;

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

                    // Check if name is inserted
                    if (string.IsNullOrEmpty(TB_Update_TN.Text))
                    {
                        // Both values are empty, no changes made 
                        Update_Error_TN.Text = "No changes made.";
                    }

                    else
                    {
                        try
                        {
                            // Name inserted, no year. Update TeamName 
                            //Adjust Teammembers 
                            AllTeamMembers[tempIx].TeamName = TB_Update_TN.Text;
                            // Adjust Team
                            AllTeams[tempIx].TeamName = TB_Update_TN.Text;

                            
                            SingletonInstance.EditTeamName(AllTeams[tempIx], TB_Update_TN.Text);
                        }

                        catch (ArgumentOutOfRangeException)
                        {
                            Update_Error_TN.Text = "IDK";
                        }

                        // Remove from Delete Drop down menu, specified index
                        CB1.Items.Remove(CB2.SelectedValue);
                        CB1.Items.Insert(tempIx, AllTeams[tempIx].TeamName);

                        //Remove from update Drop down menu, specified index 
                        CB2.Items.Remove(CB2.SelectedValue);
                        CB2.Items.Insert(tempIx, AllTeams[tempIx].TeamName);

                        //Refresh Values
                        DataGrid1.Items.Refresh();
                    }
                }

                else // Team Year is inserted
                {
                    // Check if Name is inserted
                    if (string.IsNullOrEmpty(TB_Update_TN.Text))
                    {
                        Update_Error_TN.Text = "No name inserted, Team Name not update";

                        try
                        {   
                            SingletonInstance.EditTeamYear(AllTeams[tempIx], CB2.Text, int.Parse(TB_Update_SY.Text));
                        }
                        catch
                        {
                            Update_Error_SY.Text = "Not a valid year inserted.";
                        }

                        // Remove from Delete Drop down menu, specified index
                        CB1.Items.Remove(CB2.SelectedValue);
                        CB1.Items.Insert(tempIx, AllTeams[tempIx].TeamName);

                        //Remove from update Drop down menu, specified index 
                        CB2.Items.Remove(CB2.SelectedValue);
                        CB2.Items.Insert(tempIx, AllTeams[tempIx].TeamName);

                        //Refresh Values
                        DataGrid1.Items.Refresh();

                    }

                    else
                    {
                        try
                        {
                            //Adjust Teammembers 
                            AllTeamMembers[tempIx].TeamName = TB_Update_TN.Text;
                            // Adjust Team
                            AllTeams[tempIx].TeamName = TB_Update_TN.Text;

                            SingletonInstance.EditTeam(AllTeams[tempIx], TB_Update_TN.Text, int.Parse(TB_Update_SY.Text));
                        }

                        catch (ArgumentOutOfRangeException)
                        {
                            Update_Error_TN.Text = "Error, Team Name not updated";
                        }

                        // Remove from Delete Drop down menu, specified index
                        CB1.Items.Remove(CB2.SelectedValue);
                        CB1.Items.Insert(tempIx, AllTeams[tempIx].TeamName);

                        //Remove from update Drop down menu, specified index 
                        CB2.Items.Remove(CB2.SelectedValue);
                        CB2.Items.Insert(tempIx, AllTeams[tempIx].TeamName);

                        //Refresh Values
                        DataGrid1.Items.Refresh();
                    }

                }
                //Refresh Values
                DataGrid1.Items.Refresh();
            }

            //Refresh Values
            DataGrid1.Items.Refresh();
        }

        private void AddTeamName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
