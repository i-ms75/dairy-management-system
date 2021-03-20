using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user,pass;
            user = username.Text;
            pass = textBox2.Text;
          /*  if (user == "" || pass == "")

                MessageBox.Show("username and passord cannot be empty");

            else
            {

                if (user == "Admin" && pass == "Admin")
                {
                    MessageBox.Show("logged in successfully");
                    this.Hide();
                    Form2 f2 = new Form2();
                    f2.Show();

                }
                else
                {
                    MessageBox.Show("incorrect username or password");
                }
            }*/
            MessageBox.Show("logged in successfully");
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
