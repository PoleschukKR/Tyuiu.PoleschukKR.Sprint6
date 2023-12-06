
namespace Tyuiu.PoleschukKR.Sprint6.Task3.V22
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
            this.groupBoxTask_PKR = new System.Windows.Forms.GroupBox();
            this.dataGridViewMatrixTask_PKR = new System.Windows.Forms.DataGridView();
            this.textBoxTask_PKR = new System.Windows.Forms.TextBox();
            this.groupBoxResult_PKR = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_PKR = new System.Windows.Forms.DataGridView();
            this.buttonDone_PKR = new System.Windows.Forms.Button();
            this.buttonHelp_PKR = new System.Windows.Forms.Button();
            this.groupBoxTask_PKR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrixTask_PKR)).BeginInit();
            this.groupBoxResult_PKR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_PKR)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_PKR
            // 
            this.groupBoxTask_PKR.Controls.Add(this.dataGridViewMatrixTask_PKR);
            this.groupBoxTask_PKR.Controls.Add(this.textBoxTask_PKR);
            this.groupBoxTask_PKR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTask_PKR.Location = new System.Drawing.Point(12, 6);
            this.groupBoxTask_PKR.Name = "groupBoxTask_PKR";
            this.groupBoxTask_PKR.Size = new System.Drawing.Size(749, 281);
            this.groupBoxTask_PKR.TabIndex = 0;
            this.groupBoxTask_PKR.TabStop = false;
            this.groupBoxTask_PKR.Text = "Условие";
            // 
            // dataGridViewMatrixTask_PKR
            // 
            this.dataGridViewMatrixTask_PKR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrixTask_PKR.Location = new System.Drawing.Point(513, 25);
            this.dataGridViewMatrixTask_PKR.Name = "dataGridViewMatrixTask_PKR";
            this.dataGridViewMatrixTask_PKR.ReadOnly = true;
            this.dataGridViewMatrixTask_PKR.RowHeadersVisible = false;
            this.dataGridViewMatrixTask_PKR.RowHeadersWidth = 51;
            this.dataGridViewMatrixTask_PKR.RowTemplate.Height = 24;
            this.dataGridViewMatrixTask_PKR.Size = new System.Drawing.Size(223, 250);
            this.dataGridViewMatrixTask_PKR.TabIndex = 1;
            // 
            // textBoxTask_PKR
            // 
            this.textBoxTask_PKR.Enabled = false;
            this.textBoxTask_PKR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTask_PKR.Location = new System.Drawing.Point(6, 25);
            this.textBoxTask_PKR.Multiline = true;
            this.textBoxTask_PKR.Name = "textBoxTask_PKR";
            this.textBoxTask_PKR.ReadOnly = true;
            this.textBoxTask_PKR.Size = new System.Drawing.Size(499, 250);
            this.textBoxTask_PKR.TabIndex = 0;
            this.textBoxTask_PKR.Text = resources.GetString("textBoxTask_PKR.Text");
            // 
            // groupBoxResult_PKR
            // 
            this.groupBoxResult_PKR.Controls.Add(this.dataGridViewResult_PKR);
            this.groupBoxResult_PKR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxResult_PKR.Location = new System.Drawing.Point(763, 6);
            this.groupBoxResult_PKR.Name = "groupBoxResult_PKR";
            this.groupBoxResult_PKR.Size = new System.Drawing.Size(209, 240);
            this.groupBoxResult_PKR.TabIndex = 1;
            this.groupBoxResult_PKR.TabStop = false;
            this.groupBoxResult_PKR.Text = "Вывод данных:";
            // 
            // dataGridViewResult_PKR
            // 
            this.dataGridViewResult_PKR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_PKR.Location = new System.Drawing.Point(6, 25);
            this.dataGridViewResult_PKR.Name = "dataGridViewResult_PKR";
            this.dataGridViewResult_PKR.RowHeadersVisible = false;
            this.dataGridViewResult_PKR.RowHeadersWidth = 51;
            this.dataGridViewResult_PKR.RowTemplate.Height = 24;
            this.dataGridViewResult_PKR.Size = new System.Drawing.Size(203, 211);
            this.dataGridViewResult_PKR.TabIndex = 0;
            // 
            // buttonDone_PKR
            // 
            this.buttonDone_PKR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_PKR.Location = new System.Drawing.Point(835, 243);
            this.buttonDone_PKR.Name = "buttonDone_PKR";
            this.buttonDone_PKR.Size = new System.Drawing.Size(131, 44);
            this.buttonDone_PKR.TabIndex = 2;
            this.buttonDone_PKR.Text = "Выполнить";
            this.buttonDone_PKR.UseVisualStyleBackColor = true;
            this.buttonDone_PKR.Click += new System.EventHandler(this.buttonDone_PKR_Click);
            // 
            // buttonHelp_PKR
            // 
            this.buttonHelp_PKR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_PKR.Location = new System.Drawing.Point(769, 243);
            this.buttonHelp_PKR.Name = "buttonHelp_PKR";
            this.buttonHelp_PKR.Size = new System.Drawing.Size(72, 44);
            this.buttonHelp_PKR.TabIndex = 2;
            this.buttonHelp_PKR.Text = "?";
            this.buttonHelp_PKR.UseVisualStyleBackColor = true;
            this.buttonHelp_PKR.Click += new System.EventHandler(this.buttonHelp_PKR_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 589);
            this.Controls.Add(this.buttonHelp_PKR);
            this.Controls.Add(this.buttonDone_PKR);
            this.Controls.Add(this.groupBoxResult_PKR);
            this.Controls.Add(this.groupBoxTask_PKR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6  | Таск 3 | Вариант 22 | Полещук К.Р.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_PKR.ResumeLayout(false);
            this.groupBoxTask_PKR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrixTask_PKR)).EndInit();
            this.groupBoxResult_PKR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_PKR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_PKR;
        private System.Windows.Forms.DataGridView dataGridViewMatrixTask_PKR;
        private System.Windows.Forms.TextBox textBoxTask_PKR;
        private System.Windows.Forms.GroupBox groupBoxResult_PKR;
        private System.Windows.Forms.DataGridView dataGridViewResult_PKR;
        private System.Windows.Forms.Button buttonDone_PKR;
        private System.Windows.Forms.Button buttonHelp_PKR;
    }
}

