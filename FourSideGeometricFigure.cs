using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2___Lesson_7___Generics_2
{
    public class FourSideGeometricFigure
    {
        //FIELDS

        //PROPERTIES
        public string Name;
        public double Base;
        public double Height;
        //CONSTRUCTORS
        public FourSideGeometricFigure(string name, double base1, double height)
        {
            Name = name;
            Base = base1;
            Height = height;
        }

        // ==================  METHODS ==================  

        public double GetArea()
        {
            double area = Base * Height;
            return area;
        }

        public override string ToString()
        {
            //return base.ToString();
            return $"The name is {Name}, the base is {Base}, the height is {Height}";
        }
        // ================== END OF METHODS ==================
    }

}


