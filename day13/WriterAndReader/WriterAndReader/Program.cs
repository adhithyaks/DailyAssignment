using System;

using System.IO;
using System.Linq;
using System.Text;
class WriterAndReader
{


    static string file = @"D:\UST  DEMO";
        static void Main()
        {

        Write();

        Read();

        }
    static void Write()
    {
        StreamWriter fileStream = new StreamWriter(file);
        fileStream.WriteLine("what is this lide if,full of care,");
        fileStream.WriteLine("we have no time to stand and stare");
        fileStream.Close();
    }
    static void Read()
    {
        StreamReader fileStream = new StreamReader(file);
        string s = null;
        while((s = fileStream.ReadLine()) != null)
        {
            Console.WriteLine(s);
        }

        
        fileStream.Close();
    }

}
