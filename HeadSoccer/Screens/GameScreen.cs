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

            Rectangle player1 = new Rectangle(88, 194, 100, 160);
            Rectangle player2 = new Rectangle(893, 194, 100, 160);

            hitBox.Add(player1);
            hitBox.Add(player2);

            Player p1 = new Player(88, 194, 5, "left", 100, 160);
            Player p2 = new Player(88, 194, 5, "right", 100, 160);

            Players.Add(p1);
            Players.Add(p2);

            switch (CharacterScreen.rotation1)
            {
                case 1:
                    Player1.BackgroundImage = Properties.Resources.Chufu_Cry_Head;
                    break;
                case 2:
                    Player1.BackgroundImage = Properties.Resources.Cool_Cat_Head;
                    break;
                case 3:
                    Player1.BackgroundImage = Properties.Resources.Ugly_Jaden_Head;
                    break;
                case 4:
                    Player1.BackgroundImage = Properties.Resources.Thanos_Ouch_Head;
                    break;
            }

            switch (CharacterScreen.rotation2)
            {
                case 1:
                   Player2.BackgroundImage = Properties.Resources.Chufu_Cry_Head;
                    break;
               case 2:
                  Player2.BackgroundImage = Properties.Resources.Cool_Cat_Head;
                  break;
                case 3:
                   Player2.BackgroundImage = Properties.Resources.Ugly_Jaden_Head;
                    break;
                case 4:
                   Player2.BackgroundImage = Properties.Resources.Thanos_Ouch_Head;
                   break;
            }
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    Players[1].PlayerMove("left");
                    break;
                  case Keys.D:
                    Players[1].PlayerMove("right");
                    break;
                case Keys.Left:
                    Players[0].PlayerMove("left");
                    break;
                case Keys.Right:
                    Players[0].PlayerMove("right");
                    break;
                case Keys.Space:
                    Players[0].PlayerJump();
                    break;
                case Keys.Z:
                    Players[1].PlayerJump();
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
           
        }
    }
}

