using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2___Lesson_7___Generics_2
{
    public class Klase1<T1, T2>
    {
        //fields


        //properties
        public T1 Param1 { get; set; }
        public T2 Param2 { get; set; }
        //constructors//

        public Klase1(T1 param1, T2 param2)
        {
            Param1 = param1;
            Param2 = param2;
        }



        // ==================  method ==================  



        //meth1 - print properties of T1
        public void ShowT1()//jau nusirodem <T>
        {
            Console.WriteLine($"Type is : {Param1}");
            //Console.WriteLine($"T1 is of type: {typeof(T1).Name}");

        }
        //meth2 - print properties of T2
        public void ShowT2()
        {
            Console.WriteLine($"Type is : {Param2}");
        }

        //meth 3 - change value of T1
        public void ChangeT1(T1 newValue)
        {
            Param1 = newValue;
        }

        //meth 4 - change value of T2
        public void ChangeT2(T2 newValue)
        {
            Param2 = newValue;

        }

        // ================== end of methods ================== 
    }
}
