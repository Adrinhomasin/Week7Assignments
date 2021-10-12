using System;

namespace week7assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //pin 1532
            //kasutajanimi user1
            //parool password1


            int i = 0;
            int counter = 0;

            while (i < 3)
            {
                
                
                Console.WriteLine("Sisestage kasutajanimi");
                string user = Console.ReadLine();
                Console.WriteLine("Sisestage parool");
                string password = Console.ReadLine();
                Console.WriteLine("Sisestage PIN kood");
                string PIN = Console.ReadLine();


                if (PIN == "1532")
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }

                else if ((user == "user1") && (password == "password1") && (PIN == "1532"))
                {
                    Console.WriteLine("Tere tulemast!");
                }
                else if ((user != "user1") && (password == "password1"))
                {
                    Console.WriteLine("Midagi läks valesti. Proovi uuesti.");
                }
                else if ((user == "user1") && (password != "password1"))
                {
                    Console.WriteLine("Midagi läks valesti. Proovi uuesti.");
                }
                else
                {
                    i++; 
                    Console.WriteLine($"Proovi uuesti! {3 - i} katset on jäänud.");
                }

            }






        }
    }
}
