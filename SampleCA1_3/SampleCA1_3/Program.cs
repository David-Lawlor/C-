using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCA1_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // create some tracks and add to a playlist

                MusicFile track1 = new MusicFile("t1.mp3", "I follow Rivers", "Likki Li", Genre.Dance);
                MusicFile track2 = new MusicFile("t2.mp3", "Since I Left You", "The Avalanches", Genre.Dance);
                MusicFile track3 = new MusicFile("t3.mp3", "Run to the Hills", "Iron Maiden", Genre.Rock);
                MusicFile track4 = new MusicFile("t4.mp3", "Were the people", "Empire of the Sun");
                MusicFile track5 = new MusicFile("t5.mp3", "Rhythm is a Dancer", "Snap", Genre.Dance);

                Playlist playlist = new Playlist("Cool Tunes");
                playlist.AddTrack(track1);
                playlist.AddTrack(track2);
                playlist.AddTrack(track3);
                playlist.AddTrack(track4);
                playlist.AddTrack(track5);

                //MusicFile duplicate = new MusicFile("t6.mp3", "Since I Left You", "The Avalanches");
                //playlist.AddTrack(duplicate);

                // test iterator
                Console.WriteLine("All tracks on " + playlist.PlaylistName);
                foreach (MusicFile track in playlist.Tracks)
                {
                    Console.WriteLine(track);
                }

                // test indexers
                Console.WriteLine("\nDance tracks on " + playlist.PlaylistName);
                foreach (MusicFile track in playlist[Genre.Dance])
                {
                    Console.WriteLine(track);
                }

                Console.WriteLine("\nPop tracks on " + playlist.PlaylistName);
                foreach (MusicFile track in playlist[Genre.Pop])
                {
                    Console.WriteLine(track);
                }

                Console.ReadLine();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
