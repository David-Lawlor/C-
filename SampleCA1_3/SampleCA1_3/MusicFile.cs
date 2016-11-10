using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCA1_3
{
    public enum Genre
    {
        Pop, Rock, Dance, HipHop, Rap, Other
    }


    public class MusicFile : MediaFile
    {
        private string title;

        private string artist;

        private Genre genre;

        public MusicFile(string filename, string title, string artist, Genre genre)
            : base(filename)
        {
            if (String.IsNullOrEmpty(title))
            {
                throw new ArgumentException();
            }
            if (String.IsNullOrEmpty(artist))
            {
                throw new ArgumentException();
            }
            this.title = title;
            this.artist = artist;
            this.genre = genre;
        }

        public MusicFile(string filename, string title, string artist)
            : this(filename, title, artist, Genre.Other){}

        public string Title
        {
            get
            {
                return this.title;
            }
        }

        public string Artist
        {
            get
            {
                return this.artist;
            }
        }

        public Genre Genre
        {
            get
            {
                return this.genre;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("Title: {0}\nArtist: {1}\nGenre: {2}", this.Title, this.Artist, this.Genre.ToString());
        }
    }
}
