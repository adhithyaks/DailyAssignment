using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    internal class Program
    {

        static void Main(string[] args)
        {
            shape s1 = new shape();
            s1.Drawshape();
            Circle c1 = new Circle();
            c1.Drawshape();
            Rectangle R1 = new Rectangle();
            R1.Drawshape();

            shape s2 = new Circle();
            s2.Drawshape();

            shape s3 = new Rectangle();
            s3.Drawshape();

            //array of references to base class referencing
            //derived class object [upcasting]
        }
    }
}
