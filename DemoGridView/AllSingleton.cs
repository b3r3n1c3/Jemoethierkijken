using System;
using System.Collections.Generic;
using System.Text;

namespace DemoGridView
{
    public sealed class AllSingleton
    {
        // Make list with teams with length not defined 
        public List<Team> _Team;

        //Make list with teammember with length not defined
        public List<TeamMember> _TeamMember;

        // Make list with players with length not defined
        public List<Player> _Player;

        //Make list with coaches with length not defined
        public List<Coach> _Coach;


        private AllSingleton()
        {
            // Declare teams 
            Team Navi = new Team("Natus Vincere", 2009);
            Team Nip = new Team("Ninjas in Pyjama's", 2000);
            Team Astralis = new Team("Astralis", 2016);

            // Add teams to the list
            _Team = new List<Team>();
            _Team.Add(Navi);
            _Team.Add(Nip);
            _Team.Add(Astralis);


            // Declare TeamMembers 
            TeamMember Simple = new TeamMember("Oleksandr Kostyliev", 24, "S1mple", Navi);
            TeamMember GetRight = new TeamMember("Christopher Alesund", 31, "GeT_RiGhT", Nip);
            TeamMember Device = new TeamMember("Nicolai Hvilshøj Reedtz", 26, "dev1ce", Astralis);
            TeamMember CBlade = new TeamMember("Andrii Horodenskyi", 35, "B1ad3", Navi);
            TeamMember CThreat = new TeamMember("Björn Pers", 34, "THREAT", Nip);
            TeamMember CTrace = new TeamMember("Martin Alexander Bang Heldt", 31, "trace", Astralis);

            // Add TeamMembers to list 
            _TeamMember = new List<TeamMember>();
            _TeamMember.Add(Simple);
            _TeamMember.Add(GetRight);
            _TeamMember.Add(Device);

            // Declare Players 
            Player S1mple = new Player(0, 0, 0.00F, Simple, Navi);
            Player Get_Right = new Player(0, 0, 0.00F, GetRight, Nip);
            Player Dev1ce = new Player(0, 0, 0.00F, Device, Astralis);

            // Add Players to list
            _Player = new List<Player>();
            _Player.Add(S1mple);
            _Player.Add(Get_Right);
            _Player.Add(Dev1ce);

            // Declare Coaches 
            Coach Threat = new Coach(4, CThreat, Nip);
            Coach Trace = new Coach(4, CTrace, Astralis);
            Coach Blade = new Coach(4, CBlade, Navi);

            //Add item to List Coach
            _Coach = new List<Coach>();
            _Coach.Add(Threat);
            _Coach.Add(Trace);
            _Coach.Add(Blade);


        }
        private static AllSingleton _AllSingleton;

        public static AllSingleton GetInstance()
        {
            if (_AllSingleton == null)
            {
                _AllSingleton = new AllSingleton();
            }
            return _AllSingleton;
        }
        // Get Singleton Team list
        public List<Team> GetSingletonTeamList()
        {
            return _Team;
        }

        // Method for creating a team 
        public void AddTeam(Team TTeam)
        {
            _Team.Add(TTeam);
        }

        //Method for updating team name 
        public void EditTeamName(Team TTeam, string TName)
        {
            AllSingleton SingletonInstance = AllSingleton.GetInstance();
            List<TeamMember> AllTeammembers = SingletonInstance.GetSingletonTeamMemberList();
            List<Coach> AllCoaches = SingletonInstance.GetSingletonCoachList();



            // Update team name
            TTeam.TeamName = TName;
            foreach (TeamMember i in AllTeammembers)
            {
                if (i.TeamName == TTeam.ToString())
                {
                    i.TeamName = TTeam.ToString();
                }
            }

            foreach (Coach i in AllCoaches)
            {
                if (i.TeamName == TTeam.TeamName.ToString())
                {
                    i.TeamName = TTeam.ToString();
                }
            }
        }


        //Method for updating team year 
        public void EditTeamYear(Team TTeam, string TName, int TYear)
        {
            AllSingleton SingletonInstance = AllSingleton.GetInstance();
            List<TeamMember> AllTeammembers = SingletonInstance.GetSingletonTeamMemberList();

            TTeam.TeamName = TName;
            TTeam.StartYear = TYear;
            foreach (TeamMember i in AllTeammembers)
            {
                if (i.TeamName == TTeam.ToString())
                {
                    i.StartYear = TYear;
                }
            }


        }


        // Method for deleting a team
        public void DeleteTeam(Team TTeam)
        {
            _Team.Remove(TTeam);
        }

        // Get Singleton Teammember list 
        public List<TeamMember> GetSingletonTeamMemberList()
        {
            return _TeamMember;
        }

        // Method for creating a teammember
        public void AddTeam(TeamMember TTeammember)
        {
            _TeamMember.Add(TTeammember);
        }
        // method for deleting teammember
        public void DeleteTeammember(TeamMember TTeammember)
        {
            _TeamMember.Remove(TTeammember);
        }

        //method for updating teammember in game name 
        public void UpdateTeammemberInGameName(TeamMember TTeammember, string TIGN)

        {
            AllSingleton SingletonInstance = AllSingleton.GetInstance();
            List<Player> AllPlayers = SingletonInstance.GetSingletonPlayerList();

            // Update In Game Name 
            TTeammember.MemberInGameName = TIGN;
            foreach (Player i in AllPlayers)
            {
                if (i.MemberInGameName == TIGN.ToString())
                {
                    i.MemberInGameName = TIGN.ToString();
                }
            }
        }

        // Get Singleton Player list 
        public List<Player> GetSingletonPlayerList()
        {
            return _Player;
        }

        // Get Singleton Coach list 
        public List<Coach> GetSingletonCoachList()
        {
            return _Coach;
        }

    }

}
