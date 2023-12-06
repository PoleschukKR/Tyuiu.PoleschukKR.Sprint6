using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.PoleschukKR.Sprint6.Task5.V7.Lib;
using System.IO;

namespace Tyuiu.PoleschukKR.Sprint6.Task5.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Users\ILYA\source\repos\Tyuiu.PoleschukKR.Sprint6\Tyuiu.PoleschukKR.Sprint6.Task5.V7\bin\Debug\InPutFileTask5V7.txt";

        private void buttonDone_PKR_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewRes_PKR.ColumnCount = 2;
                dataGridViewRes_PKR.Columns[0].Width = 20;
                dataGridViewRes_PKR.Columns[1].Width = 60;

                this.chartDiag_PKR.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartDiag_PKR.ChartAreas[0].AxisY.Title = "Ось Y";

                chartDiag_PKR.Series[0].Points.Clear();
                double[] numMass = new double[ds.len];
                numMass = ds.LoadFromDataFile(path);

                for (int i = 0; i < numMass.Length; i++)
                {
                    dataGridViewRes_PKR.Rows.Add(Convert.ToString(i), Convert.ToString(numMass[i]));
                    chartDiag_PKR.Series[0].Points.AddXY(i, numMass[i]);
                }
            }
            catch
            {

                MessageBox.Show("Неверные данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИИПб-23-1 Полещук Кирилл Романович", "Сообщение");

        }

        private void buttonOpenFile_PKR_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process txt = new System.Diagnostics.Process();
                txt.StartInfo.FileName = "notepad.exe";
                txt.StartInfo.Arguments = path;
                txt.Start();
            }
            catch 
            {
                MessageBox.Show("Сбой при открытии файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_MouseMove(object sender, MouseEventArgs e)
        {
            buttonHelp_PKR.Cursor = System.Windows.Forms.Cursors.Hand;

        }

        private void buttonOpenFile_PKR_MouseMove(object sender, MouseEventArgs e)
        {
           buttonOpenFile_PKR.Cursor = System.Windows.Forms.Cursors.Hand;

        }

        private void buttonDone_PKR_MouseMove(object sender, MouseEventArgs e)
        {
            buttonDone_PKR.Cursor = System.Windows.Forms.Cursors.Hand;

        }

        private void buttonDone_PKR_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_PKR.BackColor = Color.Green;

        }

        private void buttonDone_PKR_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_PKR.BackColor = Color.Red;

        }

        private void buttonDone_PKR_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_PKR.BackColor = Color.Blue;

        }
    }
}
