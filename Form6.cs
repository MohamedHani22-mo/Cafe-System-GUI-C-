using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 fr7 = new Form7();
            fr7.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=MOHAMED_HANI;Initial Catalog=DB_project;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("Update sign_up set user_namee2=@user_namee2,User_Pass=@User_Pass,Age=@Age,Gender=@Gender where id=@id", con);
                cmd.Parameters.AddWithValue("@id", int.Parse(textBox3.Text));
                cmd.Parameters.AddWithValue("@user_namee2", textBox1.Text);
                cmd.Parameters.AddWithValue("@User_Pass", textBox2.Text);
                cmd.Parameters.AddWithValue("@Age", int.Parse(textBox4.Text));
                cmd.Parameters.AddWithValue("@Gender", textBox5.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                string message1 = "Update Done";
                string title1 = "Update Succsess!!";
                MessageBox.Show(message1, title1);
                textBox1.Text = " ";
                textBox2.Text = " ";
                textBox3.Text = " ";
                textBox4.Text = " ";
                textBox5.Text = " ";
            }
            catch
            {
                string message = "ID Not Found\nTry Another One";
                string title = "Update Error!!";
                MessageBox.Show(message, title);
            }



        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=MOHAMED_HANI;Initial Catalog=DB_project;Integrated Security=True");
                con.Open();

                SqlCommand cmd = new SqlCommand("Delete sign_up where id=@id", con);

                cmd.Parameters.AddWithValue("@id", int.Parse(textBox3.Text));

                cmd.ExecuteNonQuery();
                con.Close();
                string message1 = "Delete Done";
                string title1 = "Deletion Succsess!!";
                MessageBox.Show(message1, title1);
                textBox1.Text = " ";
                textBox2.Text = " ";
                textBox3.Text = " ";
                textBox4.Text = " ";
                textBox5.Text = " ";
            }
            catch
            {
                string message1 = "Deletion Error";
                string title1 = "Deletion Error!!";
                MessageBox.Show(message1, title1);
            }
        
        

            
            
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=MOHAMED_HANI;Initial Catalog=DB_project;Integrated Security=True");
                con.Open();
                SqlCommand cmd1 = new SqlCommand("insert into sign_up values(@id,@user_namee2,@User_Pass,@Age,@Gender)", con);
                cmd1.Parameters.AddWithValue("@id", int.Parse(textBox3.Text));
                cmd1.Parameters.AddWithValue("@user_namee2", textBox1.Text);
                cmd1.Parameters.AddWithValue("@User_Pass", textBox2.Text);
                cmd1.Parameters.AddWithValue("@Age", int.Parse(textBox4.Text));
                cmd1.Parameters.AddWithValue("@Gender", textBox5.Text);
                cmd1.ExecuteNonQuery();
                con.Close();
                string message1 = "Insertion Done";
                string title1 = "Insertion Succsess!!";
                MessageBox.Show(message1, title1);
                textBox1.Text = " ";
                textBox2.Text = " ";
                textBox3.Text = " ";
                textBox4.Text = " ";
                textBox5.Text = " ";
            }
            catch
            {
                string message = "ID Already Taken\nTry Another One";
                string title = "Insertion Error!!";
                MessageBox.Show(message, title);

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 fr8 = new Form8();
            fr8.Show();
            this.Hide();
            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.OpenForms[1].Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form10 fr10 = new Form10();
            fr10.Show();
            this.Hide();
        }
    }
}
