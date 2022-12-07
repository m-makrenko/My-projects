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
using TurIntel8;

namespace TurIntel_Final 
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
            comboBox1.Items.Add("7 клас");
            comboBox1.Items.Add("8 клас");
        }


        public static string name_file;
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    name_file = textBox1.Text + " " + textBox2.Text ;
        //  //  FileStream fs = File.Create(name_file);

        //    StreamWriter sw = File.CreateText(name_file+ ".txt");
        //    sw.WriteLine(name_file);
        //    sw.Close();

        //}

        string str = "";
        string str1 = "";

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                str = textBox1.Text;
                str = str.Replace(" ", "");
                str1 = textBox2.Text;
                str1 = str1.Replace(" ", "");

                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("пусто");
                }

                else
                {
                    name_file = str + " " + str1 + "7 класс";
                    //  FileStream fs = File.Create(name_file);

                    StreamWriter sw = File.CreateText(name_file + ".txt");
                    sw.WriteLine(name_file);
                    sw.Close();
                    Form2 secondForm = new Form2();
                    this.Hide();
                    secondForm.ShowDialog();
                }
               
                
              
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                str = textBox1.Text;
                str = str.Replace(" ", "");
                str1 = textBox2.Text;
                str1 = str1.Replace(" ", "");

                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("пусто");
                }

                else
                {
                 name_file = str + " " + str1 + "8 класс";
                //  FileStream fs = File.Create(name_file);

                StreamWriter sw = File.CreateText(name_file + ".txt");
                sw.WriteLine(name_file);
                sw.Close();
                Form8 secondForm = new Form8();
                secondForm.label4.Text = name_file;
                secondForm.ShowDialog();
                this.Hide();

                }
               
             

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
