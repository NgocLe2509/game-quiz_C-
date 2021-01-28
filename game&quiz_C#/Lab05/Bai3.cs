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
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }
        
        public static Image img(int flag)
        {
            Image i = Properties.Resources.banana;
            switch (flag)
            {
                case 1:
                    i = Properties.Resources.banana;
                    break;
                case 2:
                    i = Properties.Resources.kiwi;
                    break;
                case 3:
                    i = Properties.Resources.rambutan;
                    break;
                default: break;
            }
            return i;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int img1, img2, img3;
            Random random = new Random();
            img1 = random.Next(1, 4);
            img2 = random.Next(1, 4);
            img3 = random.Next(1, 4);
            pictureBox1.Image = img(img1);
            pictureBox2.Image = img(img2);
            pictureBox3.Image = img(img3);
            if(img1 == img2 && img2 == img3)
            {
                lbResult.Text = "Chúc mừng! Bạn đã chiến thắng.";
            }
            else
            {
                lbResult.Text = "Chúc bạn may mắn lần sau!";
            }
        }
    }
}
