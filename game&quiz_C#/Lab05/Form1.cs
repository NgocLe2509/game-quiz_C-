using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBai1_Click(object sender, EventArgs e)
        {
            Bai1 bai1 = new Bai1();
            bai1.Show();
        }

        private void btnBai1MR_Click(object sender, EventArgs e)
        {
            Bai1MoRong bai1MR = new Bai1MoRong();
            bai1MR.Show();
        }

        private void btBai2_Click(object sender, EventArgs e)
        {
            Bai2 bai2 = new Bai2();
            bai2.Show();
        }

        private void btBai2MR_Click(object sender, EventArgs e)
        {
            Bai2MoRong bai2MR = new Bai2MoRong();
            bai2MR.Show();
        }

        private void btBai3_Click(object sender, EventArgs e)
        {
            Bai3 bai3 = new Bai3();
            bai3.Show();
        }
    }
}
