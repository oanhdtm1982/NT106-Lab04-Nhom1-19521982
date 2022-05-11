using System;
using System.Windows.Forms;
using System.Net;

namespace Lab04_Nhom1_19521982
{
    public partial class Bai4_Lab4_Download : Form
    {
        public Bai4_Lab4_Download()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string MyProperty { get; set; }
        private void btnDownload_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            client.DownloadFile(this.MyProperty, tbPath.Text);
            rtbSourceCode.Text = client.DownloadString(this.MyProperty);
        }
    }
}
