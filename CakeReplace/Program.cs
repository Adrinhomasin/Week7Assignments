using System;

namespace CakeReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            string Cake = "the c4ke i3 4 l1e";

            Cake = Cake.Replace('4', 'a');
            Cake = Cake.Replace('1', 'i');
            Cake = Cake.Replace('3', 's');
            Console.WriteLine(Cake);

        }
    }
}
