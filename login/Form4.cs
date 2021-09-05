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

    public partial class Form4 : Form
    {

        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            /*Form2 f2 = new Form2();
            f2.Show();*/

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string MySQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=dairysystem";

            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
            databaseConnection.Open();
            MySqlCommand commandDatabase = new MySqlCommand("insert into sales(date,item_name,quantity,rate,total) values('" + date + "','" + comboBox1.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')", databaseConnection);
            commandDatabase.ExecuteNonQuery();
            commandDatabase.CommandTimeout = 60;
            databaseConnection.Close();
            MessageBox.Show("Submitted Successfully");
        }

        private void button4_Click(object sender, EventArgs e)
        {

           float qty, rate,total;
            //int total;
            qty = Convert.ToInt32(textBox1.Text);
            rate = Convert.ToInt32(textBox2.Text);
            total = qty*rate;
            textBox3.Text = Convert.ToString(total);
           // string date = dateTimePicker1.Value.ToString();
            
        }
    }
}
