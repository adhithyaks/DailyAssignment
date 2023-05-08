using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.Xml.Linq;

namespace LINQPRAC2

{

    public class Program

    {

        public static void Main()

        {

            // Student collection

            IList<Student> studentList = new List<Student>() {

      new Student() { StudentID = 1, StudentName = "John", Age = 18, StandardID = 1 } ,

        new Student() { StudentID = 2, StudentName = "Steve", Age = 21, StandardID = 1 } ,

        new Student() { StudentID = 3, StudentName = "Bill", Age = 18, StandardID = 2 } ,

        new Student() { StudentID = 4, StudentName = "Ram" , Age = 20, StandardID = 2 } ,

        new Student() { StudentID = 5, StudentName = "Ron" , Age = 21 }

    };

            IList<Standard> standardList = new List<Standard>() {

  new Standard(){ StandardID = 1, StandardName="Standard 1"},

  new Standard(){ StandardID = 2, StandardName="Standard 2"},

  new Standard(){ StandardID = 3, StandardName="Standard 3"}

};

            //Multiple Select and where operator

            /* var studentNames = studentList.Where(s => s.Age > 18)

                        .Select(s => s)

                        .Where(st => st.StandardID > 0)

                        .Select(s => s.StudentName);

             foreach (var name in studentNames)

             {

               Console.WriteLine(name);

             }

            //LINQ Query returns Collection of Anonymous Objects

            var teenStudentsName = from s in studentList

                        where s.Age > 12 && s.Age < 20

                        select new { StudentName = s.StudentName };

            teenStudentsName.ToList().ForEach(s => Console.WriteLine(s.StudentName));

            //LINQ GROUP BY QUERY

            var studentsGroupByStandard = from s in studentList

                           group s by s.StandardID into sg

                           orderby sg.Key

                           select new { sg.Key, sg };

            foreach (var group in studentsGroupByStandard)

            {

              Console.WriteLine("StandardID {0}:", group.Key);

              group.sg.ToList().ForEach(st => Console.WriteLine(st.StudentName));

            }
            // LEFT OUTER JOIN

            var studentsGroup = from stad in standardList

                                join s in studentList

                                on stad.StandardID equals s.StandardID

                                  into sg

                                select new

                                {

                                    StandardName = stad.StandardName,

                                    Students = sg

                                };

            foreach (var group in studentsGroup)

            {

                Console.WriteLine(group.StandardName);

                group.Students.ToList().ForEach(st => Console.WriteLine(st.StudentName));



            }*/
            //SORTING


            
             
             
             
             
             


        }
    }
}

    

   





























