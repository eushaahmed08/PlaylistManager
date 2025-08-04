using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PlaylistManagerApp
{
    internal class Song
    {
        public string FilePath { get; set; }
        public string Title { get; set; }
        public TimeSpan Duration { get; set; }


        //method to get the file name from the file path
        // For now, let's just use the file name as the title.
        // Later  might use a library to read actual ID3 tags.
        public Song(string filepath) {
            FilePath = filepath;
            Title = Path.GetFileNameWithoutExtension(filepath);
            Duration = TimeSpan.Zero;// Initialized to zero, will be updated later (Extra)
        }

        public override string ToString()
        {
            return $"{Title} - {Duration:mm\\:ss}";
        }   
    }
}
