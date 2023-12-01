using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.PoleschukKR.Sprint6.Task0.V24.Lib;

namespace Tyuiu.PoleschukKR.Sprint6.Task0.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonResult_PKR_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_PKR.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_PKR.Text)));
            }
            catch 
            {

                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonHelp_PKR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ИИПб-23-1 Полещук Кирилл Романович", "Сообщение");
        }


        private void textBoxVarX_PKR_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && ( e.KeyChar != '.') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
    }
}
