using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Platformer
{
    public partial class Form1 : Form
    {
        bool goleft = false; // boolean which will control players going left
        bool goright = false; // boolean which will control players going right
        bool jumping = false; // boolean to check if player is jumping or not
        bool hasKey = false; // default value of whether the player has the key
        int jumpSpeed = 18; // integer to set jump speed
        int force = 10; // force of the jump in an integer
        int score = 0; // default score integer set to 0
        int playSpeed = 8; //set player's speed
        int backLeft = 8; // this integer will set the background moving speed to 8

        bool isCollidingVertically = false; //check vertical collision
        bool isCollidingHorizontally = false; //check horizontal collision
        int gravity = 8; //speed of falling
        public Form1()
        {
            InitializeComponent();
        }

        private void keyisleft(object sender, KeyEventArgs e)
        {
            //the player pressed the left key AND the player is inside the panel
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }

            //player pressed the right key AND the player left + player width < the panel width          
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }

            //the player pressed the space key and jumping boolean is false
            if (e.KeyCode == Keys.Space && !jumping)
            {
                jumping = true;
            }
        }
        private void keyisright(object sender, KeyEventArgs e)
        {
            // left key is up -> false
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }

            // right key is up -> false 
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }

            /* when the keys are released we check if jumping is true
            if so we need to set it back to false so the player can jump again */
            if (jumping)
            {
                jumping = false;
            }
        }

        private void mainGameTimer(object sender, EventArgs e)
        {
            // linking the jumpspeed integer with the player picture boxes to location
            player.Top += jumpSpeed;
            // refresh the player picture box consistently
            player.Refresh();

            /* if jumping is true and force is less than 0
             then change jumping to false */
            if (jumping && force < 0)
            {
                jumping = false;
            }
            /* if jumping is true
             then change jump speed to -12 
             reduce force by 1 */
            if (jumping)
            {
                jumpSpeed = -12;
                force -= 1;
            }
            else
            {
                jumpSpeed = 12;
            }

            //setting gravity
            if (!isCollidingVertically)
            {
                player.Top += gravity;
            }

            //Left and right movement
            if (goleft && player.Left > 0)
            {
                player.Left -= playSpeed;
            }

            if (goright && player.Left + (player.Width + 100) < this.ClientSize.Width)
            {
                player.Left += playSpeed;
            }

            /* by doing the if statement above, the player picture will stop on the forms right
            if go right is true and the background picture left is greater 1352
            then we move the background picture towards the left*/
            if (goright && background.Left > -1980 && !isCollidingHorizontally)
            {
                background.Left -= backLeft;
                /* the for loop below is checking to see the platforms and coins in the level
                when they are found it will move them towards the left*/
                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox && x.Tag == "platform" || x is PictureBox && x.Tag == "coin" || x is PictureBox && x.Tag == "door" || x is PictureBox && x.Tag == "key")
                    {
                        x.Left -= backLeft;
                    }
                }
            }

            /* if go left is true and the background pictures left is less than 2
            then we move the background picture towards the right */
            if (goleft && background.Left < 2 && !isCollidingHorizontally)
            {
                background.Left += backLeft;

                /* below the is the for loop thats checking to see the platforms and coins in the level
                when they are found in the level it will move them all towards the right with the background */
                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox && x.Tag == "platform" || x is PictureBox && x.Tag == "coin" || x is PictureBox && x.Tag == "door" || x is PictureBox && x.Tag == "key")
                    {
                        x.Left += backLeft;
                    }
                }
            }

            // below if the for loop thats checking for all of the controls in this form
            foreach (Control x in this.Controls)
            {
                // X is a picturebox and it has a tag of platform
                if (x is PictureBox && x.Tag == "platform")
                {
                    //preventing fall
                    if (player.Bounds.IntersectsWith(x.Bounds) && !jumping)
                    {
                        force = 8;

                        player.Top = x.Top - player.Height; // also we place the player on top of the picture box
                        jumpSpeed = 0; // set the jump speed to 0
                    }
                }
                //preventing left collision
                if (player.Bounds.IntersectsWith(x.Bounds) && player.Right >= x.Left && player.Left < x.Left)
                {
                    player.Left = x.Left - player.Width;
                    isCollidingHorizontally = true;
                }
                //preventing right collision
                if (player.Bounds.IntersectsWith(x.Bounds) && player.Left <= x.Right && player.Right > x.Right)
                {
                    player.Left = x.Right;
                    isCollidingHorizontally = true;
                }

                if (player.Bounds.IntersectsWith(x.Bounds) && x.Tag == "coin")
                {
                    this.Controls.Remove(x);
                }

                // if the picture box found has a tag of coin
                if (x is PictureBox && x.Tag == "coin")
                {
                    // if the player collides with the coin picture box
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x); // then we are going to remove the coin image
                        score++; // add 1 to the score
                    }
                }
            }

            // if the player collides with the door and has key boolean is true
            if (player.Bounds.IntersectsWith(door.Bounds) && hasKey)
            {
                //door.Image = Properties.Resources.door_open;
                //stop the timer
                GameTimer.Stop();
                MessageBox.Show("You Completed the level!!"); // show the message box
            }
            // if the player collides with the key picture box
            if (player.Bounds.IntersectsWith(key.Bounds))
            {
                // then we remove the key from the game
                this.Controls.Remove(key);
                // change the has key boolean to true
                hasKey = true;
            } 

            // if the player goes below the forms height then we will end the game
            if (player.Top + player.Height > this.ClientSize.Height + 60)
            {
                GameTimer.Stop(); // stop the timer
                MessageBox.Show("You Died!"); // show the message box
            }
        }
    }
}
