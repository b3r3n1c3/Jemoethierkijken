using System;
using System.Collections.Generic;
using System.Text;


namespace DemoGridView
{


    public sealed class SingletonTeam
    {
        // Make list with teams with length not defined 
        public List<Team> _Team;

        // public string TeamName { get; set; }
        //  public int StartYear { get; set; }

        // Constructor for Singleton class which contains the example teams 
        private SingletonTeam()
        {
            Team Navi = new Team("Natus Vincere", 2009);
            Team Nip = new Team("Ninjas in Pyjama's", 2000);
            Team Astralis = new Team("Astralis", 2016);

            // Add teams to the list
            _Team = new List<Team>();
            _Team.Add(Navi);
            _Team.Add(Nip);
            _Team.Add(Astralis);
        }


        // Add Teams to the list 
        private static SingletonTeam _SingletonTeam;

        public static SingletonTeam GetInstance()
        {
            if (_SingletonTeam == null)
            {
                _SingletonTeam = new SingletonTeam();
            }
            return _SingletonTeam;
        }

        public List<Team> GetSingletonTeamList()
        {
            return _Team;
        }

        // Method for creating a team and add to the list 
        public void AddTeam(Team TTeam)
        {
            _Team.Add(TTeam);
        }

       public void DeleteTeam(Team TTeam)
        {
            _Team.Remove(TTeam);
        }
    }
}
