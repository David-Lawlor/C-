using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    public enum Gender{
        Male, Female
    }

    class Student
    {
        public string StudentID { get; set; }

        public string Name { get; set; }

        public Gender StudentGender { get; set; }

        public override string ToString()
        {
            return string.Format("\tStudent ID: {0}\n\tName: {1}\n\tGender: {2}\n", StudentID, Name, StudentGender);
        }

        public Student(string id, string name, Gender gender)
            : base()
        {
            this.StudentID = id;
            this.Name = name;
            this.StudentGender = gender;
        }
    }
}
