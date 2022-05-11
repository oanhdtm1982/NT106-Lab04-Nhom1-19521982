namespace Lab04_Nhom1_19521982
{
    partial class Bai4_Lab4_ViewCode
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
            this.rtbSourceCode = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbSourceCode
            // 
            this.rtbSourceCode.Location = new System.Drawing.Point(16, 62);
            this.rtbSourceCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtbSourceCode.Name = "rtbSourceCode";
            this.rtbSourceCode.Size = new System.Drawing.Size(808, 346);
            this.rtbSourceCode.TabIndex = 0;
            this.rtbSourceCode.Text = "";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bài4 - Lab4 - View Source Code";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(746, 412);
            this.Exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(78, 39);
            this.Exit.TabIndex = 9;
            this.Exit.Text = "Thoát";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Bai4_Lab4_ViewCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 462);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbSourceCode);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Bai4_Lab4_ViewCode";
            this.Text = "Lab04_Bai04_ViewCode";
            this.Load += new System.EventHandler(this.Bai4_Lab4_ViewCode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbSourceCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exit;
    }
}