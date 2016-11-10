using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCA1_4
{
    public class SoccerTeam : IEnumerable
    {
        public string TeamName { get; set; }

        public Gender TeamGender { get; set; }

        private int ageLimit;

        private List<SoccerPlayer> players;

        const int minimumAge = 5;
                
        public int AgeLimit
        {
            get
            {
                return this.ageLimit;
            }
            set
            {
                if (value < minimumAge)
                {
                    throw new ArgumentException();
                }
                else
                {
                    this.ageLimit = value;
                }

            }
        }

        public SoccerTeam(string teamName, Gender gender, int ageLimit)
        {
            this.TeamName = teamName;
            this.TeamGender = gender;
            this.AgeLimit = ageLimit;
            players = new List<SoccerPlayer>();
        }

        public IEnumerator GetEnumerator()
        {
            foreach (SoccerPlayer sp in players)
            {
                yield return sp;
            }
        }

        public IEnumerable<SoccerPlayer> this[string name]
        {
            get
            {
                if ( this.players.Count(x => x.Name.Equals(name)) == 0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    return this.players.Where(x => x.Name.Equals(name));
                }
            }
        }

        public void AddPlayer(SoccerPlayer player)
        {
            if (player.Age > minimumAge)
            {
                this.players.Add(player);
            }
        }
    }
}
