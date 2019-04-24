namespace FlappyBird
{
    partial class flappyGame
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
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.scoreText = new System.Windows.Forms.Label();
            this.endText1 = new System.Windows.Forms.Label();
            this.endText2 = new System.Windows.Forms.Label();
            this.gameDesigners = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            this.SuspendLayout();
            // 
            // flappyBird
            // 
            this.flappyBird.BackColor = System.Drawing.Color.Transparent;
            this.flappyBird.Image = global::FlappyBird.Properties.Resources.ericgif;
            this.flappyBird.Location = new System.Drawing.Point(22, 154);
            this.flappyBird.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(66, 56);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBird.TabIndex = 0;
            this.flappyBird.TabStop = false;
            // 
            // pipeTop
            // 
            this.pipeTop.BackColor = System.Drawing.Color.Transparent;
            this.pipeTop.Image = global::FlappyBird.Properties.Resources.pipedown;
            this.pipeTop.Location = new System.Drawing.Point(205, -233);
            this.pipeTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(65, 356);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 1;
            this.pipeTop.TabStop = false;
            // 
            // pipeBottom
            // 
            this.pipeBottom.BackColor = System.Drawing.Color.Transparent;
            this.pipeBottom.Image = global::FlappyBird.Properties.Resources.pipe;
            this.pipeBottom.Location = new System.Drawing.Point(427, 122);
            this.pipeBottom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(65, 441);
            this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom.TabIndex = 2;
            this.pipeBottom.TabStop = false;
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.Color.Transparent;
            this.ground.Image = global::FlappyBird.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-1, 320);
            this.ground.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(537, 73);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            this.ground.Click += new System.EventHandler(this.ground_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 15;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.Transparent;
            this.scoreText.Font = new System.Drawing.Font("Ravie", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.ForeColor = System.Drawing.Color.Black;
            this.scoreText.Location = new System.Drawing.Point(17, 21);
            this.scoreText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(0, 26);
            this.scoreText.TabIndex = 4;
            // 
            // endText1
            // 
            this.endText1.BackColor = System.Drawing.Color.DarkKhaki;
            this.endText1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.endText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endText1.Location = new System.Drawing.Point(145, 191);
            this.endText1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.endText1.Name = "endText1";
            this.endText1.Size = new System.Drawing.Size(133, 19);
            this.endText1.TabIndex = 5;
            this.endText1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // endText2
            // 
            this.endText2.BackColor = System.Drawing.Color.DarkKhaki;
            this.endText2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endText2.Location = new System.Drawing.Point(145, 220);
            this.endText2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.endText2.Name = "endText2";
            this.endText2.Size = new System.Drawing.Size(133, 19);
            this.endText2.TabIndex = 6;
            this.endText2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameDesigners
            // 
            this.gameDesigners.BackColor = System.Drawing.Color.DarkKhaki;
            this.gameDesigners.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameDesigners.Location = new System.Drawing.Point(112, 252);
            this.gameDesigners.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gameDesigners.Name = "gameDesigners";
            this.gameDesigners.Size = new System.Drawing.Size(200, 19);
            this.gameDesigners.TabIndex = 7;
            this.gameDesigners.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flappyGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FlappyBird.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(537, 392);
            this.Controls.Add(this.gameDesigners);
            this.Controls.Add(this.endText2);
            this.Controls.Add(this.endText1);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeBottom);
            this.Controls.Add(this.pipeTop);
            this.Controls.Add(this.flappyBird);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "flappyGame";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inGameKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.inGameKeyUP);
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Label endText1;
        private System.Windows.Forms.Label endText2;
        private System.Windows.Forms.Label gameDesigners;
    }
}

