using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeadSoccer.Screens
{
    public partial class CharacterScreen : UserControl
    {
        bool p1Ready = false, p2Ready = false;
        public static int rotation1 = 1;
        public static int rotation2 = 1;

        public CharacterScreen()
        {
            InitializeComponent();
        }

        private void CharacterScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
        //updates the rotation of the character based on the keys pressed
        //Also include the ready up variables.
            switch (e.KeyCode)
            {
                case Keys.W:
                    Rotation2Up();
                    break;
                case Keys.S:
                    Rotation2Down();
                    break;
                case Keys.Down:
                    Rotation1Down();
                    break;
                case Keys.Up:
                    Rotation1Up();
                    break;
                case Keys.Space:
                    player1Ready();
                    break;
                case Keys.Z:
                    player2Ready();
                    break;
            }
        }

        public void Rotation1Up()
        {
        //Rotates the players selection if they havent readied up yet. The same for the next few methods.
            if (p1Ready == false)
            {
                if (rotation1 >= 5)
                {
                    rotation1 = 1;
                }
                else
                {
                    rotation1++;
                }
            }
            drawChar();
        }

        public void Rotation1Down()
        {
            if (p1Ready == false)
            {
                if (rotation1 <= 0)
                {
                    rotation1 = 4;
                }
                else
                {
                    rotation1--;
                }
            }
            drawChar();
        }

        public void Rotation2Up()
        {
            if (p2Ready == false)
            {
                if (rotation2 >= 5)
                {
                    rotation2 = 1;
                }
                else
                {
                    rotation2++;
                }
            }
            drawChar();
        }

        public void Rotation2Down()
        {
            if (p2Ready == false)
            {
                if (rotation2 <= 0)
                {
                    rotation2 = 4;
                }
                else
                {
                    rotation2--;
                }
            }
            drawChar();
        }

        public void drawChar()
        {
        //Draws the character based off the selection set by the player.
            switch (rotation1)
            {
                case 1:
                    Char1.BackgroundImage = Properties.Resources.Chufu_Cry_Head;
                    break;
                case 2:
                    Char1.BackgroundImage = Properties.Resources.Cool_Cat_Head;
                    break;
                case 3:
                    Char1.BackgroundImage = Properties.Resources.Ugly_Jaden_Head;
                    break;
                case 4:
                    Char1.BackgroundImage = Properties.Resources.Thanos_Ouch_Head;
                    break;
            }

            switch (rotation2)
            {
                case 1:
                    Char2.BackgroundImage = Properties.Resources.Chufu_Cry_Head;
                    break;
                case 2:
                    Char2.BackgroundImage = Properties.Resources.Cool_Cat_Head;
                    break;
                case 3:
                    Char2.BackgroundImage = Properties.Resources.Ugly_Jaden_Head;
                    break;
                case 4:
                    Char2.BackgroundImage = Properties.Resources.Thanos_Ouch_Head;
                    break;
            }

            Refresh();
        }

        public void player1Ready()
        {
        //Player readies up and sets stops the player from changing characters afterwords. Same for next method
            if (p1Ready == false)
            {
                p1Ready = true;
                p1ReadyLabel.Visible = true;
            }
            else
            {
                p1Ready = false;
                p1ReadyLabel.Visible = false;
            }
            readyCheck();
        }

        public void player2Ready()
        {
            if (p2Ready == false)
            {
                p2Ready = true;
                p2ReadyLabel.Visible = true;
            }
            else
            {
                p2Ready = false;
                p2ReadyLabel.Visible = false;
            }
            readyCheck();
        }

        public void readyCheck()
        {
        //If both players are ready go to next screen.
            if (p1Ready == true && p2Ready == true)
            {
                Form f = this.FindForm();
                f.Controls.Remove(this);

                GameScreen gs = new GameScreen();
                f.Controls.Add(gs);

                gs.Location = new Point((f.Width - gs.Width) / 2, (f.Height - gs.Height) / 2);
                gs.Focus();
            }
        }
    }
}
