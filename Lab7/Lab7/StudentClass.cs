using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
namespace Lab7
{
    class StudentClass
    {
        public List<Student> ClassList { get; set; }

        public string CRN { get; set; }

        public string Lecturer { get; set; }

        public StudentClass(string CRN, string Lecturer)
            : base()
        {
            this.CRN = CRN;
            this.Lecturer = Lecturer;
            this.ClassList = new List<Student>();
        }

        public void AddStudent(Student s)
        {
            try
            {
                foreach (Student stu in ClassList)
                {
                    if (stu.StudentID == s.StudentID)
                    {
                        throw new InvalidOperationException();
                    }
                }
                ClassList.Add(s);
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Student ID already exists");
            }
        }

        public Student this[int i]
        {
            get{
                if (i < 0 || i >= this.ClassList.Count)
                {
                    throw new ArgumentException("Not a valid student. No within limits");
                }
                else
                {
                    return ClassList.ElementAt(i);
                }
            }
        }

        public Student this[string s]
        {
            get
            {
                Student stu = (Student) ClassList.SingleOrDefault(w => w.StudentID == s);
                if (stu != null){
                    return stu;
                }
                else{
                    throw new ArgumentException("No student found with that id");
                }
            }
        }
    }
}
