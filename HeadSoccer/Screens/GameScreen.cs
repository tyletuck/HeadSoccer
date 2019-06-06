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
using System.Diagnostics;

namespace HeadSoccer.Screens
{
    public partial class GameScreen : UserControl
    {
        public static bool aDown, dDown, leftDown, rightDown, spaceDown, zDown;
        int ballxSpeed = 30;
        int ballySpeed = 30;
        int p1Score = 0, p2Score = 0;

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
        public static  List<Player> Players = new List<Player>();
        public static List<Ball> Balls = new List<Ball>();

        Stopwatch scoreWatch = new Stopwatch();

        public GameScreen()
        {
            InitializeComponent();
            GameTimer.Enabled = true;

            Player p1 = new Player(88, 320, 15, 80, 170);
            Player p2 = new Player(893, 320, 15, 80, 170);

            Ball b = new Ball(525, 200, ballxSpeed, ballySpeed);

            Players.Add(p1);
            Players.Add(p2);;
            Balls.Add(b);
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

        public void GameReset()
        {
            scoreWatch.Reset();
            goalBox.Visible = false;

            Balls[0].x = 525;
            Balls[0].y = 200;
            Balls[0].direction = 0;

            Players[0].x = 88;
            Players[1].x = 893;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (scoreWatch.ElapsedMilliseconds >= 3000)
            {
                GameReset();
            }

            Players[0].Update(5);
            Players[1].Update(5);

            Balls[0].ballUpdate(5);

            Rectangle player1 = new Rectangle(Players[0].x, Players[0].y, Players[0].width, Players[0].height);
            Rectangle player2 = new Rectangle(Players[1].x, Players[1].y, Players[1].width, Players[1].height);

            #region Ball

            if (Balls[0].BallCollision(Players[0]) == true)
            {
                Balls[0].y += Convert.ToInt16(Balls[0].velocityY);
                Balls[0].OnHit();
                Balls[0].Horizontal(Players[0]);
            }

            if (Balls[0].BallCollision(Players[1]) == true)
            {
                Balls[0].y += Convert.ToInt16(Balls[0].velocityY);
                Balls[0].OnHit();
                Balls[0].Horizontal(Players[1]);
            }

            switch (Balls[0].BallCollisonNet())
            {
                case 0:
                    break;
                case 1:
                    scoreWatch.Restart();
                    goalBox.Visible = true;
                    p1Score++;
                    break;
                case 2:
                    scoreWatch.Restart();
                    goalBox.Visible = true;
                    p2Score++;
                    break;
            }

            if (Balls[0].BallCollision() == true)
            {
                Balls[0].xSpeed *= -1;
            }
            if (Balls[0].topCollision() == true)
            {
                Balls[0].velocityY *= -1;
            }
            #endregion

            #region Player
            if (player1.IntersectsWith(player2))
            {
                Players[0].x -= 20;
                Players[1].x += 20;
            }

            if (aDown == true && Players[1].WallStop() == true)
            {
                Players[1].x = Players[1].x - Players[1].speed;
            }
            if (dDown == true && Players[1].WallStop() == true)
            {
                Players[1].x = Players[1].x + Players[1].speed;
            }

            if (leftDown == true && Players[0].WallStop() == true)
            {
                Players[0].x = Players[0].x - Players[0].speed;
            }
            if (rightDown == true && Players[0].WallStop() == true)
            {
                Players[0].x = Players[0].x + Players[0].speed;
            }
            if (spaceDown == true && Players[0].y >= 300)
            {
                Players[0].y += Convert.ToInt16(Players[0].velocityY);
                Players[0].OnJumpKeyPressed();
            }
            if (zDown == true && Players[1].y >= 300)
            {
                Players[1].y += Convert.ToInt16(Players[0].velocityY);
                Players[1].OnJumpKeyPressed();
            }
            #endregion
            Refresh();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {

            e.Graphics.DrawImage(Properties.Resources.Ball, Balls[0].x, Balls[0].y, 50, 50);

                switch (CharacterScreen.rotation1)
                {
                    case 1:
                        e.Graphics.DrawImage(Properties.Resources.Chufu_Cry_Head, Players[0].x, Players[0].y, 79, 170);
                        break;
                    case 2:
                        e.Graphics.DrawImage(Properties.Resources.Cool_Cat_Head, Players[0].x, Players[0].y, 79, 170);
                        break;
                    case 3:
                        e.Graphics.DrawImage(Properties.Resources.Ugly_Jaden_Head, Players[0].x, Players[0].y, 79, 170);
                        break;
                    case 4:
                        e.Graphics.DrawImage(Properties.Resources.Thanos_Ouch_Head, Players[0].x, Players[0].y, 79, 170);
                        break;
                }

                switch (CharacterScreen.rotation2)
                {
                    case 1:
                        e.Graphics.DrawImage(Properties.Resources.Chufu_Cry_Head, Players[1].x, Players[1].y, 79, 170);
                    
                        break;
                    case 2:
                        e.Graphics.DrawImage(Properties.Resources.Cool_Cat_Head, Players[1].x, Players[1].y, 79, 170);
                        break;
                    case 3:
                        e.Graphics.DrawImage(Properties.Resources.Ugly_Jaden_Head, Players[1].x, Players[1].y, 79, 170);
                        break;
                    case 4:
                        e.Graphics.DrawImage(Properties.Resources.Thanos_Ouch_Head, Players[1].x, Players[1].y, 79, 170);
                        break;
                }
            

            
        }
    }
}

