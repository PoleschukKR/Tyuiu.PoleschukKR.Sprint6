using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.PoleschukKR.Sprint6.Task2.V27.Lib;

namespace Tyuiu.PoleschukKR.Sprint6.Task2.V27
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonDone_PKR_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStrtValue_PKR.Text);
                int stopValue = Convert.ToInt32(textBoxStopValue_PKR.Text);
                int len = ds.GetMassFunction(startValue, stopValue).Length;
                double[] valueArray = new double[len];
                valueArray = ds.GetMassFunction(startValue, stopValue);

                this.chartFuction_PKR.Titles.Add("График функции  (2x - 3) / (cos(x) - 2x) +5x - sin(x)");

                this.chartFuction_PKR.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFuction_PKR.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i= 0; i <= len - 1; i++)
                {
                    this.dataGridViewFuction_PKR.Rows.Add(Convert.ToString(startValue), Convert.ToString(valueArray[i]));
                    this.chartFuction_PKR.Series[0].Points.AddXY(startValue, valueArray[i]);
                    startValue++;
                }

            }
            catch
            {

                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void buttonDone_PKR_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_PKR.BackColor = Color.Red;
        }

        private void buttonDone_PKR_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_PKR.BackColor = Color.Green;

        }

        private void buttonDone_PKR_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_PKR.BackColor = Color.Blue;
        }

        private void buttonHelp_PKR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИИПб-23-1 Полещук Кирилл Романович", "Сообщение");
        }
    }
}
