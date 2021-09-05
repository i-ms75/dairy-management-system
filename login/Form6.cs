/*using System;
using System.Collections;
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
    public partial class Form6 : Form
    {
        ArrayList item_nam = new ArrayList();
        ArrayList qty = new ArrayList();
        ArrayList rate = new ArrayList();
        ArrayList total = new ArrayList();
        ArrayList ListID = new ArrayList();


        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
            MySqlCommand commandDatabase = new MySqlCommand("SELECT serial,item_name,quantity,rate,total FROM `sales` WHERE date BETWEEN '2021-08-23' AND '2021-08-26'", databaseConnection);
            {
                //MessageBox.Show("retriving");
                var reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    /* int i;
                     i = 0;
                     al.Add(reader.GetString(i));
                    // MessageBox.Show(Convert.ToString(al));

                     //dataGridView1.DataSource = reader.GetString(i);


                     //MessageBox.Show(reader.GetString(i));
                     //user = name;
                     //MessageBox.Show(user);
                     i++;
                     //textBox1.Text = Convert.ToString(reader.GetString(i));
                     //pass = reader.GetString(i);
                     dataGridView1= al;
                    */
                  /*  ListID.Add(reader["serial"].ToString());
                    item_nam.Add(reader["item_name"].ToString());
                    qty.Add(reader["quantity"].ToString());
                    rate.Add(reader["rate"].ToString());
                    total.Add(reader["total"].ToString());
                    dataGridView1.DataSource = item_nam.Add(reader["item_name"].ToString());*/*/



                    //dataGridView1.Rows.Clear();

                    /*for (int i = 0; i < 10; i++)
                    {

                        DataGridViewRow newRow = new DataGridViewRow();
                        newRow.CreateCells(dataGridView1);
                        dataGridView1.ColumnCount = 5;
                        //newRow.CreateCells.Column1=


                        newRow.Cells[0].Value = ListID[i];
                        newRow.Cells[1].Value = item_nam[i];
                        newRow.Cells[2].Value = qty[i];
                        newRow.Cells[3].Value = rate[i];
                        newRow.Cells[4].Value = total[i];
                        dataGridView1.Rows.Add(newRow);*/

             /*   }



                    
                    
                    commandDatabase.CommandTimeout = 60;
                databaseConnection.Close();
               }
             
                
            }
            

            /**/
      /*  }
    }*/
      
