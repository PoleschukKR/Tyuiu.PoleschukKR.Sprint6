
namespace Tyuiu.PoleschukKR.Sprint6.Task4.V8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTask_PKR = new System.Windows.Forms.Panel();
            this.panelResult_PKR = new System.Windows.Forms.Panel();
            this.panelGraph_PKR = new System.Windows.Forms.Panel();
            this.splitterResGraph_PKR = new System.Windows.Forms.Splitter();
            this.groupBoxRes_PKR = new System.Windows.Forms.GroupBox();
            this.textBoxResult_PKR = new System.Windows.Forms.TextBox();
            this.groupBoxTask_PKR = new System.Windows.Forms.GroupBox();
            this.groupBoxInPutValue_PKR = new System.Windows.Forms.GroupBox();
            this.labelStartValue_PKR = new System.Windows.Forms.Label();
            this.labelStopValue_PKR = new System.Windows.Forms.Label();
            this.textBoxStrtVal_PKR = new System.Windows.Forms.TextBox();
            this.textBoxStopValue_PKR = new System.Windows.Forms.TextBox();
            this.buttonHelp_PKR = new System.Windows.Forms.Button();
            this.buttonSave_PKR = new System.Windows.Forms.Button();
            this.buttonDone_PKR = new System.Windows.Forms.Button();
            this.textBoxTask_PKR = new System.Windows.Forms.TextBox();
            this.chartFunction_PKR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTask_PKR.SuspendLayout();
            this.panelResult_PKR.SuspendLayout();
            this.panelGraph_PKR.SuspendLayout();
            this.groupBoxRes_PKR.SuspendLayout();
            this.groupBoxTask_PKR.SuspendLayout();
            this.groupBoxInPutValue_PKR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_PKR)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTask_PKR
            // 
            this.panelTask_PKR.BackColor = System.Drawing.Color.White;
            this.panelTask_PKR.Controls.Add(this.buttonHelp_PKR);
            this.panelTask_PKR.Controls.Add(this.buttonDone_PKR);
            this.panelTask_PKR.Controls.Add(this.buttonSave_PKR);
            this.panelTask_PKR.Controls.Add(this.groupBoxInPutValue_PKR);
            this.panelTask_PKR.Controls.Add(this.groupBoxTask_PKR);
            this.panelTask_PKR.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_PKR.Location = new System.Drawing.Point(0, 0);
            this.panelTask_PKR.Name = "panelTask_PKR";
            this.panelTask_PKR.Padding = new System.Windows.Forms.Padding(5);
            this.panelTask_PKR.Size = new System.Drawing.Size(1032, 108);
            this.panelTask_PKR.TabIndex = 0;
            // 
            // panelResult_PKR
            // 
            this.panelResult_PKR.BackColor = System.Drawing.Color.White;
            this.panelResult_PKR.Controls.Add(this.groupBoxRes_PKR);
            this.panelResult_PKR.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelResult_PKR.Location = new System.Drawing.Point(0, 108);
            this.panelResult_PKR.Name = "panelResult_PKR";
            this.panelResult_PKR.Padding = new System.Windows.Forms.Padding(5);
            this.panelResult_PKR.Size = new System.Drawing.Size(200, 295);
            this.panelResult_PKR.TabIndex = 1;
            // 
            // panelGraph_PKR
            // 
            this.panelGraph_PKR.BackColor = System.Drawing.Color.White;
            this.panelGraph_PKR.Controls.Add(this.chartFunction_PKR);
            this.panelGraph_PKR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGraph_PKR.Location = new System.Drawing.Point(200, 108);
            this.panelGraph_PKR.Name = "panelGraph_PKR";
            this.panelGraph_PKR.Size = new System.Drawing.Size(832, 295);
            this.panelGraph_PKR.TabIndex = 2;
            // 
            // splitterResGraph_PKR
            // 
            this.splitterResGraph_PKR.Location = new System.Drawing.Point(200, 108);
            this.splitterResGraph_PKR.Name = "splitterResGraph_PKR";
            this.splitterResGraph_PKR.Size = new System.Drawing.Size(10, 295);
            this.splitterResGraph_PKR.TabIndex = 3;
            this.splitterResGraph_PKR.TabStop = false;
            // 
            // groupBoxRes_PKR
            // 
            this.groupBoxRes_PKR.Controls.Add(this.textBoxResult_PKR);
            this.groupBoxRes_PKR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxRes_PKR.Location = new System.Drawing.Point(5, 5);
            this.groupBoxRes_PKR.Name = "groupBoxRes_PKR";
            this.groupBoxRes_PKR.Size = new System.Drawing.Size(190, 285);
            this.groupBoxRes_PKR.TabIndex = 0;
            this.groupBoxRes_PKR.TabStop = false;
            this.groupBoxRes_PKR.Text = "Вывод данных:";
            // 
            // textBoxResult_PKR
            // 
            this.textBoxResult_PKR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult_PKR.Location = new System.Drawing.Point(3, 18);
            this.textBoxResult_PKR.Multiline = true;
            this.textBoxResult_PKR.Name = "textBoxResult_PKR";
            this.textBoxResult_PKR.ReadOnly = true;
            this.textBoxResult_PKR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_PKR.Size = new System.Drawing.Size(184, 264);
            this.textBoxResult_PKR.TabIndex = 0;
            // 
            // groupBoxTask_PKR
            // 
            this.groupBoxTask_PKR.Controls.Add(this.textBoxTask_PKR);
            this.groupBoxTask_PKR.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_PKR.Name = "groupBoxTask_PKR";
            this.groupBoxTask_PKR.Size = new System.Drawing.Size(433, 106);
            this.groupBoxTask_PKR.TabIndex = 0;
            this.groupBoxTask_PKR.TabStop = false;
            this.groupBoxTask_PKR.Text = "Условие:";
            // 
            // groupBoxInPutValue_PKR
            // 
            this.groupBoxInPutValue_PKR.Controls.Add(this.textBoxStopValue_PKR);
            this.groupBoxInPutValue_PKR.Controls.Add(this.textBoxStrtVal_PKR);
            this.groupBoxInPutValue_PKR.Controls.Add(this.labelStopValue_PKR);
            this.groupBoxInPutValue_PKR.Controls.Add(this.labelStartValue_PKR);
            this.groupBoxInPutValue_PKR.Location = new System.Drawing.Point(439, 0);
            this.groupBoxInPutValue_PKR.Name = "groupBoxInPutValue_PKR";
            this.groupBoxInPutValue_PKR.Size = new System.Drawing.Size(295, 102);
            this.groupBoxInPutValue_PKR.TabIndex = 1;
            this.groupBoxInPutValue_PKR.TabStop = false;
            this.groupBoxInPutValue_PKR.Text = "Ввод данных:";
            // 
            // labelStartValue_PKR
            // 
            this.labelStartValue_PKR.AutoSize = true;
            this.labelStartValue_PKR.Location = new System.Drawing.Point(6, 31);
            this.labelStartValue_PKR.Name = "labelStartValue_PKR";
            this.labelStartValue_PKR.Size = new System.Drawing.Size(87, 17);
            this.labelStartValue_PKR.TabIndex = 0;
            this.labelStartValue_PKR.Text = "Старт шага:";
            // 
            // labelStopValue_PKR
            // 
            this.labelStopValue_PKR.AutoSize = true;
            this.labelStopValue_PKR.Location = new System.Drawing.Point(160, 31);
            this.labelStopValue_PKR.Name = "labelStopValue_PKR";
            this.labelStopValue_PKR.Size = new System.Drawing.Size(89, 17);
            this.labelStopValue_PKR.TabIndex = 0;
            this.labelStopValue_PKR.Text = "Конец шага:";
            // 
            // textBoxStrtVal_PKR
            // 
            this.textBoxStrtVal_PKR.Location = new System.Drawing.Point(9, 51);
            this.textBoxStrtVal_PKR.Multiline = true;
            this.textBoxStrtVal_PKR.Name = "textBoxStrtVal_PKR";
            this.textBoxStrtVal_PKR.Size = new System.Drawing.Size(127, 34);
            this.textBoxStrtVal_PKR.TabIndex = 1;
            // 
            // textBoxStopValue_PKR
            // 
            this.textBoxStopValue_PKR.Location = new System.Drawing.Point(163, 51);
            this.textBoxStopValue_PKR.Multiline = true;
            this.textBoxStopValue_PKR.Name = "textBoxStopValue_PKR";
            this.textBoxStopValue_PKR.Size = new System.Drawing.Size(128, 34);
            this.textBoxStopValue_PKR.TabIndex = 1;
            // 
            // buttonHelp_PKR
            // 
            this.buttonHelp_PKR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_PKR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonHelp_PKR.Location = new System.Drawing.Point(944, 12);
            this.buttonHelp_PKR.Name = "buttonHelp_PKR";
            this.buttonHelp_PKR.Size = new System.Drawing.Size(87, 80);
            this.buttonHelp_PKR.TabIndex = 2;
            this.buttonHelp_PKR.Text = "Справка";
            this.buttonHelp_PKR.UseVisualStyleBackColor = false;
            this.buttonHelp_PKR.Click += new System.EventHandler(this.buttonHelp_PKR_Click);
            this.buttonHelp_PKR.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonHelp_PKR_MouseMove);
            // 
            // buttonSave_PKR
            // 
            this.buttonSave_PKR.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonSave_PKR.Location = new System.Drawing.Point(848, 12);
            this.buttonSave_PKR.Name = "buttonSave_PKR";
            this.buttonSave_PKR.Size = new System.Drawing.Size(90, 80);
            this.buttonSave_PKR.TabIndex = 2;
            this.buttonSave_PKR.Text = "Сохранить";
            this.buttonSave_PKR.UseVisualStyleBackColor = false;
            this.buttonSave_PKR.Click += new System.EventHandler(this.buttonSave_PKR_Click);
            this.buttonSave_PKR.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonSave_PKR_MouseMove);
            // 
            // buttonDone_PKR
            // 
            this.buttonDone_PKR.BackColor = System.Drawing.Color.Green;
            this.buttonDone_PKR.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonDone_PKR.Location = new System.Drawing.Point(740, 12);
            this.buttonDone_PKR.Name = "buttonDone_PKR";
            this.buttonDone_PKR.Size = new System.Drawing.Size(102, 80);
            this.buttonDone_PKR.TabIndex = 2;
            this.buttonDone_PKR.Text = "Выполнить";
            this.buttonDone_PKR.UseVisualStyleBackColor = false;
            this.buttonDone_PKR.Click += new System.EventHandler(this.buttonDone_PKR_Click);
            this.buttonDone_PKR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_PKR_MouseDown);
            this.buttonDone_PKR.MouseEnter += new System.EventHandler(this.buttonDone_PKR_MouseEnter);
            this.buttonDone_PKR.MouseLeave += new System.EventHandler(this.buttonDone_PKR_MouseLeave);
            this.buttonDone_PKR.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonDone_PKR_MouseMove);
            // 
            // textBoxTask_PKR
            // 
            this.textBoxTask_PKR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_PKR.Location = new System.Drawing.Point(3, 18);
            this.textBoxTask_PKR.Multiline = true;
            this.textBoxTask_PKR.Name = "textBoxTask_PKR";
            this.textBoxTask_PKR.ReadOnly = true;
            this.textBoxTask_PKR.Size = new System.Drawing.Size(427, 85);
            this.textBoxTask_PKR.TabIndex = 0;
            this.textBoxTask_PKR.Text = resources.GetString("textBoxTask_PKR.Text");
            // 
            // chartFunction_PKR
            // 
            chartArea10.Name = "ChartArea1";
            this.chartFunction_PKR.ChartAreas.Add(chartArea10);
            this.chartFunction_PKR.Dock = System.Windows.Forms.DockStyle.Fill;
            legend10.Name = "Legend1";
            this.chartFunction_PKR.Legends.Add(legend10);
            this.chartFunction_PKR.Location = new System.Drawing.Point(0, 0);
            this.chartFunction_PKR.Name = "chartFunction_PKR";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series10.IsVisibleInLegend = false;
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            this.chartFunction_PKR.Series.Add(series10);
            this.chartFunction_PKR.Size = new System.Drawing.Size(832, 295);
            this.chartFunction_PKR.TabIndex = 0;
            this.chartFunction_PKR.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 403);
            this.Controls.Add(this.splitterResGraph_PKR);
            this.Controls.Add(this.panelGraph_PKR);
            this.Controls.Add(this.panelResult_PKR);
            this.Controls.Add(this.panelTask_PKR);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 8 | Полещук К. Р.";
            this.panelTask_PKR.ResumeLayout(false);
            this.panelResult_PKR.ResumeLayout(false);
            this.panelGraph_PKR.ResumeLayout(false);
            this.groupBoxRes_PKR.ResumeLayout(false);
            this.groupBoxRes_PKR.PerformLayout();
            this.groupBoxTask_PKR.ResumeLayout(false);
            this.groupBoxTask_PKR.PerformLayout();
            this.groupBoxInPutValue_PKR.ResumeLayout(false);
            this.groupBoxInPutValue_PKR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_PKR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTask_PKR;
        private System.Windows.Forms.Panel panelResult_PKR;
        private System.Windows.Forms.Panel panelGraph_PKR;
        private System.Windows.Forms.Splitter splitterResGraph_PKR;
        private System.Windows.Forms.GroupBox groupBoxInPutValue_PKR;
        private System.Windows.Forms.TextBox textBoxStopValue_PKR;
        private System.Windows.Forms.TextBox textBoxStrtVal_PKR;
        private System.Windows.Forms.Label labelStopValue_PKR;
        private System.Windows.Forms.Label labelStartValue_PKR;
        private System.Windows.Forms.GroupBox groupBoxTask_PKR;
        private System.Windows.Forms.GroupBox groupBoxRes_PKR;
        private System.Windows.Forms.TextBox textBoxResult_PKR;
        private System.Windows.Forms.Button buttonHelp_PKR;
        private System.Windows.Forms.Button buttonDone_PKR;
        private System.Windows.Forms.Button buttonSave_PKR;
        private System.Windows.Forms.TextBox textBoxTask_PKR;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_PKR;
    }
}

