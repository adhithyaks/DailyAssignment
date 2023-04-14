using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace abstractdimension
{
   
        
        class program
        {
            static void Main()
            {
                figure fig = new square();
                fig.Dimension = 10;
                Console.WriteLine(fig.Area());
                Console.WriteLine(fig.Perimeter());
            }
        }
    }
