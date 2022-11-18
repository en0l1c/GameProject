using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameProject
{
    public partial class MainMenu : Form
    {
        List<int> largestNumbers = new List<int>();

        public MainMenu()
        {
            InitializeComponent();
        }

        private void mmLeaderboardLabel_MouseEnter(object sender, EventArgs e)
        {
            mmLeaderboardLabel.ForeColor = Color.Red;
        }

        private void mmLeaderboardLabel_MouseLeave(object sender, EventArgs e)
        {
            mmLeaderboardLabel.ForeColor = Color.Black;

        }

        private void mmNewGameLabel_MouseEnter(object sender, EventArgs e)
        {
            mmNewGameLabel.ForeColor = Color.Red;
        }

        private void mmNewGameLabel_MouseLeave(object sender, EventArgs e)
        {
            mmNewGameLabel.ForeColor = Color.Black;

        }

        private void mmNewGameLabel_Click(object sender, EventArgs e)
        {
            Game game = new Game(50);
            game.Show();
            this.Hide();
        }

        // main menu Leaderboard Label
        private void mmLeaderboardLabel_Click(object sender, EventArgs e)
        {
            using (StreamReader readtext = new StreamReader("leaderboard.txt"))
            {
               
                foreach(string line in File.ReadLines("leaderboard.txt"))
                {
                    string readText = readtext.ReadLine();
                    int scoreNum = Int32.Parse(readText); //parse string to int
                   
                    //MessageBox.Show(readText);

                    // add the parsed number to a list
                    largestNumbers.Add(scoreNum);

                   

                }
            }
            var noDupes = largestNumbers.Distinct().ToList(); // Creates a new list with no duplicates
            noDupes.Sort();
            noDupes.Reverse();
            noDupes.Take(10); //take first 10 elements from the noDupes list
            string top10 = string.Join(", ", noDupes);

             

            MessageBox.Show(top10);

        }
    }
}
