using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04_Nhom1_19521982
{
    public partial class Bai4_Lab4_ViewCode : Form
    {
        public Bai4_Lab4_ViewCode()
        {
            InitializeComponent();
        }
        public string MyProperty { get; set; }
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bai4_Lab4_ViewCode_Load(object sender, EventArgs e)
        {
            rtbSourceCode.Text = this.MyProperty;
        }
    }
}
