using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2___Lesson_7___Generics_2
{
    public class SportsLeague
    {
        //FIELDS

        //PROPERTIES
        public List<Team> LeagueBeginner { get; set; } = new List<Team>();
        public List<Team> LeagueIntermediate { get; set; } = new List<Team>();
        public List<Team> LeagueProfessional { get; set; } = new List<Team>();


        //CONSTRUCTORS - generic class doesn't have objects


        // ==================  METHODS ==================  

        public List<Team> AddToBeginner(List<Team> teams, string sportType)
        {
            List<Team> beginnerLeague = new List<Team>();
            foreach (var team in teams)
            {
                if (team.League.ToLower().Contains("beginner") && team.SportType == sportType)
                {
                    beginnerLeague.Add(team);
                }
                else if (team.SportType != sportType)
                {
                    Console.WriteLine($"We cannot add {team.TeamName} because it's not in the same category.");
                }
            }
            return beginnerLeague;
        }

        public List<Team> AddToIntermediate(List<Team> teams, string sportType)
        {

            List<Team> intermediateLeague = new List<Team>();
            foreach (var team in teams)
            {
                if (team.League.ToLower().Contains("intermediate") && team.SportType == sportType)
                {
                    intermediateLeague.Add(team);
                }
                else if (team.SportType != sportType)
                {
                    Console.WriteLine($"We cannot add {team.TeamName} because it's not in the same category.");
                }
            }
            return intermediateLeague;

        }

        public List<Team> AddToProfessional(List<Team> teams, string sportType)
        {
            List<Team> professionalLeague = new List<Team>();
            foreach (var team in teams)
            {
                if (team.League.ToLower().Contains("professional") && team.SportType == sportType)
                {
                    professionalLeague.Add(team);
                }
                else if (team.SportType != sportType)
                {
                    Console.WriteLine($"We cannot add {team.TeamName} because it's not in the same category.");
                }
            }
            return professionalLeague;
        }


        public Dictionary<string, List<Team>> MoreGenericCategorize(List<Team> teams, string sportType)
        {
            Dictionary<string, List<Team>> categorizedLeagues = new Dictionary<string, List<Team>>
    {
        { "Beginner", new List<Team>() },
        { "Intermediate", new List<Team>() },
        { "Professional", new List<Team>() }
    };

            foreach (var team in teams)
            {
                string category = CategorizeTeam(team, sportType);
                if (category != null)
                {
                    categorizedLeagues[category].Add(team);
                }
            }

            return categorizedLeagues;
        }

        private string CategorizeTeam(Team team, string sportType)
        {
            string league = team.League.ToLower();
            if (league.Contains("beginner") && team.SportType == sportType)
            {
                return "Beginner";
            }
            else if (league.Contains("intermediate") && team.SportType == sportType)
            {
                return "Intermediate";
            }
            else if (league.Contains("professional") && team.SportType == sportType)
            {
                return "Professional";
            }

            Console.WriteLine($"Team '{team.TeamName}' does not have a valid category and won't be added.");
            return null;
        }

        //public List<Team> CategorizeIntoLeagues(List<Team> teams, string sportType)
        //{
        //    Dictionary<string, List<Team>> categorizedTeams = new Dictionary<string, List<Team>>();

        //    categorizedTeams["Beginner"] = new List<Team>();
        //    categorizedTeams["Intermediate"] = new List<Team>();
        //    categorizedTeams["Professional"] = new List<Team>();


        //}

        public void ShowTeamInfo()
        {
            //Console.WriteLine($"The name of the team is: {TeamName}");
            //Console.WriteLine($"The sport type is: {SportType}");
            //Console.WriteLine($"The league is: {League}");
        }

        public void ShowAllTeams(List<Team> beginnerLeague, List<Team> intermediateLeague, List<Team> professionalLeague)
        {
            Console.WriteLine($"Beginner Leage: ");
            foreach (var team in beginnerLeague)
            {
                Console.WriteLine(team);
            }

            Console.WriteLine($"Intermediate Leage: ");
            foreach (var team in intermediateLeague)
            { Console.WriteLine(team); }

            Console.WriteLine($"Professional Leage: ");
            foreach (var team in professionalLeague)
            {
                Console.WriteLine(team);
            }
        }


        // ================== END OF METHODS ==================

    }

    // end of class



}
