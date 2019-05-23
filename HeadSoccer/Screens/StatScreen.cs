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
    public partial class StatScreen : UserControl
    {
        public StatScreen()
        {
            InitializeComponent();
        }

        private void MainButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            MainScreen ms = new MainScreen();
            f.Controls.Add(ms);

            ms.Location = new Point((f.Width - ms.Width) / 2, (f.Height - ms.Height) / 2);
        }
    }
}
