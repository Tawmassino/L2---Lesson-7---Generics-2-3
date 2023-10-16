using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2___Lesson_7___Generics_2
{
    internal class Klase2<T>
    {
        //FIELDS

        //PROPERTIES

        private readonly List<T> MyList; //readonly negali buti get set ir nustatymo



        //CONSTRUCTORS
        public Klase2(List<T> userList)//konstruktoriuje sudarome nauja sarasa, pririsame kas bus nurodyta mainprogram prie sitos klases
                                       //kadangi nerea get set, sito keisti nebus galima
        {
            MyList = userList;

        }

        // ==================  METHODS ==================  
        //print list
        public void PrintList()//neleidzia imt tiesiai is property list
        {
            foreach (T item in MyList)
            {
                Console.WriteLine(item);
            }
        }

        //convert to array
        public T[] ListToArray()
        {
            T[] newArray = MyList.ToArray();
            return newArray;
        }

        //bool - check if element exists
        public bool ElementExists(T userinput)
        {
            return MyList.Contains(userinput);
            //for (int i = 0; i < MyList.Count; i++)
            //{

            //    if (userinput == MyList[i])
            //    {
            //        return true;
            //    }
            //    else { return false; }
            //}

        }
        //find one element, otherwise - exception
        public T FindElement(T userinput)
        {
            //for (int i = 0; i<MyList.Count; i++)
            //{
            //    if (userinput != MyList[i])
            //    {
            //        return thrownewexception;
            //    }
            //    else
            //    {
            //        return;
            //    }
            //}

            //for (int i = 0; i < MyList.Count; i++)
            //{
            //    if (userinput.Equals(MyList[i]))
            //    {
            //        return MyList[i];
            //    }

            //}

            // MyList.FirstOrDefault(userinput);
            var kazkas = MyList.Find(x => x.Equals(userinput));
            return kazkas;

            //find one element


            // ================== END OF METHODS ==================

        }
    }
}
