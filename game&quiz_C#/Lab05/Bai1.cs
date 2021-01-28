using System;
using System.Windows.Forms;

namespace Lab05
{
    public partial class Bai1 : Form
    {
        int count = 60;
        public Bai1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (btStartEnd.Text == "Start The Quiz")
            {
                timer1.Start();
                groupBox.Visible = true;
                btStartEnd.Text = "End The Quiz";
            }
            else
            {
                timer1.Stop();
                if(richtbxResultAdd.Text == "62" && richtbxResultSub.Text == "7" && richtbxResultMul.Text == "30"
                    && richtbxResultDiv.Text == "5")
                {
                    MessageBox.Show("Bạn đã chiến thắng!");
                }
                else
                {
                    MessageBox.Show("Bạn đã trả lời sai!");
                }
                count = 60;
                tbTimeLeft.Text = "60 seconds";
                richtbxResultAdd.Text = "";
                richtbxResultDiv.Text = "";
                richtbxResultMul.Text = "";
                richtbxResultSub.Text = "";
                groupBox.Visible = false;
                btStartEnd.Text = "Start The Quiz";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count--;
            tbTimeLeft.Text = count.ToString() + " seconds";
            if (count == 0)
            {
                timer1.Stop();
                MessageBox.Show("Hết Giờ!");
                count = 60;
                richtbxResultAdd.Text = "";
                richtbxResultDiv.Text = "";
                richtbxResultMul.Text = "";
                richtbxResultSub.Text = "";
                groupBox.Visible = false;
                btStartEnd.Text = "Start The Quiz";
            }
        }
    }
}
