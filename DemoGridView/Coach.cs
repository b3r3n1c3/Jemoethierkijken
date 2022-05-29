using System;
using System.Collections.Generic;
using System.Text;

namespace DemoGridView
{
    public class Coach : TeamMember
    {
        public int TacticalTimeouts { get; set; }

        public Coach(int CTimeouts, TeamMember MemberTeam, Team team) : base(MemberTeam.MemberName, MemberTeam.MemberAge, MemberTeam.MemberInGameName, team)
        {
            TacticalTimeouts = CTimeouts;
        }
    }
}
