using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurIntel8
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
int k = 0;
int sch = 0;
        private void Form4_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;

            pictureBox1.Image = Image.FromFile("pictures/0.png");
            pictureBox2.Image = Image.FromFile("pictures/1.png");
            pictureBox3.Image = Image.FromFile("pictures/2.png");
            pictureBox4.Image = Image.FromFile("pictures/3.png");
            pictureBox5.Image = Image.FromFile("pictures/4.png");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (k == 0)
            {
                if(radioButton1.Checked==true)
                {
                    sch++;
                }

           radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;

                pictureBox1.Image = Image.FromFile("pictures/5.png");
                pictureBox2.Image = Image.FromFile("pictures/6.png");
                pictureBox3.Image = Image.FromFile("pictures/9.png");
                pictureBox4.Image = Image.FromFile("pictures/7.png");
                pictureBox5.Image = Image.FromFile("pictures/8.png");
                k++;
            }

            else if (k == 1)
            {
                if (radioButton3.Checked == true)
                {
                    sch++;
                }
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;

                pictureBox1.Image = Image.FromFile("pictures/10.png");
                pictureBox2.Image = Image.FromFile("pictures/11.png");
                pictureBox3.Image = Image.FromFile("pictures/14.png");
                pictureBox4.Image = Image.FromFile("pictures/13.png");
                pictureBox5.Image = Image.FromFile("pictures/12.png");
                k++;
            }

            else if (k == 2)
            {
                if (radioButton3.Checked == true)
                {
                    sch++;
                }
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;

                pictureBox1.Image = Image.FromFile("pictures/15.png");
                pictureBox2.Image = Image.FromFile("pictures/17.png");
                pictureBox3.Image = Image.FromFile("pictures/18.png");
                pictureBox4.Image = Image.FromFile("pictures/19.png");
                pictureBox5.Image = Image.FromFile("pictures/16.png");
                k++;
            }

            else if (k == 3)
            {
                button2.Visible = true;
                if (radioButton4.Checked == true)
                {
                    sch++;
                }
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton2.Checked = false;
                radioButton4.Checked = false;

                pictureBox1.Image = Image.FromFile("pictures/20.png");
                pictureBox2.BackColor = Color.White;
                pictureBox3.BackColor = Color.White;
                pictureBox4.BackColor = Color.White;
                pictureBox5.BackColor = Color.White;
                k++;
            }


            textBox1.Text = sch.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 secondForm = new Form8();
            secondForm.ShowDialog();
           
        }
    }
}
