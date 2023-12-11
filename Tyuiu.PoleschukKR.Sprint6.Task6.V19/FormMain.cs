using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.PoleschukKR.Sprint6.Task6.V19.Lib;
using System.IO;

namespace Tyuiu.PoleschukKR.Sprint6.Task6.V19
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path;
        private void buttonOpenFile_PKR_Click(object sender, EventArgs e)
        {
            openFileDialogTask_PKR.ShowDialog();
            path = openFileDialogTask_PKR.FileName;
            textBoxLoadFromFile_PKR.Text = File.ReadAllText(path);
            groupBoxLoadFromFile_PKR.Text = groupBoxLoadFromFile_PKR.Text + " " + openFileDialogTask_PKR.FileName;
            buttonDone_PKR.Enabled = true;
        }

        private void buttonDone_PKR_Click(object sender, EventArgs e)
        {

            textBoxResult_PKR.Text = ds.CollectTextFromFile(path);
        }

        private void buttonInfo_PKR_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpenFile_PKR_MouseMove(object sender, MouseEventArgs e)
        {
            buttonOpenFile_PKR.Cursor = System.Windows.Forms.Cursors.Hand;

        }

        private void buttonDone_PKR_MouseMove(object sender, MouseEventArgs e)
        {
            buttonDone_PKR.Cursor = System.Windows.Forms.Cursors.Hand;

        }

        private void buttonInfo_PKR_MouseMove(object sender, MouseEventArgs e)
        {
            buttonInfo_PKR.Cursor = System.Windows.Forms.Cursors.Hand;

        }
    }
}
