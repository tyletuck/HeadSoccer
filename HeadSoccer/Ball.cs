using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using HeadSoccer.Classes;

namespace HeadSoccer
{
    public class Ball
    {
        public static int x, y, xSpeed, ySpeed;
        public float velocityY;     // Velocity of the ball
        float gravity = 0.5f;           // How strong is gravity

        public Ball(int _x, int _y, int _xSpeed, int _ySpeed)
        {
            x = _x;
            y = _y;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
        }

        public void ballUpdate(float time)
        {
            velocityY += gravity * time;        // Apply gravity to vertical velocity
            y += Convert.ToInt16(velocityY * time);      // Apply vertical velocity to X position

            if (y > 200)
            {
                y = 200;
                velocityY = 00;
            }
        }

        public void OnHit()
        {
            velocityY = -12.0f;   // Give a vertical boost to the balls velocity to start
        }

        public bool BallCollision(Player p)
        {
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

        public bool BallCollision()
        {
            Rectangle ballRec = new Rectangle(x, y, 50, 50);
            Rectangle floorRec = new Rectangle(0, 495, 1106, 495);
            Rectangle roofRec = new Rectangle(0, 0, 1106, 4);
            Rectangle rWallRec = new Rectangle(1103, 0, 4, 280);
            Rectangle lWallRec = new Rectangle(0, 0, 4, 280);
            Rectangle topNet1 = new Rectangle(0, 240, 80, 6);
            Rectangle topNet2 = new Rectangle(1103, 240, 80, 6);

            if (ballRec.IntersectsWith(floorRec))
            {
                return ballRec.IntersectsWith(floorRec);
            }

            if (ballRec.IntersectsWith(roofRec))
            {
                return ballRec.IntersectsWith(roofRec);
            }

            if (ballRec.IntersectsWith(rWallRec))
            {
                return ballRec.IntersectsWith(rWallRec);
            }

            if (ballRec.IntersectsWith(lWallRec))
            {
                return ballRec.IntersectsWith(lWallRec);
            }

            if (ballRec.IntersectsWith(topNet1))
            {
                return ballRec.IntersectsWith(topNet1);
            }

            if (ballRec.IntersectsWith(topNet2))
            {
                return ballRec.IntersectsWith(topNet2);
            }

            return ballRec.IntersectsWith(ballRec);
        }

        public bool BallCollisonNet()
        {
            Rectangle ballRec = new Rectangle(x, y, 50, 50);
            Rectangle rNetRec = new Rectangle(x, y, 85, 250);
            Rectangle lNetRec = new Rectangle(1090, 250, 85, 250);


            if (ballRec.IntersectsWith(rNetRec))
            {
                return ballRec.IntersectsWith(rNetRec);
            }

            if (ballRec.IntersectsWith(lNetRec))
            {
                return ballRec.IntersectsWith(lNetRec);
            }

            return ballRec.IntersectsWith(ballRec);
        }
    }
}
