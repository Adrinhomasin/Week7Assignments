using System;

namespace Randomletter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisestage eesnimi");
            string name = Console.ReadLine();
            Random rnd = new Random();
            int rndletter = rnd.Next(0, name.Length);



            Console.WriteLine(name[rndletter]);
        }
    }
}
