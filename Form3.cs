using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Side_Scrolling_Game_MOO_ICT
{
    public partial class Form3 : Form

    {
        bool goLeft = false;
        bool goRight = false;
        bool jumping = false;
        bool hasKey = false;
        int jumpSpeed = 10;
        int force = 8;
        int score = 0;
        int playSpeed = 18;
        int backLeft = 8;
        public Form3()
        {
            InitializeComponent();
            //this.BackgroundImage = Properties.Resources.Pixel;
          //  player.BackColor = Color.Transparent;
           // player.Image = Properties.Resources.pler;
           // player.BringToFront();
        }
        private void mainGameTimer(object sender, EventArgs e)
        {
            player.Top += jumpSpeed;
            //player.Refresh();
            if (jumping && force < 0)
            {
                jumping = false;
            }
            if (jumping)
            {
                jumpSpeed = -12;
                force -= 1;
            }
            else
            {
                jumpSpeed = 12;
            }
            if (goLeft && player.Left > 0)
            {
                player.Left -= playSpeed;
            }
            if (goRight && player.Left + (player.Width + 100) < this.ClientSize.Width + 100)
            {
                player.Left += playSpeed;
            }
            //if (goRight && background.Left > -1353)
            //{
            //    background.Left -= backLeft;
            //    foreach (Control x in this.Controls)
            //    {
            //        if (x is PictureBox && x.Tag == "platform" || x is PictureBox && x.Tag == "coin" || x is PictureBox && x.Tag == "door" || x is PictureBox && x.Tag == "key")
            //        {
            //            x.Left -= backLeft;
            //        }
            //    }
            //}
            //if (goLeft && background.Left < 2)
            //{
            //    background.Left += backLeft;
            //    foreach (Control x in this.Controls)
            //    {
            //        if (x is PictureBox && x.Tag == "platform" || x is PictureBox && x.Tag == "coin" || x is PictureBox && x.Tag == "door" || x is PictureBox && x.Tag == "key")
            //        {
            //            x.Left += backLeft;
            //        }
            //    }
            //}
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "platform")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !jumping)
                    {
                        force = 8;
                        //player.Top = x.Top - player.Height;
                        jumpSpeed = 0;
                    }
                }
                if (x is PictureBox && x.Tag == "coin")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        score++;
                    }
                }
            }
            if (player.Bounds.IntersectsWith(door.Bounds) && hasKey)
            {

                gameTimer.Stop();
                MessageBox.Show("You Completed the level!!!");
            }
            if (player.Bounds.IntersectsWith(key.Bounds))
            {
                this.Controls.Remove(key);
                hasKey = true;
            }
            if (player.Top + player.Height > this.ClientSize.Height + 60)
            {
                gameTimer.Stop();
                MessageBox.Show("You Died!!!");
                this.Close();
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

            if (e.KeyCode == Keys.Space && !jumping)
            {
                jumping = true;
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
            if (jumping)
            {
                jumping = false;
            }
        }
        private void CloseGame(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void RestartGame()
        {
            Form1 newWindow = new Form1();
            newWindow.Show();
            this.Hide();
        }


    }
}
