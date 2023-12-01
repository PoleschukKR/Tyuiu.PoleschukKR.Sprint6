using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.PoleschukKR.Sprint6.Task1.V3.Lib;

namespace Tyuiu.PoleschukKR.Sprint6.Task1.V3
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
                int startValue = Convert.ToInt32(textBoxStartValue_PKR.Text);
                int stopValue = Convert.ToInt32(textBoxStopValue_PKR.Text);
                string strLine;
                int len = ds.GetMassFunction(startValue, stopValue).Length;
                double[] valueArray = new double[len];
                valueArray = ds.GetMassFunction(startValue, stopValue);
                textBoxResult_PKR.Text = "";
                textBoxResult_PKR.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_PKR.AppendText("|     X       +    F(x)   |" + Environment.NewLine);
                textBoxResult_PKR.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    if (valueArray[i] < 10 && valueArray[i] != -10)
                    {
                        strLine = String.Format("|{0,5:d}         |   {1,5:f}   |", startValue, valueArray[i]);
                    }
                    else
                    {
                    strLine = String.Format("|{0,5:d}         |   {1,5:f}  |", startValue, valueArray[i]);

                    }
                    //strLine = String.Format("|{0,5:d}         |   {1,5:f}  |", startValue, valueArray[i]);
                    textBoxResult_PKR.AppendText(strLine + Environment.NewLine);
                    startValue++;
                }

                textBoxResult_PKR.AppendText("+----------+----------+" + Environment.NewLine);



            }
            catch 
            {

                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void buttonReference_PKR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИИПб-23-1 Полещук Кирилл Романович", "Сообщение");
        }
    }
}
