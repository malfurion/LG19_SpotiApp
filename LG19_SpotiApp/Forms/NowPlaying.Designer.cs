namespace LG19_SpotiApp
{
    partial class NowPlaying
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LabelTrackTitle = new System.Windows.Forms.Label();
            this.LabelTrackArtist = new System.Windows.Forms.Label();
            this.LabelTrackAlbum = new System.Windows.Forms.Label();
            this.LabelTimeMax = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.LabelTimeIs = new System.Windows.Forms.Label();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LabelTrackTitle
            // 
            this.LabelTrackTitle.AutoSize = true;
            this.LabelTrackTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTrackTitle.ForeColor = System.Drawing.Color.White;
            this.LabelTrackTitle.Location = new System.Drawing.Point(138, 12);
            this.LabelTrackTitle.Name = "LabelTrackTitle";
            this.LabelTrackTitle.Size = new System.Drawing.Size(138, 24);
            this.LabelTrackTitle.TabIndex = 1;
            this.LabelTrackTitle.Text = "LabelTrackTitle";
            // 
            // LabelTrackArtist
            // 
            this.LabelTrackArtist.AutoSize = true;
            this.LabelTrackArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.LabelTrackArtist.ForeColor = System.Drawing.Color.White;
            this.LabelTrackArtist.Location = new System.Drawing.Point(139, 36);
            this.LabelTrackArtist.Name = "LabelTrackArtist";
            this.LabelTrackArtist.Size = new System.Drawing.Size(106, 16);
            this.LabelTrackArtist.TabIndex = 2;
            this.LabelTrackArtist.Text = "LabelTrackArtist";
            // 
            // LabelTrackAlbum
            // 
            this.LabelTrackAlbum.AutoSize = true;
            this.LabelTrackAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.LabelTrackAlbum.ForeColor = System.Drawing.Color.White;
            this.LabelTrackAlbum.Location = new System.Drawing.Point(139, 52);
            this.LabelTrackAlbum.Name = "LabelTrackAlbum";
            this.LabelTrackAlbum.Size = new System.Drawing.Size(115, 16);
            this.LabelTrackAlbum.TabIndex = 3;
            this.LabelTrackAlbum.Text = "LabelTrackAlbum";
            // 
            // LabelTimeMax
            // 
            this.LabelTimeMax.AutoSize = true;
            this.LabelTimeMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.LabelTimeMax.ForeColor = System.Drawing.Color.White;
            this.LabelTimeMax.Location = new System.Drawing.Point(210, 154);
            this.LabelTimeMax.Name = "LabelTimeMax";
            this.LabelTimeMax.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelTimeMax.Size = new System.Drawing.Size(98, 16);
            this.LabelTimeMax.TabIndex = 4;
            this.LabelTimeMax.Text = "LabelTimeMax";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 173);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(296, 10);
            this.progressBar1.TabIndex = 5;
            // 
            // LabelTimeIs
            // 
            this.LabelTimeIs.AutoSize = true;
            this.LabelTimeIs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.LabelTimeIs.ForeColor = System.Drawing.Color.White;
            this.LabelTimeIs.Location = new System.Drawing.Point(12, 154);
            this.LabelTimeIs.Name = "LabelTimeIs";
            this.LabelTimeIs.Size = new System.Drawing.Size(83, 16);
            this.LabelTimeIs.TabIndex = 9;
            this.LabelTimeIs.Text = "LabelTimeIs";
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.Black;
            this.btn_next.BackgroundImage = global::LG19_SpotiApp.Properties.Resources.next;
            this.btn_next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_next.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_next.Location = new System.Drawing.Point(190, 189);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(46, 46);
            this.btn_next.TabIndex = 13;
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.Color.Black;
            this.btn_play.BackgroundImage = global::LG19_SpotiApp.Properties.Resources.play;
            this.btn_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_play.Location = new System.Drawing.Point(138, 189);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(46, 46);
            this.btn_play.TabIndex = 14;
            this.btn_play.UseVisualStyleBackColor = false;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.BackColor = System.Drawing.Color.Black;
            this.btn_prev.BackgroundImage = global::LG19_SpotiApp.Properties.Resources.previous;
            this.btn_prev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_prev.Location = new System.Drawing.Point(86, 189);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(46, 46);
            this.btn_prev.TabIndex = 15;
            this.btn_prev.UseVisualStyleBackColor = false;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // NowPlaying
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 240);
            this.Controls.Add(this.btn_prev);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.LabelTimeIs);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.LabelTimeMax);
            this.Controls.Add(this.LabelTrackAlbum);
            this.Controls.Add(this.LabelTrackArtist);
            this.Controls.Add(this.LabelTrackTitle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "NowPlaying";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.NowPlaying_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LabelTrackTitle;
        private System.Windows.Forms.Label LabelTrackArtist;
        private System.Windows.Forms.Label LabelTrackAlbum;
        private System.Windows.Forms.Label LabelTimeMax;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label LabelTimeIs;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_prev;
    }
}

