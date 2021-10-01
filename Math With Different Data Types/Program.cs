using System;

namespace Math_With_Different_Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var num1 = 4;
            var num2 = 9;
            var addNumbers = num1 + num2; // addNumbers equals 13
            var subtractNumbers = num2 - num1; // subtractNumbers equals 5
            var multiplyNumbers = num1 * num2; // multiplyNumbers equals 36
            var divideNumbers = num2 / num1; // divideNumbers equals 2.25

            int num1 = 7;
            float num2 = 5.5f;

            //??? total = num1 + num2;

            //What type of data type should you assign to the variable “total”? If you assign it to “int,” then the compiler wouldn’t know what to do with the extra .5 in “num2.”
            //So the answer is always to assign the resulting data type to the most specific one. In this case, a “float” can have decimal places, so it is the most specific:

            float total = num1 + num2;

            //If you needed “total” to be of type “int,” then you would need to cast num2 to int before performing the calculation:

            int total = num1 + (Int32)num2;

            //When casting “down” from a precision number to an integer, the numbers after the decimal are lost. In other words, it always rounds down.


            //A “float” is 32-bit and a “double” is 64-bit. In other words, a “float” is no more than 7 digits long, and a “double” is no more than 15-16 digits long.
            //So a “double” is the more precise choice. When the compiler converts a “float” to a “double” without being told to, this is called an “implicit conversion.”
            //If we wanted to go the other way and convert a “double” to a “float,” we would have to do an “explicit conversion” on the “double” value.
            //This example code will successfully compile:

            double num1 = 7.03230923;
            float num2 = 5.9f;
            float total = (float)num1 + num2;
            Console.WriteLine(total);

            //The output is 12.93231

            //There is no implicit conversion available from a “float” or “double” to a “decimal.” These conversions must be done “explicitly.”
            //This is due solely to the nature of floats and decimals, which are encoded very differently than other number data types.

            decimal num1 = 7.03230923m;
            int num2 = 5;
            decimal total = num1 + num2;
            Console.WriteLine(total);

            //or

            decimal num1 = 7.03230923m;
            sbyte num2 = 5;
            decimal total = num1 + num2;
            Console.WriteLine(total);

            //both equal a output of 12.03230923

            string name = "Chad";
            int number = 0;
            Console.WriteLine(name + number);

            //the output is Chad0


        }



    }
}
