using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGenetics
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> emp1 = new Employee<string>(1, "Chad", "Culver");
            emp1.things = new List<string>() { "Chad", "Culver", "is", "employed." };
            emp1.things.ForEach(i => Console.Write("{0} ", i));
            Console.ReadLine();

            Employee<int> emp2 = new Employee<int>(2, "Elon", "Musk");
            emp2.things = new List<int>() { 20, 5, 1 };
            emp2.things.ForEach(i => Console.Write("{0} \n", i));
            Console.ReadLine();
        }
    }
}
