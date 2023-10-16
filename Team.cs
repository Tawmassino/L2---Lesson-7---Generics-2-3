using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2___Lesson_7___Generics_2
{
    public class Team
    {
        //FIELDS

        //PROPERTIES
        public string TeamName { get; set; }
        public string SportType { get; set; }
        public string League { get; set; }


        //CONSTRUCTORS
        public Team(string teamName, string sportType, string league)
        {
            TeamName = teamName;
            SportType = sportType;
            League = league;
        }


        // ==================  METHODS ==================  


        // ================== END OF METHODS ==================

    }
}
