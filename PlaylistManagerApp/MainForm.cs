using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
