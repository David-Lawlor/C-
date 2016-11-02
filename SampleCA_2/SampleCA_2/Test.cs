using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCA1_2
{
    class Test
    {
        static void Main(string[] args)
        {

            ToDoList tdl = new ToDoList("Dave");

            ToDoNote note1 = new ToDoNote("College", DateTime.Now, Priority.High);
            ToDoNote note2 = new ToDoNote("College", DateTime.Now, Priority.Medium);

            tdl.addNote(note1);
            tdl.addNote(note2);

            tdl[0].OutputToFile();

            Console.ReadLine();
        }
    }
}
