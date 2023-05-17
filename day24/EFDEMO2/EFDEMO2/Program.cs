using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDEMO2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INSERT
            /*using (var context = new SchoolDBEntities())
            {
                var std = new Student()
                {
                    FirstName = "Bill",
                    LastName = "Gates"
                };
                context.Students.Add(std);

                context.SaveChanges();
            }
            //UPDATE
            using (var context = new SchoolDBEntities())
            {
                var std = context.Students.First<Student>();
                std.FirstName = "Steve";
                context.SaveChanges();
            }*/
            //DELETE
            using (var context = new SchoolDBEntities())
            {
                var std = context.Students.First<Student>();
                context.Students.Remove(std);

                context.SaveChanges();
            }

        }
    }
}
