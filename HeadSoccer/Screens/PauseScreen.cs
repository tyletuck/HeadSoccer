using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeadSoccer.Screens
{
    public partial class PauseScreen : Form
    {

        private static PauseScreen pauseForm;

        private static DialogResult buttonResult = new DialogResult();

        public PauseScreen()
        {
            InitializeComponent();
        }

        public static DialogResult Show()
        {

            pauseForm = new PauseScreen();

            pauseForm.ShowDialog();



            return buttonResult;

        }

        private static void ButtonClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender; 

            switch (btn.Text)
            {
                case "Continue":
                    buttonResult = DialogResult.Cancel;
                    break;
                case "Exit Game":
                    buttonResult = DialogResult.Abort;
                    break;
            }

            pauseForm.Close();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            buttonResult = DialogResult.Abort;
            pauseForm.Close();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            buttonResult = DialogResult.Cancel;
            pauseForm.Close();

        }

        private void continueButton_Enter(object sender, EventArgs e)
        {
            continueButton.BackColor = Color.Red;
        }

        private void continueButton_Leave(object sender, EventArgs e)
        {
            continueButton.BackColor = Color.White;
        }

        private void exitButton_Enter(object sender, EventArgs e)
        {
            exitButton.BackColor = Color.Red;
        }

        private void exitButton_Leave(object sender, EventArgs e)
        {   
            exitButton.BackColor = Color.White;
        }
    }
}
