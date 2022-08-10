namespace MP3_Player
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnAddSong = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnDeleteSong = new System.Windows.Forms.Button();
            this.informationtxt = new System.Windows.Forms.TextBox();
            this.playlisttxt = new System.Windows.Forms.TextBox();
            this.Playlist1 = new System.Windows.Forms.ListView();
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.logoTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.noOfSongstxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRepeat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(281, 475);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(112, 44);
            this.btnPrevious.TabIndex = 0;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnAddSong
            // 
            this.btnAddSong.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSong.Location = new System.Drawing.Point(21, 475);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(87, 44);
            this.btnAddSong.TabIndex = 0;
            this.btnAddSong.Text = "Add Song";
            this.btnAddSong.UseVisualStyleBackColor = true;
            this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click);
            // 
            // btnForward
            // 
            this.btnForward.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForward.Location = new System.Drawing.Point(399, 475);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(116, 44);
            this.btnForward.TabIndex = 0;
            this.btnForward.Text = "Forward";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnDeleteSong
            // 
            this.btnDeleteSong.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSong.Location = new System.Drawing.Point(114, 475);
            this.btnDeleteSong.Name = "btnDeleteSong";
            this.btnDeleteSong.Size = new System.Drawing.Size(109, 44);
            this.btnDeleteSong.TabIndex = 0;
            this.btnDeleteSong.Text = "Delete Song";
            this.btnDeleteSong.UseVisualStyleBackColor = true;
            this.btnDeleteSong.Click += new System.EventHandler(this.btnDeleteSong_Click);
            // 
            // informationtxt
            // 
            this.informationtxt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.informationtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.informationtxt.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informationtxt.ForeColor = System.Drawing.Color.Red;
            this.informationtxt.Location = new System.Drawing.Point(127, 436);
            this.informationtxt.Name = "informationtxt";
            this.informationtxt.ReadOnly = true;
            this.informationtxt.Size = new System.Drawing.Size(692, 19);
            this.informationtxt.TabIndex = 0;
            this.informationtxt.TabStop = false;
            this.informationtxt.Text = "Please Add Songs in your Playlist";
            this.informationtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // playlisttxt
            // 
            this.playlisttxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playlisttxt.Font = new System.Drawing.Font("Eras Bold ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playlisttxt.Location = new System.Drawing.Point(12, 123);
            this.playlisttxt.Name = "playlisttxt";
            this.playlisttxt.ReadOnly = true;
            this.playlisttxt.Size = new System.Drawing.Size(185, 18);
            this.playlisttxt.TabIndex = 3;
            this.playlisttxt.TabStop = false;
            this.playlisttxt.Text = " P  L  A  Y  L  I  S  T ";
            // 
            // Playlist1
            // 
            this.Playlist1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Playlist1.Location = new System.Drawing.Point(12, 147);
            this.Playlist1.Name = "Playlist1";
            this.Playlist1.Size = new System.Drawing.Size(807, 257);
            this.Playlist1.TabIndex = 5;
            this.Playlist1.UseCompatibleStateImageBehavior = false;
            this.Playlist1.View = System.Windows.Forms.View.List;
            this.Playlist1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Playlist1_MouseDoubleClick);
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold);
            this.btnPlayPause.Location = new System.Drawing.Point(568, 475);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(95, 44);
            this.btnPlayPause.TabIndex = 6;
            this.btnPlayPause.Text = "Pause";
            this.btnPlayPause.UseVisualStyleBackColor = true;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MP3_Player.Properties.Resources.bars;
            this.pictureBox1.Location = new System.Drawing.Point(145, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // logo
            // 
            this.logo.Image = global::MP3_Player.Properties.Resources.music;
            this.logo.Location = new System.Drawing.Point(468, 32);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(91, 77);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 7;
            this.logo.TabStop = false;
            // 
            // logoTitle
            // 
            this.logoTitle.AutoSize = true;
            this.logoTitle.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoTitle.Location = new System.Drawing.Point(12, 32);
            this.logoTitle.Name = "logoTitle";
            this.logoTitle.Size = new System.Drawing.Size(228, 57);
            this.logoTitle.TabIndex = 9;
            this.logoTitle.Text = "Audio Player";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(565, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "No. Of Audio Files :";
            // 
            // noOfSongstxt
            // 
            this.noOfSongstxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.noOfSongstxt.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noOfSongstxt.Location = new System.Drawing.Point(699, 71);
            this.noOfSongstxt.Name = "noOfSongstxt";
            this.noOfSongstxt.ReadOnly = true;
            this.noOfSongstxt.Size = new System.Drawing.Size(58, 19);
            this.noOfSongstxt.TabIndex = 11;
            this.noOfSongstxt.TabStop = false;
            this.noOfSongstxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Instructions :";
            // 
            // btnRepeat
            // 
            this.btnRepeat.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepeat.Location = new System.Drawing.Point(690, 475);
            this.btnRepeat.Name = "btnRepeat";
            this.btnRepeat.Size = new System.Drawing.Size(104, 44);
            this.btnRepeat.TabIndex = 13;
            this.btnRepeat.Text = "Repeat All";
            this.btnRepeat.UseVisualStyleBackColor = true;
            this.btnRepeat.Click += new System.EventHandler(this.btnRepeat_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 543);
            this.Controls.Add(this.btnRepeat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.noOfSongstxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logoTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.btnPlayPause);
            this.Controls.Add(this.Playlist1);
            this.Controls.Add(this.playlisttxt);
            this.Controls.Add(this.informationtxt);
            this.Controls.Add(this.btnAddSong);
            this.Controls.Add(this.btnDeleteSong);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnForward);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mp3 Player";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnAddSong;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnDeleteSong;
        private System.Windows.Forms.TextBox informationtxt;
        private System.Windows.Forms.TextBox playlisttxt;
        private System.Windows.Forms.ListView Playlist1;
        private System.Windows.Forms.Button btnPlayPause;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label logoTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox noOfSongstxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRepeat;

    }
}

