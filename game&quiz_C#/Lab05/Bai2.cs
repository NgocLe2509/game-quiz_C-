using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab05
{
    public partial class Bai2 : Form
    {
        int[] arr = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 1, 2, 3, 4, 5, 6, 7, 8 };
        int num1 = 0, num2 = 0, count = 0;
        public Bai2()
        {
            InitializeComponent();
        }
        //
        //
        //
        public static int[] delArr(int[] arr, int index)
        {
            int[] newr = new int[arr.Length-1];
            for (int i = 0; i < index; i++)
            {
                newr[i] = arr[i];
            }
            for(int i=index; i<arr.Length-1; i++)
            {
                newr[i] = arr[i + 1];
            }
            return newr;
        }
        public static int[] newArr(int[] arr)
        {
            
            Random r = new Random();
            int[] newrandom = new int[16];
            for (int i = 0; i < 16; i++)
            {
                
                int index = r.Next(0, arr.Length - 1);
                newrandom[i] = arr[index];
                arr = delArr(arr, index);
            }
            return newrandom;
        }
        //
        //
        //
        private void btStart_Click(object sender, EventArgs e)
        {
            if(btStart.Text == "Start") 
            {
                groupBox.Enabled = true;
                btStart.Enabled = false;
            }
            else
            {
                pictureBox1.Visible = true;
                pictureBox1.Image = Properties.Resources.red;
                pictureBox2.Visible = true;
                pictureBox2.Image = Properties.Resources.red;
                pictureBox3.Visible = true;
                pictureBox3.Image = Properties.Resources.red;
                pictureBox4.Visible = true;
                pictureBox4.Image = Properties.Resources.red;
                pictureBox5.Visible = true;
                pictureBox5.Image = Properties.Resources.red;
                pictureBox6.Visible = true;
                pictureBox6.Image = Properties.Resources.red;
                pictureBox7.Visible = true;
                pictureBox7.Image = Properties.Resources.red;
                pictureBox8.Visible = true;
                pictureBox8.Image = Properties.Resources.red;
                pictureBox9.Visible = true;
                pictureBox9.Image = Properties.Resources.red;
                pictureBox10.Visible = true;
                pictureBox10.Image = Properties.Resources.red;
                pictureBox11.Visible = true;
                pictureBox11.Image = Properties.Resources.red;
                pictureBox12.Visible = true;
                pictureBox12.Image = Properties.Resources.red;
                pictureBox13.Visible = true;
                pictureBox13.Image = Properties.Resources.red;
                pictureBox14.Visible = true;
                pictureBox14.Image = Properties.Resources.red;
                pictureBox15.Visible = true;
                pictureBox15.Image = Properties.Resources.red;
                pictureBox16.Visible = true;
                pictureBox16.Image = Properties.Resources.red;
            }
            arr = newArr(arr);
        }
        // 
        //
        //
        public static Image chooseImg(int flag)
        {
            Image img = Properties.Resources.red;
            switch (flag)
            {
                case 1:
                    img = Properties.Resources.banana;
                    break;
                case 2:
                    img = Properties.Resources.cherry;
                    break;
                case 3:
                    img = Properties.Resources.grapes;
                    break;
                case 4:
                    img = Properties.Resources.kiwi;
                    break;
                case 5:
                    img = Properties.Resources.lychee;
                    break;
                case 6:
                    img = Properties.Resources.mango;
                    break;
                case 7:
                    img = Properties.Resources.rambutan;
                    break;
                case 8:
                    img = Properties.Resources.strawberry;
                    break;
                default: break;
            }
            return img;
        }
        //
        //
        //
        public PictureBox check(int flag)
        {
            PictureBox ptb = new PictureBox();
            switch (flag)
            {
                case 1: ptb = pictureBox1;
                    break;
                case 2:
                    ptb = pictureBox2;
                    break;
                case 3:
                    ptb = pictureBox3;
                    break;
                case 4:
                    ptb = pictureBox4;
                    break;
                case 5:
                    ptb = pictureBox5;
                    break;
                case 6:
                    ptb = pictureBox6;
                    break;
                case 7:
                    ptb = pictureBox7;
                    break;
                case 8:
                    ptb = pictureBox8;
                    break;
                case 9:
                    ptb = pictureBox9;
                    break;
                case 10:
                    ptb = pictureBox10;
                    break;
                case 11:
                    ptb = pictureBox11;
                    break;
                case 12:
                    ptb = pictureBox12;
                    break;
                case 13:
                    ptb = pictureBox13;
                    break;
                case 14:
                    ptb = pictureBox14;
                    break;
                case 15:
                    ptb = pictureBox15;
                    break;
                case 16:
                    ptb = pictureBox16;
                    break;
                default: break;
            }
            return ptb;
        }
        //
        //
        //
        public void Act(ref int n1,ref int n2)
        {
            System.Threading.Thread.Sleep(500);
            if (arr[n1 - 1] == arr[n2 - 1])
            {
                count++;
                check(n1).Visible = false;
                check(n2).Visible = false;
                if(count == 8)
                {
                    MessageBox.Show("You Win!");
                    btStart.Enabled = true;
                    btStart.Text = "Restart";
                }
            }
            else
            {
                check(n1).Image = Properties.Resources.red;
                check(n2).Image = Properties.Resources.red;
            }
            check(n1).Enabled = true;
            check(n2).Enabled = true;
            n1 = 0;
            n2 = 0;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = chooseImg(arr[1]);
            pictureBox2.Enabled = false;
            if (num1 == 0)
            {
                num1 = 2;
            }
            else
            {
                num2 = 2;
                Act(ref num1, ref num2);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = chooseImg(arr[2]);
            pictureBox3.Enabled = false;
            if (num1 == 0)
            {
                num1 = 3;
            }
            else
            {
                num2 = 3;
                Act(ref num1, ref num2);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = chooseImg(arr[3]);
            pictureBox4.Enabled = false;
            if (num1 == 0)
            {
                num1 = 4;
            }
            else
            {
                num2 = 4;
                Act(ref num1, ref num2);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = chooseImg(arr[4]);
            pictureBox5.Enabled = false;
            if (num1 == 0)
            {
                num1 = 5;
            }
            else
            {
                num2 = 5;
                Act(ref num1, ref num2);
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = chooseImg(arr[5]);
            pictureBox6.Enabled = false;
            if (num1 == 0)
            {
                num1 = 6;
            }
            else
            {
                num2 = 6;
                Act(ref num1, ref num2);
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox7.Image = chooseImg(arr[6]);
            pictureBox7.Enabled = false;
            if (num1 == 0)
            {
                num1 = 7;
            }
            else
            {
                num2 = 7;
                Act(ref num1, ref num2);
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox8.Image = chooseImg(arr[7]);
            pictureBox8.Enabled = false;
            if (num1 == 0)
            {
                num1 = 8;
            }
            else
            {
                num2 = 8;
                Act(ref num1, ref num2);
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox9.Image = chooseImg(arr[8]);
            pictureBox9.Enabled = false;
            if (num1 == 0)
            {
                num1 = 9;
            }
            else
            {
                num2 = 9;
                Act(ref num1, ref num2);
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox10.Image = chooseImg(arr[9]);
            pictureBox10.Enabled = false;
            if (num1 == 0)
            {
                num1 = 10;
            }
            else
            {
                num2 = 10;
                Act(ref num1, ref num2);
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            pictureBox11.Image = chooseImg(arr[10]);
            pictureBox11.Enabled = false;
            if (num1 == 0)
            {
                num1 = 11;
            }
            else
            {
                num2 = 11;
                Act(ref num1, ref num2);
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            pictureBox12.Image = chooseImg(arr[11]);
            pictureBox12.Enabled = false;
            if (num1 == 0)
            {
                num1 = 12;
            }
            else
            {
                num2 = 12;
                Act(ref num1, ref num2);
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            pictureBox13.Image = chooseImg(arr[12]);
            pictureBox13.Enabled = false;
            if (num1 == 0)
            {
                num1 = 13;
            }
            else
            {
                num2 = 13;
                Act(ref num1, ref num2);
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            pictureBox14.Image = chooseImg(arr[13]);
            pictureBox14.Enabled = false;
            if (num1 == 0)
            {
                num1 = 14;
            }
            else
            {
                num2 = 14;
                Act(ref num1, ref num2);
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            pictureBox15.Image = chooseImg(arr[14]);
            pictureBox15.Enabled = false;
            if (num1 == 0)
            {
                num1 = 15;
            }
            else
            {
                num2 = 15;
                Act(ref num1, ref num2);
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            pictureBox16.Image = chooseImg(arr[15]);
            pictureBox16.Enabled = false;
            if (num1 == 0)
            {
                num1 = 16;
            }
            else
            {
                num2 = 16;
                Act(ref num1, ref num2);
            }
        }
        //
        //
        //
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = chooseImg(arr[0]);
            pictureBox1.Enabled = false;
            if (num1 == 0)
            {
                num1 = 1;
            }
            else
            {
                num2 = 1;
                Act(ref num1, ref num2);
            }
        }
    }
}
