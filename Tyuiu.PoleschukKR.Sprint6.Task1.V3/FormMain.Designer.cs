
namespace Tyuiu.PoleschukKR.Sprint6.Task1.V3
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
            this.groupBoxTask_PKR = new System.Windows.Forms.GroupBox();
            this.textBoxTask_PKR = new System.Windows.Forms.TextBox();
            this.groupBoxResult_PKR = new System.Windows.Forms.GroupBox();
            this.labelResult_PKR = new System.Windows.Forms.Label();
            this.textBoxResult_PKR = new System.Windows.Forms.TextBox();
            this.groupBoxInPutOut_PKR = new System.Windows.Forms.GroupBox();
            this.textBoxStopValue_PKR = new System.Windows.Forms.TextBox();
            this.textBoxStartValue_PKR = new System.Windows.Forms.TextBox();
            this.labelStopValue_PKR = new System.Windows.Forms.Label();
            this.labelStartValue_PKR = new System.Windows.Forms.Label();
            this.buttonDone_PKR = new System.Windows.Forms.Button();
            this.buttonReference_PKR = new System.Windows.Forms.Button();
            this.groupBoxTask_PKR.SuspendLayout();
            this.groupBoxResult_PKR.SuspendLayout();
            this.groupBoxInPutOut_PKR.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_PKR
            // 
            this.groupBoxTask_PKR.Controls.Add(this.textBoxTask_PKR);
            this.groupBoxTask_PKR.Location = new System.Drawing.Point(21, 12);
            this.groupBoxTask_PKR.Name = "groupBoxTask_PKR";
            this.groupBoxTask_PKR.Size = new System.Drawing.Size(565, 325);
            this.groupBoxTask_PKR.TabIndex = 0;
            this.groupBoxTask_PKR.TabStop = false;
            this.groupBoxTask_PKR.Text = "Условие";
            // 
            // textBoxTask_PKR
            // 
            this.textBoxTask_PKR.Enabled = false;
            this.textBoxTask_PKR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTask_PKR.Location = new System.Drawing.Point(6, 27);
            this.textBoxTask_PKR.Multiline = true;
            this.textBoxTask_PKR.Name = "textBoxTask_PKR";
            this.textBoxTask_PKR.Size = new System.Drawing.Size(553, 134);
            this.textBoxTask_PKR.TabIndex = 0;
            this.textBoxTask_PKR.Text = "Протабулировать функцию\r\n F(x) = 5 - 3x + (1 + sin(x)) / (2x - 0,5) на заданном д" +
    "иапазоне.\r\nРезультат вывести в виде таблицы.";
            // 
            // groupBoxResult_PKR
            // 
            this.groupBoxResult_PKR.Controls.Add(this.labelResult_PKR);
            this.groupBoxResult_PKR.Controls.Add(this.textBoxResult_PKR);
            this.groupBoxResult_PKR.Location = new System.Drawing.Point(606, 12);
            this.groupBoxResult_PKR.Name = "groupBoxResult_PKR";
            this.groupBoxResult_PKR.Size = new System.Drawing.Size(283, 402);
            this.groupBoxResult_PKR.TabIndex = 1;
            this.groupBoxResult_PKR.TabStop = false;
            this.groupBoxResult_PKR.Text = "Вывод данных";
            // 
            // labelResult_PKR
            // 
            this.labelResult_PKR.AutoSize = true;
            this.labelResult_PKR.Location = new System.Drawing.Point(6, 27);
            this.labelResult_PKR.Name = "labelResult_PKR";
            this.labelResult_PKR.Size = new System.Drawing.Size(80, 17);
            this.labelResult_PKR.TabIndex = 1;
            this.labelResult_PKR.Text = "Результат:";
            // 
            // textBoxResult_PKR
            // 
            this.textBoxResult_PKR.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxResult_PKR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_PKR.Location = new System.Drawing.Point(6, 58);
            this.textBoxResult_PKR.Multiline = true;
            this.textBoxResult_PKR.Name = "textBoxResult_PKR";
            this.textBoxResult_PKR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_PKR.Size = new System.Drawing.Size(271, 336);
            this.textBoxResult_PKR.TabIndex = 0;
            // 
            // groupBoxInPutOut_PKR
            // 
            this.groupBoxInPutOut_PKR.Controls.Add(this.textBoxStopValue_PKR);
            this.groupBoxInPutOut_PKR.Controls.Add(this.textBoxStartValue_PKR);
            this.groupBoxInPutOut_PKR.Controls.Add(this.labelStopValue_PKR);
            this.groupBoxInPutOut_PKR.Controls.Add(this.labelStartValue_PKR);
            this.groupBoxInPutOut_PKR.Location = new System.Drawing.Point(21, 343);
            this.groupBoxInPutOut_PKR.Name = "groupBoxInPutOut_PKR";
            this.groupBoxInPutOut_PKR.Size = new System.Drawing.Size(304, 71);
            this.groupBoxInPutOut_PKR.TabIndex = 2;
            this.groupBoxInPutOut_PKR.TabStop = false;
            this.groupBoxInPutOut_PKR.Text = "Ввод данных";
            // 
            // textBoxStopValue_PKR
            // 
            this.textBoxStopValue_PKR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxStopValue_PKR.Location = new System.Drawing.Point(140, 38);
            this.textBoxStopValue_PKR.Name = "textBoxStopValue_PKR";
            this.textBoxStopValue_PKR.Size = new System.Drawing.Size(100, 30);
            this.textBoxStopValue_PKR.TabIndex = 2;
            this.textBoxStopValue_PKR.Text = "5";
            // 
            // textBoxStartValue_PKR
            // 
            this.textBoxStartValue_PKR.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxStartValue_PKR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxStartValue_PKR.Location = new System.Drawing.Point(9, 38);
            this.textBoxStartValue_PKR.Name = "textBoxStartValue_PKR";
            this.textBoxStartValue_PKR.Size = new System.Drawing.Size(100, 30);
            this.textBoxStartValue_PKR.TabIndex = 2;
            this.textBoxStartValue_PKR.Text = "-5";
            // 
            // labelStopValue_PKR
            // 
            this.labelStopValue_PKR.AutoSize = true;
            this.labelStopValue_PKR.Location = new System.Drawing.Point(137, 18);
            this.labelStopValue_PKR.Name = "labelStopValue_PKR";
            this.labelStopValue_PKR.Size = new System.Drawing.Size(89, 17);
            this.labelStopValue_PKR.TabIndex = 1;
            this.labelStopValue_PKR.Text = "Конец шага:";
            // 
            // labelStartValue_PKR
            // 
            this.labelStartValue_PKR.AutoSize = true;
            this.labelStartValue_PKR.Location = new System.Drawing.Point(6, 18);
            this.labelStartValue_PKR.Name = "labelStartValue_PKR";
            this.labelStartValue_PKR.Size = new System.Drawing.Size(87, 17);
            this.labelStartValue_PKR.TabIndex = 1;
            this.labelStartValue_PKR.Text = "Старт шага:";
            // 
            // buttonDone_PKR
            // 
            this.buttonDone_PKR.BackColor = System.Drawing.Color.Green;
            this.buttonDone_PKR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_PKR.Location = new System.Drawing.Point(458, 343);
            this.buttonDone_PKR.Name = "buttonDone_PKR";
            this.buttonDone_PKR.Size = new System.Drawing.Size(128, 71);
            this.buttonDone_PKR.TabIndex = 3;
            this.buttonDone_PKR.Text = "Выполнить";
            this.buttonDone_PKR.UseVisualStyleBackColor = false;
            this.buttonDone_PKR.Click += new System.EventHandler(this.buttonDone_PKR_Click);
            // 
            // buttonReference_PKR
            // 
            this.buttonReference_PKR.BackColor = System.Drawing.Color.Teal;
            this.buttonReference_PKR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReference_PKR.Location = new System.Drawing.Point(337, 343);
            this.buttonReference_PKR.Name = "buttonReference_PKR";
            this.buttonReference_PKR.Size = new System.Drawing.Size(115, 71);
            this.buttonReference_PKR.TabIndex = 3;
            this.buttonReference_PKR.Text = "Справка";
            this.buttonReference_PKR.UseVisualStyleBackColor = false;
            this.buttonReference_PKR.Click += new System.EventHandler(this.buttonReference_PKR_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 418);
            this.Controls.Add(this.buttonReference_PKR);
            this.Controls.Add(this.buttonDone_PKR);
            this.Controls.Add(this.groupBoxInPutOut_PKR);
            this.Controls.Add(this.groupBoxResult_PKR);
            this.Controls.Add(this.groupBoxTask_PKR);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 3 | Полещук К.Р.";
            this.groupBoxTask_PKR.ResumeLayout(false);
            this.groupBoxTask_PKR.PerformLayout();
            this.groupBoxResult_PKR.ResumeLayout(false);
            this.groupBoxResult_PKR.PerformLayout();
            this.groupBoxInPutOut_PKR.ResumeLayout(false);
            this.groupBoxInPutOut_PKR.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_PKR;
        private System.Windows.Forms.GroupBox groupBoxResult_PKR;
        private System.Windows.Forms.Label labelResult_PKR;
        private System.Windows.Forms.TextBox textBoxResult_PKR;
        private System.Windows.Forms.GroupBox groupBoxInPutOut_PKR;
        private System.Windows.Forms.TextBox textBoxStopValue_PKR;
        private System.Windows.Forms.TextBox textBoxStartValue_PKR;
        private System.Windows.Forms.Label labelStopValue_PKR;
        private System.Windows.Forms.Label labelStartValue_PKR;
        private System.Windows.Forms.Button buttonDone_PKR;
        private System.Windows.Forms.Button buttonReference_PKR;
        private System.Windows.Forms.TextBox textBoxTask_PKR;
    }
}

