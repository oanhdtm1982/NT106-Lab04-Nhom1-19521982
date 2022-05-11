
namespace Lab04_Nhom1_19521982
{
    partial class Bai3_Lab4
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
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.btDownload = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btOpen = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbContent
            // 
            this.rtbContent.Location = new System.Drawing.Point(64, 104);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.Size = new System.Drawing.Size(577, 301);
            this.rtbContent.TabIndex = 8;
            this.rtbContent.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "URL:";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(64, 20);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(577, 22);
            this.txtURL.TabIndex = 10;
            // 
            // btDownload
            // 
            this.btDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDownload.Location = new System.Drawing.Point(647, 13);
            this.btDownload.Name = "btDownload";
            this.btDownload.Size = new System.Drawing.Size(140, 35);
            this.btDownload.TabIndex = 11;
            this.btDownload.Text = "DOWNLOAD";
            this.btDownload.UseVisualStyleBackColor = true;
            this.btDownload.Click += new System.EventHandler(this.btDownload_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(64, 62);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(577, 22);
            this.txtPath.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Path:";
            // 
            // btOpen
            // 
            this.btOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOpen.Location = new System.Drawing.Point(647, 62);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(140, 35);
            this.btOpen.TabIndex = 15;
            this.btOpen.Text = "OPEN";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // btDelete
            // 
            this.btDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.Location = new System.Drawing.Point(647, 114);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(140, 35);
            this.btDelete.TabIndex = 16;
            this.btDelete.Text = "DELETE";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btClose
            // 
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Location = new System.Drawing.Point(647, 166);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(140, 35);
            this.btClose.TabIndex = 17;
            this.btClose.Text = "CLOSE";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // Bai3_Lab4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btDownload);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbContent);
            this.Name = "Bai3_Lab4";
            this.Text = "Bai3_Lab4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Button btDownload;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btClose;
    }
}