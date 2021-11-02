using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Employee employee &&
                   Id == employee.Id &&
                   FirstName == employee.FirstName &&
                   LastName == employee.LastName;
        }

        public void SayName()
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
        }

        public void ShowID()
        {
            Console.WriteLine("ID: {0}", Id);
        }

        public static bool operator ==(Employee firstEmployee, Employee secondEmployee)
        {
            if (firstEmployee.Id == secondEmployee.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Employee firstEmployee, Employee secondEmployee)
        {
            if (firstEmployee.Id != secondEmployee.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}