using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace day13
{

    class Student
    {
        public String name;
        public String lastName;
        public int course;

        public Student(String name, String lastName, int course)
        {
            this.name = name;
            this.lastName = lastName;
            this.course = course;
        }

        public void PrintInfo()
        {
            Console.WriteLine(name);
            Console.WriteLine(lastName);
            Console.WriteLine(course);
        }
    }

}
