//TODO:
//disable grow and shrink size of the form
//lose life if playersImg collide with the enemy

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;


namespace GameProject
{
    public partial class Game : Form
    {
        Random rnd;
        SoundPlayer sound;

        PictureBox bulletimg = new PictureBox();
        PictureBox enemyBulletImg = new PictureBox();

        List<PictureBox> bullets = new List<PictureBox>();
        List<PictureBox> enemyBullets = new List<PictureBox>();

        int score = 0;
        int counter = 10;
        int userCounter = 10; //default value = 10 but if user call the constructor with option userCounter stores his value
        bool gameOver = false;

        

        public Game()
        {
            InitializeComponent();
        }
        public Game(int counter)
        {
            InitializeComponent();
            this.counter = counter;
            this.userCounter = counter;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            playerImg.ImageLocation = "player.png";
            enemyImg.ImageLocation = "mosquito.gif";
            rnd = new Random();
            sound = new SoundPlayer(); //i have to bring the path of the wav file as parameter

            gameDuration.Start();
            gameDurationLabel.Text = counter.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(!gameOver)
            {
                //MessageBox.Show(e.KeyCode.ToString());
                if (e.KeyCode.ToString().Equals("Right"))
                {
                    playerImg.Location = new Point(playerImg.Location.X + 50, playerImg.Location.Y);
                }
                else if (e.KeyCode.ToString().Equals("Left"))
                {
                    playerImg.Location = new Point(playerImg.Location.X - 50, playerImg.Location.Y);
                }
                else if (e.KeyCode.ToString().Equals("Up"))
                {
                    playerImg.Location = new Point(playerImg.Location.X, playerImg.Location.Y - 50);
                }
                else if (e.KeyCode.ToString().Equals("Down"))
                {
                    playerImg.Location = new Point(playerImg.Location.X, playerImg.Location.Y + 50);
                }
                else if (e.KeyCode.ToString().Equals("Space"))
                {
                    CreateBullet(playerImg.Location.X);
                }
            }
            
        }


        private void CreateBullet(int pointX)
        {
            if(!gameOver)
            {
                bulletimg.Location = new Point(pointX + 20, playerImg.Location.Y - 50);
                bulletimg.ImageLocation = "bullet.png";
                bulletimg.Size = new Size(50, 70);
                bulletimg.SizeMode = PictureBoxSizeMode.StretchImage;
                Controls.Add(bulletimg);
                bullets.Add(bulletimg);
            }
            

        }
        private void CreateBulletEnemy(int pointX)
        {
            if(!gameOver)
            {
                enemyBulletImg.Location = new Point(pointX, enemyImg.Location.Y + 50);
                enemyBulletImg.ImageLocation = "bloodBullet.png";
                enemyBulletImg.BackColor = Color.Transparent;
                enemyBulletImg.Size = new Size(50, 70);
                enemyBulletImg.SizeMode = PictureBoxSizeMode.StretchImage;
                Controls.Add(enemyBulletImg);
                enemyBullets.Add(enemyBulletImg);
            }
        }

        // Timer for bullet to go upward to the enemy
        // timer1 = bulletTimer
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(gameOver != true)
            {
                // move player's bullet 
                foreach (PictureBox pBox in bullets)
                {
                    pBox.Location = new Point(pBox.Location.X, pBox.Location.Y - 100);

                    // If player's bullet hit the enemy
                    if (bulletimg.Bounds.IntersectsWith(enemyImg.Bounds))
                    {
                        enemyImg.Location = new Point(rnd.Next(750), enemyImg.Location.Y);
                        score += 100;
                        scoreLabel.Text = score.ToString();
                    }
                }

                // move enemy's bullet
                foreach (PictureBox pBox in enemyBullets)
                {
                    pBox.Location = new Point(pBox.Location.X, pBox.Location.Y + 20);
                }
                //
                if (enemyBulletImg.Bounds.IntersectsWith(playerImg.Bounds))
                {
                    enemyImg.Location = new Point(rnd.Next(750), enemyImg.Location.Y);
                    score -= 100;
                    scoreLabel.Text = score.ToString();
                }
            }
        }

        private void gameDuration_Tick(object sender, EventArgs e)
        {
            counter--;
            if(counter==0)
            {
                gameDuration.Stop();
                //MessageBox.Show("Time passed");

                // Enemy position
                enemyImg.Location = new Point(328, 12);
                // Player's position
                playerImg.Location = new Point(328, 450);
                // Game over if time passed
                gameOverLabel.Visible = true;
                startNewGameLabel.Visible = true;
                enemyPositionTimer.Stop();
                gameOver = true;
                counter = 0;


                //write the score to txt
                using (StreamWriter writetext = new StreamWriter("leaderboard.txt", true))
                {
                    writetext.WriteLine(score);


                }
            }
            gameDurationLabel.Text = counter.ToString() + "s";
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void enemyPositionTimer_Tick(object sender, EventArgs e)
        {
            // Change position of the enemy every 0,7s
            enemyImg.Location = new Point(rnd.Next(750), enemyImg.Location.Y);
            // create an enemy bullet
            CreateBulletEnemy(enemyImg.Location.X);
            // bullet going downward to our player
            
        }

        private void startNewGameLabel_MouseHover(object sender, EventArgs e)
        {
        }

        private void startNewGameLabel_Click(object sender, EventArgs e)
        {
            gameOver = false;
            gameOverLabel.Visible = false;

            startNewGameLabel.Visible = false;

            counter = userCounter;
            score = 0;

            enemyPositionTimer.Start();
            gameDuration.Start();
        }

        private void startNewGameLabel_MouseEnter(object sender, EventArgs e)
        {
            startNewGameLabel.ForeColor = Color.Red;
        }

        private void startNewGameLabel_MouseLeave(object sender, EventArgs e)
        {
            startNewGameLabel.ForeColor = Color.Black;
        }

        private void isGameOverTimer_Tick(object sender, EventArgs e)
        {
        }

        private void Game_Leave(object sender, EventArgs e)
        {
        }

        // Close application on Game's form exit
        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void enemyBulletTimer_Tick(object sender, EventArgs e)
        {
            foreach(PictureBox enBullet in enemyBullets)
            {
                enBullet.Location = new Point(enBullet.Location.X, enBullet.Location.Y + 10);
            }
        }
    }
}
