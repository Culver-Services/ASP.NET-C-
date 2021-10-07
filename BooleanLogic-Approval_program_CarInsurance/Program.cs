using System;

namespace BooleanLogic_Approval_program_CarInsurance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI?");
            Console.WriteLine("true or false:");
            bool dui = bool.Parse(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?");
            int ticket = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qualified?");
            Console.WriteLine(age > 15 && ticket < 3 && dui == false);
            Console.ReadLine();
        }
    }
}
