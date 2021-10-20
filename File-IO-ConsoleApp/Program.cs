using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_IO_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Please enter a number:");
            string number = string.Format(Console.ReadLine());
            File.WriteAllText(@"C:\Users\Chadp\Documents\logs\number.txt", number);
            string text = File.ReadAllText(@"C:\Users\Chadp\Documents\logs\number.txt");
            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}
