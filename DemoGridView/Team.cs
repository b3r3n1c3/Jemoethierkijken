using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace DemoGridView
{
    public class Team
    {
        public string TeamName { get; set; }
        public int StartYear { get; set; }
        protected string RandomIndex;

        public Team(string TName, int TYear)
        {
            TeamName = TName;
            StartYear= TYear;
            Guid x = Guid.NewGuid();
            RandomIndex = x.ToString();
    }

    }



}
