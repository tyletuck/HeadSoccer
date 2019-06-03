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
        int jumpHeight = 40, counter = 1;
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
            velocityY += gravity * time;        // Apply gravity to vertical velocity
            y += Convert.ToInt16(velocityY * time);      // Apply vertical velocity to X position

            if (y > 200)
            {
                y = 200;
                velocityY = 00;
                onGround = true;
            }
        }

       public void OnJumpKeyPressed()
        {
            velocityY = -12.0f;   // Give a vertical boost to the players velocity to start jump
        }


    }
}
