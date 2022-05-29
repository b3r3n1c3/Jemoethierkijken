using System;
using System.Collections.Generic;
using System.Text;

namespace DemoGridView
{
    public class Player : TeamMember
    {
        public float Kills { get; set; }
        public float Deaths { get; set; }
        public float KD { get; set; }


        public Player(float PKills, float PDeaths, float PKD, TeamMember MemberTeam, Team team) : base(MemberTeam.MemberName, MemberTeam.MemberAge, MemberTeam.MemberInGameName, team)
        {
            Kills = PKills;
            Deaths = PDeaths;
            KD = PKD;
        }
    }
}
