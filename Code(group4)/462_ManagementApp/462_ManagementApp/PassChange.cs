using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _462_ManagementApp
{
    public partial class PassChange : Form
    {
        public PassChange()
        {
            InitializeComponent();
            textBox1.PasswordChar = '*';
            textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
                if (textBox1.Text.Length < 6)
                {
                    MessageBox.Show("Password Too Short Please Renter Password");
                    textBox1.Focus();
                }
                else if (textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("Please enter the blank fields!");
                }
                     else if (textBox1.Text != textBox2.Text)
                     {
                         MessageBox.Show("Passwords Did not Matched!!!");
                     }
                     
                     else
                     {
                         try
                     {
                         String myConnection = "datasource=localhost;port=3306;username=root;password=admin";
                         MySqlConnection myConn = new MySqlConnection(myConnection);
                         MySqlCommand SelectCommand = new MySqlCommand("Update project.user SET password = '" + this.textBox1.Text + "' WHERE username = '" + this.label3.Text + "';", myConn);
                         MySqlDataReader myReader;
                         myConn.Open();
                         myReader = SelectCommand.ExecuteReader();
                         while (myReader.Read())
                         {
                        
                         }
                         MessageBox.Show("Password Changed Successfully Login Again");
                         this.Hide();
                         Form1 f = new Form1();
                         f.ShowDialog();
                         
                     }
                         catch (Exception ex)
                         {
                             MessageBox.Show(ex.Message);
                         }
                    }
            
                }
            }
            
        }
    