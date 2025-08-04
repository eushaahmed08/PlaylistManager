using System;
using System.Linq;
using System.Windows.Forms;

namespace PlaylistManagerApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLoadPlaylists = new System.Windows.Forms.Button();
            this.btnSavePlaylists = new System.Windows.Forms.Button();
            this.btnRemoveSong = new System.Windows.Forms.Button();
            this.btnAddSong = new System.Windows.Forms.Button();
            this.btnCreatePlaylist = new System.Windows.Forms.Button();
            this.lstPlaylists = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lstSongs = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.btnLoadPlaylists);
            this.splitContainer1.Panel1.Controls.Add(this.btnSavePlaylists);
            this.splitContainer1.Panel1.Controls.Add(this.btnRemoveSong);
            this.splitContainer1.Panel1.Controls.Add(this.btnAddSong);
            this.splitContainer1.Panel1.Controls.Add(this.btnCreatePlaylist);
            this.splitContainer1.Panel1.Controls.Add(this.lstPlaylists);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button3);
            this.splitContainer1.Panel2.Controls.Add(this.txtSearch);
            this.splitContainer1.Panel2.Controls.Add(this.lstSongs);
            this.splitContainer1.Size = new System.Drawing.Size(927, 554);
            this.splitContainer1.SplitterDistance = 308;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 496);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Sort";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 467);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Shuffle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnLoadPlaylists
            // 
            this.btnLoadPlaylists.Location = new System.Drawing.Point(3, 438);
            this.btnLoadPlaylists.Name = "btnLoadPlaylists";
            this.btnLoadPlaylists.Size = new System.Drawing.Size(136, 23);
            this.btnLoadPlaylists.TabIndex = 5;
            this.btnLoadPlaylists.Text = "Load Playlists";
            this.btnLoadPlaylists.UseVisualStyleBackColor = true;
            this.btnLoadPlaylists.Click += new System.EventHandler(this.btnLoadPlaylists_Click);
            // 
            // btnSavePlaylists
            // 
            this.btnSavePlaylists.Location = new System.Drawing.Point(3, 409);
            this.btnSavePlaylists.Name = "btnSavePlaylists";
            this.btnSavePlaylists.Size = new System.Drawing.Size(133, 23);
            this.btnSavePlaylists.TabIndex = 4;
            this.btnSavePlaylists.Text = "Save Playlists";
            this.btnSavePlaylists.UseVisualStyleBackColor = true;
            this.btnSavePlaylists.Click += new System.EventHandler(this.btnSavePlaylists_Click);
            // 
            // btnRemoveSong
            // 
            this.btnRemoveSong.Location = new System.Drawing.Point(3, 380);
            this.btnRemoveSong.Name = "btnRemoveSong";
            this.btnRemoveSong.Size = new System.Drawing.Size(136, 23);
            this.btnRemoveSong.TabIndex = 3;
            this.btnRemoveSong.Text = "Remove Song";
            this.btnRemoveSong.UseVisualStyleBackColor = true;
            this.btnRemoveSong.Click += new System.EventHandler(this.btnRemoveSong_Click);
            // 
            // btnAddSong
            // 
            this.btnAddSong.Location = new System.Drawing.Point(3, 351);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(136, 23);
            this.btnAddSong.TabIndex = 2;
            this.btnAddSong.Text = "Add Song";
            this.btnAddSong.UseVisualStyleBackColor = true;
            this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click);
            // 
            // btnCreatePlaylist
            // 
            this.btnCreatePlaylist.Location = new System.Drawing.Point(4, 322);
            this.btnCreatePlaylist.Name = "btnCreatePlaylist";
            this.btnCreatePlaylist.Size = new System.Drawing.Size(132, 23);
            this.btnCreatePlaylist.TabIndex = 1;
            this.btnCreatePlaylist.Text = "Create New Playlist";
            this.btnCreatePlaylist.UseVisualStyleBackColor = true;
            this.btnCreatePlaylist.Click += new System.EventHandler(this.btnCreatePlaylist_Click);
            // 
            // lstPlaylists
            // 
            this.lstPlaylists.BackColor = System.Drawing.Color.Black;
            this.lstPlaylists.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lstPlaylists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPlaylists.Font = new System.Drawing.Font("Montserrat SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPlaylists.ForeColor = System.Drawing.Color.White;
            this.lstPlaylists.FormattingEnabled = true;
            this.lstPlaylists.ItemHeight = 20;
            this.lstPlaylists.Location = new System.Drawing.Point(0, 0);
            this.lstPlaylists.Name = "lstPlaylists";
            this.lstPlaylists.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstPlaylists.Size = new System.Drawing.Size(308, 554);
            this.lstPlaylists.TabIndex = 0;
            this.lstPlaylists.SelectedIndexChanged += new System.EventHandler(this.lstPlaylists_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(272, 506);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(17, 506);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(249, 22);
            this.txtSearch.TabIndex = 1;
            // 
            // lstSongs
            // 
            this.lstSongs.BackColor = System.Drawing.Color.Black;
            this.lstSongs.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lstSongs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSongs.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSongs.ForeColor = System.Drawing.Color.White;
            this.lstSongs.FormattingEnabled = true;
            this.lstSongs.ItemHeight = 21;
            this.lstSongs.Location = new System.Drawing.Point(0, 0);
            this.lstSongs.Name = "lstSongs";
            this.lstSongs.Size = new System.Drawing.Size(614, 554);
            this.lstSongs.TabIndex = 0;
            this.lstSongs.SelectedIndexChanged += new System.EventHandler(this.lstSongs_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = global::PlaylistManagerApp.Properties.Resources.Gg5aNPsbgAAjPrO;
            this.ClientSize = new System.Drawing.Size(927, 554);
            this.Controls.Add(this.splitContainer1);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Playlist selectedPlaylist = lstPlaylists.SelectedItem as Playlist;
            if (selectedPlaylist == null)
            {
                MessageBox.Show("Please select a playlist first.", "No Playlist Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Shuffle the songs using LINQ and a random number generator
            Random rng = new Random();
            selectedPlaylist.Songs = selectedPlaylist.Songs.OrderBy(s => rng.Next()).ToList();

            // Refresh the song list display
            lstPlaylists_SelectedIndexChanged(null, null);
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnCreatePlaylist;
        private System.Windows.Forms.ListBox lstPlaylists;
        private System.Windows.Forms.ListBox lstSongs;
        private System.Windows.Forms.Button btnRemoveSong;
        private System.Windows.Forms.Button btnAddSong;
        private System.Windows.Forms.Button btnLoadPlaylists;
        private System.Windows.Forms.Button btnSavePlaylists;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Button button3;
        private TextBox txtSearch;
    }
}

