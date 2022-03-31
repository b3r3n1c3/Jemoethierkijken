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
        public List<Team> _Team;
        public List<Player> _Player;

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

            // Declare Player 
            Player S1mple = new Player();
            S1mple.MemberInGameName = Simple.MemberInGameName;
            S1mple.Kills = 0;
            S1mple.Deaths = 0;
            S1mple.KD = 0.00F;

            //Add item to List Player 
            _Player = new List<Player>();
            _Player.Add(S1mple);

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

            // Add data to grid 
            DG_Player.Items.Add(_Player[0]);

            // Add Data to Combobox
            CB_Select_Player.Items.Add(_Player[0].MemberInGameName);
        }

     public void CalculateKD(float x, float y)
        {

            _Player[CB_Select_Player.SelectedIndex].KD = y / x;

        }

        private void Player_GetKill_Click(object sender, RoutedEventArgs e)

        {
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
                    DG_Player.Items.Remove(_Player[CB_Select_Player.SelectedIndex]);
                    DG_Player.Items.Add(_Player[CB_Select_Player.SelectedIndex]);
                }

                else
                {
                    _Player[CB_Select_Player.SelectedIndex].KD = _Player[CB_Select_Player.SelectedIndex].Kills;
                }
            }

            //DG_Player.Items.Refresh();
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
                }
            }
            DG_Player.Items.Refresh();

        }
    }
}
