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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string MySQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=dairysystem";

            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
            databaseConnection.Open();
            int id = Convert.ToInt32(textBox1.Text);
            MySqlCommand commandDatabase = new MySqlCommand("select name from staffs where id= '" + id + "'", databaseConnection);
            {
                var reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {

                    var name = reader.GetString(0);
                    if (name == null)
                        MessageBox.Show("enter a valid id");
                    textBox2.Text = name;




                }

                commandDatabase.CommandTimeout = 60;
                databaseConnection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string MySQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=dairysystem";

            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
            databaseConnection.Open();
            int id = Convert.ToInt32(textBox1.Text);
            MySqlCommand commandDatabase = new MySqlCommand("DELETE FROM `staffs` WHERE `staffs`.`id` ='" + id + "'", databaseConnection);
            {
                MessageBox.Show("Staff deleted successfully");
            }

            commandDatabase.CommandTimeout = 60;
            databaseConnection.Close();

        }

    }
}
