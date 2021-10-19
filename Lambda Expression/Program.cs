using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a list of employees and add 10 employees
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Beth", "Kibble", 1));
            employees.Add(new Employee("Curry", "Bowmer", 2));
            employees.Add(new Employee("Deli", "Bossit", 3));
            employees.Add(new Employee("Reeda", "Alex", 4));
            employees.Add(new Employee("Joe", "Culver", 5));
            employees.Add(new Employee("Chad", "Blues", 6));
            employees.Add(new Employee("Yellerton", "Soup", 7));
            employees.Add(new Employee("Bill", "Burr5", 8));
            employees.Add(new Employee("Joe", "Schmo", 9));
            employees.Add(new Employee("Joe", "Montana", 10));

            //create a list for employees with the name joe
            List<Employee> joes = new List<Employee>();
            //iterate through the employees loop and add ones with the firstname joe to the joe list
            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    joes.Add(employee);
                }
            }
            Console.WriteLine("Joe list created with a foreach loop: ");
            //Display the employees in the Joe list
            foreach (Employee joe in joes)
            {
                Console.WriteLine(joe.FirstName + " " + joe.LastName);
            }

            //use lambda expression to create the list of joes
            List<Employee> newJoeList = employees.Where(x => x.FirstName == "Joe").ToList();

            Console.WriteLine("\nJoe list created with Lambda Expression:");
            //Display the employees in the new Joe list
            foreach (Employee joe in newJoeList)
            {
                Console.WriteLine(joe.FirstName + " " + joe.LastName);
            }

            //use a lambda expression to make a list of all employees with an id greater than 5
            List<Employee> idsGreaterThan5 = employees.Where(x => x.Id > 5).ToList();

            Console.WriteLine("\nEmployees with an id greater than 5: ");
            //Display the employees in the new Joe list
            foreach (Employee employeeName in idsGreaterThan5)
            {
                Console.WriteLine(employeeName.FirstName + " " + employeeName.LastName);
            }
            Console.ReadLine();
        }
    }
}
