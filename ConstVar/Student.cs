using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVar
{
    public class Student
    {
        public Student() : this("", "")
        {
        }

        public Student(string name, string city)
        {
            const string studentName = "Ivan Galas";
            var City = "North Port";
            Console.WriteLine("Student name = {0}, City = {1}", studentName, City);
        }
    }
}