using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.PoleschukKR.Sprint6.Task4.V8.Lib;
using System.IO;

namespace Tyuiu.PoleschukKR.Sprint6.Task4.V8
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
                int startValue = Convert.ToInt32(textBoxStrtVal_PKR.Text);
                int stopValue = Convert.ToInt32(textBoxStopValue_PKR.Text);

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray = new double[len];
                valueArray = ds.GetMassFunction(startValue, stopValue);

                this.chartFunction_PKR.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_PKR.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_PKR.Text = "";
                chartFunction_PKR.Series[0].Points.Clear();
                for (int i = 0; i < len; i++)
                {
                    this.chartFunction_PKR.Series[0].Points.AddXY(startValue, valueArray[i]);
                    textBoxResult_PKR.AppendText(valueArray[i] + Environment.NewLine);
                    startValue++;
                }

            }
            catch 
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

        }

        private void buttonSave_PKR_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V8.txt";
                File.WriteAllText(path, textBoxResult_PKR.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно! \n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void buttonHelp_PKR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ИИПб-23-1 Полещук Кирилл Романович", "Сообщение");

        }

        private void buttonDone_PKR_MouseMove(object sender, MouseEventArgs e)
        {
            buttonDone_PKR.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void buttonSave_PKR_MouseMove(object sender, MouseEventArgs e)
        {
            buttonSave_PKR.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void buttonHelp_PKR_MouseMove(object sender, MouseEventArgs e)
        {
            buttonHelp_PKR.Cursor = System.Windows.Forms.Cursors.Hand;

        }

        private void buttonDone_PKR_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_PKR.BackColor = Color.Blue;
        }

        private void buttonDone_PKR_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_PKR.BackColor = Color.Red;

        }

        private void buttonDone_PKR_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_PKR.BackColor = Color.Green;

        }
    }
}
