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
    public partial class Game2 : Form
    {
        public static Random rnd = new Random();
        public static int target = 0;
        public static int cmdCounter = 0;

        public Game2()
        {

            InitializeComponent();
            btnPlus.Text = "+1";
            btnMultiply.Text = "x2";
            btnReset.Text = "Сброс";
            lblNum.Text = "0";
            lblCmdCounter.Text = "0";
            this.Text = "Удвоитель";

            taskNumb();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            cmdCounter++;
            lblNum.Text = (int.Parse(lblNum.Text) + 1).ToString();
            lblCmdCounter.Text = "Всего ходов: " + cmdCounter;
            checkNum();

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            cmdCounter++;
            lblNum.Text = (int.Parse(lblNum.Text) * 2).ToString();
            lblCmdCounter.Text = "Всего ходов: " + cmdCounter;
            checkNum();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmdCounter++;
            lblNum.Text = "0";
            lblCmdCounter.Text = "Всего ходов: " + cmdCounter;
        }

        private void lblNum_Click(object sender, EventArgs e)
        {

        }

        private void lblCmdCounter_Click(object sender, EventArgs e)
        {

        }

        private void taskNumb()
        {

            lblNum.Text = "0";
            target = rnd.Next(1, 100);
            MessageBox.Show($"Игра началась. Наберите число {target} за минимальное колличество ходов", "", MessageBoxButtons.OK);
            lblCmdCounter.Text = "количество ходов";
            cmdCounter = 0;

        }

        private void checkNum()
        {
            if (int.Parse(lblNum.Text) == target)
            {
                MessageBox.Show($"Вы набрали необходимое число {target} за {cmdCounter} ходов.", "", MessageBoxButtons.OK);
            }
        }
        



}
}
