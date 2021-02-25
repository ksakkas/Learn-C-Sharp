using System;

namespace _3_Casting
{
    class Casting
    {
        static void Main(string[] args)
        {
            //Μετατροπή τύπων (casting)
            double d = 5.75;
            int dn = (int) d;
            Console.WriteLine(dn);

            //2ος Τρόπος
            double txt = 10.552;
            Console.WriteLine(Convert.ToString(txt));


        }
    }
}
