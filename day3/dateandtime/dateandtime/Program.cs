// Date and Time

using System;



namespace Date_and_Time
{

    internal class Program


    {


        static void Main(string[] args)

        {



            DateTime dt = new DateTime();
            Console.WriteLine(dt);



            DateTime dt1 = new DateTime(2015, 12, 3);
            Console.WriteLine(dt1);



            DateTime dt2 = new DateTime(2015, 12, 3, 5, 13, 6);
            Console.WriteLine(dt2);

            DateTime dt3 = new DateTime(2015, 12, 3, 5, 7, 8, DateTimeKind.Utc);
            Console.WriteLine(dt3);

            //throw exception

            //DateTime dt4 = new DateTime (2015, 12, 32);
            // Console.WriteLine(dt4);

            DateTime dt4 = new DateTime(345768000000);
            Console.WriteLine(dt4);
            Console.WriteLine(DateTime.MinValue.Ticks);
            Console.WriteLine(DateTime.MaxValue.Ticks);

            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine(currentDateTime);

            DateTime todaysDate = DateTime.Today;
            Console.WriteLine(todaysDate);

            DateTime currentDateTimeUtc = DateTime.UtcNow;
            Console.WriteLine(currentDateTimeUtc);

            DateTime dt5 = new DateTime(2006, 5, 21);
            TimeSpan ts = new TimeSpan(6, 16, 7);
            DateTime newDate = dt5.Add(ts);
        }
    }
}
