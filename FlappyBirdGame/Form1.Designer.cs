namespace FlappyBirdGame
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
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.LblScore = new System.Windows.Forms.Label();
            this.PicBoxPipeBottom = new System.Windows.Forms.PictureBox();
            this.PicBoxPipeTop = new System.Windows.Forms.PictureBox();
            this.PicBoxGround = new System.Windows.Forms.PictureBox();
            this.PicBoxBird = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxPipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxPipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxBird)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LblScore
            // 
            this.LblScore.AutoSize = true;
            this.LblScore.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblScore.Location = new System.Drawing.Point(55, 9);
            this.LblScore.Name = "LblScore";
            this.LblScore.Size = new System.Drawing.Size(63, 23);
            this.LblScore.TabIndex = 4;
            this.LblScore.Text = "Score:";
            // 
            // PicBoxPipeBottom
            // 
            this.PicBoxPipeBottom.Image = global::FlappyBirdGame.Properties.Resources.pipe;
            this.PicBoxPipeBottom.Location = new System.Drawing.Point(524, 252);
            this.PicBoxPipeBottom.Name = "PicBoxPipeBottom";
            this.PicBoxPipeBottom.Size = new System.Drawing.Size(84, 112);
            this.PicBoxPipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxPipeBottom.TabIndex = 3;
            this.PicBoxPipeBottom.TabStop = false;
            // 
            // PicBoxPipeTop
            // 
            this.PicBoxPipeTop.Image = global::FlappyBirdGame.Properties.Resources.Fantasy_Pipe_Flappy_Bird_Game_World_PNG;
            this.PicBoxPipeTop.Location = new System.Drawing.Point(515, -3);
            this.PicBoxPipeTop.Name = "PicBoxPipeTop";
            this.PicBoxPipeTop.Size = new System.Drawing.Size(84, 118);
            this.PicBoxPipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxPipeTop.TabIndex = 2;
            this.PicBoxPipeTop.TabStop = false;
            // 
            // PicBoxGround
            // 
            this.PicBoxGround.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PicBoxGround.Location = new System.Drawing.Point(-3, 354);
            this.PicBoxGround.Name = "PicBoxGround";
            this.PicBoxGround.Size = new System.Drawing.Size(788, 10);
            this.PicBoxGround.TabIndex = 1;
            this.PicBoxGround.TabStop = false;
            // 
            // PicBoxBird
            // 
            this.PicBoxBird.Image = global::FlappyBirdGame.Properties.Resources._151_1515288_flappy_bird_png_jpg_download_flappy_bird_bird;
            this.PicBoxBird.Location = new System.Drawing.Point(60, 69);
            this.PicBoxBird.Name = "PicBoxBird";
            this.PicBoxBird.Size = new System.Drawing.Size(81, 46);
            this.PicBoxBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxBird.TabIndex = 0;
            this.PicBoxBird.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Start : S";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Restart: R";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblScore);
            this.Controls.Add(this.PicBoxPipeBottom);
            this.Controls.Add(this.PicBoxPipeTop);
            this.Controls.Add(this.PicBoxGround);
            this.Controls.Add(this.PicBoxBird);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "  Restart: R";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxPipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxPipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxBird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBoxBird;
        private System.Windows.Forms.PictureBox PicBoxGround;
        private System.Windows.Forms.PictureBox PicBoxPipeTop;
        private System.Windows.Forms.PictureBox PicBoxPipeBottom;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label LblScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

