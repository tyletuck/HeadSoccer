using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeadSoccer.Screens;

namespace HeadSoccer.Classes
{
    public class Player
    {
        public int x, y, speed, width, height;
        int jumpHeight = 40, counter = 1;
        bool flag = true;

        public Player(int _x, int _y, int _speed, int _width, int _height)
        {
            x = _x;
            y = _y;
            speed = _speed;
            width = _width;
            height = _height;
        }

        public void PlayerJump()
        {
            if (flag == true)
            {
                flag = false;

                if (counter == 1)
                {
                    y = y + 15;
                }

                if (counter == 2)
                {
                    y = y + 25;
                }

                if (y >= 710)
                {
                    flag = true;
                }
            }

        }

    }
}
