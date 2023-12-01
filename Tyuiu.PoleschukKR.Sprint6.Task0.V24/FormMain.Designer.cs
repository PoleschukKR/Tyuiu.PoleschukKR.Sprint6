
namespace Tyuiu.PoleschukKR.Sprint6.Task0.V24
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
            this.pictureBoxFormula_PKR = new System.Windows.Forms.PictureBox();
            this.textBoxCondition_PKR = new System.Windows.Forms.TextBox();
            this.groupBoxInPutX_PKR = new System.Windows.Forms.GroupBox();
            this.labelVarX_PKR = new System.Windows.Forms.Label();
            this.textBoxVarX_PKR = new System.Windows.Forms.TextBox();
            this.groupBoxResult_PKR = new System.Windows.Forms.GroupBox();
            this.labelResult_PKR = new System.Windows.Forms.Label();
            this.textBoxResult_PKR = new System.Windows.Forms.TextBox();
            this.buttonResult_PKR = new System.Windows.Forms.Button();
            this.buttonHelp_PKR = new System.Windows.Forms.Button();
            this.groupBoxTask_PKR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_PKR)).BeginInit();
            this.groupBoxInPutX_PKR.SuspendLayout();
            this.groupBoxResult_PKR.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_PKR
            // 
            this.groupBoxTask_PKR.Controls.Add(this.pictureBoxFormula_PKR);
            this.groupBoxTask_PKR.Controls.Add(this.textBoxCondition_PKR);
            this.groupBoxTask_PKR.Location = new System.Drawing.Point(25, 24);
            this.groupBoxTask_PKR.Name = "groupBoxTask_PKR";
            this.groupBoxTask_PKR.Size = new System.Drawing.Size(521, 196);
            this.groupBoxTask_PKR.TabIndex = 0;
            this.groupBoxTask_PKR.TabStop = false;
            this.groupBoxTask_PKR.Text = "Условие";
            // 
            // pictureBoxFormula_PKR
            // 
            this.pictureBoxFormula_PKR.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_PKR.Image")));
            this.pictureBoxFormula_PKR.Location = new System.Drawing.Point(11, 63);
            this.pictureBoxFormula_PKR.Name = "pictureBoxFormula_PKR";
            this.pictureBoxFormula_PKR.Size = new System.Drawing.Size(391, 114);
            this.pictureBoxFormula_PKR.TabIndex = 1;
            this.pictureBoxFormula_PKR.TabStop = false;
            // 
            // textBoxCondition_PKR
            // 
            this.textBoxCondition_PKR.Enabled = false;
            this.textBoxCondition_PKR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCondition_PKR.Location = new System.Drawing.Point(11, 21);
            this.textBoxCondition_PKR.Name = "textBoxCondition_PKR";
            this.textBoxCondition_PKR.ReadOnly = true;
            this.textBoxCondition_PKR.Size = new System.Drawing.Size(391, 36);
            this.textBoxCondition_PKR.TabIndex = 0;
            this.textBoxCondition_PKR.Text = "Найдите значение выражения ";
            // 
            // groupBoxInPutX_PKR
            // 
            this.groupBoxInPutX_PKR.Controls.Add(this.labelVarX_PKR);
            this.groupBoxInPutX_PKR.Controls.Add(this.textBoxVarX_PKR);
            this.groupBoxInPutX_PKR.Location = new System.Drawing.Point(25, 226);
            this.groupBoxInPutX_PKR.Name = "groupBoxInPutX_PKR";
            this.groupBoxInPutX_PKR.Size = new System.Drawing.Size(332, 145);
            this.groupBoxInPutX_PKR.TabIndex = 1;
            this.groupBoxInPutX_PKR.TabStop = false;
            this.groupBoxInPutX_PKR.Text = "Ввод данных";
            // 
            // labelVarX_PKR
            // 
            this.labelVarX_PKR.AutoSize = true;
            this.labelVarX_PKR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVarX_PKR.Location = new System.Drawing.Point(6, 24);
            this.labelVarX_PKR.Name = "labelVarX_PKR";
            this.labelVarX_PKR.Size = new System.Drawing.Size(311, 29);
            this.labelVarX_PKR.TabIndex = 1;
            this.labelVarX_PKR.Text = "Значение переменной X:";
            // 
            // textBoxVarX_PKR
            // 
            this.textBoxVarX_PKR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxVarX_PKR.Location = new System.Drawing.Point(6, 69);
            this.textBoxVarX_PKR.Name = "textBoxVarX_PKR";
            this.textBoxVarX_PKR.Size = new System.Drawing.Size(311, 36);
            this.textBoxVarX_PKR.TabIndex = 0;
            this.textBoxVarX_PKR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_PKR_KeyPress);
            // 
            // groupBoxResult_PKR
            // 
            this.groupBoxResult_PKR.Controls.Add(this.labelResult_PKR);
            this.groupBoxResult_PKR.Controls.Add(this.textBoxResult_PKR);
            this.groupBoxResult_PKR.Location = new System.Drawing.Point(363, 226);
            this.groupBoxResult_PKR.Name = "groupBoxResult_PKR";
            this.groupBoxResult_PKR.Size = new System.Drawing.Size(183, 145);
            this.groupBoxResult_PKR.TabIndex = 2;
            this.groupBoxResult_PKR.TabStop = false;
            this.groupBoxResult_PKR.Text = "Вывод данных:";
            // 
            // labelResult_PKR
            // 
            this.labelResult_PKR.AutoSize = true;
            this.labelResult_PKR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult_PKR.Location = new System.Drawing.Point(6, 24);
            this.labelResult_PKR.Name = "labelResult_PKR";
            this.labelResult_PKR.Size = new System.Drawing.Size(138, 29);
            this.labelResult_PKR.TabIndex = 1;
            this.labelResult_PKR.Text = "Результат:";
            // 
            // textBoxResult_PKR
            // 
            this.textBoxResult_PKR.Enabled = false;
            this.textBoxResult_PKR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_PKR.Location = new System.Drawing.Point(6, 69);
            this.textBoxResult_PKR.Name = "textBoxResult_PKR";
            this.textBoxResult_PKR.ReadOnly = true;
            this.textBoxResult_PKR.Size = new System.Drawing.Size(166, 36);
            this.textBoxResult_PKR.TabIndex = 0;
            // 
            // buttonResult_PKR
            // 
            this.buttonResult_PKR.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonResult_PKR.Location = new System.Drawing.Point(363, 392);
            this.buttonResult_PKR.Name = "buttonResult_PKR";
            this.buttonResult_PKR.Size = new System.Drawing.Size(183, 43);
            this.buttonResult_PKR.TabIndex = 3;
            this.buttonResult_PKR.Text = "Выполнить";
            this.buttonResult_PKR.UseVisualStyleBackColor = true;
            this.buttonResult_PKR.Click += new System.EventHandler(this.buttonResult_PKR_Click);
            // 
            // buttonHelp_PKR
            // 
            this.buttonHelp_PKR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_PKR.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_PKR.Location = new System.Drawing.Point(293, 392);
            this.buttonHelp_PKR.Name = "buttonHelp_PKR";
            this.buttonHelp_PKR.Size = new System.Drawing.Size(64, 43);
            this.buttonHelp_PKR.TabIndex = 3;
            this.buttonHelp_PKR.Text = "?";
            this.buttonHelp_PKR.UseVisualStyleBackColor = true;
            this.buttonHelp_PKR.Click += new System.EventHandler(this.buttonHelp_PKR_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 456);
            this.Controls.Add(this.buttonHelp_PKR);
            this.Controls.Add(this.buttonResult_PKR);
            this.Controls.Add(this.groupBoxResult_PKR);
            this.Controls.Add(this.groupBoxInPutX_PKR);
            this.Controls.Add(this.groupBoxTask_PKR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 24 | Полещук К.Р.";
            this.groupBoxTask_PKR.ResumeLayout(false);
            this.groupBoxTask_PKR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_PKR)).EndInit();
            this.groupBoxInPutX_PKR.ResumeLayout(false);
            this.groupBoxInPutX_PKR.PerformLayout();
            this.groupBoxResult_PKR.ResumeLayout(false);
            this.groupBoxResult_PKR.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_PKR;
        private System.Windows.Forms.PictureBox pictureBoxFormula_PKR;
        private System.Windows.Forms.GroupBox groupBoxInPutX_PKR;
        private System.Windows.Forms.TextBox textBoxVarX_PKR;
        private System.Windows.Forms.Label labelVarX_PKR;
        private System.Windows.Forms.GroupBox groupBoxResult_PKR;
        private System.Windows.Forms.Label labelResult_PKR;
        private System.Windows.Forms.TextBox textBoxResult_PKR;
        private System.Windows.Forms.Button buttonResult_PKR;
        private System.Windows.Forms.Button buttonHelp_PKR;
        private System.Windows.Forms.TextBox textBoxCondition_PKR;
    }
}

