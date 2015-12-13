using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _462_ManagementApp
{
    public partial class NewAssign : Form
    {
        public NewAssign()
        {
            InitializeComponent();
          
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

     


        private void button1_Click(object sender, EventArgs e)
        { 
            
            foreach (string s in checkedListBox1.CheckedItems)
            {

                listBox1.Items.Add(s);
            }
            foreach (object liItem in listBox1.Items)
            {
                textBox2.Text += liItem.ToString() + " ";
            }

            if (textBox1.Text == "" || textBox2.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Please enter the blank fields!");
            }

            else
            {
                Main m = new Main();
                try
                {
                    string MyConnection3 = "datasource=localhost;port=3306;username=root;password=admin";
                    string Query = "insert into project.assignments(Assignment,UserAssigned,DueDate,Details,SetAuthorization,Assignor,Department) values('" + this.textBox1.Text + "','" + this.textBox2.Text + "','" + this.dateTimePicker1.Text + "','" + this.textBox4.Text + "','Null','" + this.textBox5.Text + "','" + this.textBox3.Text + "');";
                    MySqlConnection MyConn3 = new MySqlConnection(MyConnection3);
                    MySqlCommand MyCommand3 = new MySqlCommand(Query, MyConn3);
                    MySqlDataReader MyReader3;
                    MyConn3.Open();
                    MyReader3 = MyCommand3.ExecuteReader();
                    while (MyReader3.Read())
                    {

                    }
                    MessageBox.Show("Assignment Added Successfully");
                    MyConn3.Close();
                    this.Hide();
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Now;
        }

    }
    }

