using System;

namespace _4_input
{
    class Input
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give a number");

            string inp = Console.ReadLine();

            Console.WriteLine("Number is: " + inp);

            //------------------------------------------

            Console.WriteLine("Give a number");
            int inpt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Numer (int) is: " + inpt);

        }
    }
}
