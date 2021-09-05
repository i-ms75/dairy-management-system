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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string MySQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=dairysystem";

            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
            databaseConnection.Open();
            MySqlCommand commandDatabase = new MySqlCommand("insert into staffs(name,address,phone,username,designation,password) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','"+textBox5.Text+"','" + comboBox1.Text + "','"+textBox4.Text+"')", databaseConnection);
            commandDatabase.ExecuteNonQuery();
            commandDatabase.CommandTimeout = 60;
            databaseConnection.Close();
            MessageBox.Show("Employee added Successfully");
            this.Hide();
        }
    }
}
