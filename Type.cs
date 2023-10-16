using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2___Lesson_7___Generics_2
{
    public class Type<T1, T2>
    {
        //FIELDS

        //PROPERTIES
        public T1 Input;
        public T2 Input2;

        //CONSTRUCTORS
        public Type(T1 input, T2 input2)
        {
            Input = input;
            Input2 = input2;

        }

        // ==================  METHODS ==================  

        public void GetType(T1 input)
        {
            Console.WriteLine($"The type of input is: {input.GetType()}");
            //Console.WriteLine($"The type of input2 is: {Input2.GetType()}");

        }

        // ================== END OF METHODS ==================


    }
}
