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
    /// Interaction logic for PlayerInfo.xaml
    /// </summary>
    public partial class PlayerInfo : Window
    {
        public List<TeamMember> _Teammember;
        public List<Player> _Player;
        public List<Coach> _Coach;

        public PlayerInfo()
        {
            InitializeComponent();

            AllSingleton SingletonInstance = AllSingleton.GetInstance();
            List<Team> AllTeams = SingletonInstance.GetSingletonTeamList();
            List<TeamMember> AllTeamMembers = SingletonInstance.GetSingletonTeamMemberList();
            List<Player> AllPlayers = SingletonInstance.GetSingletonPlayerList();
            List<Coach> AllCoaches = SingletonInstance.GetSingletonCoachList();

            foreach (Player i in AllPlayers)
            {
                DG_Player.Items.Add(i);
                CB_Select_Player.Items.Add(i.MemberInGameName);
            }

            foreach (Coach i in AllCoaches)
            {
                DG_Coach.Items.Add(i);
                CB_Coach_Timeout.Items.Add(i.MemberInGameName);
            }

        }

        // method for calculating the KD of a player
        public void CalculateKD(float x, float y)
        {
            AllSingleton SingletonInstance = AllSingleton.GetInstance();
            List<Player> AllPlayers = SingletonInstance.GetSingletonPlayerList();
            AllPlayers[CB_Select_Player.SelectedIndex].KD = y / x;
        }

        private void Player_GetKill_Click(object sender, RoutedEventArgs e)
        {
            AllSingleton SingletonInstance = AllSingleton.GetInstance();
            List<Player> AllPlayers = SingletonInstance.GetSingletonPlayerList();
            TB_PlayerMessage.Text = "";

            if (string.IsNullOrEmpty(CB_Select_Player.Text))
            {
                TB_PlayerMessage.Text = "No player selected.";
            }
            else
            {
                AllPlayers[CB_Select_Player.SelectedIndex].Kills++;

                if ((AllPlayers[CB_Select_Player.SelectedIndex].Kills != 0) || (AllPlayers[CB_Select_Player.SelectedIndex].Deaths != 0))
                {
                    CalculateKD(AllPlayers[CB_Select_Player.SelectedIndex].Deaths, AllPlayers[CB_Select_Player.SelectedIndex].Kills);
                    TB_Update.Text = $" {CB_Select_Player.Text} got a kill, total kills: {AllPlayers[CB_Select_Player.SelectedIndex].Kills}";
                }

                else
                {
                    _Player[CB_Select_Player.SelectedIndex].KD = _Player[CB_Select_Player.SelectedIndex].Kills;
                }
            }

            DG_Player.Items.Refresh();
        }

        // Method for adding a Death
        private void Player_GetDeath_Click(object sender, RoutedEventArgs e)
        {
            AllSingleton SingletonInstance = AllSingleton.GetInstance();
            List<Player> AllPlayers = SingletonInstance.GetSingletonPlayerList();
            if (string.IsNullOrEmpty(CB_Select_Player.Text))
            {
                TB_PlayerMessage.Text = "No player selected.";
            }
            else
            {
                AllPlayers[CB_Select_Player.SelectedIndex].Deaths++;

                if ((AllPlayers[CB_Select_Player.SelectedIndex].Kills != 0) || (AllPlayers[CB_Select_Player.SelectedIndex].Deaths != 0))
                {
                    CalculateKD(AllPlayers[CB_Select_Player.SelectedIndex].Deaths, AllPlayers[CB_Select_Player.SelectedIndex].Kills);
                    TB_Update.Text = $" {CB_Select_Player.Text} died, total deaths: {AllPlayers[CB_Select_Player.SelectedIndex].Deaths}";
                }
            }
            DG_Player.Items.Refresh();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AllSingleton SingletonInstance = AllSingleton.GetInstance();
            List<Coach> AllCoaches = SingletonInstance.GetSingletonCoachList();
            int tempIx = CB_Coach_Timeout.SelectedIndex;
            if (AllCoaches[tempIx].TacticalTimeouts > 0) 
                 {
                     AllCoaches[tempIx].TacticalTimeouts--;
                     TB_Coach_Timeout.Text = $" Timeout called by {AllCoaches[tempIx].MemberInGameName}, Using Timeout. 30 seconds";
                      DG_Coach.Items.Refresh();
                 }
            else
            {
                TB_Coach_Timeout.Text = $" Timeout called by {AllCoaches[tempIx].MemberInGameName}, No Timeouts left";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var newForm = new MainWindow();
            newForm.Show();
            this.Close();
        }
    }
}
