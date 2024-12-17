using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Platformer
{
    public partial class Form1 : Form
    {
        bool goleft = false; //lean which will control players going left
        bool goright = false; //boolean which will control players going right
        bool jumping = false; //boolean to check if player is jumping or not
        bool hasKey = false; //player starts with no key
        int jumpSpeed = 10; //how fast player moves vertically
        int force = 10; //force of the jump in an integer
        int score = 0; //default score = 0
        int playSpeed = 8; //set player's speed
        int backLeft = 8; //set background and objects moving speed to 8

        /*by moving the background and objects surrounding the player
        we simulate the feeling of movement in the form*/
        public Form1()
        {
            InitializeComponent();
        }

        //player has 3 lives
        private int life = 3;

        //Code for stopwatch
        private int counter = 0;
        private void Stopwatch_Tick(object sender, EventArgs e)
        {
            counter++;
        }
        private void StartStopwatch(object sender, EventArgs e)
        {
            Stopwatch.Start(); // Start the stopwatch
        }

        //Code for setting keys
        private void keyisdown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }

            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }

            if (e.KeyCode == Keys.Space && !jumping)
            {
                jumping = true;
            }
        }
        private void keyisup(object sender, KeyEventArgs e)
        {
            //left key is up -> false
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }

            //right key is up -> false 
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }

            //resetting jumping key 
            if (jumping)
            {
                jumping = false;
            }
        }

        private void mainGameTimer(object sender, EventArgs e)
        {
            player.Top += jumpSpeed;
            player.Refresh(); //refresh player's picturebox consistently

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


            //moving right by adding to player.Left
            if (goright && player.Left + (player.Width + 100) < this.ClientSize.Width)
            {
                player.Left += playSpeed;
            }

            //moving left and stopping on the form's left
            if (goleft && player.Left > 30)
            {
                player.Left -= playSpeed;
            }

            //moving background and object to create illusion of movement
            if (goright && background.Left > -1980)
            {
                background.Left -= backLeft;
                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox && x.Tag == "platform"
                        || x is PictureBox && x.Tag == "coin"
                        || x is PictureBox && x.Tag == "key"
                        || x is PictureBox && x.Tag == "door")
                    {
                        x.Left -= backLeft;
                    }
                }
            }
            if (goleft && background.Left < 10)
            {
                background.Left += backLeft;
                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox && x.Tag == "platform"
                        || x is PictureBox && x.Tag == "coin"
                        || x is PictureBox && x.Tag == "key"
                        || x is PictureBox && x.Tag == "door")
                    {
                        x.Left += backLeft;
                    }
                }
            }

            //preventing collision and pass-throughs
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "platform")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !jumping)
                    {
                        //placing the player on top of pictureboxes to avoid falling
                        force = 8;
                        player.Top = x.Top - player.Height;
                        jumpSpeed = 0;
                    }
                }

                if (x is PictureBox && x.Tag == "coin")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        //remove coin when come in contact and add score
                        this.Controls.Remove(x);
                        score++;
                    }
                }
            }

            //Ending the game
            Menu menu = new Menu();

            //Collecting key
            if (player.Bounds.IntersectsWith(key.Bounds))
            {
                this.Controls.Remove(key);
                hasKey = true;
            }

            //Winning scenario
            if (player.Bounds.IntersectsWith(door.Bounds) && hasKey)
            {
                GameTimer.Stop();
                Stopwatch.Stop();
                MessageBox.Show($"You've completed the level! \nScore: {score} \nTime: {counter}");
                this.Hide();
                menu.ShowDialog();
            }

            //Death scenario
            if (player.Top + player.Height > this.ClientSize.Height)
            {
                GameTimer.Stop();
                Stopwatch.Stop();
                MessageBox.Show($"You died \nScore: {score} \nTime: {counter}");
                this.Hide();
                menu.ShowDialog();
            }
        }
    }
}