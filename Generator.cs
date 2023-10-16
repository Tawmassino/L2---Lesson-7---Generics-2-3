using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2___Lesson_7___Generics_2
{
    public class Generator<T>
    {
        //method
        public void Show(T item)
        {
            Console.WriteLine(item.ToString());

        }
    }
}
