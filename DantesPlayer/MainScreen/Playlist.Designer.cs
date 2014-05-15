﻿namespace MainScreen
{
    partial class Playlist
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
            this.playListContainer = new System.Windows.Forms.ListBox();
            this.AddPlaylist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playListContainer
            // 
            this.playListContainer.FormattingEnabled = true;
            this.playListContainer.Location = new System.Drawing.Point(0, 27);
            this.playListContainer.Name = "playListContainer";
            this.playListContainer.Size = new System.Drawing.Size(352, 238);
            this.playListContainer.TabIndex = 0;
            this.playListContainer.DoubleClick += new System.EventHandler(this.PlayListContainer_DoubleClick);
            // 
            // AddPlaylist
            // 
            this.AddPlaylist.Location = new System.Drawing.Point(0, -2);
            this.AddPlaylist.Name = "AddPlaylist";
            this.AddPlaylist.Size = new System.Drawing.Size(75, 23);
            this.AddPlaylist.TabIndex = 1;
            this.AddPlaylist.Text = "Open";
            this.AddPlaylist.UseVisualStyleBackColor = true;
            this.AddPlaylist.Click += new System.EventHandler(this.AddPlaylist_Click);
            // 
            // Playlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 263);
            this.ControlBox = false;
            this.Controls.Add(this.AddPlaylist);
            this.Controls.Add(this.playListContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Playlist";
            this.Text = "Playlist";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox playListContainer;
        private System.Windows.Forms.Button AddPlaylist;
    }
}