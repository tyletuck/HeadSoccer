using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeadSoccer.Screens;
using System.Drawing;

namespace HeadSoccer.Classes
{
    public class Player
    {    
       public float velocityY;     // Velocity of the character
        float gravity = 0.5f;           // How strong is gravity
        public int x, y, speed, width, height;
        bool onGround = false;

        public Player(int _x, int _y, int _speed, int _width, int _height)
        {
            x = _x;
            y = _y;
            speed = _speed;
            width = _width;
            height = _height;
        }

        public bool WallStop()
        {
            //checks if the player collides with the wall and moves them off it.
            if (x < 55)
            {
                x = 70;
                return false;
            }
            else if (x > 1045 - width)
            {
                x = 1030- width;
                return false;
            }

            return true;
        }

       public void Update(float time)
        {
           //updates the y based off the velocity calculated.
            velocityY += gravity * time;        // Apply gravity to vertical velocity
            y += Convert.ToInt16(velocityY * time);      // Apply vertical velocity to X position

            if (y > 320)
            {
                //doesnt allow the character to jump if not on the ground (or close to it)
                y = 320;
                velocityY = 00;
                onGround = true;
            }
        }

       public void OnJumpKeyPressed()
        {
           //getting the jump started
            velocityY = -12.0f;   // Give a vertical boost to the players velocity to start jump
        }


    }
}
