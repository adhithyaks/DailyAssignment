using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractdimension
{
    internal class Class1
    {
    }
    abstract class figure
    {
        public int Dimension;
        public abstract double Area();
        public abstract double Perimeter();
    }
    class square : figure
    {
        public override double Area()
        {
            return Dimension * Dimension;

        }
        public override double Perimeter()
        {
            return 4 * Dimension;
        }
    }
    class circle : figure
    {
        public override double Area()
        {
            return Math.PI * Dimension * Dimension;
        }
        public override double Perimeter()
        {
            return 2 * Math.PI * Dimension;
        }
    }

}


