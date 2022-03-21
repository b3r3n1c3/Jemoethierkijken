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

        public TeamInfo()
        {
            InitializeComponent();
            Team Navi = new Team();
            Navi.TeamName = "Natus Vincere";
            Navi.StartYear = 2009;

            Team Nip = new Team();
            Nip.TeamName = "Ninjas in Pyjama's";
            Nip.StartYear = 2000;

            Team Astralis = new Team();
            Astralis.TeamName = "Astralis";
            Astralis.StartYear = 2016;

            TeamMember Simple = new TeamMember();
           // Simple.Team = Navi;
            Simple.TeamName = Navi.TeamName;
            Simple.MemberName = "Oleksandr Kostyliev";
            Simple.MemberAge = 24;
            Simple.MemberInGameName = "S1mple";

            TeamMember GetRight = new TeamMember();
            GetRight.Team = Nip;
            GetRight.TeamName = Nip.TeamName;
            GetRight.StartYear = Nip.StartYear;
            GetRight.MemberName = "Christopher Alesund";
            GetRight.MemberAge = 31;
            GetRight.MemberInGameName = "GeT_RiGhT";

            TeamMember Device = new TeamMember();
            // Device.TeamName = "Astralis";
            // Device.StartYear = 2016;
            Device.Team = Astralis;
            Device.MemberName = "Nicolai Hvilshøj Reedtz";
            Device.MemberAge = 26;
            Device.MemberInGameName = "dev1ce";


            _Teammember = new List<TeamMember>();
            _Teammember.Add(Simple);
            _Teammember.Add(GetRight);
            _Teammember.Add(Device);

            DataGrid2.Items.Add(_Teammember[0]);
            DataGrid2.Items.Add(_Teammember[1]);
            DataGrid2.Items.Add(_Teammember[2]);




        }





    }

}

