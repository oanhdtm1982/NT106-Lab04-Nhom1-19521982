using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace Lab04_Nhom1_19521982
{
    public partial class Bai3_Lab4 : Form
    {
        public Bai3_Lab4()
        {
            InitializeComponent();
        }
        private void btOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "HTML|*.html";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                txtPath.Text = openFileDialog.FileName;


            }

        }

        private void btDownload_Click(object sender, EventArgs e)
        {
            if (txtPath.Text == ""||txtURL.Text==" ")
                MessageBox.Show("Ô Path hoặc URL đang để trống!", "THÔNG BÁO", MessageBoxButtons.OK);
            
            WebClient client = new WebClient();
            client.DownloadFile(txtURL.Text,txtPath.Text);
            rtbContent.Text = client.DownloadString(txtURL.Text);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            rtbContent.Text = " ";
            txtPath.Text = " ";
            txtURL.Text = " ";
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc muốn thoát!", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (MessageBox.Show("Bạn có chắc muốn thoát!", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
