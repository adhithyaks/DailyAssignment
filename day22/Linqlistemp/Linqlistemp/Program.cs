

using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace LINQSORTEMP

{

    internal class Program

    {

        static void Main(string[] args)

        {

            {

                List<Employee> EmpList = new List<Employee>();

                EmpList.Add(new Employee("RAM", "KTM"));

                EmpList.Add(new Employee("SAM", "DEL"));

                EmpList.Add(new Employee("JAM", "MUB"));

                EmpList.Add(new Employee("ROY", "GOA"));

                EmpList.Add(new Employee("SHYAM", "TVM"));

                EmpList.Add(new Employee("SITA", "KOZ"));

                var lquery = from Employee employee in EmpList

                             orderby employee.City

                             group employee by employee.City;

                foreach (var f in lquery)

                {

                    Console.WriteLine("Employees with " + f.Key + " city");

                    foreach (var nm in f)

                    {

                        Console.WriteLine("" + nm.Name);

                    }

                }

            }

        }

    }

}





































