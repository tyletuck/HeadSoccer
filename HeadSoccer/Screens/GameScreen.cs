using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using HeadSoccer.Classes;

namespace HeadSoccer.Screens
{
    public partial class GameScreen : UserControl
    {
        bool escDown = false, aDown, dDown, leftDown, rightDown,zDown, spaceDown;
        List<Rectangle> hitBox = new List<Rectangle>();
        List<Player> Players = new List<Player>();

        public GameScreen()
        {
            InitializeComponent();
            GameTimer.Enabled = true;

            Rectangle player1 = new Rectangle(200, this.Height - 160, 100, 160);
            Rectangle player2 = new Rectangle(900, this.Height - 160, 100, 160);

            hitBox.Add(player1);
            hitBox.Add(player2);

            Player p1 = new Player(100, 650, 5, "left");
            Player p2 = new Player(this.Width - 100, 650,5,"right");

            Players.Add(p1);
            Players.Add(p2);
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    aDown = true;
                    break;
                  case Keys.D:
                    dDown = true;
                    break;
                case Keys.Left:
                    leftDown = true;
                    break;
                case Keys.Right:
                    rightDown = true;
                    break;
                case Keys.Space:
                    spaceDown = true;
                    break;
                case Keys.Z:
                    zDown = true;
                    break;
            }

            //pause screen function
            if (e.KeyCode == Keys.Escape && GameTimer.Enabled)
            {
                GameTimer.Enabled = false;

                DialogResult result = PauseScreen.Show();

                if (result == DialogResult.Cancel)
                {
                    GameTimer.Enabled = true;
                }
                else if (result == DialogResult.Abort)
                {
                    Application.Exit();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (aDown == true)
            {
                Players[1].PlayerMove("left");
            }
            if (dDown == true)
            {
                Players[1].PlayerMove("right");
            }
            if (zDown == true)
            {
                Players[1].PlayerJump();
            }

            if (leftDown == true)
            {
                Players[0].PlayerMove("left");
            }
            if (rightDown == true)
            {
                Players[0].PlayerMove("right");
            }
            if (spaceDown == true)
            {
                Players[0].PlayerJump();
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    escDown = false;
                    break;
                case Keys.A:
                    aDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;
                case Keys.Left:
                    leftDown = false;
                    break;
                case Keys.Right:
                    rightDown = false;
                    break;
                case Keys.Space:
                    spaceDown = false;
                    break;
                case Keys.Z:
                    zDown = false;
                    break;
            }
        }
    }
}

