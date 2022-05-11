using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net;
using System.IO;

namespace Lab04_Nhom1_19521982
{
    public partial class Bai1_Lab4 : Form
    {
        public Bai1_Lab4()
        {
            InitializeComponent();
        }

        private void Bai1_Lab4_Load(object sender, EventArgs e)
        {

        }

        private void btGet_Click(object sender, EventArgs e)
        {
            rtbContent.Text = getHTTP(txtURL.Text);

        }
        private string getHTTP(string szURL)
        {
            WebRequest request;
            WebResponse response;
            string contentText = "";
            Stream rpStream;
            Byte[] RecvBytes = new byte[Byte.MaxValue];
            Int32 bytes;
            request = (WebRequest)
                WebRequest.Create(szURL);
            response = (WebResponse)
                request.GetResponse();
            rpStream = response.GetResponseStream();
            while (true)
            {
                bytes = rpStream.Read(RecvBytes, 0, RecvBytes.Length);
                if (bytes <= 0) break;
                contentText += System.Text.Encoding.UTF8.GetString(RecvBytes, 0, bytes);

            }
            return contentText;
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            txtURL.Text = "";
            rtbContent.Text = "";
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
