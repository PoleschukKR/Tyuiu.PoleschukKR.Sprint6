
namespace Tyuiu.PoleschukKR.Sprint6.Task2.V27
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_PKR = new System.Windows.Forms.GroupBox();
            this.textBoxTask_PKR = new System.Windows.Forms.TextBox();
            this.groupBoxInPutStrtStopValue_PKR = new System.Windows.Forms.GroupBox();
            this.labelStrtValue_PKR = new System.Windows.Forms.Label();
            this.labelStopValue_PKR = new System.Windows.Forms.Label();
            this.textBoxStrtValue_PKR = new System.Windows.Forms.TextBox();
            this.textBoxStopValue_PKR = new System.Windows.Forms.TextBox();
            this.buttonHelp_PKR = new System.Windows.Forms.Button();
            this.buttonDone_PKR = new System.Windows.Forms.Button();
            this.groupBoxResult_PKR = new System.Windows.Forms.GroupBox();
            this.dataGridViewFuction_PKR = new System.Windows.Forms.DataGridView();
            this.chartFuction_PKR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxTask_PKR.SuspendLayout();
            this.groupBoxInPutStrtStopValue_PKR.SuspendLayout();
            this.groupBoxResult_PKR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuction_PKR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFuction_PKR)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_PKR
            // 
            this.groupBoxTask_PKR.Controls.Add(this.textBoxTask_PKR);
            this.groupBoxTask_PKR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTask_PKR.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_PKR.Name = "groupBoxTask_PKR";
            this.groupBoxTask_PKR.Size = new System.Drawing.Size(572, 187);
            this.groupBoxTask_PKR.TabIndex = 0;
            this.groupBoxTask_PKR.TabStop = false;
            this.groupBoxTask_PKR.Text = "Условие";
            // 
            // textBoxTask_PKR
            // 
            this.textBoxTask_PKR.Enabled = false;
            this.textBoxTask_PKR.Location = new System.Drawing.Point(6, 25);
            this.textBoxTask_PKR.Multiline = true;
            this.textBoxTask_PKR.Name = "textBoxTask_PKR";
            this.textBoxTask_PKR.Size = new System.Drawing.Size(560, 129);
            this.textBoxTask_PKR.TabIndex = 0;
            this.textBoxTask_PKR.Text = "Протабулировать функцию \r\nF (x) = (2x - 3) / (cos(x) - 2x) +5x - sin(x) на заданн" +
    "ом диапазоне.\r\nРезультат вывести в DataGridView и построить график функции. ";
            // 
            // groupBoxInPutStrtStopValue_PKR
            // 
            this.groupBoxInPutStrtStopValue_PKR.Controls.Add(this.textBoxStopValue_PKR);
            this.groupBoxInPutStrtStopValue_PKR.Controls.Add(this.textBoxStrtValue_PKR);
            this.groupBoxInPutStrtStopValue_PKR.Controls.Add(this.labelStopValue_PKR);
            this.groupBoxInPutStrtStopValue_PKR.Controls.Add(this.labelStrtValue_PKR);
            this.groupBoxInPutStrtStopValue_PKR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInPutStrtStopValue_PKR.Location = new System.Drawing.Point(18, 205);
            this.groupBoxInPutStrtStopValue_PKR.Name = "groupBoxInPutStrtStopValue_PKR";
            this.groupBoxInPutStrtStopValue_PKR.Size = new System.Drawing.Size(318, 88);
            this.groupBoxInPutStrtStopValue_PKR.TabIndex = 1;
            this.groupBoxInPutStrtStopValue_PKR.TabStop = false;
            this.groupBoxInPutStrtStopValue_PKR.Text = "Ввод данных:";
            // 
            // labelStrtValue_PKR
            // 
            this.labelStrtValue_PKR.AutoSize = true;
            this.labelStrtValue_PKR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStrtValue_PKR.Location = new System.Drawing.Point(6, 22);
            this.labelStrtValue_PKR.Name = "labelStrtValue_PKR";
            this.labelStrtValue_PKR.Size = new System.Drawing.Size(87, 17);
            this.labelStrtValue_PKR.TabIndex = 0;
            this.labelStrtValue_PKR.Text = "Старт шага:";
            // 
            // labelStopValue_PKR
            // 
            this.labelStopValue_PKR.AutoSize = true;
            this.labelStopValue_PKR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStopValue_PKR.Location = new System.Drawing.Point(164, 22);
            this.labelStopValue_PKR.Name = "labelStopValue_PKR";
            this.labelStopValue_PKR.Size = new System.Drawing.Size(89, 17);
            this.labelStopValue_PKR.TabIndex = 0;
            this.labelStopValue_PKR.Text = "Конец шага:";
            // 
            // textBoxStrtValue_PKR
            // 
            this.textBoxStrtValue_PKR.Location = new System.Drawing.Point(6, 45);
            this.textBoxStrtValue_PKR.Name = "textBoxStrtValue_PKR";
            this.textBoxStrtValue_PKR.Size = new System.Drawing.Size(139, 26);
            this.textBoxStrtValue_PKR.TabIndex = 1;
            // 
            // textBoxStopValue_PKR
            // 
            this.textBoxStopValue_PKR.Location = new System.Drawing.Point(167, 42);
            this.textBoxStopValue_PKR.Name = "textBoxStopValue_PKR";
            this.textBoxStopValue_PKR.Size = new System.Drawing.Size(142, 26);
            this.textBoxStopValue_PKR.TabIndex = 1;
            // 
            // buttonHelp_PKR
            // 
            this.buttonHelp_PKR.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonHelp_PKR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_PKR.Location = new System.Drawing.Point(343, 218);
            this.buttonHelp_PKR.Name = "buttonHelp_PKR";
            this.buttonHelp_PKR.Size = new System.Drawing.Size(106, 75);
            this.buttonHelp_PKR.TabIndex = 2;
            this.buttonHelp_PKR.Text = "Справка";
            this.buttonHelp_PKR.UseVisualStyleBackColor = false;
            this.buttonHelp_PKR.Click += new System.EventHandler(this.buttonHelp_PKR_Click);
            // 
            // buttonDone_PKR
            // 
            this.buttonDone_PKR.BackColor = System.Drawing.Color.Green;
            this.buttonDone_PKR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_PKR.Location = new System.Drawing.Point(455, 218);
            this.buttonDone_PKR.Name = "buttonDone_PKR";
            this.buttonDone_PKR.Size = new System.Drawing.Size(129, 75);
            this.buttonDone_PKR.TabIndex = 2;
            this.buttonDone_PKR.Text = "Выполнить";
            this.buttonDone_PKR.UseVisualStyleBackColor = false;
            this.buttonDone_PKR.Click += new System.EventHandler(this.buttonDone_PKR_Click);
            this.buttonDone_PKR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_PKR_MouseDown);
            this.buttonDone_PKR.MouseEnter += new System.EventHandler(this.buttonDone_PKR_MouseEnter);
            this.buttonDone_PKR.MouseLeave += new System.EventHandler(this.buttonDone_PKR_MouseLeave);
            // 
            // groupBoxResult_PKR
            // 
            this.groupBoxResult_PKR.Controls.Add(this.chartFuction_PKR);
            this.groupBoxResult_PKR.Controls.Add(this.dataGridViewFuction_PKR);
            this.groupBoxResult_PKR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxResult_PKR.Location = new System.Drawing.Point(590, 12);
            this.groupBoxResult_PKR.Name = "groupBoxResult_PKR";
            this.groupBoxResult_PKR.Size = new System.Drawing.Size(646, 281);
            this.groupBoxResult_PKR.TabIndex = 3;
            this.groupBoxResult_PKR.TabStop = false;
            this.groupBoxResult_PKR.Text = "Вывод данных:";
            // 
            // dataGridViewFuction_PKR
            // 
            this.dataGridViewFuction_PKR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFuction_PKR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewFuction_PKR.Location = new System.Drawing.Point(6, 25);
            this.dataGridViewFuction_PKR.Name = "dataGridViewFuction_PKR";
            this.dataGridViewFuction_PKR.RowHeadersVisible = false;
            this.dataGridViewFuction_PKR.RowHeadersWidth = 51;
            this.dataGridViewFuction_PKR.RowTemplate.Height = 24;
            this.dataGridViewFuction_PKR.Size = new System.Drawing.Size(157, 250);
            this.dataGridViewFuction_PKR.TabIndex = 0;
            // 
            // chartFuction_PKR
            // 
            chartArea5.Name = "ChartArea1";
            this.chartFuction_PKR.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartFuction_PKR.Legends.Add(legend5);
            this.chartFuction_PKR.Location = new System.Drawing.Point(169, 23);
            this.chartFuction_PKR.Name = "chartFuction_PKR";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.IsVisibleInLegend = false;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartFuction_PKR.Series.Add(series5);
            this.chartFuction_PKR.Size = new System.Drawing.Size(471, 252);
            this.chartFuction_PKR.TabIndex = 1;
            this.chartFuction_PKR.Text = "chart1";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "X";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "F(X)";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 50;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 313);
            this.Controls.Add(this.groupBoxResult_PKR);
            this.Controls.Add(this.buttonDone_PKR);
            this.Controls.Add(this.buttonHelp_PKR);
            this.Controls.Add(this.groupBoxInPutStrtStopValue_PKR);
            this.Controls.Add(this.groupBoxTask_PKR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 27 | Полещук К.Р.";
            this.groupBoxTask_PKR.ResumeLayout(false);
            this.groupBoxTask_PKR.PerformLayout();
            this.groupBoxInPutStrtStopValue_PKR.ResumeLayout(false);
            this.groupBoxInPutStrtStopValue_PKR.PerformLayout();
            this.groupBoxResult_PKR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuction_PKR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFuction_PKR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_PKR;
        private System.Windows.Forms.TextBox textBoxTask_PKR;
        private System.Windows.Forms.GroupBox groupBoxInPutStrtStopValue_PKR;
        private System.Windows.Forms.Label labelStopValue_PKR;
        private System.Windows.Forms.Label labelStrtValue_PKR;
        private System.Windows.Forms.TextBox textBoxStopValue_PKR;
        private System.Windows.Forms.TextBox textBoxStrtValue_PKR;
        private System.Windows.Forms.Button buttonHelp_PKR;
        private System.Windows.Forms.Button buttonDone_PKR;
        private System.Windows.Forms.GroupBox groupBoxResult_PKR;
        private System.Windows.Forms.DataGridView dataGridViewFuction_PKR;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFuction_PKR;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

