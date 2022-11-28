namespace QuizDesktop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblContent = new System.Windows.Forms.Label();
            this.lblA1 = new System.Windows.Forms.Label();
            this.lblA2 = new System.Windows.Forms.Label();
            this.lblA4 = new System.Windows.Forms.Label();
            this.lblA3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCategory
            // 
            this.lblCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCategory.Location = new System.Drawing.Point(12, 9);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(1108, 38);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblContent
            // 
            this.lblContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblContent.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblContent.Location = new System.Drawing.Point(12, 58);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(1108, 129);
            this.lblContent.TabIndex = 1;
            this.lblContent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblA1
            // 
            this.lblA1.BackColor = System.Drawing.Color.Linen;
            this.lblA1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblA1.Location = new System.Drawing.Point(12, 198);
            this.lblA1.Name = "lblA1";
            this.lblA1.Size = new System.Drawing.Size(545, 68);
            this.lblA1.TabIndex = 2;
            this.lblA1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblA2
            // 
            this.lblA2.BackColor = System.Drawing.Color.Linen;
            this.lblA2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblA2.Location = new System.Drawing.Point(575, 198);
            this.lblA2.Name = "lblA2";
            this.lblA2.Size = new System.Drawing.Size(545, 68);
            this.lblA2.TabIndex = 3;
            this.lblA2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblA4
            // 
            this.lblA4.BackColor = System.Drawing.Color.Linen;
            this.lblA4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblA4.Location = new System.Drawing.Point(575, 277);
            this.lblA4.Name = "lblA4";
            this.lblA4.Size = new System.Drawing.Size(545, 68);
            this.lblA4.TabIndex = 5;
            this.lblA4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblA3
            // 
            this.lblA3.BackColor = System.Drawing.Color.Linen;
            this.lblA3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblA3.Location = new System.Drawing.Point(12, 277);
            this.lblA3.Name = "lblA3";
            this.lblA3.Size = new System.Drawing.Size(545, 68);
            this.lblA3.TabIndex = 4;
            this.lblA3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 360);
            this.Controls.Add(this.lblA4);
            this.Controls.Add(this.lblA3);
            this.Controls.Add(this.lblA2);
            this.Controls.Add(this.lblA1);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.lblCategory);
            this.Name = "Form1";
            this.Text = "Quiz";
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblCategory;
        private Label lblContent;
        private Label lblA1;
        private Label lblA2;
        private Label lblA4;
        private Label lblA3;
    }
}