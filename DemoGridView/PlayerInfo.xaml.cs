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
        public List<Player> _Player;
        public List<Coach> _Coach;

        public PlayerInfo()
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

            // Declare Players 
            Player S1mple = new Player();
            S1mple.MemberInGameName = Simple.MemberInGameName;
            S1mple.Kills = 0;
            S1mple.Deaths = 0;
            S1mple.KD = 0.00F;

            Player Get_Right = new Player();
            Get_Right.MemberInGameName = GetRight.MemberInGameName;
            Get_Right.Kills = 0;
            Get_Right.Deaths = 0;
            Get_Right.KD = 0.00F;

            Player Dev1ce = new Player();
            Dev1ce.MemberInGameName = Device.MemberInGameName;
            Dev1ce.Kills = 0;
            Dev1ce.Deaths = 0;
            Dev1ce.KD = 0.00F;

            // Declare Coaches 
            Coach Threat = new Coach();
            Threat.MemberInGameName = "THREAT";
            Threat.TeamName = Nip.TeamName;
            Threat.TacticalTimeouts = 4;

            Coach Glave = new Coach();
            Glave.MemberInGameName = "gla1ve";
            Glave.TeamName = Astralis.TeamName;
            Glave.TacticalTimeouts = 4;

            Coach Blade = new Coach();
            Blade.MemberInGameName = "B1ad3";
            Blade.TeamName = Navi.TeamName;
            Blade.TacticalTimeouts = 4; 


            //Add item to List Player 
            _Player = new List<Player>();
            _Player.Add(S1mple);
            _Player.Add(Get_Right);
            _Player.Add(Dev1ce);

            //Add item to List Coach
            _Coach = new List<Coach>();
            _Coach.Add(Threat);
            _Coach.Add(Glave);
            _Coach.Add(Blade);

            // Add data to Player grid 
            DG_Player.Items.Add(_Player[0]);
            DG_Player.Items.Add(_Player[1]);
            DG_Player.Items.Add(_Player[2]);


            // Add Data to Player Combobox
            CB_Select_Player.Items.Add(_Player[0].MemberInGameName);
            CB_Select_Player.Items.Add(_Player[1].MemberInGameName);
            CB_Select_Player.Items.Add(_Player[2].MemberInGameName);

            // Add data to Coach grid
            DG_Coach.Items.Add(_Coach[0]);
            DG_Coach.Items.Add(_Coach[1]);
            DG_Coach.Items.Add(_Coach[2]);

            // Add Data to Coach Combobox 
            CB_Coach_Timeout.Items.Add(_Coach[0].MemberInGameName);
            CB_Coach_Timeout.Items.Add(_Coach[1].MemberInGameName);
            CB_Coach_Timeout.Items.Add(_Coach[2].MemberInGameName);
        }

        // method for calculating the KD of a player
        public void CalculateKD(float x, float y)
        {
            _Player[CB_Select_Player.SelectedIndex].KD = y / x;
        }

        private void Player_GetKill_Click(object sender, RoutedEventArgs e)

        {
            TB_PlayerMessage.Text = "";

            if (string.IsNullOrEmpty(CB_Select_Player.Text))
            {
                TB_PlayerMessage.Text = "No player selected.";
            }
            else
            {
                _Player[CB_Select_Player.SelectedIndex].Kills++;

                if ((_Player[CB_Select_Player.SelectedIndex].Kills != 0) || (_Player[CB_Select_Player.SelectedIndex].Deaths != 0))
                {
                    CalculateKD(_Player[CB_Select_Player.SelectedIndex].Deaths, _Player[CB_Select_Player.SelectedIndex].Kills);
                    TB_Update.Text = $" {CB_Select_Player.Text} got a kill, total kills: {_Player[CB_Select_Player.SelectedIndex].Kills}";
                }

                else
                {
                    _Player[CB_Select_Player.SelectedIndex].KD = _Player[CB_Select_Player.SelectedIndex].Kills;
                }
            }

            DG_Player.Items.Refresh();
        }

        private void Player_GetDeath_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(CB_Select_Player.Text))
            {
                TB_PlayerMessage.Text = "No player selected.";
            }
            else
            {
                _Player[CB_Select_Player.SelectedIndex].Deaths++;

                if ((_Player[CB_Select_Player.SelectedIndex].Kills != 0) || (_Player[CB_Select_Player.SelectedIndex].Deaths != 0))
                {
                    CalculateKD(_Player[CB_Select_Player.SelectedIndex].Deaths, _Player[CB_Select_Player.SelectedIndex].Kills);
                    TB_Update.Text = $" {CB_Select_Player.Text} died, total deaths: {_Player[CB_Select_Player.SelectedIndex].Deaths}";
                }
            }
            DG_Player.Items.Refresh();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int tempIx = CB_Coach_Timeout.SelectedIndex;
            if (_Coach[tempIx].TacticalTimeouts > 0) 
                 {
                     _Coach[tempIx].TacticalTimeouts--;
                     TB_Coach_Timeout.Text = $" Timeout called by {_Coach[tempIx].MemberInGameName}, Using Timeout. 30 seconds";
                      DG_Coach.Items.Refresh();
                 }
            else
            {
                TB_Coach_Timeout.Text = $" Timeout called by {_Coach[tempIx].MemberInGameName}, No Timeouts left";
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
