using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCA1_4
{
    public enum Gender{
        Male, Female
    }

    public abstract class SportsPlayer
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Gender Gender { get; set; }

        public SportsPlayer(string name, int age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public override string ToString()
        {
            return string.Format("Name: {0}\nAge: {1}\nGender: {2}\n", this.Name, this.Age, this.Gender);
        }
    }
}
