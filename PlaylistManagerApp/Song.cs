using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TagLib; // Add this using directive after installing TagLibSharp

namespace PlaylistManagerApp
{
    public class Song
    {
        public string FilePath { get; set; }
        public string Title { get; set; }
        public TimeSpan Duration { get; set; }

        public Song(string filePath)
        {
            FilePath = filePath;
            Title = Path.GetFileNameWithoutExtension(filePath); // Default title
                  

            // Try to read metadata using TagLibSharp
            try
            {
                using (var file = TagLib.File.Create(filePath))
                {
                    if (file != null)
                    {
                        // Get title from metadata if available, otherwise fallback to file name
                        Title = string.IsNullOrEmpty(file.Tag.Title) ? Path.GetFileNameWithoutExtension(filePath) : file.Tag.Title;
                        Duration = file.Properties.Duration;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle cases where the file is not a valid audio file or cannot be read
                Console.WriteLine($"Error reading metadata for {filePath}: {ex.Message}");
                Duration = TimeSpan.Zero; // Default to zero if reading fails
            }
        }

        public override string ToString()
        {
            // Format duration as MM:SS
            string formattedDuration = Duration.TotalSeconds > 0 ? $" - {Duration:mm\\:ss}" : "";
            return $"{Title}{formattedDuration}";
        }
    }
}
