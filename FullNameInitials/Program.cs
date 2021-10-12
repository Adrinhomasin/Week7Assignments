using System;

namespace FullNameInitials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisestage eesnimi");
            string firstname = Console.ReadLine();
            Console.WriteLine("sisestage perekonnanimi");
            string lastname = Console.ReadLine();

            Console.WriteLine($"tere, {firstname[0]}. {lastname[0]}");
        }
    }
}
