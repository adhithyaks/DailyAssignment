using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace directorydemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DirectoryInfo temp = new DirectoryInfo("D:\\UST  DEMO\\Test");
            // temp.Create();
            Console.WriteLine("***** Directory Info *****\n");



            DirectoryInfo dir = new DirectoryInfo(@"D:\Windows");
            DriveInfo[] 

            Console.WriteLine("FullName: {0}", dir.FullName);

            Console.WriteLine("Name: {0}", dir.Name);

            Console.WriteLine("Parent: {0}", dir.Parent);

            Console.WriteLine("Creation: {0}", dir.CreationTime);

            Console.WriteLine("Attributes: {0}", dir.Attributes);

            Console.WriteLine("Root: {0}", dir.Root);

            Console.WriteLine("**************************\n");



        }
    }
}
