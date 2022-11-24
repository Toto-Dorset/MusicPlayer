namespace MusicPlayer
{
    partial class Form1
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
            this.PanelBottom = new System.Windows.Forms.Panel();
            this.PanelLeft = new System.Windows.Forms.Panel();
            this.PanelPlaylist = new System.Windows.Forms.Panel();
            this.FavoritesButton = new System.Windows.Forms.Button();
            this.PlaylistButton = new System.Windows.Forms.Button();
            this.LibraryButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LibraryPanel = new System.Windows.Forms.Panel();
            this.FavoritesPanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PanelLeft.SuspendLayout();
            this.PanelPlaylist.SuspendLayout();
            this.LibraryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelBottom
            // 
            this.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBottom.Location = new System.Drawing.Point(0, 651);
            this.PanelBottom.Name = "PanelBottom";
            this.PanelBottom.Size = new System.Drawing.Size(1357, 69);
            this.PanelBottom.TabIndex = 0;
            // 
            // PanelLeft
            // 
            this.PanelLeft.Controls.Add(this.PanelPlaylist);
            this.PanelLeft.Controls.Add(this.PlaylistButton);
            this.PanelLeft.Controls.Add(this.LibraryButton);
            this.PanelLeft.Controls.Add(this.panel1);
            this.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLeft.Location = new System.Drawing.Point(0, 0);
            this.PanelLeft.Name = "PanelLeft";
            this.PanelLeft.Size = new System.Drawing.Size(229, 651);
            this.PanelLeft.TabIndex = 1;
            // 
            // PanelPlaylist
            // 
            this.PanelPlaylist.Controls.Add(this.FavoritesButton);
            this.PanelPlaylist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPlaylist.Location = new System.Drawing.Point(0, 192);
            this.PanelPlaylist.Name = "PanelPlaylist";
            this.PanelPlaylist.Size = new System.Drawing.Size(229, 459);
            this.PanelPlaylist.TabIndex = 0;
            // 
            // FavoritesButton
            // 
            this.FavoritesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.FavoritesButton.Location = new System.Drawing.Point(0, 0);
            this.FavoritesButton.Name = "FavoritesButton";
            this.FavoritesButton.Size = new System.Drawing.Size(229, 64);
            this.FavoritesButton.TabIndex = 0;
            this.FavoritesButton.Text = "Favorites";
            this.FavoritesButton.UseVisualStyleBackColor = true;
            this.FavoritesButton.Click += new System.EventHandler(this.FavoritesButton_Click);
            // 
            // PlaylistButton
            // 
            this.PlaylistButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.PlaylistButton.Location = new System.Drawing.Point(0, 130);
            this.PlaylistButton.Name = "PlaylistButton";
            this.PlaylistButton.Size = new System.Drawing.Size(229, 62);
            this.PlaylistButton.TabIndex = 3;
            this.PlaylistButton.Text = "Playlist";
            this.PlaylistButton.UseVisualStyleBackColor = true;
            this.PlaylistButton.Click += new System.EventHandler(this.PlaylistButton_Click);
            // 
            // LibraryButton
            // 
            this.LibraryButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.LibraryButton.Location = new System.Drawing.Point(0, 68);
            this.LibraryButton.Name = "LibraryButton";
            this.LibraryButton.Size = new System.Drawing.Size(229, 62);
            this.LibraryButton.TabIndex = 2;
            this.LibraryButton.Text = "Library";
            this.LibraryButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 68);
            this.panel1.TabIndex = 0;
            // 
            // LibraryPanel
            // 
            this.LibraryPanel.Controls.Add(this.textBox1);
            this.LibraryPanel.Controls.Add(this.FavoritesPanel);
            this.LibraryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LibraryPanel.Location = new System.Drawing.Point(229, 0);
            this.LibraryPanel.Name = "LibraryPanel";
            this.LibraryPanel.Size = new System.Drawing.Size(1128, 651);
            this.LibraryPanel.TabIndex = 2;
            // 
            // FavoritesPanel
            // 
            this.FavoritesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FavoritesPanel.Location = new System.Drawing.Point(0, 0);
            this.FavoritesPanel.Name = "FavoritesPanel";
            this.FavoritesPanel.Size = new System.Drawing.Size(1128, 651);
            this.FavoritesPanel.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(354, 269);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(395, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Library";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 720);
            this.Controls.Add(this.LibraryPanel);
            this.Controls.Add(this.PanelLeft);
            this.Controls.Add(this.PanelBottom);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelLeft.ResumeLayout(false);
            this.PanelPlaylist.ResumeLayout(false);
            this.LibraryPanel.ResumeLayout(false);
            this.LibraryPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelBottom;
        private System.Windows.Forms.Panel PanelLeft;
        private System.Windows.Forms.Button PlaylistButton;
        private System.Windows.Forms.Button LibraryButton;
        private System.Windows.Forms.Panel PanelPlaylist;
        private System.Windows.Forms.Button FavoritesButton;
        private System.Windows.Forms.Panel LibraryPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel FavoritesPanel;
    }
}

