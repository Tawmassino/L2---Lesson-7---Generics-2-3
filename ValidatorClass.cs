using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2___Lesson_7___Generics_2
{
    public static class ValidatorClass<T>
    {

        //FIELDS

        //PROPERTIES

        //CONSTRUCTORS


        // ======================  METHODS ====================  

        public static bool CheckIfNotNull(T userInput)
        {
            return userInput != null;
        }

        // ================== END OF METHODS ==================


    }
}
