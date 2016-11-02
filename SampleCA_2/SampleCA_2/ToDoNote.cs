using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace SampleCA1_2
{
    public enum Priority
    {
        High, Medium, Low
    }

    public class ToDoNote : ISerialisedXML
    {
        private string subject;

        private DateTime dueDate;

        private Priority priority;

        public ToDoNote(String subject, DateTime date, Priority priority)
        {
            this.subject = subject;
            this.dueDate = date;
            this.priority = priority;
        }

        public String Subject
        {
            get
            {
                return subject;
            }
            set
            {
                this.subject = value;
            }
        }

        public DateTime DueDate
        {
            get
            {
                return dueDate;
            }
            set
            {
                this.dueDate = value;
            }
        }

        public Priority Priority
        {
            get
            {
                return priority;
            }
            set
            {
                this.priority = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Subject: {0}\nDue date: {1}\nPriority: {2}", this.subject, this.dueDate.Date, this.priority);
        }

        public void OutputToFile()
        {
            XmlTextWriter writer = new XmlTextWriter("Notes.xml", new UTF8Encoding());

            writer.Formatting = Formatting.Indented;

            writer.WriteStartElement("To-Do-Note");
            writer.WriteElementString("Subject", this.Subject);
            writer.WriteElementString("Due Date", this.DueDate.Date.ToShortDateString());
            writer.WriteElementString("Priority", this.Priority.ToString());
            writer.WriteEndElement();

            writer.Close();

        }
    }
}
