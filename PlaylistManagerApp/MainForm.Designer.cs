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
            this.lstPlaylists = new System.Windows.Forms.ListBox();
            this.lstSongs = new System.Windows.Forms.ListBox();
            this.btnCreatePlaylist = new System.Windows.Forms.Button();
            this.btnAddSong = new System.Windows.Forms.Button();
            this.btnRemoveSong = new System.Windows.Forms.Button();
            this.btnSavePlaylists = new System.Windows.Forms.Button();
            this.btnLoadPlaylists = new System.Windows.Forms.Button();
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
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnLoadPlaylists);
            this.splitContainer1.Panel1.Controls.Add(this.btnSavePlaylists);
            this.splitContainer1.Panel1.Controls.Add(this.btnRemoveSong);
            this.splitContainer1.Panel1.Controls.Add(this.btnAddSong);
            this.splitContainer1.Panel1.Controls.Add(this.btnCreatePlaylist);
            this.splitContainer1.Panel1.Controls.Add(this.lstPlaylists);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lstSongs);
            this.splitContainer1.Size = new System.Drawing.Size(927, 554);
            this.splitContainer1.SplitterDistance = 308;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // lstPlaylists
            // 
            this.lstPlaylists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPlaylists.FormattingEnabled = true;
            this.lstPlaylists.ItemHeight = 16;
            this.lstPlaylists.Location = new System.Drawing.Point(0, 0);
            this.lstPlaylists.Name = "lstPlaylists";
            this.lstPlaylists.Size = new System.Drawing.Size(308, 554);
            this.lstPlaylists.TabIndex = 0;
            // 
            // lstSongs
            // 
            this.lstSongs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSongs.FormattingEnabled = true;
            this.lstSongs.ItemHeight = 16;
            this.lstSongs.Location = new System.Drawing.Point(0, 0);
            this.lstSongs.Name = "lstSongs";
            this.lstSongs.Size = new System.Drawing.Size(614, 554);
            this.lstSongs.TabIndex = 0;
            // 
            // btnCreatePlaylist
            // 
            this.btnCreatePlaylist.Location = new System.Drawing.Point(0, 322);
            this.btnCreatePlaylist.Name = "btnCreatePlaylist";
            this.btnCreatePlaylist.Size = new System.Drawing.Size(136, 23);
            this.btnCreatePlaylist.TabIndex = 1;
            this.btnCreatePlaylist.Text = "Create New Playlist";
            this.btnCreatePlaylist.UseVisualStyleBackColor = true;
            this.btnCreatePlaylist.Click += new System.EventHandler(this.btnCreatePlaylist_Click);
            // 
            // btnAddSong
            // 
            this.btnAddSong.Location = new System.Drawing.Point(0, 351);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(136, 23);
            this.btnAddSong.TabIndex = 2;
            this.btnAddSong.Text = "Add Song";
            this.btnAddSong.UseVisualStyleBackColor = true;
            this.btnAddSong.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRemoveSong
            // 
            this.btnRemoveSong.Location = new System.Drawing.Point(0, 380);
            this.btnRemoveSong.Name = "btnRemoveSong";
            this.btnRemoveSong.Size = new System.Drawing.Size(136, 23);
            this.btnRemoveSong.TabIndex = 3;
            this.btnRemoveSong.Text = "Remove Song";
            this.btnRemoveSong.UseVisualStyleBackColor = true;
            // 
            // btnSavePlaylists
            // 
            this.btnSavePlaylists.Location = new System.Drawing.Point(3, 409);
            this.btnSavePlaylists.Name = "btnSavePlaylists";
            this.btnSavePlaylists.Size = new System.Drawing.Size(133, 23);
            this.btnSavePlaylists.TabIndex = 4;
            this.btnSavePlaylists.Text = "Save Playlists";
            this.btnSavePlaylists.UseVisualStyleBackColor = true;
            // 
            // btnLoadPlaylists
            // 
            this.btnLoadPlaylists.Location = new System.Drawing.Point(0, 438);
            this.btnLoadPlaylists.Name = "btnLoadPlaylists";
            this.btnLoadPlaylists.Size = new System.Drawing.Size(136, 23);
            this.btnLoadPlaylists.TabIndex = 5;
            this.btnLoadPlaylists.Text = "Load Playlists";
            this.btnLoadPlaylists.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 554);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

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
    }
}

