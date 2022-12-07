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


namespace TurIntel_Final
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //private void pictureBox2_MouseHover(object sender, EventArgs e)
        //{
        //    pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;


        //}

 

        //private void pictureBox2_MouseLeave(object sender, EventArgs e)
        //{
        //    pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
        //}

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;

        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Dispose();
            this.Close();
            pictureBox2.Enabled = false;
            Form3 secondForm = new Form3();
            secondForm.ShowDialog();
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form5 secondForm = new Form5();
            secondForm.ShowDialog();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form4 secondForm = new Form4();
            secondForm.ShowDialog();
            this.Hide();
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form6 secondForm = new Form6();
            secondForm.ShowDialog();
            this.Hide();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form7 secondForm = new Form7();
            secondForm.ShowDialog();
            this.Hide();
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }
    }
}
