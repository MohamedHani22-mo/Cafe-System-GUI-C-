using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form2 : Form
    {
        public static Form2 instance;
        public Form2()
        {
            instance = this;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 fr2 = new Form3();
            fr2.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult res2 = MessageBox.Show("Are You Want Exit Application", "Exit Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            if (res2 == System.Windows.Forms.DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();



        }





        private void button4_Click_1(object sender, EventArgs e)
        {


        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult res3 = MessageBox.Show("Are You Sure About Order?", "Your Order!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            if (res3 == System.Windows.Forms.DialogResult.OK)
            {


                int sum = 0;
                int ch1 = 10;
                int ch2 = 20;
                int ch3 = 15;
                int ch4 = 5;
                int ch5 = 3;
                int ch6 = 5;
                int ch7 = 10;
                int ch8 = 10;
                int ch9 = 3;
                int ch10 = 5;
                int ch11 = 5;
                int ch12 = 5;
                int ch13 = 5;
                int ch14 = 3;
                int ch15 = 5;
                int ch16 = 5;
                int ch17 = 5;
                int ch18 = 5;
                int ch19 = 5;
                int ch20 = 5;
                int ch21 = 10;
                int ch22 = 5;
                int ch23 = 10;
                int ch24 = 10;
                int ch25 = 5;
                int ch26 = 10;
                int ch27 = 5;


                if (checkBox1.Checked)
                {
                    sum = sum + ch1;
                    c.Text = sum.ToString() + '$';
                }else
                {
                    c.Text = "";
                }
                if (checkBox2.Checked)
                {
                    sum = sum + ch2;
                    c.Text = sum.ToString() + '$';
                }
                if (checkBox3.Checked)
                {
                    sum = sum + ch3;
                    c.Text = sum.ToString() + '$';
                }
                if (checkBox4.Checked)
                {
                    sum = sum + ch4;
                    c.Text = sum.ToString() + '$';
                }
                if (checkBox5.Checked)
                {
                    sum = sum + ch5;
                    c.Text = sum.ToString() + '$';
                }
                if (checkBox6.Checked)
                {
                    sum = sum + ch6;
                    c.Text = sum.ToString() + '$';
                }
                if (checkBox7.Checked)
                {
                    sum = sum + ch7;
                    c.Text = sum.ToString() + '$';
                }
                if (checkBox8.Checked)
                {
                    sum = sum + ch8;
                    c.Text = sum.ToString() + '$';
                }
                if (checkBox9.Checked)
                {
                    sum = sum + ch9;
                    c.Text = sum.ToString() + '$';
                }
                if (checkBox10.Checked)
                {
                    sum = sum + ch10;
                    c.Text = sum.ToString() + '$';
                }
                if (checkBox11.Checked)
                {
                    sum = sum + ch11;
                    c.Text = sum.ToString() + '$';
                }
                if (checkBox12.Checked)
                {
                    sum = sum + ch12;
                    c.Text = sum.ToString() + '$';
                }
                if (checkBox13.Checked)
                {
                    sum = sum + ch13;
                    c.Text = sum.ToString() + '$';
                }
                if (checkBox14.Checked)
                {
                    sum = sum + ch14;
                    c.Text = sum.ToString() + '$';
                }
                if (checkBox15.Checked)
                {
                    sum = sum + ch15;
                    c.Text = sum.ToString() + '$';
                }
                if (checkBox16.Checked)
                {
                    sum = sum + ch16;
                    c.Text = sum.ToString() + '$';
                }
                if (checkBox17.Checked)
                {
                    sum = sum + ch17;
                    c.Text = sum.ToString() + '$';
                }
                if (checkBox18.Checked)
                {
                    sum = sum + ch18;
                    c.Text = sum.ToString() + '$';
                }
                if (checkBox19.Checked)
                {
                    sum = sum + ch19;
                    c.Text = sum.ToString() + '$';
                }
                if (checkBox20.Checked)
                {
                    sum = sum + ch20;
                    c.Text = sum.ToString() + '$';
                }
                if (checkBox21.Checked)
                {
                    sum = sum + ch21;
                    c.Text = sum.ToString() + '$';
                }
                if (checkBox22.Checked)
                {
                    sum = sum + ch22;
                    c.Text = sum.ToString() + '$';
                }
                if (checkBox23.Checked)
                {
                    sum = sum + ch23;
                    c.Text = sum.ToString() + '$';
                }
                if (checkBox24.Checked)
                {
                    sum = sum + ch24;
                    c.Text = sum.ToString() + '$';
                }
                if (checkBox25.Checked)
                {
                    sum = sum + ch25;
                    c.Text = sum.ToString() + '$';
                }
                if (checkBox26.Checked)
                {
                    sum = sum + ch26;
                    c.Text = sum.ToString() + '$';
                }
                if (checkBox27.Checked)
                {
                    sum = sum + ch27;
                    c.Text = sum.ToString() + '$';
                }
            }
            if(c.Text=="")
            {
                MessageBox.Show("You Shoud Ordered Or Exit APP", "Error");
            }
            
            }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form3 fr = new Form3();
            fr.Show();
        }
    }
    }


