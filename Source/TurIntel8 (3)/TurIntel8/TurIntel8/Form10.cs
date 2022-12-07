using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TurIntel8
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private string Int2StringTime(int time)
        {
            int hours = (time - (time % (60 * 60))) / (60 * 60);
            int minutes = (time - time % 60) / 60 - hours * 60;
            int seconds = time - hours * 60 * 60 - minutes * 60;
            return String.Format("{0:00}:{1:00}:{2:00}", hours, minutes, seconds);
        }

        Label[] Row = new System.Windows.Forms.Label[10];
        Label[] Row1 = new System.Windows.Forms.Label[10];
        Label[] Row2 = new System.Windows.Forms.Label[10];
        Label[] Row3 = new System.Windows.Forms.Label[10];
        Label[] Row4 = new System.Windows.Forms.Label[10];
        Label[] Row5 = new System.Windows.Forms.Label[10];

        int [] aa=new int [10];
            int[] aa1=new int[10];
            int[] aa2 = new int[10];
            int[] aa3 = new int[10];
        int[] aa5 = new int[10];
        int n = 10;
        private void button1_Click(object sender, EventArgs e)
        {
            startValue = 60 * 0 + 5;
            timer1.Start();
            button1.Visible = false;
            int k = 0;
            Font myFont = new Font("Microsoft Sans Serif", 16, FontStyle.Regular);
           
            int k1 = 0;
           
            double[] aa4 = new double[10];
            
            for (int i = 0; i < n; i++)

            {


                Row[i] = new System.Windows.Forms.Label();
                Row[i].Width = 50;
                Row[i].Height = 30;
                Row[i].Top = 120;
                Row[i].Left = 50 + i * 50;
                //Row[i].Text = i.ToString();
                Row[i].Font = myFont;
                Row[i].AutoSize = false;


                Row1[i] = new System.Windows.Forms.Label();
                Row1[i].Width = 50;
                Row1[i].Height = 30;
                Row1[i].Top = 240;
                Row1[i].Left = 50 + i * 50;
                //Row[i].Text = i.ToString();
                Row1[i].Font = myFont;
                Row1[i].AutoSize = false;


                Row2[i] = new System.Windows.Forms.Label();
                Row2[i].Width = 50;
                Row2[i].Height = 30;
                Row2[i].Top = 360;
                Row2[i].Left = 50 + i * 50;
                //Row[i].Text = i.ToString();
                Row2[i].Font = myFont;
                Row2[i].AutoSize = false;

                Row3[i] = new System.Windows.Forms.Label();
                Row3[i].Width = 50;
                Row3[i].Height = 30;
                Row3[i].Top = 480;
                Row3[i].Left = 50 + i * 50;
                //Row[i].Text = i.ToString();
                Row3[i].Font = myFont;
                Row3[i].AutoSize = false;

                Row4[i] = new System.Windows.Forms.Label();
                Row4[i].Width = 50;
                Row4[i].Height = 30;
                Row4[i].Top = 600;
                Row4[i].Left = 50 + i * 50;
                //Row[i].Text = i.ToString();
                Row4[i].Font = myFont;
                Row4[i].AutoSize = false;

                Row5[i] = new System.Windows.Forms.Label();
                Row5[i].Width = 50;
                Row5[i].Height = 30;
                Row5[i].Top = 720;
                Row5[i].Left = 50 + i * 50;
                //Row[i].Text = i.ToString();
                Row5[i].Font = myFont;
                Row5[i].AutoSize = false;



            }

            this.Controls.AddRange(this.Row);
            this.Controls.AddRange(this.Row1);
            this.Controls.AddRange(this.Row2);
            this.Controls.AddRange(this.Row3);
            this.Controls.AddRange(this.Row4);
            this.Controls.AddRange(this.Row5);
            Random rnd = new Random();
            aa[0] = rnd.Next(1, 10);
           for(int i=1;i<10;i++)
            {
                aa[i] = aa[i - 1] * 2;
            }

            for (int j = 0; j < 10; j++)
            {

                Row[j].Text = aa[j].ToString();

            }

            int f =rnd.Next(1, 10);
           

            for (int i = 0; i < 10; i++)
            {
                
                aa1[i] =f * f;
                f++;
            }

            for (int j = 0; j < 10; j++)
            {

                Row1[j].Text = aa1[j].ToString();

            }


            int b= rnd.Next(20, 30);
            int c = b - 1;

            for (int j = 0; j < 10; j++)
            {
                if(j%2==0)
                {
                   Row2[j].Text = b.ToString();
                    b++;
                }
                if (j % 2 != 0)
                {
                    Row2[j].Text = c.ToString();
                    c--;
                }

            }


            aa3[0] = rnd.Next(1, 10);
            for (int i = 1; i < 10; i++)
            {
                aa3[i] = aa3[i - 1] * 2;
            }

            for (int j = 0; j < 10; j++)
            {

                Row3[j].Text = aa3[j].ToString();

            }

            aa4[0] = rnd.Next(1, 10); 
            double w = 1;
            for (int i = 1; i < 10; i++)
            {
                aa4[i] = aa4[i - 1] + Math.Pow(2,w);
                w++;
            }

            for (int j = 0; j < 10; j++)
            {

                Row4[j].Text = aa4[j].ToString();

            }

            aa5[0] = rnd.Next(1, 10);
           
            for (int i = 1; i < 10; i++)
            {
                aa5[i] = aa5[i - 1]*2+1;
              
            }

            for (int j = 0; j < 10; j++)
            {

                Row5[j].Text = aa5[j].ToString();

            }

            Row[n - 1].Visible = false;
            Row[n - 2].Visible = false;
            Row1[n - 1].Visible = false;
            Row1[n - 2].Visible = false;

            Row2[n - 1].Visible = false;
            Row2[n - 2].Visible = false;

            Row3[n - 1].Visible = false;
            Row3[n - 2].Visible = false;

            Row4[n - 1].Visible = false;
            Row4[n - 2].Visible = false;

            Row5[n - 1].Visible = false;
            Row5[n - 2].Visible = false;

        }
        
        int startValue = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (startValue != 0)
            {
                timeLabel.Text = Int2StringTime(startValue);
                startValue--;
            }
            else
            {
                (sender as Timer).Stop();
                (sender as Timer).Dispose();
                MessageBox.Show("Time's up!");
                int kol = 0;
                if (Row[n - 2].Text == textBox1.Text && Row[n - 1].Text == textBox2.Text)
                {
                    kol++;
                }
                if (Row1[n - 2].Text == textBox5.Text && Row1[n - 1].Text == textBox4.Text)
                    kol++;

                if (Row2[n - 2].Text == textBox7.Text && Row2[n - 1].Text == textBox6.Text)
                    kol++;

                if (Row3[n - 2].Text == textBox11.Text && Row3[n - 1].Text == textBox10.Text)
                    kol++;

                if (Row4[n - 2].Text == textBox9.Text && Row4[n - 1].Text == textBox8.Text)
                    kol++;

                if (Row5[n - 2].Text == textBox13.Text && Row4[n - 1].Text == textBox12.Text)
                    kol++;


                Form8 secondForm = new Form8();
                secondForm.ShowDialog();

                this.Hide();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int kol = 0;
            if (Row[n - 2].Text == textBox1.Text && Row[n - 1].Text == textBox2.Text)
            {
                kol++;
            }
            if (Row1[n - 2].Text == textBox5.Text && Row1[n - 1].Text == textBox4.Text)
                kol++;

            if (Row2[n - 2].Text == textBox7.Text && Row2[n - 1].Text == textBox6.Text)
                kol++;

            if (Row3[n - 2].Text == textBox11.Text && Row3[n - 1].Text == textBox10.Text)
                kol++;

            if (Row4[n - 2].Text == textBox9.Text && Row4[n - 1].Text == textBox8.Text)
                kol++;

            if (Row5[n - 2].Text == textBox13.Text && Row4[n - 1].Text == textBox12.Text)
                kol++;


            string nf = Form8.f_name;
            StreamWriter sw = File.AppendText(nf + ".txt");
            sw.WriteLine("Числові ряди" + kol + " балів");
            sw.Close();
           
            Form8 secondForm = new Form8();
            secondForm.ShowDialog();

            this.Hide();
        }
    }
}
