using System;
using System.Collections.Generic;
using System.Text;

namespace DemoGridView
{
    public class TeamMember : Team
    {
        public string MemberName { get; set; }
        public int MemberAge { get; set; }
        public string MemberInGameName { get; set; }
        
        public TeamMember(string TMName, int TMAge, string TMIGN, Team MemberTeam) : base(MemberTeam.TeamName, MemberTeam.StartYear)
        {
            MemberName = TMName;
            MemberAge = TMAge;
            MemberInGameName = TMIGN;
        }
    }
}
