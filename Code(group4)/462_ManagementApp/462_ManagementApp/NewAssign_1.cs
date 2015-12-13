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
                try
                {
                    string MyConnection3 = "datasource=localhost;port=3306;username=root;password=admin";
                    string Query = "insert into project.assignments(Assignment,UserAssigned,DueDate,Details) values('" + this.textBox1.Text + "','" + this.textBox2.Text + "','" + this.dateTimePicker1.Text + "','" + this.textBox4.Text + "');";
                    MySqlConnection MyConn3 = new MySqlConnection(MyConnection3);
                    MySqlCommand MyCommand3 = new MySqlCommand(Query, MyConn3);
                    MySqlDataReader MyReader3;
                    MyConn3.Open();
                    MyReader3 = MyCommand3.ExecuteReader();
                    while (MyReader3.Read())
                    {

                    }
                    MessageBox.Show("Assignment Added");
                    MyConn3.Close();
                    this.Hide();
                    Main mi = new Main();
                    mi.Refresh();
                    mi.Update();
                    mi.Validate();
                   
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

    }
    }

