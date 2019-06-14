using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace HeadSoccer.Screens
{
    public partial class StatScreen : UserControl
    {
        static int lastTimer, p1Goal, p2Goal, totalGoal;
        public StatScreen()
        {
            InitializeComponent();
            Loading();
        }

        private void MainButton_Click(object sender, EventArgs e)
        {
        //goes back to the main menu 
            Form f = this.FindForm();
            f.Controls.Remove(this);

            MainScreen ms = new MainScreen();
            f.Controls.Add(ms);

            ms.Location = new Point((f.Width - ms.Width) / 2, (f.Height - ms.Height) / 2);
            ms.Focus();
        }
        
        //Changing the button colour
        private void MainButton_Enter(object sender, EventArgs e)
        {
            MainButton.BackColor = Color.Red;
        }

        private void MainButton_Leave(object sender, EventArgs e)
        {
            MainButton.BackColor = Color.White;
        }

        public void Loading()
        {
        //Loads the stats off the xml and displays them to the screen in the order they are loaded.
            XmlReader reader = XmlReader.Create("stats.xml");

            reader.ReadToFollowing("P1Goals");
            p1Goal = Convert.ToInt16(reader.ReadString());

            reader.ReadToFollowing("P2Goals");
            p2Goal = Convert.ToInt16(reader.ReadString());

            totalGoal = p1Goal + p2Goal;

            reader.ReadToFollowing("Longest");
            lastTimer = Convert.ToInt16(reader.ReadString());

            outputLabel.Text = "Player 1 Total Goals: " + p1Goal + "\n \n \n";
            outputLabel.Text += "Player 2 Total Goals: " + p2Goal + "\n \n \n";
            outputLabel.Text += "Total Goals Scored: " + totalGoal + " \n \n \n";
            outputLabel.Text += "Longest Game: " + lastTimer;
        }
    }
}
