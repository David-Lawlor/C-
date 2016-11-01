using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("1", "Dave", Gender.Male);
            Student student2 = new Student("2", "George", Gender.Male);
            Student student3 = new Student("3", "Tom", Gender.Male);

            StudentClass class1 = new StudentClass("123", "Mr. T");

            class1.AddStudent(student1);
            class1.AddStudent(student2);
            class1.AddStudent(student3);

            Student student = class1["1"];
            Console.WriteLine(student.Name + " " + student.StudentID);

            //student = class1["177"];
            //Console.WriteLine(student.Name + " " + student.StudentID);

            student = class1[1];
            Console.WriteLine(student.Name + " " + student.StudentID);

            student = class1[3];
            Console.WriteLine(student.Name + " " + student.StudentID);

            Console.ReadLine();
        }
    }
}
