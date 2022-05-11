
namespace Lab04_Nhom1_19521982
{
    partial class Bai2_Lab4
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
            this.label1 = new System.Windows.Forms.Label();
            this.rtbResponse = new System.Windows.Forms.TextBox();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.btPost = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContents = new System.Windows.Forms.TextBox();
            this.btClose = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(-39, -40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "URL";
            // 
            // rtbResponse
            // 
            this.rtbResponse.Location = new System.Drawing.Point(27, 124);
            this.rtbResponse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbResponse.Multiline = true;
            this.rtbResponse.Name = "rtbResponse";
            this.rtbResponse.Size = new System.Drawing.Size(636, 295);
            this.rtbResponse.TabIndex = 8;
            // 
            // txtURL
            // 
            this.txtURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtURL.Location = new System.Drawing.Point(99, 19);
            this.txtURL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(565, 34);
            this.txtURL.TabIndex = 10;
            // 
            // btPost
            // 
            this.btPost.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btPost.Location = new System.Drawing.Point(683, 19);
            this.btPost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btPost.Name = "btPost";
            this.btPost.Size = new System.Drawing.Size(105, 65);
            this.btPost.TabIndex = 7;
            this.btPost.Text = "POST";
            this.btPost.UseVisualStyleBackColor = true;
            this.btPost.Click += new System.EventHandler(this.btPost_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(22, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 29);
            this.label3.TabIndex = 15;
            this.label3.Text = "URL";
            // 
            // txtContents
            // 
            this.txtContents.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtContents.Location = new System.Drawing.Point(99, 73);
            this.txtContents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContents.Name = "txtContents";
            this.txtContents.Size = new System.Drawing.Size(564, 34);
            this.txtContents.TabIndex = 16;
            // 
            // btClose
            // 
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btClose.Location = new System.Drawing.Point(683, 188);
            this.btClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(105, 65);
            this.btClose.TabIndex = 18;
            this.btClose.Text = "CLOSE";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btDelete
            // 
            this.btDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btDelete.Location = new System.Drawing.Point(683, 107);
            this.btDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(105, 65);
            this.btDelete.TabIndex = 19;
            this.btDelete.Text = "DELETE";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // Bai2_Lab4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.txtContents);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbResponse);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.btPost);
            this.Name = "Bai2_Lab4";
            this.Text = "Bai2_Lab4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rtbResponse;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Button btPost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContents;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btDelete;
    }
}