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
    public partial class Form1 : Form
    {
        bool goLeft = false; 
        bool goRight = false; 
        bool jumping = false; 
        bool hasKey = false; 
        int jumpSpeed = 10;
        int force = 8; 
        int score = 0;
        int playSpeed = 10; 
        int backLeft = 8; 
            PictureBox PBtest1 = new PictureBox();
            PictureBox PBtest2 = new PictureBox();
        public Form1()
        {
            InitializeComponent();

            this.BackgroundImage = Properties.Resources.Pixel;
            pictureBox13.BackColor = Color.Transparent;
            pictureBox13.Image = Properties.Resources.cat;

            this.KeyPreview = true;
            this.KeyDown += TestKeyDown;

            pictureBox1.BringToFront();
        }

        private void TestKeyDown(object sender, KeyEventArgs e) {
            // Handle key presses to move the kitty
            switch(e.KeyCode) {
                case Keys.Left:
                    // Move the kitty left
                    pictureBox13.Left -= playSpeed;
                    break;
                case Keys.Right:
                    // Move the kitty right
                    pictureBox13.Left += playSpeed;
                    break;
                case Keys.Up:
                    // Move the kitty up
                    pictureBox13.Top -= playSpeed;
                    break;
                case Keys.Down:
                    // Move the kitty down
                    pictureBox13.Top += playSpeed;
                    break;
            }
        }

        private void mainGameTimer(object sender, EventArgs e)
        {
            PBtest1.Top += jumpSpeed;
            PBtest1.Refresh();
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
            if (goLeft && PBtest1.Left > 100)
            {
                PBtest1.Left -= playSpeed;
            }
            if (goRight && PBtest1.Left + (PBtest1.Width + 100) < this.ClientSize.Width)
            {
                PBtest1.Left += playSpeed;
            }
            if (goRight && PBtest1.Left > -1353)
            {
                PBtest1.Left -= backLeft;
                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox && x.Tag == "platform" || x is PictureBox && x.Tag == "coin" || x is PictureBox && x.Tag == "door" || x is PictureBox && x.Tag == "key")
                    {
                        x.Left -= backLeft;
                    }
                }
            }
            if (goLeft && PBtest1.Left < 2)
            {
                PBtest1.Left += backLeft;
                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox && x.Tag == "platform" || x is PictureBox && x.Tag == "coin" || x is PictureBox && x.Tag == "door" || x is PictureBox && x.Tag == "key")
                    {
                        x.Left += backLeft;
                    }
                }
            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "platform")
                {
                    if (PBtest1.Bounds.IntersectsWith(x.Bounds) && !jumping)
                    {
                        force = 8; 
                        PBtest1.Top = x.Top - PBtest1.Height; 
                        jumpSpeed = 0; 
                    }
                }
                if (x is PictureBox && x.Tag == "coin")
                {
                    if (PBtest1.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x); 
                        score++; 
                    }
                }
            }
            if (PBtest1.Bounds.IntersectsWith(door.Bounds) && hasKey)
            {

                gameTimer.Stop();
                MessageBox.Show("You Completed the level!!");
            }
            if (PBtest1.Bounds.IntersectsWith(key.Bounds))
            {
                this.Controls.Remove(key);
                hasKey = true;
            }
            if (PBtest1.Top + PBtest1.Height > this.ClientSize.Height + 60)
            {
                gameTimer.Stop(); 
                MessageBox.Show("You Died!!!"); 
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