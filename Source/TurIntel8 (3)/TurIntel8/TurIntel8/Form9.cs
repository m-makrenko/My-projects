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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

       
        RadioButton[] Column = new System.Windows.Forms.RadioButton[9];
        RadioButton[] Column1 = new System.Windows.Forms.RadioButton[9];
        string[] slov_9;
        List<string> List10 = new List<string>();
        int n_inList = 10;
        string[] slova, st;
        int tick = 0;
        Font myFont = new Font("Arial", 18, FontStyle.Bold);
        int count_slov;
        int[] qq_for_all_slov;
        int proba;
        int kol = 0;
        string slovo;

        private void Mixer(ref int[] q_rand, int count)
        {
            Random rand = new Random();
            int x, y;
            for (int i = 0; i < count; i++)
                q_rand[i] = i;
            for (int i = 0; i < count; i++)
            {
                x = i + rand.Next(count - i);
                y = q_rand[x];
                q_rand[x] = q_rand[i];
                q_rand[i] = y; 
            }

        }

        private void radioButton1_Click(object sender, EventArgs e)
        {

            int nrb = 0;
            for (int i = 0; i < 9; i++)
            {
                if (Column1[i].Checked == true)
                    nrb = i;
            }

            if (Column1[nrb].Text == slovo)
            {
                //label1.Text = "вірно";
                kol++;
                pictureBox1.Image = Image.FromFile("pictures/1vv.jpg");
            }
            else

            {
                //label1.Text = "не вірно";
                pictureBox1.Image = Image.FromFile("pictures/2vv.jpg");
            }
            proba++;
            if (proba == 4)
            {

                label1.Text = "finish";
               
                string nf = Form8.f_name; 
                StreamWriter sw = File.AppendText(nf + ".txt");
                sw.WriteLine("Слова  " + kol + " балів");
                sw.Close();
                return;


            }
            else
            {

                panel2.Visible = false;
                panel1.Visible = true;
                radioButton1.Checked = true;
                tick = 0;
                Block(proba);
            }
        }
        
        void Block(int num)
        {


            slov_9 = new string[9];
            for (int i = 0; i < 9; i++)
                slov_9[i] = st[qq_for_all_slov[num * 9 + i]];
            List10 = slov_9.ToList();

            for (int i = 0; i < 9; i++)
            {
                Column[i].Text = slov_9[i];

            }


            slovo = slov_9[8];
            label2.Text = slovo;
            timer1.Start();


        }
        private void button2_Click(object sender, EventArgs e)
        {

            st = File.ReadAllLines("texts/words.txt");

            count_slov = st.Length;
            slova = new string[count_slov];

            qq_for_all_slov = new int[count_slov];
            Mixer(ref qq_for_all_slov, count_slov);
            for (int i = 0; i < count_slov; i++)
                slova[i] = st[qq_for_all_slov[i]];



            for (int i = 0; i < 9; i++)
            {

                Column[i] = new System.Windows.Forms.RadioButton();
                Column[i].Width = 200;
                Column[i].Height = 50;
                Column[i].Top = 20 + i * 60;
                Column[i].Left = 50;
                Column[i].Text = i.ToString();
                Column[i].Font = myFont;
                Column[i].AutoSize = false;
                Column[i].Enabled = false;
            }
            Column[8].Visible = false;
            panel1.Controls.AddRange(Column);
            for (int i = 0; i < 9; i++)
            {

                Column1[i] = new System.Windows.Forms.RadioButton();
                Column1[i].Width = 200;
                Column1[i].Height = 50;
                Column1[i].Top = 20 + i * 60;
                Column1[i].Left = 50;
                Column1[i].Text = i.ToString();
                Column1[i].Font = myFont;
                Column1[i].AutoSize = false;
                Column1[i].Click += radioButton1_Click;

            }

            panel2.Controls.AddRange(Column1);
            panel2.Visible = false;
            panel1.Visible = false;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            tick++;
            if (tick == 5)
            {
                timer1.Stop();
                int[] qq = new int[9];
                Mixer(ref qq, 9);
                for (int i = 0; i < 9; i++)
                    Column1[i].Text = slov_9[qq[i]].ToString();

                panel1.Visible = false;
                panel2.Visible = true;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 secondForm = new Form8();
            secondForm.ShowDialog();
           
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            proba = 0;
            Block(proba);
            panel1.Visible = true;
        }
    }
}
