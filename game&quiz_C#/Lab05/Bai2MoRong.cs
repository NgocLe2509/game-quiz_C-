using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab05
{
    public partial class Bai2MoRong : Form
    {
        int[] arr = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 1, 2, 3, 4,
        5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18};
        int num1 = 0, num2 = 0, count = 0;
        public Bai2MoRong()
        {
            InitializeComponent();
        }
        //
        //
        //
        public static int[] delArr(int[] arr, int index)
        {
            int[] newr = new int[arr.Length - 1];
            for (int i = 0; i < index; i++)
            {
                newr[i] = arr[i];
            }
            for (int i = index; i < arr.Length - 1; i++)
            {
                newr[i] = arr[i + 1];
            }
            return newr;
        }
        public static int[] newArr(int[] arr)
        {

            Random r = new Random();
            int[] newrandom = new int[36];
            for (int i = 0; i < 36; i++)
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
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Start")
            {
                groupBox1.Visible = true;
                btnStart.Enabled = false;
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
                pictureBox17.Visible = true;
                pictureBox17.Image = Properties.Resources.red;
                pictureBox18.Visible = true;
                pictureBox18.Image = Properties.Resources.red;
                pictureBox19.Visible = true;
                pictureBox19.Image = Properties.Resources.red;
                pictureBox20.Visible = true;
                pictureBox20.Image = Properties.Resources.red;
                pictureBox21.Visible = true;
                pictureBox21.Image = Properties.Resources.red;
                pictureBox22.Visible = true;
                pictureBox22.Image = Properties.Resources.red;
                pictureBox23.Visible = true;
                pictureBox23.Image = Properties.Resources.red;
                pictureBox24.Visible = true;
                pictureBox24.Image = Properties.Resources.red;
                pictureBox25.Visible = true;
                pictureBox25.Image = Properties.Resources.red;
                pictureBox26.Visible = true;
                pictureBox26.Image = Properties.Resources.red;
                pictureBox27.Visible = true;
                pictureBox27.Image = Properties.Resources.red;
                pictureBox28.Visible = true;
                pictureBox28.Image = Properties.Resources.red;
                pictureBox29.Visible = true;
                pictureBox29.Image = Properties.Resources.red;
                pictureBox30.Visible = true;
                pictureBox30.Image = Properties.Resources.red;
                pictureBox31.Visible = true;
                pictureBox31.Image = Properties.Resources.red;
                pictureBox32.Visible = true;
                pictureBox32.Image = Properties.Resources.red;
                pictureBox33.Visible = true;
                pictureBox33.Image = Properties.Resources.red;
                pictureBox34.Visible = true;
                pictureBox34.Image = Properties.Resources.red;
                pictureBox35.Visible = true;
                pictureBox35.Image = Properties.Resources.red;
                pictureBox36.Visible = true;
                pictureBox36.Image = Properties.Resources.red;
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
                case 9:
                    img = Properties.Resources.chili;
                    break;
                case 10:
                    img = Properties.Resources.gralic;
                    break;
                case 11:
                    img = Properties.Resources.guava;
                    break;
                case 12:
                    img = Properties.Resources.lemon;
                    break;
                case 13:
                    img = Properties.Resources.mangosteen;
                    break;
                case 14:
                    img = Properties.Resources.papaya;
                    break;
                case 15:
                    img = Properties.Resources.pomegranate;
                    break;
                case 16:
                    img = Properties.Resources.tangerine;
                    break;
                case 17:
                    img = Properties.Resources.vegetable;
                    break;
                case 18:
                    img = Properties.Resources.watermelon;
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
                case 1:
                    ptb = pictureBox1;
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
                case 17:
                    ptb = pictureBox17;
                    break;
                case 18:
                    ptb = pictureBox18;
                    break;
                case 19:
                    ptb = pictureBox19;
                    break;
                case 20:
                    ptb = pictureBox20;
                    break;
                case 21:
                    ptb = pictureBox21;
                    break;
                case 22:
                    ptb = pictureBox22;
                    break;
                case 23:
                    ptb = pictureBox23;
                    break;
                case 24:
                    ptb = pictureBox24;
                    break;
                case 25:
                    ptb = pictureBox25;
                    break;
                case 26:
                    ptb = pictureBox26;
                    break;
                case 27:
                    ptb = pictureBox27;
                    break;
                case 28:
                    ptb = pictureBox28;
                    break;
                case 29:
                    ptb = pictureBox29;
                    break;
                case 30:
                    ptb = pictureBox30;
                    break;
                case 31:
                    ptb = pictureBox31;
                    break;
                case 32:
                    ptb = pictureBox32;
                    break;
                case 33:
                    ptb = pictureBox33;
                    break;
                case 34:
                    ptb = pictureBox34;
                    break;
                case 35:
                    ptb = pictureBox35;
                    break;
                case 36:
                    ptb = pictureBox36;
                    break;
                default: break;
            }
            return ptb;
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

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            pictureBox17.Image = chooseImg(arr[16]);
            pictureBox17.Enabled = false;
            if (num1 == 0)
            {
                num1 = 17;
            }
            else
            {
                num2 = 17;
                Act(ref num1, ref num2);
            }
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            pictureBox18.Image = chooseImg(arr[17]);
            pictureBox18.Enabled = false;
            if (num1 == 0)
            {
                num1 = 18;
            }
            else
            {
                num2 = 18;
                Act(ref num1, ref num2);
            }
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            pictureBox21.Image = chooseImg(arr[20]);
            pictureBox21.Enabled = false;
            if (num1 == 0)
            {
                num1 = 21;
            }
            else
            {
                num2 = 21;
                Act(ref num1, ref num2);
            }
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            pictureBox20.Image = chooseImg(arr[19]);
            pictureBox20.Enabled = false;
            if (num1 == 0)
            {
                num1 = 20;
            }
            else
            {
                num2 = 20;
                Act(ref num1, ref num2);
            }
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            pictureBox19.Image = chooseImg(arr[18]);
            pictureBox19.Enabled = false;
            if (num1 == 0)
            {
                num1 = 19;
            }
            else
            {
                num2 = 19;
                Act(ref num1, ref num2);
            }
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            pictureBox22.Image = chooseImg(arr[21]);
            pictureBox22.Enabled = false;
            if (num1 == 0)
            {
                num1 = 22;
            }
            else
            {
                num2 = 22;
                Act(ref num1, ref num2);
            }
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            pictureBox23.Image = chooseImg(arr[22]);
            pictureBox23.Enabled = false;
            if (num1 == 0)
            {
                num1 = 23;
            }
            else
            {
                num2 = 23;
                Act(ref num1, ref num2);
            }
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            pictureBox24.Image = chooseImg(arr[23]);
            pictureBox24.Enabled = false;
            if (num1 == 0)
            {
                num1 = 24;
            }
            else
            {
                num2 = 24;
                Act(ref num1, ref num2);
            }
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            pictureBox25.Image = chooseImg(arr[24]);
            pictureBox25.Enabled = false;
            if (num1 == 0)
            {
                num1 = 25;
            }
            else
            {
                num2 = 25;
                Act(ref num1, ref num2);
            }
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            pictureBox26.Image = chooseImg(arr[25]);
            pictureBox26.Enabled = false;
            if (num1 == 0)
            {
                num1 = 26;
            }
            else
            {
                num2 = 26;
                Act(ref num1, ref num2);
            }
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            pictureBox27.Image = chooseImg(arr[26]);
            pictureBox27.Enabled = false;
            if (num1 == 0)
            {
                num1 = 27;
            }
            else
            {
                num2 = 27;
                Act(ref num1, ref num2);
            }
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            pictureBox28.Image = chooseImg(arr[27]);
            pictureBox28.Enabled = false;
            if (num1 == 0)
            {
                num1 = 28;
            }
            else
            {
                num2 = 28;
                Act(ref num1, ref num2);
            }
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            pictureBox29.Image = chooseImg(arr[28]);
            pictureBox29.Enabled = false;
            if (num1 == 0)
            {
                num1 = 29;
            }
            else
            {
                num2 = 29;
                Act(ref num1, ref num2);
            }
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            pictureBox30.Image = chooseImg(arr[29]);
            pictureBox30.Enabled = false;
            if (num1 == 0)
            {
                num1 = 30;
            }
            else
            {
                num2 = 30;
                Act(ref num1, ref num2);
            }
        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            pictureBox31.Image = chooseImg(arr[30]);
            pictureBox31.Enabled = false;
            if (num1 == 0)
            {
                num1 = 31;
            }
            else
            {
                num2 = 31;
                Act(ref num1, ref num2);
            }
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            pictureBox32.Image = chooseImg(arr[31]);
            pictureBox32.Enabled = false;
            if (num1 == 0)
            {
                num1 = 32;
            }
            else
            {
                num2 = 32;
                Act(ref num1, ref num2);
            }
        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {
            pictureBox33.Image = chooseImg(arr[32]);
            pictureBox33.Enabled = false;
            if (num1 == 0)
            {
                num1 = 33;
            }
            else
            {
                num2 = 33;
                Act(ref num1, ref num2);
            }
        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {
            pictureBox34.Image = chooseImg(arr[33]);
            pictureBox34.Enabled = false;
            if (num1 == 0)
            {
                num1 = 34;
            }
            else
            {
                num2 = 34;
                Act(ref num1, ref num2);
            }
        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {
            pictureBox35.Image = chooseImg(arr[34]);
            pictureBox35.Enabled = false;
            if (num1 == 0)
            {
                num1 = 35;
            }
            else
            {
                num2 = 35;
                Act(ref num1, ref num2);
            }
        }

        private void pictureBox36_Click(object sender, EventArgs e)
        {
            pictureBox36.Image = chooseImg(arr[35]);
            pictureBox36.Enabled = false;
            if (num1 == 0)
            {
                num1 = 36;
            }
            else
            {
                num2 = 36;
                Act(ref num1, ref num2);
            }
        }

        //
        //
        //
        public void Act(ref int n1, ref int n2)
        {
            System.Threading.Thread.Sleep(500);
            if (arr[n1 - 1] == arr[n2 - 1])
            {
                count++;
                check(n1).Visible = false;
                check(n2).Visible = false;
                if (count == 18)
                {
                    MessageBox.Show("You Win!");
                    btnStart.Enabled = true;
                    btnStart.Text = "Restart";
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
 