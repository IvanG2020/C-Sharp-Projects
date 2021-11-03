// Jacob Kessler 11/22/2019
// NOTE: Program might look like its hanging first time its run while database is created.
// give it time or just run a second time to get proper result

using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new MyContext())
            {
                Console.WriteLine("Add new student");
                Console.WriteLine("First Name?");
                string fName = Console.ReadLine();
                Console.WriteLine("Last Name?");
                string lName = Console.ReadLine();

                var student = new Student
                {
                    FirstName = fName,
                    LastName = lName,
                    EnrollmentDate = DateTime.Parse(DateTime.Today.ToString())
                };

                context.Students.Add(student);
                context.SaveChanges();

                var students = (from s in context.Students orderby s.FirstName select s).ToList<Student>();

                Console.WriteLine("Displaying student database...");

                foreach (var stdnt in students)
                {
                    string name = stdnt.FirstName + " " + stdnt.LastName;
                    Console.WriteLine("ID: {0}, Name: {1}", stdnt.ID, name);
                }

                Console.ReadLine();
            }

        }
    }
}
