using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCA1_3
{
    public abstract class MediaFile
    {
        private string filename;

        public MediaFile(string filename)
        {
            this.filename = filename;
        }

        public string Filename
        {
            get
            {
                return filename;
            }
            set
            {
                if (value != null)
                {
                    this.filename = value;
                }
                else
                {
                    Console.WriteLine("Filename cannot be null");
                }
            }
        }

        public override string ToString()
        {
            return string.Format("Filename: {0}\n", this.Filename);
        }
    }
}
