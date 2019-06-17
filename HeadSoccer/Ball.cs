using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using HeadSoccer.Classes;
using HeadSoccer.Screens;

namespace HeadSoccer
{
    public class Ball
    {
        public int x, y, xSpeed, ySpeed;
        public float velocityY;     // Velocity of the ball
        float gravity = 0.5f;           // How strong is gravity
        bool grounded = false;
       public int direction = 0;

        public Ball(int _x, int _y, int _xSpeed, int _ySpeed)
        {
            x = _x;
            y = _y;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
        }

        public void Horizontal(Player p)
        {
            //Checks where the player is and bounces the ball based off that position.
            if (p.x > x)
            {
                direction = 1;
                grounded = false;
            }
            else if (p.x < x)
            {
                direction = 2;
                grounded = false;
            }
        }

        public void ballUpdate(float time)
        {
            //updates the y based on velocity
            velocityY += gravity * time;        // Apply gravity to vertical velocity
            y += Convert.ToInt16(velocityY * time);      // Apply vertical velocity to X position

            if (y > 460)
            {
                y = 460;
                velocityY = 00;
            }

            if (grounded == false && direction == 2)
            {
                x += xSpeed;
            }
            if (grounded == false && direction == 1)
            {
                x -= xSpeed;
            }
        }

        public void OnHit()
        {
            //a boost to get started
            velocityY = -18.0f;   // Give a vertical boost to the balls velocity to start
        }

        public bool BallCollision(Player p)
        {
            //checks for ball collision with player
            Rectangle playerRec = new Rectangle(p.x, p.y, p.width, p.height);
            Rectangle ballRec = new Rectangle(x, y, 50, 50);

            if (ballRec.IntersectsWith(playerRec))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool topCollision()
        {
            //checks the ball collision with roof and the top of the nets
            Rectangle ballRec = new Rectangle(x, y, 50, 50);
            Rectangle topNet1 = new Rectangle(0, 240, 100, 6);
            Rectangle topNet2 = new Rectangle(1003, 240, 100, 6);
            Rectangle roofRec = new Rectangle(0, 0, 1106, 2);

            if (ballRec.IntersectsWith(roofRec))
            {
                return true;
            }
            if (ballRec.IntersectsWith(topNet1))
            {
                return true;
            }
            if (ballRec.IntersectsWith(topNet2))
            {
                return true;
            }
            return false;
        }
        public bool BallCollision()
        {
            //ball collision with the walls
            Rectangle ballRec = new Rectangle(x, y, 50, 50);
            Rectangle rWallRec = new Rectangle(1103, 0, 4, 280);
            Rectangle lWallRec = new Rectangle(0, 0, 4, 280);


            if (ballRec.IntersectsWith(rWallRec))
            {
                return true;
            }

            if (ballRec.IntersectsWith(lWallRec))
            {
                return true;
            }

            return false;
        }

        public int BallCollisonNet()
        {
            //Ball collision with the net
            Rectangle ballRec = new Rectangle(x, y, 50, 50);
            Rectangle rNetRec = new Rectangle(0, 250, 85, 250);
            Rectangle lNetRec = new Rectangle(1106 - 85, 250, 85, 250);


            if (ballRec.IntersectsWith(rNetRec))
            {
                return 1;
            }

            if (ballRec.IntersectsWith(lNetRec))
            {
                return 2;
            }

            return 0;
        }
    }
}
