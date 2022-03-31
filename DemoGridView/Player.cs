using System;
using System.Collections.Generic;
using System.Text;

namespace DemoGridView
{
    public class Player : TeamMember
    {
        public int Kills { get; set; }
        public int Deaths { get; set; }
        public float KD { get; set; }
    }
}
