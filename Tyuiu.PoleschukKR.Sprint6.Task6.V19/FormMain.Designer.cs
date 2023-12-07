
namespace Tyuiu.PoleschukKR.Sprint6.Task6.V19
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
            this.panelTask_PKR = new System.Windows.Forms.Panel();
            this.groupBoxTask_PKR = new System.Windows.Forms.GroupBox();
            this.textBoxTask_PKR = new System.Windows.Forms.TextBox();
            this.panelLoadFromFile_PKR = new System.Windows.Forms.Panel();
            this.groupBoxLoadFromFile_PKR = new System.Windows.Forms.GroupBox();
            this.textBoxLoadFromFile_PKR = new System.Windows.Forms.TextBox();
            this.panelResult_PKR = new System.Windows.Forms.Panel();
            this.groupBoxRes_PKR = new System.Windows.Forms.GroupBox();
            this.textBoxResult_PKR = new System.Windows.Forms.TextBox();
            this.splitterResLoadFile_PKR = new System.Windows.Forms.Splitter();
            this.openFileDialogTask_PKR = new System.Windows.Forms.OpenFileDialog();
            this.toolTipButtons_PKR = new System.Windows.Forms.ToolTip(this.components);
            this.panelButtons_PKR.SuspendLayout();
            this.panelTask_PKR.SuspendLayout();
            this.groupBoxTask_PKR.SuspendLayout();
            this.panelLoadFromFile_PKR.SuspendLayout();
            this.groupBoxLoadFromFile_PKR.SuspendLayout();
            this.panelResult_PKR.SuspendLayout();
            this.groupBoxRes_PKR.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtons_PKR
            // 
            this.panelButtons_PKR.Controls.Add(this.buttonOpenFile_PKR);
            this.panelButtons_PKR.Controls.Add(this.buttonDone_PKR);
            this.panelButtons_PKR.Controls.Add(this.buttonInfo_PKR);
            this.panelButtons_PKR.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons_PKR.Location = new System.Drawing.Point(0, 0);
            this.panelButtons_PKR.Name = "panelButtons_PKR";
            this.panelButtons_PKR.Padding = new System.Windows.Forms.Padding(5);
            this.panelButtons_PKR.Size = new System.Drawing.Size(980, 80);
            this.panelButtons_PKR.TabIndex = 0;
            // 
            // buttonOpenFile_PKR
            // 
            this.buttonOpenFile_PKR.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_PKR.Image")));
            this.buttonOpenFile_PKR.Location = new System.Drawing.Point(8, 5);
            this.buttonOpenFile_PKR.Name = "buttonOpenFile_PKR";
            this.buttonOpenFile_PKR.Size = new System.Drawing.Size(115, 69);
            this.buttonOpenFile_PKR.TabIndex = 0;
            this.toolTipButtons_PKR.SetToolTip(this.buttonOpenFile_PKR, "Открыть файл\r\nВыберите нужный файл для обработки\r\n\r\n");
            this.buttonOpenFile_PKR.UseVisualStyleBackColor = true;
            this.buttonOpenFile_PKR.Click += new System.EventHandler(this.buttonOpenFile_PKR_Click);
            this.buttonOpenFile_PKR.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonOpenFile_PKR_MouseMove);
            // 
            // buttonDone_PKR
            // 
            this.buttonDone_PKR.Enabled = false;
            this.buttonDone_PKR.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_PKR.Image")));
            this.buttonDone_PKR.Location = new System.Drawing.Point(129, 5);
            this.buttonDone_PKR.Name = "buttonDone_PKR";
            this.buttonDone_PKR.Size = new System.Drawing.Size(115, 69);
            this.buttonDone_PKR.TabIndex = 0;
            this.toolTipButtons_PKR.SetToolTip(this.buttonDone_PKR, "Производит поиск слов, в которых встречается символ \"I\",\r\nВыводит их в результиру" +
        "ющую строку\r\n");
            this.buttonDone_PKR.UseVisualStyleBackColor = true;
            this.buttonDone_PKR.Click += new System.EventHandler(this.buttonDone_PKR_Click);
            this.buttonDone_PKR.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonDone_PKR_MouseMove);
            // 
            // buttonInfo_PKR
            // 
            this.buttonInfo_PKR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_PKR.Image = ((System.Drawing.Image)(resources.GetObject("buttonInfo_PKR.Image")));
            this.buttonInfo_PKR.Location = new System.Drawing.Point(892, 5);
            this.buttonInfo_PKR.Name = "buttonInfo_PKR";
            this.buttonInfo_PKR.Size = new System.Drawing.Size(83, 69);
            this.buttonInfo_PKR.TabIndex = 0;
            this.toolTipButtons_PKR.SetToolTip(this.buttonInfo_PKR, "Сведения о программе");
            this.buttonInfo_PKR.UseVisualStyleBackColor = true;
            this.buttonInfo_PKR.Click += new System.EventHandler(this.buttonInfo_PKR_Click);
            this.buttonInfo_PKR.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonInfo_PKR_MouseMove);
            // 
            // panelTask_PKR
            // 
            this.panelTask_PKR.Controls.Add(this.groupBoxTask_PKR);
            this.panelTask_PKR.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_PKR.Location = new System.Drawing.Point(0, 80);
            this.panelTask_PKR.Name = "panelTask_PKR";
            this.panelTask_PKR.Padding = new System.Windows.Forms.Padding(5);
            this.panelTask_PKR.Size = new System.Drawing.Size(980, 100);
            this.panelTask_PKR.TabIndex = 1;
            // 
            // groupBoxTask_PKR
            // 
            this.groupBoxTask_PKR.Controls.Add(this.textBoxTask_PKR);
            this.groupBoxTask_PKR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTask_PKR.Location = new System.Drawing.Point(5, 5);
            this.groupBoxTask_PKR.Name = "groupBoxTask_PKR";
            this.groupBoxTask_PKR.Size = new System.Drawing.Size(970, 90);
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
            this.textBoxTask_PKR.Size = new System.Drawing.Size(964, 69);
            this.textBoxTask_PKR.TabIndex = 0;
            this.textBoxTask_PKR.Text = resources.GetString("textBoxTask_PKR.Text");
            // 
            // panelLoadFromFile_PKR
            // 
            this.panelLoadFromFile_PKR.Controls.Add(this.groupBoxLoadFromFile_PKR);
            this.panelLoadFromFile_PKR.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLoadFromFile_PKR.Location = new System.Drawing.Point(0, 180);
            this.panelLoadFromFile_PKR.Name = "panelLoadFromFile_PKR";
            this.panelLoadFromFile_PKR.Padding = new System.Windows.Forms.Padding(5);
            this.panelLoadFromFile_PKR.Size = new System.Drawing.Size(501, 369);
            this.panelLoadFromFile_PKR.TabIndex = 2;
            // 
            // groupBoxLoadFromFile_PKR
            // 
            this.groupBoxLoadFromFile_PKR.Controls.Add(this.textBoxLoadFromFile_PKR);
            this.groupBoxLoadFromFile_PKR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxLoadFromFile_PKR.Location = new System.Drawing.Point(5, 5);
            this.groupBoxLoadFromFile_PKR.Name = "groupBoxLoadFromFile_PKR";
            this.groupBoxLoadFromFile_PKR.Size = new System.Drawing.Size(491, 359);
            this.groupBoxLoadFromFile_PKR.TabIndex = 0;
            this.groupBoxLoadFromFile_PKR.TabStop = false;
            this.groupBoxLoadFromFile_PKR.Text = "Ввод:";
            // 
            // textBoxLoadFromFile_PKR
            // 
            this.textBoxLoadFromFile_PKR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLoadFromFile_PKR.Location = new System.Drawing.Point(3, 18);
            this.textBoxLoadFromFile_PKR.Multiline = true;
            this.textBoxLoadFromFile_PKR.Name = "textBoxLoadFromFile_PKR";
            this.textBoxLoadFromFile_PKR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLoadFromFile_PKR.Size = new System.Drawing.Size(485, 338);
            this.textBoxLoadFromFile_PKR.TabIndex = 0;
            // 
            // panelResult_PKR
            // 
            this.panelResult_PKR.Controls.Add(this.groupBoxRes_PKR);
            this.panelResult_PKR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelResult_PKR.Location = new System.Drawing.Point(501, 180);
            this.panelResult_PKR.Name = "panelResult_PKR";
            this.panelResult_PKR.Padding = new System.Windows.Forms.Padding(5);
            this.panelResult_PKR.Size = new System.Drawing.Size(479, 369);
            this.panelResult_PKR.TabIndex = 3;
            // 
            // groupBoxRes_PKR
            // 
            this.groupBoxRes_PKR.Controls.Add(this.textBoxResult_PKR);
            this.groupBoxRes_PKR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxRes_PKR.Location = new System.Drawing.Point(5, 5);
            this.groupBoxRes_PKR.Name = "groupBoxRes_PKR";
            this.groupBoxRes_PKR.Size = new System.Drawing.Size(469, 359);
            this.groupBoxRes_PKR.TabIndex = 0;
            this.groupBoxRes_PKR.TabStop = false;
            this.groupBoxRes_PKR.Text = "Вывод:";
            // 
            // textBoxResult_PKR
            // 
            this.textBoxResult_PKR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult_PKR.Location = new System.Drawing.Point(3, 18);
            this.textBoxResult_PKR.Multiline = true;
            this.textBoxResult_PKR.Name = "textBoxResult_PKR";
            this.textBoxResult_PKR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_PKR.Size = new System.Drawing.Size(463, 338);
            this.textBoxResult_PKR.TabIndex = 0;
            // 
            // splitterResLoadFile_PKR
            // 
            this.splitterResLoadFile_PKR.Location = new System.Drawing.Point(501, 180);
            this.splitterResLoadFile_PKR.Name = "splitterResLoadFile_PKR";
            this.splitterResLoadFile_PKR.Size = new System.Drawing.Size(10, 369);
            this.splitterResLoadFile_PKR.TabIndex = 4;
            this.splitterResLoadFile_PKR.TabStop = false;
            // 
            // openFileDialogTask_PKR
            // 
            this.openFileDialogTask_PKR.FileName = "openFileDialog1";
            // 
            // toolTipButtons_PKR
            // 
            this.toolTipButtons_PKR.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipButtons_PKR.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 549);
            this.Controls.Add(this.splitterResLoadFile_PKR);
            this.Controls.Add(this.panelResult_PKR);
            this.Controls.Add(this.panelLoadFromFile_PKR);
            this.Controls.Add(this.panelTask_PKR);
            this.Controls.Add(this.panelButtons_PKR);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 19 | Полещук К.Р.";
            this.panelButtons_PKR.ResumeLayout(false);
            this.panelTask_PKR.ResumeLayout(false);
            this.groupBoxTask_PKR.ResumeLayout(false);
            this.groupBoxTask_PKR.PerformLayout();
            this.panelLoadFromFile_PKR.ResumeLayout(false);
            this.groupBoxLoadFromFile_PKR.ResumeLayout(false);
            this.groupBoxLoadFromFile_PKR.PerformLayout();
            this.panelResult_PKR.ResumeLayout(false);
            this.groupBoxRes_PKR.ResumeLayout(false);
            this.groupBoxRes_PKR.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons_PKR;
        private System.Windows.Forms.Button buttonOpenFile_PKR;
        private System.Windows.Forms.Button buttonDone_PKR;
        private System.Windows.Forms.Button buttonInfo_PKR;
        private System.Windows.Forms.Panel panelTask_PKR;
        private System.Windows.Forms.GroupBox groupBoxTask_PKR;
        private System.Windows.Forms.TextBox textBoxTask_PKR;
        private System.Windows.Forms.Panel panelLoadFromFile_PKR;
        private System.Windows.Forms.GroupBox groupBoxLoadFromFile_PKR;
        private System.Windows.Forms.TextBox textBoxLoadFromFile_PKR;
        private System.Windows.Forms.Panel panelResult_PKR;
        private System.Windows.Forms.GroupBox groupBoxRes_PKR;
        private System.Windows.Forms.TextBox textBoxResult_PKR;
        private System.Windows.Forms.Splitter splitterResLoadFile_PKR;
        private System.Windows.Forms.ToolTip toolTipButtons_PKR;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_PKR;
    }
}

