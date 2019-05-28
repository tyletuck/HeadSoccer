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
        bool wDown, sDown, upDown, downDown;
        int rotation1 = 1;
        int rotation2 = 1;

        public CharacterScreen()
        {
            InitializeComponent();
        }

        private void CharacterScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    Rotation1Up();
                    break;
                case Keys.S:
                    Rotation1Down();
                    break;
                case Keys.Down:
                    Rotation2Down();
                    break;
                case Keys.Up:
                    Rotation2Up();
                    break;
            }
        }

        private void CharacterScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.Down:
                    downDown = false;
                    break;
                case Keys.Up:
                    upDown = false;
                    break;
            }
        }

        public void Rotation1Up()
        {
            if (rotation1 >= 5)
            {
                rotation1 = 1;
            }
            else
            {
                rotation1++;
            }
            drawChar();
        }

        public void Rotation1Down()
        {
            if (rotation1 <= 0)
            {
                rotation1 = 4;
            }
            else
            {
                rotation1--;
            }
            drawChar();
        }

        public void Rotation2Up()
        {
            if (rotation2 >= 5)
            {
                rotation2 = 1;
            }
            else
            {
                rotation2++;
            }
            drawChar();
        }

        public void Rotation2Down()
        {
            if (rotation2 <= 0)
            {
                rotation2 = 4;
            }
            else
            {
                rotation2--;
            }
            drawChar();
        }

        public void drawChar()
        {
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
    }
}
