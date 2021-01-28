using System;
using System.Windows.Forms;
using System.Threading;

namespace Lab05
{
    public partial class Bai1MoRong : Form
    {
        Thread time;
        int countTime = 60, flag = 0;
        public Bai1MoRong()
        {
            InitializeComponent();
            time = new Thread(new ThreadStart(CountDownTimer));
            time.Start();
        }
        public void CountDownTimer()
        {
            var timer = new System.Threading.Timer(ojb => {
                if(flag == 1)
                {
                    countTime--;
                    if (countTime >= 0)
                    {
                        tbTimeLeft.Text = countTime.ToString() + " seconds";
                        if(countTime == 0)
                        {
                            MessageBox.Show("Hết giờ!");
                            flag = 0;
                            btStartEnd.Text = "Start The Quiz";
                            groupBox.Visible = false;
                            tbTimeLeft.Text = "60 seconds";
                        }
                    }
                }
            }, null, 0, 1000);
        }
        private void btStartEnd_Click(object sender, EventArgs e)
        {
            countTime = 60;
            CheckForIllegalCrossThreadCalls = false;
            if (btStartEnd.Text == "Start The Quiz")
            {
                tbTimeLeft.Text = "60 seconds";
                flag = 1;
                groupBox.Visible = true;
                Random r = new Random();
                lbNum1.Text = r.Next(0, 99).ToString();
                lbNum2.Text = r.Next(0, 99).ToString();
                lbNum3.Text = r.Next(0, 99).ToString();
                lbNum4.Text = r.Next(0, 99).ToString();
                lbNum5.Text = r.Next(0, 99).ToString();
                lbNum6.Text = r.Next(0, 99).ToString();
                lbNum7.Text = r.Next(0, 99).ToString();
                lbNum8.Text = r.Next(0, 99).ToString();
                btStartEnd.Text = "End The Quiz";
            }
            else
            {
                flag = 0;
                string add = (int.Parse(lbNum1.Text) + int.Parse(lbNum2.Text)).ToString();
                string sub = (int.Parse(lbNum3.Text) - int.Parse(lbNum4.Text)).ToString();
                string mul = (int.Parse(lbNum5.Text) * int.Parse(lbNum6.Text)).ToString();
                string div = (int.Parse(lbNum7.Text) / int.Parse(lbNum8.Text)).ToString();
                if (richtbxResultAdd.Text == add && richtbxResultSub.Text == sub && richtbxResultMul.Text == mul
                    && richtbxResultDiv.Text == div)
                {
                    MessageBox.Show("Bạn đã chiến thắng!");
                }
                else
                {
                    MessageBox.Show("Bạn đã trả lời sai!");
                }
                tbTimeLeft.Text = "60 seconds";
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
