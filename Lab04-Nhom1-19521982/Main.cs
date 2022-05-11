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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

       

        private void btBai4_Click(object sender, EventArgs e)
        {
            Bai4_Lab04 Bai4 = new Bai4_Lab04();
            Bai4.Show();
        }

        private void btBai1_Click(object sender, EventArgs e)
        {
            Bai1_Lab4 Bai1 = new Bai1_Lab4();
            Bai1.Show();

        }

        private void btBai3_Click(object sender, EventArgs e)
        {
            Bai3_Lab4 Bai3 = new Bai3_Lab4();
            Bai3.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btBai2_Click(object sender, EventArgs e)
        {
            Bai2_Lab4 Bai2 = new Bai2_Lab4();
            Bai2.Show();
        }
    }
}
