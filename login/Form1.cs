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
        string user, pass;
       //133
       
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string MySQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=dairysystem";

            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
            databaseConnection.Open();
            MySqlCommand commandDatabase = new MySqlCommand("select username,password from staffs where username= '" + username.Text + "'", databaseConnection);
            {
                //MessageBox.Show("retriving");
                var reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    int i;
                    i = 0;

                    var name = reader.GetString(i);
                    user = name;
                    //MessageBox.Show(user);
                    i++;
                    pass = reader.GetString(i);
                    
                    if (name == null ||username.Text==null || textBox2.Text==null)
                        MessageBox.Show("enter a valid user creditential");
                }
                
               /* if (username.Text == null || textBox2.Text == null)
                        MessageBox.Show("enter a valid user creditential");*/

                if (username.Text==user && textBox2.Text==pass)
                    {
                    this.Hide();
                    Form2 f2 = new Form2();
                    f2.Show(); 
                     }
                else if(username.Text == "" || textBox2.Text == "")
                    {
                        MessageBox.Show("user creditentials cannot be empty");
                    }
                else
                {
                    MessageBox.Show("Enter valid user creditentials");
                }
                commandDatabase.CommandTimeout = 60;
                databaseConnection.Close();

            }

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
