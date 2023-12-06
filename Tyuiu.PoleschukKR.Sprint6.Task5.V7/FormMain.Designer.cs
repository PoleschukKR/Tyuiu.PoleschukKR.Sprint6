
namespace Tyuiu.PoleschukKR.Sprint6.Task5.V7
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTask_PKR = new System.Windows.Forms.Panel();
            this.panelRes_PKR = new System.Windows.Forms.Panel();
            this.panelDiag_PKR = new System.Windows.Forms.Panel();
            this.splitterResDiag_PKR = new System.Windows.Forms.Splitter();
            this.groupBoxTask_PKR = new System.Windows.Forms.GroupBox();
            this.textBoxTask_PKR = new System.Windows.Forms.TextBox();
            this.groupBoxRes_PKR = new System.Windows.Forms.GroupBox();
            this.dataGridViewRes_PKR = new System.Windows.Forms.DataGridView();
            this.chartDiag_PKR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonDone_PKR = new System.Windows.Forms.Button();
            this.buttonOpenFile_PKR = new System.Windows.Forms.Button();
            this.buttonHelp_PKR = new System.Windows.Forms.Button();
            this.panelTask_PKR.SuspendLayout();
            this.panelRes_PKR.SuspendLayout();
            this.panelDiag_PKR.SuspendLayout();
            this.groupBoxTask_PKR.SuspendLayout();
            this.groupBoxRes_PKR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_PKR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_PKR)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTask_PKR
            // 
            this.panelTask_PKR.Controls.Add(this.buttonHelp_PKR);
            this.panelTask_PKR.Controls.Add(this.buttonOpenFile_PKR);
            this.panelTask_PKR.Controls.Add(this.buttonDone_PKR);
            this.panelTask_PKR.Controls.Add(this.groupBoxTask_PKR);
            this.panelTask_PKR.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_PKR.Location = new System.Drawing.Point(0, 0);
            this.panelTask_PKR.Name = "panelTask_PKR";
            this.panelTask_PKR.Padding = new System.Windows.Forms.Padding(5);
            this.panelTask_PKR.Size = new System.Drawing.Size(739, 88);
            this.panelTask_PKR.TabIndex = 0;
            // 
            // panelRes_PKR
            // 
            this.panelRes_PKR.Controls.Add(this.groupBoxRes_PKR);
            this.panelRes_PKR.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelRes_PKR.Location = new System.Drawing.Point(0, 88);
            this.panelRes_PKR.Name = "panelRes_PKR";
            this.panelRes_PKR.Padding = new System.Windows.Forms.Padding(5);
            this.panelRes_PKR.Size = new System.Drawing.Size(171, 377);
            this.panelRes_PKR.TabIndex = 1;
            // 
            // panelDiag_PKR
            // 
            this.panelDiag_PKR.Controls.Add(this.chartDiag_PKR);
            this.panelDiag_PKR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDiag_PKR.Location = new System.Drawing.Point(174, 88);
            this.panelDiag_PKR.Name = "panelDiag_PKR";
            this.panelDiag_PKR.Padding = new System.Windows.Forms.Padding(5);
            this.panelDiag_PKR.Size = new System.Drawing.Size(565, 377);
            this.panelDiag_PKR.TabIndex = 3;
            // 
            // splitterResDiag_PKR
            // 
            this.splitterResDiag_PKR.Location = new System.Drawing.Point(171, 88);
            this.splitterResDiag_PKR.Name = "splitterResDiag_PKR";
            this.splitterResDiag_PKR.Size = new System.Drawing.Size(3, 377);
            this.splitterResDiag_PKR.TabIndex = 2;
            this.splitterResDiag_PKR.TabStop = false;
            // 
            // groupBoxTask_PKR
            // 
            this.groupBoxTask_PKR.Controls.Add(this.textBoxTask_PKR);
            this.groupBoxTask_PKR.Location = new System.Drawing.Point(0, 2);
            this.groupBoxTask_PKR.Name = "groupBoxTask_PKR";
            this.groupBoxTask_PKR.Size = new System.Drawing.Size(409, 76);
            this.groupBoxTask_PKR.TabIndex = 0;
            this.groupBoxTask_PKR.TabStop = false;
            this.groupBoxTask_PKR.Text = "Условие:";
            // 
            // textBoxTask_PKR
            // 
            this.textBoxTask_PKR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_PKR.Location = new System.Drawing.Point(3, 18);
            this.textBoxTask_PKR.Multiline = true;
            this.textBoxTask_PKR.Name = "textBoxTask_PKR";
            this.textBoxTask_PKR.ReadOnly = true;
            this.textBoxTask_PKR.Size = new System.Drawing.Size(403, 55);
            this.textBoxTask_PKR.TabIndex = 0;
            this.textBoxTask_PKR.Text = "Прочитать данные из файла InPutFileTask5V7.txt. Вывести все числа, больше 5  в da" +
    "taGridView.\r\nПостроить диаграмму по этим значениям.";
            // 
            // groupBoxRes_PKR
            // 
            this.groupBoxRes_PKR.Controls.Add(this.dataGridViewRes_PKR);
            this.groupBoxRes_PKR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxRes_PKR.Location = new System.Drawing.Point(5, 5);
            this.groupBoxRes_PKR.Name = "groupBoxRes_PKR";
            this.groupBoxRes_PKR.Size = new System.Drawing.Size(161, 367);
            this.groupBoxRes_PKR.TabIndex = 0;
            this.groupBoxRes_PKR.TabStop = false;
            this.groupBoxRes_PKR.Text = "Вывод данных:";
            // 
            // dataGridViewRes_PKR
            // 
            this.dataGridViewRes_PKR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRes_PKR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRes_PKR.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewRes_PKR.Name = "dataGridViewRes_PKR";
            this.dataGridViewRes_PKR.ReadOnly = true;
            this.dataGridViewRes_PKR.RowHeadersVisible = false;
            this.dataGridViewRes_PKR.RowHeadersWidth = 51;
            this.dataGridViewRes_PKR.RowTemplate.Height = 24;
            this.dataGridViewRes_PKR.Size = new System.Drawing.Size(155, 346);
            this.dataGridViewRes_PKR.TabIndex = 0;
            // 
            // chartDiag_PKR
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDiag_PKR.ChartAreas.Add(chartArea1);
            this.chartDiag_PKR.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartDiag_PKR.Legends.Add(legend1);
            this.chartDiag_PKR.Location = new System.Drawing.Point(5, 5);
            this.chartDiag_PKR.Name = "chartDiag_PKR";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartDiag_PKR.Series.Add(series1);
            this.chartDiag_PKR.Size = new System.Drawing.Size(555, 367);
            this.chartDiag_PKR.TabIndex = 0;
            this.chartDiag_PKR.Text = "chart1";
            // 
            // buttonDone_PKR
            // 
            this.buttonDone_PKR.BackColor = System.Drawing.Color.Green;
            this.buttonDone_PKR.Location = new System.Drawing.Point(415, 8);
            this.buttonDone_PKR.Name = "buttonDone_PKR";
            this.buttonDone_PKR.Size = new System.Drawing.Size(102, 66);
            this.buttonDone_PKR.TabIndex = 1;
            this.buttonDone_PKR.Text = "Выполнить";
            this.buttonDone_PKR.UseVisualStyleBackColor = false;
            this.buttonDone_PKR.Click += new System.EventHandler(this.buttonDone_PKR_Click);
            this.buttonDone_PKR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_PKR_MouseDown);
            this.buttonDone_PKR.MouseEnter += new System.EventHandler(this.buttonDone_PKR_MouseEnter);
            this.buttonDone_PKR.MouseLeave += new System.EventHandler(this.buttonDone_PKR_MouseLeave);
            this.buttonDone_PKR.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonDone_PKR_MouseMove);
            // 
            // buttonOpenFile_PKR
            // 
            this.buttonOpenFile_PKR.BackColor = System.Drawing.Color.Teal;
            this.buttonOpenFile_PKR.Location = new System.Drawing.Point(523, 9);
            this.buttonOpenFile_PKR.Name = "buttonOpenFile_PKR";
            this.buttonOpenFile_PKR.Size = new System.Drawing.Size(102, 66);
            this.buttonOpenFile_PKR.TabIndex = 1;
            this.buttonOpenFile_PKR.Text = "Открыть файл";
            this.buttonOpenFile_PKR.UseVisualStyleBackColor = false;
            this.buttonOpenFile_PKR.Click += new System.EventHandler(this.buttonOpenFile_PKR_Click);
            this.buttonOpenFile_PKR.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonOpenFile_PKR_MouseMove);
            // 
            // buttonHelp_PKR
            // 
            this.buttonHelp_PKR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_PKR.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_PKR.Location = new System.Drawing.Point(631, 8);
            this.buttonHelp_PKR.Name = "buttonHelp_PKR";
            this.buttonHelp_PKR.Size = new System.Drawing.Size(102, 66);
            this.buttonHelp_PKR.TabIndex = 1;
            this.buttonHelp_PKR.Text = "Справка";
            this.buttonHelp_PKR.UseVisualStyleBackColor = false;
            this.buttonHelp_PKR.Click += new System.EventHandler(this.buttonHelp_Click);
            this.buttonHelp_PKR.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonHelp_MouseMove);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 465);
            this.Controls.Add(this.panelDiag_PKR);
            this.Controls.Add(this.splitterResDiag_PKR);
            this.Controls.Add(this.panelRes_PKR);
            this.Controls.Add(this.panelTask_PKR);
            this.MinimumSize = new System.Drawing.Size(750, 450);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6  | Таск 5 | Вариант 7  | Полещук К.Р.";
            this.panelTask_PKR.ResumeLayout(false);
            this.panelRes_PKR.ResumeLayout(false);
            this.panelDiag_PKR.ResumeLayout(false);
            this.groupBoxTask_PKR.ResumeLayout(false);
            this.groupBoxTask_PKR.PerformLayout();
            this.groupBoxRes_PKR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_PKR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_PKR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTask_PKR;
        private System.Windows.Forms.Panel panelRes_PKR;
        private System.Windows.Forms.Panel panelDiag_PKR;
        private System.Windows.Forms.Splitter splitterResDiag_PKR;
        private System.Windows.Forms.Button buttonHelp_PKR;
        private System.Windows.Forms.Button buttonOpenFile_PKR;
        private System.Windows.Forms.Button buttonDone_PKR;
        private System.Windows.Forms.GroupBox groupBoxTask_PKR;
        private System.Windows.Forms.TextBox textBoxTask_PKR;
        private System.Windows.Forms.GroupBox groupBoxRes_PKR;
        private System.Windows.Forms.DataGridView dataGridViewRes_PKR;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_PKR;
    }
}

