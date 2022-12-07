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
    public partial class Form5 : Form
    {
        public Form5()
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

    

        private void button1_Click_1(object sender, EventArgs e)
        {
            startValue = 60 * 5 + 5;
            timer1.Start();
            button1.Visible = false;
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
                if (radioButton5.Checked == true)
                {
                    kol++;
                }
                if (radioButton11.Checked == true)
                {
                    kol++;
                }
                if (radioButton18.Checked == true)
                {
                    kol++;
                }
                if (radioButton19.Checked == true)
                {
                    kol++;
                }
                if (radioButton27.Checked == true)
                {
                    kol++;
                }
                if (radioButton58.Checked == true)
                {
                    kol++;
                }
                if (radioButton53.Checked == true)
                {
                    kol++;
                }
                if (radioButton43.Checked == true)
                {
                    kol++;
                }
                if (radioButton38.Checked == true)
                {
                    kol++;
                }
                if (radioButton36.Checked == true)
                {
                    kol++;
                }


               
                string nf = Form1.name_file;
                StreamWriter sw = File.AppendText(nf + ".txt");
                sw.WriteLine("Асоціації  " + kol + " балів");
                sw.Close();

                this.Close();
                Form2 secondForm = new Form2();
                secondForm.ShowDialog();
                
                return;
            }
       }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int kol = 0;
            if (radioButton5.Checked == true)
            {
                kol++;
            }
            if (radioButton11.Checked == true)
            {
                kol++;
            }
            if (radioButton18.Checked == true)
            {
                kol++;
            }
            if (radioButton19.Checked == true)
            {
                kol++;
            }
            if (radioButton27.Checked == true)
            {
                kol++;
            }
            if (radioButton58.Checked == true)
            {
                kol++;
            }
            if (radioButton53.Checked == true)
            {
                kol++;
            }
            if (radioButton43.Checked == true)
            {
                kol++;
            }
            if (radioButton38.Checked == true)
            {
                kol++;
            }
            if (radioButton36.Checked == true)
            {
                kol++;
            }



            string nf = Form1.name_file;
            StreamWriter sw = File.AppendText(nf + ".txt");
            sw.WriteLine("Асоціації  " + kol + " балів");
            sw.Close();

            this.Close();
            Form2 secondForm = new Form2();
            secondForm.ShowDialog();

            return;
        }
    }
}
