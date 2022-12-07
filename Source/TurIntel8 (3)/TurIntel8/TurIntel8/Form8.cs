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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 secondForm = new Form9();
            secondForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form10 secondForm = new Form10();
            secondForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form11 secondForm = new Form11();
            secondForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form12 secondForm = new Form12();
            secondForm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public static string f_name;
        private void Form8_Load(object sender, EventArgs e)
        {
            f_name = label4.Text;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form17 secondForm = new Form17();
            secondForm.ShowDialog();
        }
    }
}
