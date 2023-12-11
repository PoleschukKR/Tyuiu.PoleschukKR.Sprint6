
namespace Tyuiu.PoleschukKR.Sprint6.Task7.V15
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelButtons_PKR = new System.Windows.Forms.Panel();
            this.buttonOpenFile_PKR = new System.Windows.Forms.Button();
            this.buttonDone_PKR = new System.Windows.Forms.Button();
            this.buttonInfo_PKR = new System.Windows.Forms.Button();
            this.buttonSave_PKR = new System.Windows.Forms.Button();
            this.panelTask_PKR = new System.Windows.Forms.Panel();
            this.groupBoxTask_PKR = new System.Windows.Forms.GroupBox();
            this.textBoxTask_PKR = new System.Windows.Forms.TextBox();
            this.panelLoadFromFile_PKR = new System.Windows.Forms.Panel();
            this.groupBoxInPutMatrix_PKR = new System.Windows.Forms.GroupBox();
            this.dataGridViewInput_PKR = new System.Windows.Forms.DataGridView();
            this.splitterLoadFileRes_PKR = new System.Windows.Forms.Splitter();
            this.panelOutPutMatrix_PKR = new System.Windows.Forms.Panel();
            this.groupBoxOutPutMatrix_PKR = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutPut_PKR = new System.Windows.Forms.DataGridView();
            this.openFileDialogTask_PKR = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogMatrix_PKR = new System.Windows.Forms.SaveFileDialog();
            this.toolTipButtons_PKR = new System.Windows.Forms.ToolTip(this.components);
            this.panelButtons_PKR.SuspendLayout();
            this.panelTask_PKR.SuspendLayout();
            this.groupBoxTask_PKR.SuspendLayout();
            this.panelLoadFromFile_PKR.SuspendLayout();
            this.groupBoxInPutMatrix_PKR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput_PKR)).BeginInit();
            this.panelOutPutMatrix_PKR.SuspendLayout();
            this.groupBoxOutPutMatrix_PKR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_PKR)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButtons_PKR
            // 
            this.panelButtons_PKR.Controls.Add(this.buttonOpenFile_PKR);
            this.panelButtons_PKR.Controls.Add(this.buttonDone_PKR);
            this.panelButtons_PKR.Controls.Add(this.buttonInfo_PKR);
            this.panelButtons_PKR.Controls.Add(this.buttonSave_PKR);
            this.panelButtons_PKR.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons_PKR.Location = new System.Drawing.Point(0, 0);
            this.panelButtons_PKR.Name = "panelButtons_PKR";
            this.panelButtons_PKR.Padding = new System.Windows.Forms.Padding(5);
            this.panelButtons_PKR.Size = new System.Drawing.Size(955, 82);
            this.panelButtons_PKR.TabIndex = 0;
            // 
            // buttonOpenFile_PKR
            // 
            this.buttonOpenFile_PKR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFile_PKR.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_PKR.Image")));
            this.buttonOpenFile_PKR.Location = new System.Drawing.Point(12, 7);
            this.buttonOpenFile_PKR.Name = "buttonOpenFile_PKR";
            this.buttonOpenFile_PKR.Size = new System.Drawing.Size(105, 69);
            this.buttonOpenFile_PKR.TabIndex = 0;
            this.toolTipButtons_PKR.SetToolTip(this.buttonOpenFile_PKR, "Открыть файл для обработки файла в формате csv");
            this.buttonOpenFile_PKR.UseVisualStyleBackColor = true;
            this.buttonOpenFile_PKR.Click += new System.EventHandler(this.buttonOpenFile_PKR_Click);
            this.buttonOpenFile_PKR.MouseEnter += new System.EventHandler(this.buttonOpenFile_PKR_MouseEnter);
            this.buttonOpenFile_PKR.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonOpenFile_PKR_MouseMove);
            // 
            // buttonDone_PKR
            // 
            this.buttonDone_PKR.Enabled = false;
            this.buttonDone_PKR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_PKR.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_PKR.Image")));
            this.buttonDone_PKR.Location = new System.Drawing.Point(123, 8);
            this.buttonDone_PKR.Name = "buttonDone_PKR";
            this.buttonDone_PKR.Size = new System.Drawing.Size(105, 69);
            this.buttonDone_PKR.TabIndex = 0;
            this.toolTipButtons_PKR.SetToolTip(this.buttonDone_PKR, "Выполнить обработку данных");
            this.buttonDone_PKR.UseVisualStyleBackColor = true;
            this.buttonDone_PKR.Click += new System.EventHandler(this.buttonDone_PKR_Click);
            this.buttonDone_PKR.MouseEnter += new System.EventHandler(this.buttonDone_PKR_MouseEnter);
            this.buttonDone_PKR.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonDone_PKR_MouseMove);
            // 
            // buttonInfo_PKR
            // 
            this.buttonInfo_PKR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_PKR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo_PKR.Image = ((System.Drawing.Image)(resources.GetObject("buttonInfo_PKR.Image")));
            this.buttonInfo_PKR.Location = new System.Drawing.Point(842, 7);
            this.buttonInfo_PKR.Name = "buttonInfo_PKR";
            this.buttonInfo_PKR.Size = new System.Drawing.Size(105, 69);
            this.buttonInfo_PKR.TabIndex = 0;
            this.toolTipButtons_PKR.SetToolTip(this.buttonInfo_PKR, "Сведения о программе");
            this.buttonInfo_PKR.UseVisualStyleBackColor = true;
            this.buttonInfo_PKR.Click += new System.EventHandler(this.buttonInfo_PKR_Click);
            this.buttonInfo_PKR.MouseEnter += new System.EventHandler(this.buttonInfo_PKR_MouseEnter);
            this.buttonInfo_PKR.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonInfo_PKR_MouseMove);
            // 
            // buttonSave_PKR
            // 
            this.buttonSave_PKR.Enabled = false;
            this.buttonSave_PKR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave_PKR.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave_PKR.Image")));
            this.buttonSave_PKR.Location = new System.Drawing.Point(234, 8);
            this.buttonSave_PKR.Name = "buttonSave_PKR";
            this.buttonSave_PKR.Size = new System.Drawing.Size(105, 69);
            this.buttonSave_PKR.TabIndex = 0;
            this.toolTipButtons_PKR.SetToolTip(this.buttonSave_PKR, "Сохранить обработанные данные в файл в формате csv\r\n");
            this.buttonSave_PKR.UseVisualStyleBackColor = true;
            this.buttonSave_PKR.Click += new System.EventHandler(this.buttonSave_PKR_Click);
            this.buttonSave_PKR.MouseEnter += new System.EventHandler(this.buttonSave_PKR_MouseEnter);
            this.buttonSave_PKR.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonSave_PKR_MouseMove);
            // 
            // panelTask_PKR
            // 
            this.panelTask_PKR.Controls.Add(this.groupBoxTask_PKR);
            this.panelTask_PKR.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_PKR.Location = new System.Drawing.Point(0, 82);
            this.panelTask_PKR.Name = "panelTask_PKR";
            this.panelTask_PKR.Padding = new System.Windows.Forms.Padding(5);
            this.panelTask_PKR.Size = new System.Drawing.Size(955, 100);
            this.panelTask_PKR.TabIndex = 1;
            // 
            // groupBoxTask_PKR
            // 
            this.groupBoxTask_PKR.Controls.Add(this.textBoxTask_PKR);
            this.groupBoxTask_PKR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTask_PKR.Location = new System.Drawing.Point(5, 5);
            this.groupBoxTask_PKR.Name = "groupBoxTask_PKR";
            this.groupBoxTask_PKR.Size = new System.Drawing.Size(945, 90);
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
            this.textBoxTask_PKR.Size = new System.Drawing.Size(939, 69);
            this.textBoxTask_PKR.TabIndex = 0;
            this.textBoxTask_PKR.Text = resources.GetString("textBoxTask_PKR.Text");
            // 
            // panelLoadFromFile_PKR
            // 
            this.panelLoadFromFile_PKR.Controls.Add(this.groupBoxInPutMatrix_PKR);
            this.panelLoadFromFile_PKR.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLoadFromFile_PKR.Location = new System.Drawing.Point(0, 182);
            this.panelLoadFromFile_PKR.Name = "panelLoadFromFile_PKR";
            this.panelLoadFromFile_PKR.Padding = new System.Windows.Forms.Padding(5);
            this.panelLoadFromFile_PKR.Size = new System.Drawing.Size(470, 363);
            this.panelLoadFromFile_PKR.TabIndex = 2;
            // 
            // groupBoxInPutMatrix_PKR
            // 
            this.groupBoxInPutMatrix_PKR.Controls.Add(this.dataGridViewInput_PKR);
            this.groupBoxInPutMatrix_PKR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInPutMatrix_PKR.Location = new System.Drawing.Point(5, 5);
            this.groupBoxInPutMatrix_PKR.Name = "groupBoxInPutMatrix_PKR";
            this.groupBoxInPutMatrix_PKR.Size = new System.Drawing.Size(460, 353);
            this.groupBoxInPutMatrix_PKR.TabIndex = 0;
            this.groupBoxInPutMatrix_PKR.TabStop = false;
            this.groupBoxInPutMatrix_PKR.Text = "Ввод:";
            // 
            // dataGridViewInput_PKR
            // 
            this.dataGridViewInput_PKR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInput_PKR.ColumnHeadersVisible = false;
            this.dataGridViewInput_PKR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInput_PKR.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewInput_PKR.Name = "dataGridViewInput_PKR";
            this.dataGridViewInput_PKR.RowHeadersVisible = false;
            this.dataGridViewInput_PKR.RowHeadersWidth = 51;
            this.dataGridViewInput_PKR.RowTemplate.Height = 24;
            this.dataGridViewInput_PKR.Size = new System.Drawing.Size(454, 332);
            this.dataGridViewInput_PKR.TabIndex = 0;
            // 
            // splitterLoadFileRes_PKR
            // 
            this.splitterLoadFileRes_PKR.Location = new System.Drawing.Point(470, 182);
            this.splitterLoadFileRes_PKR.Name = "splitterLoadFileRes_PKR";
            this.splitterLoadFileRes_PKR.Size = new System.Drawing.Size(3, 363);
            this.splitterLoadFileRes_PKR.TabIndex = 3;
            this.splitterLoadFileRes_PKR.TabStop = false;
            // 
            // panelOutPutMatrix_PKR
            // 
            this.panelOutPutMatrix_PKR.Controls.Add(this.groupBoxOutPutMatrix_PKR);
            this.panelOutPutMatrix_PKR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOutPutMatrix_PKR.Location = new System.Drawing.Point(473, 182);
            this.panelOutPutMatrix_PKR.Name = "panelOutPutMatrix_PKR";
            this.panelOutPutMatrix_PKR.Padding = new System.Windows.Forms.Padding(5);
            this.panelOutPutMatrix_PKR.Size = new System.Drawing.Size(482, 363);
            this.panelOutPutMatrix_PKR.TabIndex = 4;
            // 
            // groupBoxOutPutMatrix_PKR
            // 
            this.groupBoxOutPutMatrix_PKR.Controls.Add(this.dataGridViewOutPut_PKR);
            this.groupBoxOutPutMatrix_PKR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPutMatrix_PKR.Location = new System.Drawing.Point(5, 5);
            this.groupBoxOutPutMatrix_PKR.Name = "groupBoxOutPutMatrix_PKR";
            this.groupBoxOutPutMatrix_PKR.Size = new System.Drawing.Size(472, 353);
            this.groupBoxOutPutMatrix_PKR.TabIndex = 0;
            this.groupBoxOutPutMatrix_PKR.TabStop = false;
            this.groupBoxOutPutMatrix_PKR.Text = "Вывод:";
            // 
            // dataGridViewOutPut_PKR
            // 
            this.dataGridViewOutPut_PKR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPut_PKR.ColumnHeadersVisible = false;
            this.dataGridViewOutPut_PKR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOutPut_PKR.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewOutPut_PKR.Name = "dataGridViewOutPut_PKR";
            this.dataGridViewOutPut_PKR.RowHeadersVisible = false;
            this.dataGridViewOutPut_PKR.RowHeadersWidth = 51;
            this.dataGridViewOutPut_PKR.RowTemplate.Height = 24;
            this.dataGridViewOutPut_PKR.Size = new System.Drawing.Size(466, 332);
            this.dataGridViewOutPut_PKR.TabIndex = 0;
            // 
            // openFileDialogTask_PKR
            // 
            this.openFileDialogTask_PKR.FileName = "openFileDialog1";
            // 
            // toolTipButtons_PKR
            // 
            this.toolTipButtons_PKR.ForeColor = System.Drawing.SystemColors.Highlight;
            this.toolTipButtons_PKR.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipButtons_PKR.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 545);
            this.Controls.Add(this.panelOutPutMatrix_PKR);
            this.Controls.Add(this.splitterLoadFileRes_PKR);
            this.Controls.Add(this.panelLoadFromFile_PKR);
            this.Controls.Add(this.panelTask_PKR);
            this.Controls.Add(this.panelButtons_PKR);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 15 | Полещук К.Р.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelButtons_PKR.ResumeLayout(false);
            this.panelTask_PKR.ResumeLayout(false);
            this.groupBoxTask_PKR.ResumeLayout(false);
            this.groupBoxTask_PKR.PerformLayout();
            this.panelLoadFromFile_PKR.ResumeLayout(false);
            this.groupBoxInPutMatrix_PKR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput_PKR)).EndInit();
            this.panelOutPutMatrix_PKR.ResumeLayout(false);
            this.groupBoxOutPutMatrix_PKR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_PKR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons_PKR;
        private System.Windows.Forms.Panel panelTask_PKR;
        private System.Windows.Forms.Panel panelLoadFromFile_PKR;
        private System.Windows.Forms.Splitter splitterLoadFileRes_PKR;
        private System.Windows.Forms.Panel panelOutPutMatrix_PKR;
        private System.Windows.Forms.GroupBox groupBoxTask_PKR;
        private System.Windows.Forms.GroupBox groupBoxInPutMatrix_PKR;
        private System.Windows.Forms.Button buttonOpenFile_PKR;
        private System.Windows.Forms.Button buttonDone_PKR;
        private System.Windows.Forms.Button buttonInfo_PKR;
        private System.Windows.Forms.Button buttonSave_PKR;
        private System.Windows.Forms.TextBox textBoxTask_PKR;
        private System.Windows.Forms.DataGridView dataGridViewInput_PKR;
        private System.Windows.Forms.GroupBox groupBoxOutPutMatrix_PKR;
        private System.Windows.Forms.DataGridView dataGridViewOutPut_PKR;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_PKR;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_PKR;
        private System.Windows.Forms.ToolTip toolTipButtons_PKR;
    }
}

