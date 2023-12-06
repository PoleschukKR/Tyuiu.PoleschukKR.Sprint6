using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.PoleschukKR.Sprint6.Task3.V22.Lib;

namespace Tyuiu.PoleschukKR.Sprint6.Task3.V22
{
    
    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        int[,] matrix = new int[5,5] { {17,0,19,-8,-1},
                                     {9, 4, -5, 7,15},
                                     {11,13,4,-4,-14},
                                     {11,14,5,-15,16},
                                     {2,-14,-2,11,11}};
        
        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            dataGridViewMatrixTask_PKR.ColumnCount = columns;
            dataGridViewMatrixTask_PKR.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrixTask_PKR.Columns[i].Width = 30;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrixTask_PKR.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }

        private void buttonDone_PKR_Click(object sender, EventArgs e)
        {
          
            DataService ds = new DataService();
            int[,] mtrx = ds.Calculate(matrix);
            int rows = mtrx.GetLength(0);
            int columns = mtrx.GetLength(1);

            dataGridViewResult_PKR.ColumnCount = columns;
            dataGridViewResult_PKR.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewResult_PKR.Columns[i].Width =30;
            }


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult_PKR.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i,j]);
                }
            }
        }

        private void buttonHelp_PKR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИИПб-23-1 Полещук Кирилл Романович", "Сообщение");

        }

    }
}
