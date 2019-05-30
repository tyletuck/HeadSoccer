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
        bool runOnce = false;
        public static bool aDown, dDown, leftDown, rightDown, spaceDown, zDown;

        int i = 0;
       

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
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

        List<Rectangle> hitBox = new List<Rectangle>();
        List<Player> Players = new List<Player>();

        public GameScreen()
        {
            InitializeComponent();
            GameTimer.Enabled = true;

            Rectangle player1 = new Rectangle(88, 194, 100, 160);
            Rectangle player2 = new Rectangle(893, 194, 100, 160);

            hitBox.Add(player1);
            hitBox.Add(player2);

            Player p1 = new Player(88, 200, 15, 100, 160);
            Player p2 = new Player(893, 200, 15, 100, 160);

            Players.Add(p1);
            Players.Add(p2);

        }

        public void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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
                Players[1].x = Players[1].x - Players[1].speed;
            }
            if (dDown == true)
            {
                Players[1].x = Players[1].x + Players[1].speed;
            }

            if (leftDown == true)
            {
                Players[0].x = Players[0].x - Players[0].speed;
            }
            if (rightDown == true)
            {
                Players[0].x = Players[0].x + Players[0].speed;
            }
            Refresh();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {

                switch (CharacterScreen.rotation1)
                {
                    case 1:
                        e.Graphics.DrawImage(Properties.Resources.Chufu_Cry_Head, Players[0].x, Players[0].y, 105, 325);
                        break;
                    case 2:
                        e.Graphics.DrawImage(Properties.Resources.Cool_Cat_Head, Players[0].x, Players[0].y, 105, 325);
                        break;
                    case 3:
                        e.Graphics.DrawImage(Properties.Resources.Ugly_Jaden_Head, Players[0].x, Players[0].y, 105, 325);
                        break;
                    case 4:
                        e.Graphics.DrawImage(Properties.Resources.Thanos_Ouch_Head, Players[0].x, Players[0].y, 105, 325);
                        break;
                }

                switch (CharacterScreen.rotation2)
                {
                    case 1:
                        e.Graphics.DrawImage(Properties.Resources.Chufu_Cry_Head, Players[1].x, Players[1].y, 105, 325);
                    
                        break;
                    case 2:
                        e.Graphics.DrawImage(Properties.Resources.Cool_Cat_Head, Players[1].x, Players[1].y, 105, 325);
                        break;
                    case 3:
                        e.Graphics.DrawImage(Properties.Resources.Ugly_Jaden_Head, Players[1].x, Players[1].y, 105, 325);
                        break;
                    case 4:
                        e.Graphics.DrawImage(Properties.Resources.Thanos_Ouch_Head, Players[1].x, Players[1].y, 105, 325);
                        break;
                }
            

            
        }
    }
}

