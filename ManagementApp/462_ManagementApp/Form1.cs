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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PasswordTxtBox.PasswordChar= '*';
           // tabControl1.Apperance = TabAppearance.Normal;
            tabControl1.Appearance = TabAppearance.Normal;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
        }

               
         private void SignInButton_Click(object sender, EventArgs e)
        {
            try
            {
                String myConnection = "datasource=localhost;port=3306;username=root;password=admin";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand SelectCommand = new MySqlCommand("select * from project.user where username='" + this.UsernameTxtBox.Text + "' and password='" + this.PasswordTxtBox.Text + "';", myConn);
                MySqlDataReader myReader;
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();
                int count = 0;
                while (myReader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    this.Hide();
                    string sName = myReader.GetString("Designation");
                    string Pass = myReader.GetString("password");
                    string ID = myReader.GetString("ID");
                    string dept = myReader.GetString("Department");
                    textBoxID.Text = ID;
                    textBox1.Text = dept;
                    if (Pass == ID)
                    {
                        
                        PassChange p = new PassChange();
                        p.label3.Text = UsernameTxtBox.Text;
                        p.ShowDialog();
                    }
                    else
                    {
                        if (sName == "Employee")
                        {
                            MainEmp f2 = new MainEmp();
                            f2.PassNameLbl.Text = UsernameTxtBox.Text;
                            f2.PassNameLbl1.Text = UsernameTxtBox.Text;
                            f2.IDlabel.Text = textBoxID.Text;
                            f2.label16.Text = textBox1.Text;
                            f2.ShowDialog();

                        }

                        if (sName == "Manager")
                        {
                            Main f2 = new Main();
                            f2.label17.Text = UsernameTxtBox.Text;
                            f2.PassNameLbl1.Text = UsernameTxtBox.Text;
                            f2.employeeIDLabel2.Text = textBoxID.Text;
                            f2.label20.Text = textBox1.Text;
                            f2.ShowDialog();
                        }

                        if (sName == "Director")
                        {
                            MainDir f2 = new MainDir();
                            f2.PassNameLbl.Text = UsernameTxtBox.Text;
                            f2.PassNameLbl1.Text = UsernameTxtBox.Text;
                            f2.employeeIDLabel2.Text = textBoxID.Text;
                            f2.label16.Text = textBox1.Text;
                            f2.ShowDialog();
                        }
                    }
                }
                else if (count > 1)
                {
                    MessageBox.Show("Duplicate Username and Password Exist .... Access Denied");
                }
                else
                    MessageBox.Show("Incorrect Username and Password ... Try Again");

                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
         private void Form1_Load(object sender, EventArgs e)
         {
             
         }
      
        private void UsernameTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

       private void PasswordTxtBox_TextChanged(object sender, EventArgs e)
        {
        
        }


        private void assignmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void WelcomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void HomeUsernameLabel_Click(object sender, EventArgs e)
        {
       
        }

        private void HomePage_Click(object sender, EventArgs e)
        {

        }

        private void companynamelabel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void AssignmentsLabel_Click(object sender, EventArgs e)
        {

        }

        private void Assign_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AssignmentsTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AssignmentsPage_Click(object sender, EventArgs e)
        {

        }

        private void PendingTab_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void homeToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void assignmentsToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void authorizationRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void signOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void employeeIDLabel2_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void StatusLabel_Click(object sender, EventArgs e)
        {

        }

        private void CompanyNameLabel2_Click(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void authorizeRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SignInPage_Click(object sender, EventArgs e)
        {

        }

        private void HelpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void CompanyLogoPix_Click(object sender, EventArgs e)
        {

        }

        private void PasswordLabel_Click(object sender, EventArgs e)
        {

        }

        private void UsernameLabel_Click(object sender, EventArgs e)
        {

        }

      

        
    }
}
