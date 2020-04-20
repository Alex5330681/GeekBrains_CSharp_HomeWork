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
    public partial class Game1 : Form
    {

        static public Random rnd = new Random();
        static public int i = rnd.Next(1, 10);

        public Game1()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (i == Convert.ToInt32(textBox.Text))
            {

                MessageBox.Show("Верно, компьютер загадал число : " + i, "", MessageBoxButtons.OK);

            }
            else MessageBox.Show("Не угадал, попробуй еще! ", "", MessageBoxButtons.OK);

        }
    }
}
