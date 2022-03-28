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


            // Declare teams 
            Team Navi = new Team();
            Navi.TeamName = "Natus Vincere";
            Navi.StartYear = 2009;

            Team Nip = new Team();
            Nip.TeamName = "Ninjas in Pyjama's";
            Nip.StartYear = 2000;

            Team Astralis = new Team();
            Astralis.TeamName = "Astralis";
            Astralis.StartYear = 2016;
            
            // Declare TeamMembers 
            TeamMember Simple = new TeamMember();
            Simple.Team = Navi;
            Simple.MemberName = "Oleksandr Kostyliev";
            Simple.MemberAge = 24;
            Simple.MemberInGameName = "S1mple";

            TeamMember GetRight = new TeamMember();
            GetRight.Team = Nip;
            GetRight.MemberName = "Christopher Alesund";
            GetRight.MemberAge = 31;
            GetRight.MemberInGameName = "GeT_RiGhT";

            TeamMember Device = new TeamMember();
            Device.Team = Astralis;
            Device.MemberName = "Nicolai Hvilshøj Reedtz";
            Device.MemberAge = 26;
            Device.MemberInGameName = "dev1ce";

            // Create list of Teammembers Classes
            _Teammember = new List<TeamMember>();
            _Teammember.Add(Simple);
            _Teammember.Add(GetRight);
            _Teammember.Add(Device);

            // Add a list with Team classes
            _Team = new List<Team>();
            _Team.Add(Navi);
            _Team.Add(Nip);
            _Team.Add(Astralis);

            // Add to grid 
            DataGrid2.Items.Add(_Teammember[0]);
            DataGrid2.Items.Add(_Teammember[1]);
            DataGrid2.Items.Add(_Teammember[2]);

            // Add items to Combobox for adding teammember 
            CB_Add_TN.Items.Add(_Team[0].TeamName);
            CB_Add_TN.Items.Add(_Team[1].TeamName);
            CB_Add_TN.Items.Add(_Team[2].TeamName);

            // Add items to Comboxbox for deleting teammember (showing IGN)
            CB_Delete_TM.Items.Add(_Teammember[0].MemberInGameName);
            CB_Delete_TM.Items.Add(_Teammember[1].MemberInGameName);
            CB_Delete_TM.Items.Add(_Teammember[2].MemberInGameName);

            // Add items to Combobox for updating teammembers (showing IGN)
            CB_Update_TM.Items.Add(_Teammember[0].MemberInGameName);
            CB_Update_TM.Items.Add(_Teammember[1].MemberInGameName);
            CB_Update_TM.Items.Add(_Teammember[2].MemberInGameName);

        }

        private void BT_Add_TM_Click(object sender, RoutedEventArgs e)
        {
            // This is the code for adding a Teammember
            TeamMember tempTeammember = new TeamMember();
            int tempInt = CB_Add_TN.SelectedIndex;
            tempTeammember.Team = _Team[tempInt];
            tempTeammember.MemberName = TBox_Add_MN.Text;
            tempTeammember.MemberAge = int.Parse(TBox_Add_Age.Text);
            tempTeammember.MemberInGameName = TBox_Add_IGN.Text;

            // Add Teammember To the List _Teammembers
            _Teammember.Add(tempTeammember);
            DataGrid2.Items.Add(tempTeammember);

            // Add Teammember to Combobox for deleting Teammembers
            CB_Delete_TM.Items.Add(tempTeammember.MemberInGameName);

            // Add Teammember to Combobox for updating Teammembers 
            CB_Update_TM.Items.Add(tempTeammember.MemberInGameName);

        }

        private void BT_Delete_TM_Click(object sender, RoutedEventArgs e)
        {
            // This is the code to delete the teammember 
            int tempIx = CB_Delete_TM.SelectedIndex;
            DataGrid2.Items.Remove(_Teammember[tempIx]);
            CB_Update_TM.Items.Remove(CB_Delete_TM.SelectedValue);
            CB_Delete_TM.Items.Remove(CB_Delete_TM.SelectedValue);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var newForm = new MainWindow();
            newForm.Show();
            this.Close();
        }

        private void DataGrid2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BT_Update_TM_Click(object sender, RoutedEventArgs e)
        {
            // Check if teammember is selected in Combobox
            if (string.IsNullOrEmpty(CB_Update_TM.Text))
            {
                TB_Update_Error.Text = "No teammember selected.";
            }

            else
            {
                
            }
        }
    }

}

