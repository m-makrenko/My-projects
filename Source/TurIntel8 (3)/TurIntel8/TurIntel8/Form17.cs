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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        string[] slov_10;
        List<string> List10 = new List<string>();
        int n_inList = 10;
        int kol = 0;
        int k_slov = 0;
        private void Mixer(ref int[] q_rand, int count)
        {
            Random rand = new Random();
            int x, y;
            for (int i = 0; i < count; i++)
                q_rand[i] = i;
            for (int i = 1; i < count; i++)
            {
                x = i + rand.Next(count - i);
                y = q_rand[x];
                q_rand[x] = q_rand[i];
                q_rand[i] = y;
            }
        }

        private string Int2StringTime(int time)
        {
            int hours = (time - (time % (60 * 60))) / (60 * 60);
            int minutes = (time - time % 60) / 60 - hours * 60;
            int seconds = time - hours * 60 * 60 - minutes * 60;
            return String.Format("{0:00}:{1:00}:{2:00}", hours, minutes, seconds);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            startValue = 60 * 5 + 5;
            timer1.Start();
            button1.Visible = false;
            int k = 10;
            string[] aa;
            string[] bb;

            //  Random r = new Random();
            Random rnd = new Random();
            string[] st = File.ReadAllLines("texts/words500.txt");
            string str = "";
            string newstr = "";
            int count_slov = st.Length;
            string[] slova = new string[count_slov];


            for (int i = 0; i < count_slov; i++)
            {
                aa = st[i].Split(new char[] { '=' });
                slova[i] = aa[1];

            }
            int[] qq = new int[count_slov];
            Mixer(ref qq, count_slov);

            slov_10 = new string[10];
            for (int i = 0; i < 10; i++)
                slov_10[i] = slova[qq[i]];
            List10 = slov_10.ToList();

            bb = str.Split(new char[] { ' ' });

            for (int i = 0; i < k; i++)
            {
                string s = "";
                for (int j = 0; j < rnd.Next(70, 100); j++)
                {
                    s = s + (char)(rnd.Next(1072, 1104));
                }
                s.ToLower();

                newstr = newstr + s + slov_10[i];
            }
            richTextBox1.Text = newstr + "вау";
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            string slovo = richTextBox1.SelectedText;


            if (k_slov == 10)
                label2.Text = " Всі знайдені!";
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
                string nf = Form8.f_name;
                StreamWriter sw = File.AppendText(nf + ".txt");
                sw.WriteLine("Увага " + kol + " балів");
                sw.Close();
               

                this.Close();
                Form8 secondForm = new Form8();
                secondForm.ShowDialog();

                return;
            }

        }

        int begin = 0, end = 0;

        private void richTextBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                //   richTextBox1.SelectionStart
                end = richTextBox1.GetCharIndexFromPosition(e.Location);
            label3.Text = richTextBox1.SelectedText;
            int i = 0;
            string slovo = richTextBox1.SelectedText;
            while (i < n_inList)
            {
                if (slovo.Length == 6)
                    if (slovo == List10[i])
                    {
                        List10.Remove(slovo); n_inList--;
                        //richTextBox1.SelectionFont = new Font("Verdana", 15, FontStyle.Italic);
                        richTextBox1.SelectionColor = Color.Tomato;
                        k_slov++;
                        listBox1.Items.Add(slovo);

                        kol++;
                    }
                i++;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            string nf = Form8.f_name;
            StreamWriter sw = File.AppendText(nf + ".txt");
            sw.WriteLine("Увага  " + kol + " балів");
            sw.Close();
            

            this.Close();
            Form8 secondForm = new Form8();
            secondForm.ShowDialog();

            return;
        }

        private void richTextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                richTextBox1.SelectionStart = richTextBox1.GetCharIndexFromPosition(e.Location);
            begin = richTextBox1.SelectionStart;
        }


    }
}
