using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression
{
    public class Employee
    {
        //constructor to create a new employee
        public Employee(string fName, string lName, int ID)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.Id = ID;
        }
        //Employees have a firstname, lastname and id
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
    }
}
