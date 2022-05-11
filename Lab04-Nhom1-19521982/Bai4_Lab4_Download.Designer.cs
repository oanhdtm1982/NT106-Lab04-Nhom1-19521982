namespace Lab04_Nhom1_19521982
{
    partial class Bai4_Lab4_Download
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
            this.tbPath = new System.Windows.Forms.TextBox();
            this.rtbSourceCode = new System.Windows.Forms.RichTextBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(73, 76);
            this.tbPath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPath.Multiline = true;
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(630, 41);
            this.tbPath.TabIndex = 29;
            // 
            // rtbSourceCode
            // 
            this.rtbSourceCode.Location = new System.Drawing.Point(23, 128);
            this.rtbSourceCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtbSourceCode.Name = "rtbSourceCode";
            this.rtbSourceCode.Size = new System.Drawing.Size(790, 281);
            this.rtbSourceCode.TabIndex = 28;
            this.rtbSourceCode.Text = "";
            // 
            // btnDownload
            // 
            this.btnDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.Location = new System.Drawing.Point(706, 76);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(106, 41);
            this.btnDownload.TabIndex = 27;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(737, 413);
            this.Exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 38);
            this.Exit.TabIndex = 26;
            this.Exit.Text = "Thoát";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Bai4 - Lab4 - Download";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 24);
            this.label2.TabIndex = 30;
            this.label2.Text = "Path";
            // 
            // Bai4_Lab4_Download
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.rtbSourceCode);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Bai4_Lab4_Download";
            this.Text = "Lab04_Bai04_Download";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.RichTextBox rtbSourceCode;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}