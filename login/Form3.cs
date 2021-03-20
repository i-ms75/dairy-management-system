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
    public partial class Form3 : Form
    {
       /* private int fatt;
        private int fnff;*/

        public Form3()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* string fat,fnf;
            int fatt, fnff;
            
            */

        }

        public void button3_Click(object sender, EventArgs e)
        {
            int rate, fat, snf;
            fat =Convert.ToInt32("textBox1.Text");
            snf = Convert.ToInt32("textBox2.Text");
            fat = Convert.ToInt32(fat);
            snf = Convert.ToInt32(snf);
            rate = fat * snf;
            MessageBox.Show(rate.ToString());
         

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string MySQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=dairysystem";

            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
            databaseConnection.Open();
            MySqlCommand commandDatabase = new MySqlCommand("insert into milk(date,f_id,animal,shift,fat,snf,quantity) values('" + textBox5.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox4.Text + "')", databaseConnection);
            commandDatabase.ExecuteNonQuery();
            commandDatabase.CommandTimeout = 60;
            databaseConnection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string MySQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=dairysystem";

            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
            databaseConnection.Open();
            /*int frm = Convert.ToInt32(textBox3.Text);*/
            MySqlCommand commandDatabase = new MySqlCommand("select name from farmer where id= '"+textBox3.Text+"'", databaseConnection);
            commandDatabase.ExecuteNonQuery();
            /*int result = (Int32)(commandDatabase.ExecuteScalar());*/
            commandDatabase.CommandTimeout = 60;
            databaseConnection.Close();
        }
    }
}
