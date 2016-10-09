using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class ModuleCAResult
    {
        public string ModuleName { get; set; }
        public int Credits { get; set; }
        public string StudentName { get; set; }
        public List<int> Scores;

        public ModuleCAResult(string moduleName, int credits, string studentName, List<int> scores)
        {
            ModuleName = moduleName;
            Credits = credits;
            StudentName = studentName;
            Scores = new List<int>(scores);
        }

        public int GetResult(int ca)
        {
            try
            {
                if (ca <= 0 || ca  > Scores.Count)
                {
                    throw new IndexOutOfRangeException();
                }
                return Scores[ca-1];
            }
            catch (IndexOutOfRangeException){
                Console.WriteLine("Invalid CA specied");
            }
            return -1;
            
        }

        public override string ToString()
        {
            string s = "Module Name: " + ModuleName + "\nCredits: " + Credits + "\nStudent Name: " + StudentName + "\n";
            for (int x = 0; x < Scores.Count; x++)
            {
                s += "CA" + (x + 1) + " " + Scores.ElementAt(x) + "\n";
            }
            return s;
        }


    }
}
