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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are You Want Exit Application", "Exit Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            if (res == System.Windows.Forms.DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string t1 = textBox1.Text;
            string t2 = textBox2.Text;
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Username or Pass Is Empty", "Error");
            }
            else
            {

                this.Hide();
                Form2 fr = new Form2();
                fr.Show();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabel1.Text == "Show password")
            {
                textBox2.PasswordChar = '\0';
                linkLabel1.Text = "Hide password";
            }
            else
            {
                textBox2.PasswordChar = '*';
                linkLabel1.Text = "Show password";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void time_Click(object sender, EventArgs e)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            date.Text = DateTime.Now.ToLongDateString();
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToLongDateString();
        }
    }
}

