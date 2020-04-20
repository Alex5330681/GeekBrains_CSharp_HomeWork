using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_7_HomeWork_WF
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnGame1_Click(object sender, EventArgs e)
        {
            Game1 fp = new Game1();
            fp.Show();
        }

        private void btnGame2_Click(object sender, EventArgs e)
        {
            Game2 fp = new Game2();
            fp.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
