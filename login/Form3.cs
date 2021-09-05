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
        MySqlDataAdapter adp;
       // sqlCommand cb;
       DataSet ds;
       DataTable dt;
       DataRow dr;
        int rate, fat, snf, total,id;
        String name;
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
            
            fat =Convert.ToInt32(textBox1.Text);
            snf = Convert.ToInt32(textBox2.Text);
            fat = Convert.ToInt32(fat);
            snf = Convert.ToInt32(snf);
            rate = fat * snf;
            total = rate * Convert.ToInt32(textBox4.Text);
            textBox6.Text =Convert.ToString(rate);
            textBox7.Text = Convert.ToString(total);


            //MessageBox.Show(rate.ToString());
         

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

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
           // textBox8.Text = name;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string MySQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=dairysystem";

            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
            databaseConnection.Open();
            MySqlCommand commandDatabase = new MySqlCommand("insert into milk(date,f_id,animal,shift,fat,snf,quantity,rate,total) values('" + date + "','" + textBox3.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox4.Text + "','"+ rate+"','"+total+"')", databaseConnection);
            commandDatabase.ExecuteNonQuery();
            commandDatabase.CommandTimeout = 60;
            databaseConnection.Close();
            MessageBox.Show("Submitted Successfully");
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
           
            string MySQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=dairysystem";

            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
            databaseConnection.Open();
            /*int frm = Convert.ToInt32(textBox3.Text);*/
           id = Convert.ToInt32(textBox3.Text);

            //sqlDataAdapter adp;

          MySqlCommand commandDatabase = new MySqlCommand("select name from farmer where id= '" + id + "'", databaseConnection);
            {
               // MessageBox.Show("retriving");
                var reader = commandDatabase.ExecuteReader();
                while(reader.Read())
                {
                   
                    var name = reader.GetString(0);
                   // adp = name;
                   // MessageBox.Show(reader.GetString(0));
                    if (name == null)
                        MessageBox.Show("enter a valid id");
                    //dataGridView1.Rows.Add(name);
                    textBox8.Text = name;

                    //DataGridView dataGrid = new DataGridView();
                    /*dataGridView1.DataSource = reader.GetString(0);
                    adp.Fill(ds,"mydata");
                    dt = ds.Tables["mydata"];
                    dr = dt.Rows[0];
                    dataGridView1.DataSource = ds.Tables["mydata"];*/


                     
                }
                //   ds = new DataSet();
                // adp.Fill(ds);


                //  MessageBox.Show(ToString(commandDatabase.Rows[0].name));
                // Console.WriteLine(commandDatabase);
                //  MessageBox.Show(commandDatabase);
                // textBox8.Text(commandDatabase);

                // int output = (int)commandDatabase.ExecuteScalar();
                //string check=Convert.ToString(output);
                //  MessageBox.Show("query executed returning value");
                // Int tst = (Int32)databaseConnection.ExecuteScalar();


                //String name = commandDatabase.ExecuteScalar();
                // MessageBox.Show(tst);
                // commandDatabase.ExecuteNonQuery();
                //int result = (Int32)(commandDatabase.ExecuteScalar());
                //MessageBox.Show(check);
                // textBox8.Text(test);
                commandDatabase.CommandTimeout = 60;
                databaseConnection.Close();
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
