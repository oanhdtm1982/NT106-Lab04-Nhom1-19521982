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
using System.Web;
using System.IO;

namespace Lab04_Nhom1_19521982
{
    public partial class Bai2_Lab4 : Form
    {
        public Bai2_Lab4()
        {
            InitializeComponent();
        }

        private string post(string szURL)
        {
            WebRequest request = WebRequest.Create(szURL);
            request.Method = "POST";

            string postData = txtContents.Text;
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteArray.Length;
            Stream dataStream;
            dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();
            WebResponse response = request.GetResponse();
            dataStream = response.GetResponseStream();
            string responseFromServer = "";
            Byte[] Recv = new byte[Byte.MaxValue];
            Int32 bytes;
            while (true)
            {
                bytes = dataStream.Read(Recv, 0, Recv.Length);
                if (bytes <= 0)
                    break;
                responseFromServer += System.Text.Encoding.UTF8.GetString(Recv, 0, bytes);
            }

            response.Close();
            return responseFromServer;
        }

        private void btPost_Click(object sender, EventArgs e)
        {
            rtbResponse.Text = post(txtURL.Text);
        }

       

        private void btDelete_Click(object sender, EventArgs e)
        {
            txtURL.Text = "";
            txtContents.Text = "";
            rtbResponse.Text = "";

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
