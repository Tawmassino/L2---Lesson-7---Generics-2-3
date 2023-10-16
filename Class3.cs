using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2___Lesson_7___Generics_2
{
    internal class Class3<T>
    {
        //FIELDS

        //PROPERTIES
        public List<T> Sarasas { get; set; } = new List<T>();

        //CONSTRUCTORS


        // ======================  METHODS ====================  

        public void PrintList()
        {
            foreach (var item in Sarasas)
            {
                Console.WriteLine(item);
            }
        }

        public T[] ListToArray()
        {
            T[] newArray = Sarasas.ToArray();
            return newArray;
        }

        public void  AddElementToList(T userinput)// nebereikia nurodyti List<T> nes cia void
        {
            var kazkas = ValidatorClass<T>.CheckIfNotNull(userinput);

            Sarasas.Add(userinput);
           // return Sarasas;
        }

        public List<T> AddSeveralElementsToList(List<T> userinput)//void
        {
            

            Sarasas.AddRange(userinput);
            return Sarasas;
        }

        public List<T> RemoveElementFromList(T userinput)//void
        {
            //var x = Sarasas.RemoveAt(userinput); //negalima, nes neaisku ar is vis bus toks elementas?
            //return x;

            if (Sarasas.Contains(userinput))
            {
                Sarasas.Remove(userinput);
            }
            return Sarasas;
        }

        public List<T> RemoveElementFromListAtIndex(int userinput)//void
        {
            if (userinput <= Sarasas.Count) { 

            Sarasas.RemoveAt(userinput);
            }

            return Sarasas;
        }

        public List<T> RemoveElementType(T userinput)//void
        {//nebutinai sarase bus int,

            //skirtumas tarp contains ir equals
            

            for (int i = 0; i < Sarasas.Count; i++)
            {
                
                if (Sarasas[i].Equals(userinput))
                {
                    Sarasas.RemoveAt(i);
                }
            }


            Sarasas.RemoveAll(item => item.Equals(userinput));
            return Sarasas;
        }

        // ================== END OF METHODS ==================

    }
}
