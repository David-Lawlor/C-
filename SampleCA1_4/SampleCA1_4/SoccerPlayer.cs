using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCA1_4
{
    public enum Position{
        goalkeeper, defender, midfielder, striker
    }


    public class SoccerPlayer : SportsPlayer
    {
        public Position Position { get; set; }

        public SoccerPlayer(string name, int age, Gender gender, Position position)
            : base(name, age, gender)
        {
            this.Position = position;
        }

        public SoccerPlayer()
            : this("", 0, Gender.Male, Position.defender)
        {

        }

        public string ToString()
        {
            return base.ToString() + string.Format("Position: {0}\n", this.Position);
        }
    }
}
