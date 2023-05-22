using Microsoft.AspNetCore.SignalR;

namespace Razor_syntax_reference_for_ASP.NET_Core.Models
{
    public class Person
    {
        string name;
        int age;
        public string  Name { get; set; }
        public int Age { get; set; }
         public  Person() { }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
