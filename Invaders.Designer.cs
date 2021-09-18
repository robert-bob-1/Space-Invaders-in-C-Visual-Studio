namespace arcade_shooting_game
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
            this.components = new System.ComponentModel.Container();
            this.txtScore = new System.Windows.Forms.Label();
            this.move = new System.Windows.Forms.Timer(this.components);
            this.gameovertext = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.victorytext = new System.Windows.Forms.PictureBox();
            this.scorelabel = new System.Windows.Forms.Label();
            this.highscorelabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gameovertext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.victorytext)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.BackColor = System.Drawing.Color.Transparent;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtScore.Location = new System.Drawing.Point(16, 635);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(64, 69);
            this.txtScore.TabIndex = 8;
            this.txtScore.Text = "0";
            this.txtScore.Click += new System.EventHandler(this.label1_Click);
            // 
            // move
            // 
            this.move.Enabled = true;
            this.move.Interval = 1;
            this.move.Tick += new System.EventHandler(this.move_Tick);
            // 
            // gameovertext
            // 
            this.gameovertext.BackColor = System.Drawing.Color.Transparent;
            this.gameovertext.Image = global::arcade_shooting_game.Properties.Resources.gameover;
            this.gameovertext.Location = new System.Drawing.Point(392, 102);
            this.gameovertext.Name = "gameovertext";
            this.gameovertext.Size = new System.Drawing.Size(346, 320);
            this.gameovertext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gameovertext.TabIndex = 11;
            this.gameovertext.TabStop = false;
            this.gameovertext.Visible = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::arcade_shooting_game.Properties.Resources.playership12;
            this.player.Location = new System.Drawing.Point(515, 588);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(65, 72);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // victorytext
            // 
            this.victorytext.BackColor = System.Drawing.Color.Transparent;
            this.victorytext.Image = global::arcade_shooting_game.Properties.Resources.gameover1;
            this.victorytext.Location = new System.Drawing.Point(392, 102);
            this.victorytext.Name = "victorytext";
            this.victorytext.Size = new System.Drawing.Size(346, 320);
            this.victorytext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.victorytext.TabIndex = 13;
            this.victorytext.TabStop = false;
            // 
            // scorelabel
            // 
            this.scorelabel.AutoSize = true;
            this.scorelabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.scorelabel.Location = new System.Drawing.Point(25, 618);
            this.scorelabel.Name = "scorelabel";
            this.scorelabel.Size = new System.Drawing.Size(45, 17);
            this.scorelabel.TabIndex = 16;
            this.scorelabel.Text = "Score";
            // 
            // highscorelabel
            // 
            this.highscorelabel.AutoSize = true;
            this.highscorelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highscorelabel.ForeColor = System.Drawing.Color.Fuchsia;
            this.highscorelabel.Location = new System.Drawing.Point(135, 635);
            this.highscorelabel.Name = "highscorelabel";
            this.highscorelabel.Size = new System.Drawing.Size(64, 69);
            this.highscorelabel.TabIndex = 17;
            this.highscorelabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(133, 618);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Highscore";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::arcade_shooting_game.Properties.Resources.space1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1176, 732);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.highscorelabel);
            this.Controls.Add(this.scorelabel);
            this.Controls.Add(this.victorytext);
            this.Controls.Add(this.gameovertext);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.player);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.gameovertext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.victorytext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.PictureBox gameovertext;
        private System.Windows.Forms.Timer move;
        private System.Windows.Forms.PictureBox victorytext;
        private System.Windows.Forms.Label scorelabel;
        private System.Windows.Forms.Label highscorelabel;
        private System.Windows.Forms.Label label1;
    }
}

