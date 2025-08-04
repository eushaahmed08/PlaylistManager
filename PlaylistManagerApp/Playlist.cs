using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaylistManagerApp
{
    public class Playlist
    {
        public string Name { get; set; }
        public List<Song> Songs { get;  set; }
        public Playlist(string name)
        {
            Name = name;
            Songs = new List<Song>();
        }


        //Method to add a song
        public void AddSong(Song song)
        {
            if (song != null && !Songs.Any(s=>s.FilePath==song.FilePath))
            {
                Songs.Add(song);
            }
        }

        //to remove a song
        public void RemoveSong(Song song)
        {
            
            Songs.Remove(song);
            
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
