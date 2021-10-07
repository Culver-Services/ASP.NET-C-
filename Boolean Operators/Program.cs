using System;

namespace Boolean_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
         

            Console.WriteLine(true && true);    // output: True
            Console.WriteLine(true && false);   // output: False
            Console.WriteLine(false && true);   // output: False
            Console.WriteLine(false && false);  // output: False

            Console.WriteLine(true || true);    // output: True
            Console.WriteLine(true || false);   // output: True
            Console.WriteLine(false || true);   // output: True
            Console.WriteLine(false || false); // output: False

            Console.WriteLine(true != true);    // output: False
            Console.WriteLine(true != false);   // output: True
            Console.WriteLine(false != true);   // output: True
            Console.WriteLine(false != false);  // output: False

            Console.WriteLine(true ^ true);    // output: False
            Console.WriteLine(true ^ false);   // output: True
            Console.WriteLine(false ^ true);   // output: True
            Console.WriteLine(false ^ false);  // output: False
        }
    }
}
