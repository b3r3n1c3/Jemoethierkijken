using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DemoGridView
{
    /// <summary>
    /// Interaction logic for TeamInfo.xaml
    /// </summary>
    public partial class TeamInfo : Window
    {
        public List<TeamMember> _Teammember;
        public List<Team> _Team;

        public TeamInfo()
        {
            InitializeComponent();

            AllSingleton SingletonInstance = AllSingleton.GetInstance();
            List<Team> AllTeams = SingletonInstance.GetSingletonTeamList();
            List<TeamMember> AllTeamMembers = SingletonInstance.GetSingletonTeamMemberList();


            foreach (Team i in AllTeams)
            {
                // Add item to Combobox for adding teammembers
                CB_Add_TN.Items.Add(i.TeamName);

            }
            foreach (TeamMember i in AllTeamMembers)
            {
                // Add to grid 
                DataGrid2.Items.Add(i);


                // Add item to Combobox for deleting teammembers
                CB_Delete_TM.Items.Add(i.MemberInGameName);

                // Add items to Combobox for updating teammembers (showing IGN)
                CB_Update_TM.Items.Add(i.MemberInGameName);
            }
        }

        private void BT_Add_TM_Click(object sender, RoutedEventArgs e)
        {
            AllSingleton SingletonInstance = AllSingleton.GetInstance();
            List<Team> AllTeams = SingletonInstance.GetSingletonTeamList();
            List<TeamMember> AllTeamMembers = SingletonInstance.GetSingletonTeamMemberList();

            TB_Add_Error.Text = "";

            // This is the code for adding a Teammember


            // See if Team is Selected 
            if (string.IsNullOrEmpty(CB_Add_TN.Text))
            {
                TB_Add_Error.Text = "Please choose a team";
            }

            // If team is selected
            else
            {   
                // See if Teammember name is inserted
                if (string.IsNullOrEmpty(TBox_Add_MN.Text))
                {
                    TB_Add_Error.Text = "Please insert a name";
                }

                // If Teammember is insert
                else
                {
                    //See if Teammember In Game Name is inserted
                    if (string.IsNullOrEmpty(TBox_Add_IGN.Text))
                    {
                        TB_Add_Error.Text = "Please insert an In Game Name ";
                    }

                    // If Teammember In Game Name is insert
                    else
                    {
                        // See if year is inserted and correct
                        try
                        {
                            int tempInt = CB_Add_TN.SelectedIndex;
                            TeamMember tempTeammember = new TeamMember(TBox_Add_MN.Text, int.Parse(TBox_Add_Age.Text), TBox_Add_IGN.Text, AllTeams[tempInt]);

                            // Add Teammember To the List _Teammembers
                            SingletonInstance.AddTeam(tempTeammember);
                            DataGrid2.Items.Add(tempTeammember);

                            // Add Teammember to Combobox for deleting Teammembers
                            CB_Delete_TM.Items.Add(tempTeammember.MemberInGameName);

                            // Add Teammember to Combobox for updating Teammembers 
                            CB_Update_TM.Items.Add(tempTeammember.MemberInGameName);

                        }

                        catch
                        {
                            TB_Add_Error.Text = "Not a valid year inserted";
                        }
                    }
                }
            }
        }

        private void BT_Delete_TM_Click(object sender, RoutedEventArgs e)
        {

            AllSingleton SingletonInstance = AllSingleton.GetInstance();
            List<Team> AllTeams = SingletonInstance.GetSingletonTeamList();
            List<TeamMember> AllTeamMembers = SingletonInstance.GetSingletonTeamMemberList();


            TB_Delete_error.Text = "";
            // This is the code to delete the teammember 

            // Check if combobox has a value selected 
            if (string.IsNullOrEmpty(CB_Delete_TM.Text))
            {
                TB_Delete_error.Text = "No teammember selected";
            }

            // If selected 
            else
            {
                int tempIx = CB_Delete_TM.SelectedIndex;
                DataGrid2.Items.Remove(AllTeamMembers[tempIx]);
                CB_Update_TM.Items.Remove(CB_Delete_TM.SelectedValue);
                CB_Delete_TM.Items.Remove(CB_Delete_TM.SelectedValue);
                SingletonInstance.DeleteTeammember(AllTeamMembers[tempIx]);
                DataGrid2.Items.Refresh();
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var newForm = new MainWindow();
            newForm.Show();
            CB_Add_TN.Items.Refresh();
            CB_Delete_TM.Items.Refresh();
            CB_Update_TM.Items.Refresh();
            this.Close();
        }


        private void BT_Update_TM_Click(object sender, RoutedEventArgs e)
        {
            AllSingleton SingletonInstance = AllSingleton.GetInstance();
            List<Team> AllTeams = SingletonInstance.GetSingletonTeamList();
            List<TeamMember> AllTeamMembers = SingletonInstance.GetSingletonTeamMemberList();
            List<Player> AllPlayers = SingletonInstance.GetSingletonPlayerList();


            TB_Update_Error.Text = "";
            TB_Update_Error_Age.Text = "";
            TB_Update_Error_IGN.Text = "";


            // Check if teammember is selected in Combobox
            if (string.IsNullOrEmpty(CB_Update_TM.Text))
            {
                TB_Update_Error.Text = "No teammember selected.";
            }

            // If teammember is selected 
            else
            {
                // Check if teammember name is filled
                if (string.IsNullOrEmpty(TBox_Update_MN.Text))
                {
                    TB_Update_Error.Text = "No name inserted.";
                }

                // If teammember name is filled
                else
                {
                    // Update Teammember Name 
                    int tempIx = CB_Update_TM.SelectedIndex;
                    AllTeamMembers[tempIx].MemberName = TBox_Update_MN.Text;
                    //Refresh Values
                    DataGrid2.Items.Refresh();
                }

              


                // Check if teammember age is filled 
                if (string.IsNullOrEmpty(TBox_Update_Age.Text))
                {
                    TB_Update_Error_Age.Text = "No age inserted.";
                }

                else
                {
                    // Update Teammember Age

                    try
                    {
                        int tempIx = CB_Update_TM.SelectedIndex;
                        AllTeamMembers[tempIx].MemberAge = int.Parse(TBox_Update_Age.Text);
                    }

                    catch
                    {
                        TB_Update_Error_Age.Text = "Not a valid age ";
                    }


                }


                // Check if teammember IGN is filled 
                if (string.IsNullOrEmpty(TBox_Update_IGN.Text))
                {
                    TB_Update_Error_IGN.Text = "No In Game Name inserted.";
                }

                else
                {
                    // Update Teammember Ingame name 
                    int tempIx = CB_Update_TM.SelectedIndex;
                    SingletonInstance.UpdateTeammemberInGameName(AllPlayers[tempIx], TBox_Update_IGN.Text);
                    AllTeamMembers[tempIx].MemberInGameName = TBox_Update_IGN.Text;

                    //Refresh Values
                    DataGrid2.Items.Refresh();

                    //Delete and insert with specified index
                    CB_Delete_TM.Items.Remove(CB_Update_TM.SelectedValue);
                    CB_Delete_TM.Items.Insert(tempIx, AllTeamMembers[tempIx].MemberInGameName);

                    CB_Update_TM.Items.Remove(CB_Update_TM.SelectedValue);
                    CB_Update_TM.Items.Insert(tempIx, AllTeamMembers[tempIx].MemberInGameName);
                }
                //Refresh Values
                DataGrid2.Items.Refresh();
            }
        }
    }

}

