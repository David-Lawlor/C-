using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCA1_3
{
    public class Playlist : IEnumerable
    {
        public string PlaylistName { get; set; }

        List<MusicFile> tracks;

        public Playlist(string playlistName)
        {
            this.PlaylistName = playlistName;
            tracks = new List<MusicFile>();
        }

        public List<MusicFile> Tracks
        {
            get
            {
                return tracks;
            }
        }

        public void AddTrack(MusicFile mf)
        {
            if (tracks.Count(x => x.Title.Equals(mf.Title) && x.Artist.Equals(mf.Artist)) == 1)
            {
                throw new ArgumentException("Playlist already contains track");
            }
            else
            {
                tracks.Add(mf);
            }
        }


        public IEnumerator GetEnumerator()
        {
            foreach (MusicFile track in tracks)
            {
                yield return track;
            }
        }

        public IEnumerable<MusicFile> this[Genre genre]
        {
            get
            {
                var p = this.tracks.Where(x => x.Genre == genre);
                return p;
            }
        }
    }
}
