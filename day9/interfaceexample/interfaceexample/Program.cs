using interfaceexample;
using System;
using System.Diagnostics.Eventing.Reader;

class program
{
    public static void Main(string[] args)
    {
        IFigure fig = null;
        Console.WriteLine("enter c for circle or s for square ");
        string ch = Console.ReadLine();
        if (ch == "s") 
        fig = new Square();
        else if (ch == "c") 
        fig = new circle();
        fig.Dimension = 10;
        Console.WriteLine(fig.Area());
        Console.WriteLine(fig.Perimeter());
    }
}



