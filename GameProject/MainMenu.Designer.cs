namespace GameProject
{
    partial class MainMenu
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
            this.mmNewGameLabel = new System.Windows.Forms.Label();
            this.mmLeaderboardLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mmNewGameLabel
            // 
            this.mmNewGameLabel.AutoSize = true;
            this.mmNewGameLabel.BackColor = System.Drawing.Color.Transparent;
            this.mmNewGameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmNewGameLabel.Location = new System.Drawing.Point(322, 154);
            this.mmNewGameLabel.Name = "mmNewGameLabel";
            this.mmNewGameLabel.Size = new System.Drawing.Size(157, 31);
            this.mmNewGameLabel.TabIndex = 0;
            this.mmNewGameLabel.Text = "New Game";
            this.mmNewGameLabel.Click += new System.EventHandler(this.mmNewGameLabel_Click);
            this.mmNewGameLabel.MouseEnter += new System.EventHandler(this.mmNewGameLabel_MouseEnter);
            this.mmNewGameLabel.MouseLeave += new System.EventHandler(this.mmNewGameLabel_MouseLeave);
            // 
            // mmLeaderboardLabel
            // 
            this.mmLeaderboardLabel.AutoSize = true;
            this.mmLeaderboardLabel.BackColor = System.Drawing.Color.Transparent;
            this.mmLeaderboardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmLeaderboardLabel.Location = new System.Drawing.Point(298, 217);
            this.mmLeaderboardLabel.Name = "mmLeaderboardLabel";
            this.mmLeaderboardLabel.Size = new System.Drawing.Size(203, 31);
            this.mmLeaderboardLabel.TabIndex = 1;
            this.mmLeaderboardLabel.Text = "Top 10 Scores";
            this.mmLeaderboardLabel.Click += new System.EventHandler(this.mmLeaderboardLabel_Click);
            this.mmLeaderboardLabel.MouseEnter += new System.EventHandler(this.mmLeaderboardLabel_MouseEnter);
            this.mmLeaderboardLabel.MouseLeave += new System.EventHandler(this.mmLeaderboardLabel_MouseLeave);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameProject.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mmLeaderboardLabel);
            this.Controls.Add(this.mmNewGameLabel);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mmNewGameLabel;
        private System.Windows.Forms.Label mmLeaderboardLabel;
    }
}