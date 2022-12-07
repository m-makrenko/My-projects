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
    public partial class Form14 : Form
    {
        static public int q;
        public Form14()
        {
            InitializeComponent();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    q = int.Parse(textBox1.Text);
        //    this.Hide();
        //    Form8 secondForm = new Form8();
        //    secondForm.ShowDialog();
        //}
        PictureBox[] pic = new PictureBox[30];

        private void Form14_Load(object sender, EventArgs e)
        {
            textBox1.Text = Form13.p.ToString();
            q = int.Parse(Form13.p.ToString());
            Random rnd = new Random();

            string path = Application.StartupPath + "\\pictures\\";

            pic[0] = pictureBox1;
            pic[1] = pictureBox2;
            pic[2] = pictureBox3;
            pic[3] = pictureBox4;
            pic[4] = pictureBox5;
            pic[5] = pictureBox6;
            pic[6] = pictureBox7;
            pic[7] = pictureBox8;
            pic[8] = pictureBox9;
            pic[9] = pictureBox10;
            pic[10] = pictureBox11;
            pic[11] = pictureBox12;
            pic[12] = pictureBox13;
            pic[13] = pictureBox14;
            pic[14] = pictureBox15;
            pic[15] = pictureBox16;
            pic[16] = pictureBox17;
            pic[17] = pictureBox18;
            pic[18] = pictureBox19;
            pic[19] = pictureBox20;
            pic[20] = pictureBox21;
            pic[21] = pictureBox22;
            pic[22] = pictureBox23;
            pic[23] = pictureBox24;
            pic[24] = pictureBox25;
            pic[25] = pictureBox26;
            pic[26] = pictureBox27;
            pic[27] = pictureBox28;
            pic[28] = pictureBox29;
            pic[29] = pictureBox30;
            int t = 0;
            for (int i = 0; i < 13; i++)
            {
                pic[i].Image = Image.FromFile("pictures/25.png");
            }
            for (int i = 13; i < 30; i++)
            {
                string filename = rnd.Next(25, 27).ToString();

                if (filename == "26")
                {
                    t = i;
                    filename = path + filename + ".png";

                    pic[i].Image = new Bitmap(filename);

                    for (int j = i + 1; j < 30; j++)

                    {
                        pic[j].Image = Image.FromFile("pictures/25.png");
                    }
                    break;
                }

                else if (filename == "25")
                {
                    filename = path + filename + ".png";

                    pic[i].Image = new Bitmap(filename);
                }





            }
            for (int i = 0; i < 30; i++)
            {
                if (i == t)
                {
                    pic[t].Click += picturebox_Click;
                }
                else
                {
                    pic[i].Click += picturebox1_Click;
                }

            }

        }


        private void picturebox_Click(object sender, EventArgs e)
        {
                q++;
                string nf = Form8.f_name;
                StreamWriter sw = File.AppendText(nf + ".txt");
                sw.WriteLine("Відмінності  " + q + " балів");
                sw.Close();
                textBox1.Text = Form14.q.ToString();
                textBox1.Clear();
                this.Hide();
                Form8 secondForm = new Form8();
                secondForm.ShowDialog();
          return;
        }

        private void picturebox1_Click(object sender, EventArgs e)
        {
            q = int.Parse(textBox1.Text);
            string nf = Form8.f_name;
            StreamWriter sw = File.AppendText(nf + ".txt");
            sw.WriteLine("Відмінності  " + q + " балів");
            sw.Close();
            this.Hide();
                Form8 secondForm = new Form8();
                secondForm.ShowDialog();
            return;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            q = int.Parse(textBox1.Text);
            string nf = Form8.f_name;
            StreamWriter sw = File.AppendText(nf + ".txt");
            sw.WriteLine("Відмінності  " + q + " балів");
            sw.Close();
            this.Hide();
            Form8 secondForm = new Form8();
            secondForm.ShowDialog();
            return;
        }
    }

       
      
    }

