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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string MySQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=dairysystem";

            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
            databaseConnection.Open();
            int id = Convert.ToInt32(ID.Text);
            MySqlCommand commandDatabase = new MySqlCommand("UPDATE farmer SET name ='"+name.Text+"',address = '"+address.Text+"',phone = '"+phone.Text+"' WHERE id= '"+id+ "'", databaseConnection);
            commandDatabase.ExecuteNonQuery();
            MessageBox.Show("Farmer updated");
            this.Hide();
            commandDatabase.CommandTimeout = 60;
            databaseConnection.Close();

        }
    }
}
