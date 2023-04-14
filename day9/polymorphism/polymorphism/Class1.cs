using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class shape
    {
        public virtual void Drawshape()
        {
            Console.WriteLine("drawing shape");
        }
    }
    class Circle : shape
    {
        public override void Drawshape()

        {
            Console.WriteLine("drawing circle");
        }
    }

    class Rectangle : shape
    {
        public override void Drawshape()

        {
            Console.WriteLine("drawing rectangle");
        }
    }
}
