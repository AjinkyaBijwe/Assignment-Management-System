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
    public partial class Modify : Form
    {
        public Modify()
        {
            InitializeComponent();
            Fillcombo();
        }

        void Fillcombo() {
           // if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
          //  {
               // MessageBox.Show("Please enter the blank fields!");

           // }
            Main m = new Main();

            try
            {
                string MyConnection3 = "datasource=localhost;port=3306;username=root;password=admin";
                string Query = "select Assignment from project.assignments where assignor = '" + m.label17.Text + "';";
                MySqlConnection MyConn3 = new MySqlConnection(MyConnection3);
                MySqlCommand MyCommand3 = new MySqlCommand(Query, MyConn3);
                MySqlDataReader MyReader3;
                MyConn3.Open();
                MyReader3 = MyCommand3.ExecuteReader();
                 while (MyReader3.Read())
                {
                    string sName = MyReader3.GetString("Assignment");
                    comboBox1.Items.Add(sName);
                }
                      MyConn3.Close();
                            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

          private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
              try
            {
                string MyConnection3 = "datasource=localhost;port=3306;username=root;password=admin";
                string Query = "select * from project.assignments where Assignment = '"+ comboBox1.Text +"';";
                MySqlConnection MyConn3 = new MySqlConnection(MyConnection3);
                MySqlCommand MyCommand3 = new MySqlCommand(Query, MyConn3);
                MySqlDataReader MyReader3;
                MyConn3.Open();
                MyReader3 = MyCommand3.ExecuteReader();
                while (MyReader3.Read())
                {
                       string Primary = MyReader3.GetInt32("ID").ToString();
                       string UserAssign = MyReader3.GetString("UserAssigned");
                       string DueDate = MyReader3.GetString("DueDate");
                       string Details = MyReader3.GetString("Details");
                       textBox3.Text = Primary;
                       textBox1.Text = UserAssign;
                       checkedListBox1.Text = UserAssign;
                       dateTimePicker1.Text = DueDate;
                       textBox2.Text = Details;
                }
                      MyConn3.Close();
                            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                textBox4.Text += liItem.ToString() + " ";
            }

            if (textBox1.Text == "" || textBox2.Text == "" || dateTimePicker1.Text == "" || textBox4.Text == "" || textBox3.Text == "")
                {
                    MessageBox.Show("Please Enter the Blank Fields!");

                }


            else
            {

          
                try
                {
                    string MyConnection3 = "datasource=localhost;port=3306;username=root;password=admin";
                    string Query = "update project.assignments set UserAssigned='" + this.textBox4.Text + "',DueDate='" + this.dateTimePicker1.Text + "',Details='" + this.textBox2.Text + "' WHERE ID= " + this.textBox3.Text + ";";
                    MySqlConnection MyConn3 = new MySqlConnection(MyConnection3);
                    MySqlCommand MyCommand3 = new MySqlCommand(Query, MyConn3);
                    MySqlDataReader MyReader3;
                    MyConn3.Open();
                    MyReader3 = MyCommand3.ExecuteReader();
                    while (MyReader3.Read())
                    {
                    }
                    MessageBox.Show("Assignment Modified");
                    MyConn3.Close();
                    this.Hide();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Now;
        }
        
        }
    }

