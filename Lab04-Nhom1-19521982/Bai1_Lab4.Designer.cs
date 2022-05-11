
namespace Lab04_Nhom1_19521982
{
    partial class Bai1_Lab4
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
            this.btGet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.btDelete = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btGet
            // 
            this.btGet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGet.Location = new System.Drawing.Point(665, 16);
            this.btGet.Name = "btGet";
            this.btGet.Size = new System.Drawing.Size(93, 35);
            this.btGet.TabIndex = 4;
            this.btGet.Text = "GET";
            this.btGet.UseVisualStyleBackColor = true;
            this.btGet.Click += new System.EventHandler(this.btGet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "URL";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(64, 29);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(577, 22);
            this.txtURL.TabIndex = 5;
            // 
            // rtbContent
            // 
            this.rtbContent.Location = new System.Drawing.Point(16, 66);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.Size = new System.Drawing.Size(625, 339);
            this.rtbContent.TabIndex = 7;
            this.rtbContent.Text = "";
            // 
            // btDelete
            // 
            this.btDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.Location = new System.Drawing.Point(665, 57);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(93, 38);
            this.btDelete.TabIndex = 8;
            this.btDelete.Text = "DELETE";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btClose
            // 
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Location = new System.Drawing.Point(665, 101);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(93, 38);
            this.btClose.TabIndex = 9;
            this.btClose.Text = "CLOSE";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // Bai1_Lab4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.rtbContent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.btGet);
            this.Name = "Bai1_Lab4";
            this.Text = "Bai1_Lab4";
            this.Load += new System.EventHandler(this.Bai1_Lab4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btGet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.RichTextBox rtbContent;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btClose;
    }
}