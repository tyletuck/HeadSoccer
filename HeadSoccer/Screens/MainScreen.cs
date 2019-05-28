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
    public partial class MainScreen : UserControl
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            GameScreen gs = new GameScreen();
            f.Controls.Add(gs);

            gs.Location = new Point((f.Width - gs.Width) / 2, (f.Height - gs.Height) / 2);
            gs.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Close();
        }

        private void statButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            StatScreen ss = new StatScreen();
            f.Controls.Add(ss);

            ss.Location = new Point((f.Width - ss.Width) / 2, (f.Height - ss.Height) / 2);
        }

        private void playButton_Enter(object sender, EventArgs e)
        {
            playButton.BackColor = Color.Red;
        }

        private void playButton_Leave(object sender, EventArgs e)
        {
            playButton.BackColor = Color.White;
        }

        private void statButton_Leave(object sender, EventArgs e)
        {
            statButton.BackColor = Color.White;
        }

        private void statButton_Enter(object sender, EventArgs e)
        {
            statButton.BackColor = Color.Red;
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
