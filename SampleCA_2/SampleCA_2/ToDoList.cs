using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCA1_2
{

    public class ToDoList
    {
        private string owner;

        private ArrayList notes;

        public ToDoList(string owner)
        {
            this.owner = owner;
            notes = new ArrayList();
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                this.owner = value;
            }
        }

        public ToDoNote this[int index]
        {
            get
            {
                if (index < 0 || index > notes.Count)
                {
                    throw new ArgumentException("Invalid note index");
                }
                else
                {
                    return (ToDoNote)notes[index];
                }
            }
        }

        public void addNote(ToDoNote note)
        {
            this.notes.Add(note);
        }
    }
}
