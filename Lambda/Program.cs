using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> Roster = new List<Employee>();

            Employee Joe_A = new Employee() { Id = 1, FirstName = "Joe", LastName = "Arthur" };
            Employee Joe_B = new Employee() { Id = 2, FirstName = "Joe", LastName = "Belfort" };
            Employee Joe_C = new Employee() { Id = 3, FirstName = "Joe", LastName = "Caruthers" };
            Employee Jenny_D = new Employee() { Id = 4, FirstName = "Jenny", LastName = "Doyle" };
            Employee Jessica_E = new Employee() { Id = 5, FirstName = "Jessica", LastName = "Engel" };
            Employee Jasmine_F = new Employee() { Id = 6, FirstName = "Jasmine", LastName = "Farhad" };
            Employee Ken_G = new Employee() { Id = 7, FirstName = "Ken", LastName = "Goldman" };
            Employee Kathryn_H = new Employee() { Id = 8, FirstName = "Kathryn", LastName = "Holden" };
            Employee Klaus_I = new Employee() { Id = 9, FirstName = "Klaus", LastName = "Ignatius" };
            Employee Zoltan_J = new Employee() { Id = 10, FirstName = "Zoltan", LastName = "Josephson" };

            Roster.Add(Joe_A);
            Roster.Add(Joe_B);
            Roster.Add(Joe_C);
            Roster.Add(Jenny_D);
            Roster.Add(Jessica_E);
            Roster.Add(Jasmine_F);
            Roster.Add(Ken_G);
            Roster.Add(Kathryn_H);
            Roster.Add(Klaus_I);
            Roster.Add(Zoltan_J);

            //create list of Joes using a foreach loop
            Console.WriteLine("Here is a list of all Joes on the employee roster, found using a foreach loop:");
            List<Employee> JoeList = new List<Employee>();
            foreach (Employee employee in Roster)
            {
                if (employee.FirstName == "Joe")
                {
                    JoeList.Add(employee);
                    employee.SayName();
                }
            }

            //now perform same Joe list creation using lambda expression
            Console.WriteLine("Here is a list of all Joes on the employee roster, found using a lambda expression:");
            List<Employee> newJoeList = Roster.Where(x => x.FirstName == "Joe").ToList();
            foreach (Employee employee in newJoeList)
            {
                employee.SayName();
            }

            //make list of all employees with Id number greater than 5 using lambda expression
            Console.WriteLine("Here is a list of all employees with ID greater than 5 on the roster, found using a lambda expression:");
            List<Employee> newEmployees = Roster.Where(x => x.Id > 5).ToList();
            foreach (Employee employee in newEmployees)
            {
                employee.SayName();
                employee.ShowID();

            }

            Console.ReadLine();


        }
    }
}