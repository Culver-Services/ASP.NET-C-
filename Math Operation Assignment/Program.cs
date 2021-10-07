using System;

namespace Math_Operation_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int multi, add, greater, remainder, multiResult, addResult, remainderResult;
            string one, two, three, four, five;
            double divide, divideResult;
            bool greaterResult;


            Console.WriteLine("Enter a number.");
            one = Console.ReadLine();
            multi = Convert.ToInt32(one);
            multiResult = multi * 50;

            Console.WriteLine(multi + " multiplied by 50 equals:");
            Console.WriteLine(multiResult);
            Console.ReadLine();

            Console.WriteLine("Enter another number.");
            two = Console.ReadLine();
            add = Convert.ToInt32(two);
            addResult = add + 25;

            Console.WriteLine(add + " plus 25 equals:");
            Console.WriteLine(addResult);
            Console.ReadLine();

            Console.WriteLine("Enter another number.");
            three = Console.ReadLine();
            divide = Convert.ToDouble(three);
            divideResult = divide / 12.5;

            Console.WriteLine(divide + " divided by 12.5 equals:");
            Console.WriteLine(divideResult);
            Console.ReadLine();

            Console.WriteLine("Enter another number.");
            four = Console.ReadLine();
            greater = Convert.ToInt32(four);
            greaterResult = greater > 50;

            Console.WriteLine(" is " + greater + " greater than 50?");
            Console.WriteLine(greaterResult);
            Console.ReadLine();

            Console.WriteLine("Enter another number.");
            five = Console.ReadLine();
            remainder = Convert.ToInt32(five);
            remainderResult = remainder % 7;

            Console.WriteLine(remainder + " divided by 7 has a remainder of;");
            Console.WriteLine(remainderResult);
            Console.ReadLine();

        }
    }
}