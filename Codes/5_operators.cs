using System;

namespace Operators
{
    class Operators
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 52;
            int z;

            z = x + y;
            Console.WriteLine(z);

            z += 1; //z = z + 1
            Console.WriteLine(z);

            z ^= 2; //z = z ^ 2
            Console.WriteLine(z);
        }
    }
}
/*Operators:
+, -, *, /, %, ++, --
=, +=, -=, *=, /=, %=, &=, |=, ^=, >>=, <<=
==, !=, >, < >=, <=
&&, ||, !
*/
