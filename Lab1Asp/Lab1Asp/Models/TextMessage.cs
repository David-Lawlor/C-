using System;

namespace Lab1Asp.Models
{
    public class TextMessage
    {
        private string content;

        public string PhoneNo { get; set; }

        public string Content
        {
            get { return content; }
            set
            {
                try
                {
                    if (value.Length > 140)
                        throw new ArgumentException();
                    content = value;
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Content cannot be greater than 140 characters in length");
                }
            }
        }
    }
}