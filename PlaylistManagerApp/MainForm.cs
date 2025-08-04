using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json; // For JSON serialization
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace PlaylistManagerApp
{
    public partial class MainForm : Form
    {
        private List<Playlist> playlists;// This will hold all our playlists
        public MainForm()
        {
            InitializeComponent();
            playlists = new List<Playlist>();   //initialize the list of playlists
            UpdatePlaylistListBox(); // Update the playlist list box on form load
        }

        private void UpdatePlaylistListBox()
        {
            lstPlaylists.DataSource = null; // Clear existing binding
            lstPlaylists.DataSource = playlists; // Bind the list of Playlist objects
            lstPlaylists.DisplayMember = "Name"; // Tell the ListBox to display the 'Name' property
                                                 // (This is why the ToString() override is helpful!)
                                                 // If you overrode ToString() in Playlist class to just return Name,
                                                 // you might not strictly need DisplayMember, but it's good practice
                                                 // and clarifies intent.
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCreatePlaylist_Click(object sender, EventArgs e)
        {
            // We need to ask the user for the playlist name.
            // A simple way is to use InputBox or a custom dialog.
            // For simplicity, let's use a simple MessageBox.Prompt for now.
            // In a real app, you'd make a separate small form for input.

            // Let's create a simple input dialog:
            string playlistName = ShowInputDialog("Enter new playlist name:", "Create Playlist");

            if (!string.IsNullOrWhiteSpace(playlistName)) // Check if user entered something
            {
                // Check for duplicate names (optional but good)
                if (playlists.Any(p => p.Name.Equals(playlistName, StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show("A playlist with this name already exists. Please choose a different name.", "Duplicate Playlist", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Playlist newPlaylist = new Playlist(playlistName);
                playlists.Add(newPlaylist);
                UpdatePlaylistListBox(); // Refresh the display
                lstPlaylists.SelectedItem = newPlaylist; // Select the newly created playlist
            }
        }



        // Helper method for a simple input dialog (you can create a separate Form for this later)
        private string ShowInputDialog(string prompt, string title)
        {
            Form promptForm = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = title,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Width = 400, Text = prompt };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 80, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { promptForm.Close(); };
            promptForm.Controls.Add(textBox);
            promptForm.Controls.Add(confirmation);
            promptForm.Controls.Add(textLabel);
            promptForm.AcceptButton = confirmation; // Pressing Enter confirms

            return promptForm.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }


        private void lstPlaylists_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the currently selected playlist
            Playlist selectedPlaylist = lstPlaylists.SelectedItem as Playlist;

            // Ensure a playlist is actually selected
            if (selectedPlaylist != null)
            {
                // Bind the songs of the selected playlist to the lstSongs ListBox
                lstSongs.DataSource = null;
                lstSongs.DataSource = selectedPlaylist.Songs;
                // Remove or comment out this line to use your ToString() method
                // lstSongs.DisplayMember = "Title";
            }
            else
            {
                // No playlist selected, clear the songs list
                lstSongs.DataSource = null;
            }
        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {
            // First, ensure a playlist is selected to add songs to
            Playlist selectedPlaylist = lstPlaylists.SelectedItem as Playlist;
            if (selectedPlaylist == null)
            {
                MessageBox.Show("Please select a playlist first.", "No Playlist Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Use OpenFileDialog to allow the user to select audio files
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Audio Files|*.mp3;*.wav;*.flac|All Files|*.*"; // Filter for audio files
                openFileDialog.Multiselect = true; // Allow selecting multiple files
                openFileDialog.Title = "Select Audio Files to Add";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (string filePath in openFileDialog.FileNames)
                    {
                        Song newSong = new Song(filePath);
                        selectedPlaylist.AddSong(newSong); // Use the AddSong method from our Playlist class
                    }
                    // After adding, refresh the song list for the selected playlist
                    // We can simply call the playlist's SelectedIndexChanged event handler directly
                    lstPlaylists_SelectedIndexChanged(null, null); // Simulate the event
                                                                   // Alternatively, if you want a cleaner update:
                                                                   // lstSongs.DataSource = null;
                                                                   // lstSongs.DataSource = selectedPlaylist.Songs;
                                                                   // lstSongs.DisplayMember = "Title";
                }
            }

        }

        private void btnRemoveSong_Click(object sender, EventArgs e)
        {
            // Ensure a playlist is selected
            Playlist selectedPlaylist = lstPlaylists.SelectedItem as Playlist;
            if (selectedPlaylist == null)
            {
                MessageBox.Show("Please select a playlist first.", "No Playlist Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Ensure a song is selected within the current playlist
            Song selectedSong = lstSongs.SelectedItem as Song;
            if (selectedSong == null)
            {
                MessageBox.Show("Please select a song to remove.", "No Song Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Confirm with the user (good practice for destructive actions)
            DialogResult result = MessageBox.Show($"Are you sure you want to remove '{selectedSong.Title}' from '{selectedPlaylist.Name}'?",
                                                  "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                selectedPlaylist.RemoveSong(selectedSong); // Use the RemoveSong method
                lstPlaylists_SelectedIndexChanged(null, null); // Refresh the song list display
            }
        }

        private void btnSavePlaylists_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Playlist Files (*.json)|*.json|All Files (*.*)|*.*";
                saveFileDialog.Title = "Save Playlists";
                saveFileDialog.FileName = "my_playlists.json"; // Default file name

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Serialize the entire 'playlists' list to JSON
                        string jsonString = JsonSerializer.Serialize(playlists, new JsonSerializerOptions { WriteIndented = true });
                        File.WriteAllText(saveFileDialog.FileName, jsonString);
                        MessageBox.Show("Playlists saved successfully!", "Save Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error saving playlists: {ex.Message}", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void btnLoadPlaylists_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Playlist Files (*.json)|*.json|All Files (*.*)|*.*";
                openFileDialog.Title = "Load Playlists";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string jsonString = File.ReadAllText(openFileDialog.FileName);
                        // Deserialize the JSON string back into our list of playlists
                        List<Playlist> loadedPlaylists = JsonSerializer.Deserialize<List<Playlist>>(jsonString);

                        if (loadedPlaylists != null)
                        {
                            playlists.Clear(); // Clear current playlists
                            playlists.AddRange(loadedPlaylists); // Add loaded playlists
                            UpdatePlaylistListBox(); // Refresh the display

                            // Clear song list if no playlist is selected after loading
                            if (lstPlaylists.SelectedItem == null)
                            {
                                lstSongs.DataSource = null;
                            }
                            MessageBox.Show("Playlists loaded successfully!", "Load Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (FileNotFoundException)
                    {
                        MessageBox.Show("The specified file was not found.", "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (JsonException ex) // Catches errors specific to JSON parsing
                    {
                        MessageBox.Show($"Error parsing playlist file: {ex.Message}", "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Playlist selectedPlaylist = lstPlaylists.SelectedItem as Playlist;
            if (selectedPlaylist == null)
            {
                MessageBox.Show("Please select a playlist first.", "No Playlist Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Sort the songs alphabetically by Title
            selectedPlaylist.Songs = selectedPlaylist.Songs.OrderBy(s => s.Title).ToList();

            // Refresh the song list display
            lstPlaylists_SelectedIndexChanged(null, null);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Playlist selectedPlaylist = lstPlaylists.SelectedItem as Playlist;
            if (selectedPlaylist == null)
            {
                MessageBox.Show("Please select a playlist first to search within.", "No Playlist Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string searchText = txtSearch.Text.Trim(); // Get search text and remove leading/trailing spaces

            if (string.IsNullOrWhiteSpace(searchText))
            {
                // If search box is empty, show all songs in the current playlist
                lstSongs.DataSource = null;
                lstSongs.DataSource = selectedPlaylist.Songs;
                lstSongs.DisplayMember = "Title";
            }
            else
            {
                // Filter songs based on search text (case-insensitive)
                List<Song> filteredSongs = selectedPlaylist.Songs
                                                .Where(s => s.Title.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)// Search by title or file path
                                                .ToList();

                lstSongs.DataSource = null;
                lstSongs.DataSource = filteredSongs;
                lstSongs.DisplayMember = "Title";
            }
        }

        private void lstSongs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
