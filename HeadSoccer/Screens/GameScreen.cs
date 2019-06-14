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
using HeadSoccer.Screens;
using System.Xml;

namespace HeadSoccer.Screens
{
    public partial class GameScreen : UserControl
    {
        public static bool aDown, dDown, leftDown, rightDown, spaceDown, zDown;
        int ballxSpeed = 30;
        int ballySpeed = 30;
        int p1Score = 0, p2Score = 0;
        static int timer;
        static int lastTimer = 0;
        bool runOnce = true, doubleCheck = true;

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
        //Different keys for the players to control their character or pause the game
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

//Lists for the hitboxes, players, and the ball
        List<Rectangle> hitBox = new List<Rectangle>();
        public static List<Player> Players = new List<Player>();
        public static List<Ball> Balls = new List<Ball>();

//stopwatches used once a goal is scored
        Stopwatch scoreWatch = new Stopwatch();
        Stopwatch endWatch = new Stopwatch();

        public GameScreen()
        {
        //Starts the gametimer and sets the initial values
            InitializeComponent();
            loadStats();
            //saveStats();
            GameTimer.Enabled = true;

            Player p1 = new Player(88, 320, 15, 80, 170);
            Player p2 = new Player(893, 320, 15, 80, 170);

            Ball b = new Ball(525, 200, ballxSpeed, ballySpeed);

            Players.Add(p1);
            Players.Add(p2); ;
            Balls.Add(b);

            GameReset();
            p1Score = 0;
            p2Score = 0;
        }

        public void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
        //Different keys for the players to control their character or pause the game
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
        //Rests the positions of everything and takes the goal pop up away.
            scoreWatch.Reset();
            goalBox.Visible = false;

            Balls[0].x = 525;
            Balls[0].y = 200;
            Balls[0].direction = 0;

            Players[0].x = 88;
            Players[1].x = 893;

            runOnce = true;
        }

        public bool scoreCheck()
        {
        //Checks if a player has won and possibly ends the game if it has
            if (p1Score >= 5)
            {
                p1winBox.Visible = true;
                if (doubleCheck == true)
                {
                    doubleCheck = false;
                    endWatch.Restart();
                }

                if (endWatch.ElapsedMilliseconds >= 3000)
                {
                    doubleCheck = true;
                    end();
                }
                return true;

            }

            if (p2Score >= 5)
            {
                p2winBox.Visible = true;
                if (doubleCheck == true)
                {
                    doubleCheck = false;
                    endWatch.Restart();
                }

                if (endWatch.ElapsedMilliseconds >= 5000)
                {
                    doubleCheck = true;
                    end();
                }
                return true;
            }

            return false;
        }

        public void mainScreen()
        {
        //Goes back to the mainscreen when called
            Form f = this.FindForm();
            f.Controls.Remove(this);

            MainScreen ms = new MainScreen();
            f.Controls.Add(ms);

            ms.Location = new Point((f.Width - ms.Width) / 2, (f.Height - ms.Height) / 2);
            ms.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer++;
//if 3 seconds has passed and nobody won resets the game state (called when someone scores)
            if (scoreWatch.ElapsedMilliseconds >= 3000 && scoreCheck() == false)
            {
                GameReset();
            }

            //updates the player position mainly for the y. Also the ball position
            Players[0].Update(5);
            Players[1].Update(5);

            Balls[0].ballUpdate(5);
            
            //Draws new hitboxes every update of the screen
            Rectangle player1 = new Rectangle(Players[0].x, Players[0].y, Players[0].width, Players[0].height);
            Rectangle player2 = new Rectangle(Players[1].x, Players[1].y, Players[1].width, Players[1].height);

            #region Ball

            //Ball collision with a player. Moves the ball based on the side the player was on
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

            //balls collision with the net. changes outcome based on which net.
            switch (Balls[0].BallCollisonNet())
            {
                case 0:
                    break;
                case 1:
                    if (runOnce == true)
                    {
                        runOnce = false;
                        scoreCheck();
                        scoreWatch.Restart();
                        goalBox.Visible = true;
                        p2Score++;
                        p2Label.Text = "Player 2: " + p2Score;
                    }
                    break;
                case 2:
                    if (runOnce == true)
                    {
                        runOnce = false;
                        scoreCheck();
                        scoreWatch.Restart();
                        goalBox.Visible = true;
                        p1Score++;
                        p1Label.Text = "Player 1: " + p1Score;
                    }
                    break;
            }
            
            //if the ball collides with a player or the walls or top of screen, multiply a value by -1
            if (Balls[0].BallCollision() == true)
            {
            Balls[0].xSpeed *= -1;
            //this needs to change the direction value directly in order to properly move the ball.
            //Like this whenever it is interacted with the ball with move the opposite direction to what is wanted.
            //if (Balls[0].direction = 2)
            //{
            //  Balls[0].direction = 1;
            //}
            //if (Balls[0].direction = 1)
            //{
            //  Balls[0].direction = 2;
            //}
            }
            if (Balls[0].topCollision() == true)
            {
                Balls[0].velocityY *= -1;
            }
            #endregion

            #region Player
            //if the players collide, move them 40 units away from each other
            if (player1.IntersectsWith(player2))
            {
                Players[0].x -= 20;
                Players[1].x += 20;
            }

            //if the player is trying to move against a wall moves them away based on their speed
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
            
            //lets the player jump if they are on the ground and press the respective key
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

        public void end()
        {
        //Methods that run when the game ends and is going to reset
            saveStats();
            GameTimer.Stop();
            mainScreen();
        }


        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            //Draws the ball and character based on their selections
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

        public static void loadStats()
        {
            //XmlReader reader = XmlReader.Create("stats.xml");

            //reader.ReadToFollowing("Longest");
            //lastTimer = Convert.ToInt16(reader.ReadString());
        }

        public void saveStats()
        {
            //XmlWriter writer = XmlWriter.Create("stats.xml", null);

            //writer.WriteStartElement("statistics");

            //if(timer > lastTimer)
            //{
            //    writer.WriteElementString("Longest", timer.ToString());
            //}

            //writer.WriteEndElement();

            //writer.Close();
        }
    }
}

