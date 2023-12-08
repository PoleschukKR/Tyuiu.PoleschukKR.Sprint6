using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.PoleschukKR.Sprint6.Task7.V15.Lib;
using System.IO;

namespace Tyuiu.PoleschukKR.Sprint6.Task7.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_PKR.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
            saveFileDialogMatrix_PKR.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
        }
        static string openFile;
        static int rows;
        static int columns;
        DataService ds = new DataService();
        public int[,] LoadFromData(string path)
        {
            string file = File.ReadAllText(path);
            file = file.Replace('\n', '\r');
            string[] lines = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] array = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_mas = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = Convert.ToInt32(line_mas[j]);
                }
            }
            return array;
        }
        private void buttonOpenFile_PKR_Click(object sender, EventArgs e)
        {
            openFileDialogTask_PKR.ShowDialog();
            openFile = openFileDialogTask_PKR.FileName;

            int[,] arrayValues = new int[rows, columns];
            arrayValues = LoadFromData(openFile);

            dataGridViewInput_PKR.RowCount = rows;
            dataGridViewInput_PKR.ColumnCount = columns;
            dataGridViewOutPut_PKR.RowCount = rows;
            dataGridViewOutPut_PKR.ColumnCount = columns;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInput_PKR.Columns[i].Width = 50;
                dataGridViewOutPut_PKR.Columns[i].Width = 50;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInput_PKR.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(openFile);
            buttonDone_PKR.Enabled = true;

        }

        private void buttonSave_PKR_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_PKR.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_PKR.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_PKR.ShowDialog();

            string path = saveFileDialogMatrix_PKR.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool exists = fileInfo.Exists;
            if (exists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutPut_PKR.RowCount;
            int columns = dataGridViewOutPut_PKR.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str += dataGridViewOutPut_PKR.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str +=  dataGridViewInput_PKR.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonDone_PKR_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFile);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutPut_PKR.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSave_PKR.Enabled = true;
        }

        private void buttonOpenFile_PKR_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtons_PKR.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_PKR_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtons_PKR.ToolTipTitle = "Выполнить";
        }

        private void buttonSave_PKR_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtons_PKR.ToolTipTitle = "Сохранить файл";
        }

        private void buttonInfo_PKR_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtons_PKR.ToolTipTitle = "Справка";
        }

        private void buttonInfo_PKR_Click(object sender, EventArgs e)
        {
            FormAbout formabout = new FormAbout();
            formabout.ShowDialog();
        }

        private void buttonOpenFile_PKR_MouseMove(object sender, MouseEventArgs e)
        {
            buttonOpenFile_PKR.Cursor = System.Windows.Forms.Cursors.Hand;

        }

        private void buttonDone_PKR_MouseMove(object sender, MouseEventArgs e)
        {
            buttonDone_PKR.Cursor = System.Windows.Forms.Cursors.Hand;

        }

        private void buttonSave_PKR_MouseMove(object sender, MouseEventArgs e)
        {
            buttonSave_PKR.Cursor = System.Windows.Forms.Cursors.Hand;

        }

        private void buttonInfo_PKR_MouseMove(object sender, MouseEventArgs e)
        {
            buttonInfo_PKR.Cursor = System.Windows.Forms.Cursors.Hand;

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewInput_PKR.RowCount = 50;
            dataGridViewOutPut_PKR.RowCount = 50;

            dataGridViewInput_PKR.ColumnCount = 50;
            dataGridViewOutPut_PKR.ColumnCount = 50;

            panelLoadFromFile_PKR.Width = this.Width / 2;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewInput_PKR.Columns[i].Width = 25;
                dataGridViewOutPut_PKR.Columns[i].Width = 25;
            }
        }
    }
    
}

