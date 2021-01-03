using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shootingMan
{
    public partial class Form1 : Form
    {

        bool goLeft, goRight, shooting, isGameOver;
        int playerScore;
        int playerSpeed = 10;
        int enemySpeed;
        int bulletSpeed;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
            resetGame();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {

            score.Text = playerScore.ToString();
            enemyOne.Top += enemySpeed;
            enemyTwo.Top += enemySpeed;
            enemyThree.Top += enemySpeed;

            if (enemyOne.Top > 250 || enemyTwo.Top > 250 || enemyThree.Top > 250)
            {
                score.BringToFront();
                gameOver();
                
            }
            if (goLeft == true && Kain.Left > 0)
            {
                Kain.Left -= playerSpeed;
            }
            if (goRight == true && Kain.Left < 550)
            {
                Kain.Left += playerSpeed;
            }
            if (shooting == true)
            {
                bulletSpeed = 20;
                bullet.Top -= bulletSpeed;
            }
            else
            {
                bullet.Left = -300;
                bulletSpeed = 0;
            }
            if (bullet.Top < 50)
            {
                shooting = false;
            }
            if (bullet.Bounds.IntersectsWith(enemyOne.Bounds))
            {
                playerScore += 1;
                enemyOne.Top = -30;
                enemyOne.Left = rnd.Next(-20, 200);
                shooting = false;
            }
            if (bullet.Bounds.IntersectsWith(enemyTwo.Bounds))
            {
                playerScore += 1;
                enemyTwo.Top = -30;
                enemyTwo.Left = rnd.Next(-20, 500);
                shooting = false;
            }
            if (bullet.Bounds.IntersectsWith(enemyThree.Bounds))
            {
                playerScore += 1;
                enemyThree.Top = -30;
                enemyThree.Left = rnd.Next(-20, 200);
                shooting = false;
            }
            if (playerScore == 10)
            {
                enemySpeed = 2;
                playerSpeed = 15;
                bulletSpeed = 30;
            }
            if (playerScore == 50)
            {
                enemySpeed = 3;
                playerSpeed = 20;
                bulletSpeed = 40;
            }
            if (playerScore == 100)
            {
                enemySpeed = 4;
                playerSpeed = 30;
                bulletSpeed = 50;
            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Space && shooting == false)
            {
                shooting = true;
                bullet.Top = Kain.Top - bullet.Height;
                bullet.Left = Kain.Left + 20;
            }
            if (e.KeyCode == Keys.Enter && isGameOver == true)
            {
                resetGame();
            }
        }
        private void resetGame()
        {
            gameTimer.Start();
            enemySpeed = 1;

            enemyOne.Left = rnd.Next(20, 500);
            enemyTwo.Left = rnd.Next(20, 500);
            enemyThree.Left = rnd.Next(20, 500);

            enemyOne.Top = rnd.Next(250, 300) * -1;
            enemyTwo.Top = rnd.Next(250, 300) * -1;
            enemyThree.Top = rnd.Next(250, 300) * -1;

            playerScore = 0;
            bulletSpeed = 2;
            bullet.Left = -300;
            shooting = false;
            score.Text = playerScore.ToString();
        }
        private void gameOver()
        {
            
            isGameOver = true;
            gameTimer.Stop();            
            score.Text += Environment.NewLine + "Game Over" + Environment.NewLine + $"Result: {score.Text}" + Environment.NewLine + "Press Enter to try again.";
            


        }
    }
}
