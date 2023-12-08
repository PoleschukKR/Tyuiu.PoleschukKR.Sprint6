
namespace Tyuiu.PoleschukKR.Sprint6.Task7.V15
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxAvatar_PKR = new System.Windows.Forms.PictureBox();
            this.labelInfo_PKR = new System.Windows.Forms.Label();
            this.buttonOK_PKR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_PKR)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatar_PKR
            // 
            this.pictureBoxAvatar_PKR.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_PKR.Image")));
            this.pictureBoxAvatar_PKR.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxAvatar_PKR.Name = "pictureBoxAvatar_PKR";
            this.pictureBoxAvatar_PKR.Size = new System.Drawing.Size(147, 168);
            this.pictureBoxAvatar_PKR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvatar_PKR.TabIndex = 0;
            this.pictureBoxAvatar_PKR.TabStop = false;
            // 
            // labelInfo_PKR
            // 
            this.labelInfo_PKR.AutoSize = true;
            this.labelInfo_PKR.Location = new System.Drawing.Point(165, 12);
            this.labelInfo_PKR.Name = "labelInfo_PKR";
            this.labelInfo_PKR.Size = new System.Drawing.Size(368, 136);
            this.labelInfo_PKR.TabIndex = 1;
            this.labelInfo_PKR.Text = resources.GetString("labelInfo_PKR.Text");
            // 
            // buttonOK_PKR
            // 
            this.buttonOK_PKR.Location = new System.Drawing.Point(453, 151);
            this.buttonOK_PKR.Name = "buttonOK_PKR";
            this.buttonOK_PKR.Size = new System.Drawing.Size(80, 29);
            this.buttonOK_PKR.TabIndex = 2;
            this.buttonOK_PKR.Text = "OK";
            this.buttonOK_PKR.UseVisualStyleBackColor = true;
            this.buttonOK_PKR.Click += new System.EventHandler(this.buttonOK_PKR_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 188);
            this.Controls.Add(this.buttonOK_PKR);
            this.Controls.Add(this.labelInfo_PKR);
            this.Controls.Add(this.pictureBoxAvatar_PKR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_PKR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar_PKR;
        private System.Windows.Forms.Label labelInfo_PKR;
        private System.Windows.Forms.Button buttonOK_PKR;
    }
}