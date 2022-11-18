namespace GameProject
{
    partial class Game
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
            this.playerImg = new System.Windows.Forms.PictureBox();
            this.enemyImg = new System.Windows.Forms.PictureBox();
            this.bulletTimer = new System.Windows.Forms.Timer(this.components);
            this.gameDuration = new System.Windows.Forms.Timer(this.components);
            this.gameDurationLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.enemyPositionTimer = new System.Windows.Forms.Timer(this.components);
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.startNewGameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.playerImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyImg)).BeginInit();
            this.SuspendLayout();
            // 
            // playerImg
            // 
            this.playerImg.BackColor = System.Drawing.Color.Transparent;
            this.playerImg.Location = new System.Drawing.Point(328, 450);
            this.playerImg.Name = "playerImg";
            this.playerImg.Size = new System.Drawing.Size(110, 111);
            this.playerImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerImg.TabIndex = 0;
            this.playerImg.TabStop = false;
            this.playerImg.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // enemyImg
            // 
            this.enemyImg.BackColor = System.Drawing.Color.Transparent;
            this.enemyImg.Location = new System.Drawing.Point(328, 12);
            this.enemyImg.Name = "enemyImg";
            this.enemyImg.Size = new System.Drawing.Size(70, 70);
            this.enemyImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyImg.TabIndex = 1;
            this.enemyImg.TabStop = false;
            // 
            // bulletTimer
            // 
            this.bulletTimer.Enabled = true;
            this.bulletTimer.Interval = 50;
            this.bulletTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gameDuration
            // 
            this.gameDuration.Enabled = true;
            this.gameDuration.Interval = 1000;
            this.gameDuration.Tick += new System.EventHandler(this.gameDuration_Tick);
            // 
            // gameDurationLabel
            // 
            this.gameDurationLabel.AutoSize = true;
            this.gameDurationLabel.BackColor = System.Drawing.Color.Transparent;
            this.gameDurationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameDurationLabel.Location = new System.Drawing.Point(3, 180);
            this.gameDurationLabel.Name = "gameDurationLabel";
            this.gameDurationLabel.Size = new System.Drawing.Size(0, 24);
            this.gameDurationLabel.TabIndex = 2;
            this.gameDurationLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(3, 381);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(77, 24);
            this.scoreLabel.TabIndex = 3;
            this.scoreLabel.Text = "Score: ";
            // 
            // enemyPositionTimer
            // 
            this.enemyPositionTimer.Enabled = true;
            this.enemyPositionTimer.Interval = 700;
            this.enemyPositionTimer.Tick += new System.EventHandler(this.enemyPositionTimer_Tick);
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.AutoSize = true;
            this.gameOverLabel.BackColor = System.Drawing.Color.Transparent;
            this.gameOverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLabel.Location = new System.Drawing.Point(123, 180);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(549, 108);
            this.gameOverLabel.TabIndex = 4;
            this.gameOverLabel.Text = "Game Over";
            this.gameOverLabel.Visible = false;
            // 
            // startNewGameLabel
            // 
            this.startNewGameLabel.AutoSize = true;
            this.startNewGameLabel.BackColor = System.Drawing.Color.Transparent;
            this.startNewGameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startNewGameLabel.Location = new System.Drawing.Point(304, 305);
            this.startNewGameLabel.Name = "startNewGameLabel";
            this.startNewGameLabel.Size = new System.Drawing.Size(157, 31);
            this.startNewGameLabel.TabIndex = 5;
            this.startNewGameLabel.Text = "New Game";
            this.startNewGameLabel.Visible = false;
            this.startNewGameLabel.Click += new System.EventHandler(this.startNewGameLabel_Click);
            this.startNewGameLabel.MouseEnter += new System.EventHandler(this.startNewGameLabel_MouseEnter);
            this.startNewGameLabel.MouseLeave += new System.EventHandler(this.startNewGameLabel_MouseLeave);
            this.startNewGameLabel.MouseHover += new System.EventHandler(this.startNewGameLabel_MouseHover);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameProject.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(795, 573);
            this.Controls.Add(this.startNewGameLabel);
            this.Controls.Add(this.gameOverLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.gameDurationLabel);
            this.Controls.Add(this.enemyImg);
            this.Controls.Add(this.playerImg);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Game_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Leave += new System.EventHandler(this.Game_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.playerImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox playerImg;
        private System.Windows.Forms.PictureBox enemyImg;
        private System.Windows.Forms.Timer bulletTimer;
        private System.Windows.Forms.Timer gameDuration;
        private System.Windows.Forms.Label gameDurationLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Timer enemyPositionTimer;
        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.Label startNewGameLabel;
    }
}

