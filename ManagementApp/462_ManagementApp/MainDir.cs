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
    public partial class MainDir : Form
    {
       public MainDir()
        {
            InitializeComponent();
            Fillcombo2();
            BodyControl.SelectedIndexChanged += new EventHandler(BodyControl_Selected);
            BodyControl.Appearance = TabAppearance.Normal;
            BodyControl.ItemSize = new Size(0, 1);
            BodyControl.SizeMode = TabSizeMode.Fixed;
           
           
        }


        private void BodyControl_Selected(object sender, EventArgs e)
        {
             if (BodyControl.SelectedTab == AssignmentsPage)
            {
                try
                {
                    String myConnection1 = "datasource=localhost;port=3306;username=root;password=admin";
                    MySqlConnection myConn1 = new MySqlConnection(myConnection1);
                    MySqlCommand cmdDataBase = new MySqlCommand("select Assignor, Details, DueDate, UserAssigned, Assignment, ID from project.assignments where Department = '" + label16.Text + "';", myConn1);
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = cmdDataBase;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    dataGridView1.BringToFront();
                    BindingSource bsource = new BindingSource();
                    bsource.DataSource = dbdataset;
                    dataGridView1.DataSource = bsource;
                    sda.Update(dbdataset);
                }
                catch (Exception exx)
                {
                    MessageBox.Show(exx.Message);
                }

            }

             if (BodyControl.SelectedTab == AuthorizePage)
             {
                 try
                 {
                     string MyConnection4 = "datasource=localhost;port=3306;username=root;password=admin";
                     string Query = "SELECT ID, assignment, UserAssigned, DueDate, Details, SetAuthorization, Assignor from project.assignments WHERE SetAuthorization ='Pending' and Department = '" + label16.Text + "';";
                     MySqlConnection MyConn4 = new MySqlConnection(MyConnection4);
                     MySqlCommand MyCommand4 = new MySqlCommand(Query, MyConn4);
                     MyConn4.Open();
                     MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                     MyAdapter.SelectCommand = MyCommand4;
                     DataTable dTable = new DataTable();
                     dataGridView5.BringToFront();
                     MyAdapter.Fill(dTable);
                     dataGridView5.DataSource = dTable;
                     MyConn4.Close();
                     
                 }
                 catch (Exception ex1)
                 {
                     MessageBox.Show(ex1.Message);
                 }

                 try
                 {
                     string MyConnection388 = "datasource=localhost;port=3306;username=root;password=admin";
                     string Query = "select distinct Assignment from project.assignments where SetAuthorization = 'Pending' and Department = '" + label16.Text + "';";
                     MySqlConnection MyConn388 = new MySqlConnection(MyConnection388);
                     MySqlCommand MyCommand388 = new MySqlCommand(Query, MyConn388);
                     MySqlDataReader MyReader388;
                     MyConn388.Open();
                     MyReader388 = MyCommand388.ExecuteReader();
                     while (MyReader388.Read())
                     {
                         string sName = MyReader388.GetString("Assignment");
                         // comboBox2.Items.Add(sName);
                         if (!comboBox1.Items.Contains(sName))
                             comboBox1.Items.Add(sName);
                     }
                     MyConn388.Close();
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show(ex.Message);
                 }
             }


      


            if (BodyControl.SelectedTab == DetailsPage)
            {
                try
                {
                    string MyConnection44 = "datasource=localhost;port=3306;username=root;password=admin";
                    string Query = "SELECT * FROM project.log;";
                    MySqlConnection MyConn44 = new MySqlConnection(MyConnection44);
                    MySqlCommand MyCommand44 = new MySqlCommand(Query, MyConn44);
                    MyConn44.Open();
                    MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                    MyAdapter.SelectCommand = MyCommand44;
                    DataTable dTable = new DataTable();
                    dataGridView4.BringToFront();
                    MyAdapter.Fill(dTable);
                    dataGridView4.DataSource = dTable;
                    MyConn44.Close();
                    
                }
                catch (Exception ex1)
                {
                    MessageBox.Show(ex1.Message);
                }
             
            }
        }

        void Fillcombo2()
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

        private void AssignmentsTabControl_SelectAssignmentsPage_Click(object sender, EventArgs e)
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void HomePage_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewAssign f2 = new NewAssign();
            f2.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f3 = new Form1();
            f3.ShowDialog();
        }

        


        private void label1_Click(object sender, EventArgs e)
        {
            {
               
            }
        }

        private void Assign_Click_1(object sender, EventArgs e)
        {

        }

                      
   
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                String myConnection1 = "datasource=localhost;port=3306;username=root;password=admin";
                MySqlConnection myConn1 = new MySqlConnection(myConnection1);
                MySqlCommand cmdDataBase = new MySqlCommand("select Details, DueDate, UserAssigned, Assignment, ID from project.assignments;", myConn1);
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                dataGridView1.BringToFront();
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dbdataset;
                dataGridView1.DataSource = bsource;
                sda.Update(dbdataset);
                this.Refresh();
            }
            catch (Exception exx)
            {
                MessageBox.Show(exx.Message);
            }
        }
        

        private void signOutToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
           

        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            
            try
            {
                string MyConnection4 = "datasource=localhost;port=3306;username=root;password=admin";
                string Query = "SELECT assignment, id, SetAuthorization FROM project.assignments WHERE SetAuthorization ='Pending';";
                MySqlConnection MyConn4 = new MySqlConnection(MyConnection4);
                MySqlCommand MyCommand4 = new MySqlCommand(Query, MyConn4);
                MyConn4.Open();
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand4;
                DataTable dTable = new DataTable();
                dataGridView2.BringToFront();
                MyAdapter.Fill(dTable);
                dataGridView2.DataSource = dTable;
                MyConn4.Close();
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message);
            }
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void LogEntryTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void newAssignmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Assignments on HOMEPAGE
            BodyControl.SelectedTab = AssignmentsPage;
        }

        private void homeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //HOME PAGE ON ASSIGNMENTS
            BodyControl.SelectedTab = HomePage;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MODIFY BUTTON
            Modify f5 = new Modify();
            f5.ShowDialog();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //
        }

        private void ViewAssignDetailsButton_Click(object sender, EventArgs e)
        {
            //VIEW ASSIGNMENT DETAILS
           
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Details Page FOR HOME
            BodyControl.SelectedTab = HomePage;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //DETAILS PAGE FOR ASSIGNMENTS
            BodyControl.SelectedTab = AssignmentsPage;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            //SIGNOUT FOR DETAILS PAGE
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            //MODIFY ASSIGNMENTS TO GO TO HOME
            BodyControl.SelectedTab = HomePage;
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            //MODIFY ASSIGNMENTS TO GO TO ASSIGNMENTS
            BodyControl.SelectedTab = AssignmentsPage;
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            //SIGNOUT FROM THE MODIFY ASSIGNMENTS PAGE
        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {
            //Modify button
            //CHECK FOR THE DATE TIME IF IT IS PASSED OR NOT
            //dateTimePicker1;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //private void dataGridView1_CellButtonClick(object sender, DataGridViewCellEventArgs e)
        private void dataGridView1_CellButtonClick(object sender, DataGridViewCellEventArgs e)
        {
             
        }



        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

           
        }

        private void DetailsTab_Click(object sender, EventArgs e)
        {

        }

        private void AssignmentsPage_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
        }

        private void button8_Click(object sender, EventArgs e)
        {

            
            
        }

        private void StatusLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void signOutToolStripMenuItem1_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            Form f3 = new Form1();
            f3.ShowDialog();
        }

        private void signOutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form f3 = new Form1();
            f3.ShowDialog();
        }

        private void signOutToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f3 = new Form1();
            f3.ShowDialog();
        }

        private void signOutToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form f3 = new Form1();
            f3.ShowDialog();
        }

        private void signOutToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f3 = new Form1();
            f3.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                String myConnection1 = "datasource=localhost;port=3306;username=root;password=admin";
                MySqlConnection myConn1 = new MySqlConnection(myConnection1);
                MySqlCommand cmdDataBase = new MySqlCommand("select Assignor, Details, DueDate, UserAssigned, Assignment, ID from project.assignments where Department = '" + label16.Text + "';", myConn1);
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                dataGridView1.BringToFront();
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dbdataset;
                dataGridView1.DataSource = bsource;
                sda.Update(dbdataset);
                this.Refresh();
            }
            catch (Exception exx)
            {
                MessageBox.Show(exx.Message);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
             try
            {
                string MyConnection4 = "datasource=localhost;port=3306;username=root;password=admin";
                string Query = "SELECT Assignor, Assignment, ID, SetAuthorization FROM project.assignments WHERE SetAuthorization ='Pending' and Department = '" + label16.Text + "';";
                MySqlConnection MyConn4 = new MySqlConnection(MyConnection4);
                MySqlCommand MyCommand4 = new MySqlCommand(Query, MyConn4);
                MyConn4.Open();
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand4;
                DataTable dTable = new DataTable();
                dataGridView2.BringToFront();
                MyAdapter.Fill(dTable);
                dataGridView2.DataSource = dTable;
                MyConn4.Close();
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message);
            }
            
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            try
            {
                string MyConnection41 = "datasource=localhost;port=3306;username=root;password=admin";
                string Query = "SELECT Assignor, Assignment, ID, SetAuthorization FROM project.assignments WHERE SetAuthorization ='Complete';";
                MySqlConnection MyConn41 = new MySqlConnection(MyConnection41);
                MySqlCommand MyCommand41 = new MySqlCommand(Query, MyConn41);
                MyConn41.Open();
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand41;
                DataTable dTable = new DataTable();
                dataGridView3.BringToFront();
                MyAdapter.Fill(dTable);
                dataGridView3.DataSource = dTable;
                MyConn41.Close();
            }
            catch (Exception ex11)
            {
                MessageBox.Show(ex11.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                string MyConnection33 = "datasource=localhost;port=3306;username=root;password=admin";
                string Query = "select * from project.assignments where Assignment = '" + comboBox1.Text + "';";
                MySqlConnection MyConn33 = new MySqlConnection(MyConnection33);
                MySqlCommand MyCommand33 = new MySqlCommand(Query, MyConn33);
                MySqlDataReader MyReader33;
                MyConn33.Open();
                MyReader33 = MyCommand33.ExecuteReader();
                while (MyReader33.Read())
                {
                    string Primary = MyReader33.GetInt32("ID").ToString();
                    textBox1.Text = Primary;

                }
                MyConn33.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            this.comboBox1.Items.Clear();
            try
            {
                string MyConnection388 = "datasource=localhost;port=3306;username=root;password=admin";
                string Query = "select distinct Assignment from project.assignments where SetAuthorization = 'Pending' and Department = '" + label16.Text + "';";
                MySqlConnection MyConn388 = new MySqlConnection(MyConnection388);
                MySqlCommand MyCommand388 = new MySqlCommand(Query, MyConn388);
                MySqlDataReader MyReader388;
                MyConn388.Open();
                MyReader388 = MyCommand388.ExecuteReader();
                while (MyReader388.Read())
                {
                    string sName = MyReader388.GetString("Assignment");
                    comboBox1.Items.Add(sName);
                    if (!comboBox1.Items.Contains(sName))
                        comboBox1.Items.Contains(sName);
                }
                MyConn388.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                string MyConnection4 = "datasource=localhost;port=3306;username=root;password=admin";
                string Query = "SELECT ID, Assignment, UserAssigned, DueDate, Details, SetAuthorization, Assignor from project.assignments WHERE SetAuthorization ='Pending' and Department = '" + label16.Text + "';";
                MySqlConnection MyConn4 = new MySqlConnection(MyConnection4);
                MySqlCommand MyCommand4 = new MySqlCommand(Query, MyConn4);
                MyConn4.Open();
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand4;
                DataTable dTable = new DataTable();
                dataGridView5.BringToFront();
                MyAdapter.Fill(dTable);
                dataGridView5.DataSource = dTable;
                MyConn4.Close();
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message);
            }
           
      
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            
            try
            {
                string MyConnection3 = "datasource=localhost;port=3306;username=root;password=admin";
                string Query = "update project.assignments set SetAuthorization = 'Complete' WHERE ID= " + textBox1.Text + ";";
                MySqlConnection MyConn3 = new MySqlConnection(MyConnection3);
                MySqlCommand MyCommand3 = new MySqlCommand(Query, MyConn3);
                MySqlDataReader MyReader3;
                MyConn3.Open();
                MyReader3 = MyCommand3.ExecuteReader();
                MessageBox.Show("Assignment Authorized");
                while (MyReader3.Read())
                {
                }
                MyConn3.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            try
            {
                string MyConnection4 = "datasource=localhost;port=3306;username=root;password=admin";
                string Query = "SELECT ID, Assignment, UserAssigned, DueDate, Details, SetAuthorization, Assignor from project.assignments WHERE SetAuthorization ='Pending' and Department = '" + label16.Text + "';";
                MySqlConnection MyConn4 = new MySqlConnection(MyConnection4);
                MySqlCommand MyCommand4 = new MySqlCommand(Query, MyConn4);
                MyConn4.Open();
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand4;
                DataTable dTable = new DataTable();
                dataGridView5.BringToFront();
                MyAdapter.Fill(dTable);
                dataGridView5.DataSource = dTable;
                MyConn4.Close();
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message);
            }
            this.comboBox1.Items.Clear();
            try
            {
                string MyConnection388 = "datasource=localhost;port=3306;username=root;password=admin";
                string Query = "select distinct Assignment from project.assignments where SetAuthorization = 'Pending' and Department = '" + label16.Text + "';";
                MySqlConnection MyConn388 = new MySqlConnection(MyConnection388);
                MySqlCommand MyCommand388 = new MySqlCommand(Query, MyConn388);
                MySqlDataReader MyReader388;
                MyConn388.Open();
                MyReader388 = MyCommand388.ExecuteReader();
                while (MyReader388.Read())
                {
                    string sName = MyReader388.GetString("Assignment");
                    comboBox1.Items.Add(sName);
                 if (!comboBox1.Items.Contains(sName))
                     comboBox1.Items.Contains(sName);
                }
                MyConn388.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox3_SelectedIndexChanged_1(object sender, EventArgs e)
        {
    
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            try
            {
                string MyConnection44 = "datasource=localhost;port=3306;username=root;password=admin";
                string Query = "SELECT * FROM project.log;";
                MySqlConnection MyConn44 = new MySqlConnection(MyConnection44);
                MySqlCommand MyCommand44 = new MySqlCommand(Query, MyConn44);
                MyConn44.Open();
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand44;
                DataTable dTable = new DataTable();
                dataGridView4.BringToFront();
                MyAdapter.Fill(dTable);
                dataGridView4.DataSource = dTable;
                MyConn44.Close();
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message);
            }
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            if (textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Please enter the blank fields!");

            }
            else
            {

         
            }
        }

        private void toolStripMenuItem4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form f3 = new Form1();
            f3.ShowDialog();
        }

        private void signOutToolStripMenuItem1_Click_3(object sender, EventArgs e)
        {
            this.Hide();
            Form f3 = new Form1();
            f3.ShowDialog();
        }

        private void signOutToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            Form f3 = new Form1();
            f3.ShowDialog();
        }

        private void signOutToolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form f3 = new Form1();
            f3.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox8.Text = row.Cells["Assignment"].Value.ToString();
                textBox7.Text = row.Cells["UserAssigned"].Value.ToString();
                textBox4.Text = row.Cells["ID"].Value.ToString();
                textBox5.Text = row.Cells["DueDate"].Value.ToString();
                textBox2.Text = row.Cells["Details"].Value.ToString();
                BodyControl.SelectedTab = DetailsPage;
            }

            try
            {
                string MyConnection44 = "datasource=localhost;port=3306;username=root;password=admin";
                string Query = "SELECT * FROM project.log where Assignment = '" + this.textBox8.Text + "';";
                MySqlConnection MyConn44 = new MySqlConnection(MyConnection44);
                MySqlCommand MyCommand44 = new MySqlCommand(Query, MyConn44);
                MyConn44.Open();
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand44;
                DataTable dTable = new DataTable();
                dataGridView4.BringToFront();
                MyAdapter.Fill(dTable);
                dataGridView4.DataSource = dTable;
                MyConn44.Close();
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message);
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

            try
            {
                string MyConnection44 = "datasource=localhost;port=3306;username=root;password=admin";
                string Query = "SELECT * FROM project.log where Assignment = '" + this.textBox8.Text + "';";
                MySqlConnection MyConn44 = new MySqlConnection(MyConnection44);
                MySqlCommand MyCommand44 = new MySqlCommand(Query, MyConn44);
                MyConn44.Open();
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand44;
                DataTable dTable = new DataTable();
                dataGridView4.BringToFront();
                MyAdapter.Fill(dTable);
                dataGridView4.DataSource = dTable;
                MyConn44.Close();
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                MessageBox.Show("Log Can't Be Empty Please Enter the Log !!");
            }
            else
            {
                try
                {
                    string MyConnection88 = "datasource=localhost;port=3306;username=root;password=admin";
                    string Query = "insert into project.log(Assignment,Logger,Designation,Log) values('" + this.textBox8.Text + "','" + this.PassNameLbl1.Text + "','" + this.label12.Text + "', '" + this.textBox6.Text + "');";
                    MySqlConnection MyConn88 = new MySqlConnection(MyConnection88);
                    MySqlCommand MyCommand88 = new MySqlCommand(Query, MyConn88);
                    MySqlDataReader MyReader88;
                    MyConn88.Open();
                    MyReader88 = MyCommand88.ExecuteReader();
                    MessageBox.Show("Log Entered");
                    while (MyReader88.Read())
                    {
                    }
                    MyConn88.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                try
                {
                    string MyConnection44 = "datasource=localhost;port=3306;username=root;password=admin";
                    string Query = "SELECT * FROM project.log where Assignment = '" + this.textBox8.Text + "';";
                    MySqlConnection MyConn44 = new MySqlConnection(MyConnection44);
                    MySqlCommand MyCommand44 = new MySqlCommand(Query, MyConn44);
                    MyConn44.Open();
                    MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                    MyAdapter.SelectCommand = MyCommand44;
                    DataTable dTable = new DataTable();
                    dataGridView4.BringToFront();
                    MyAdapter.Fill(dTable);
                    dataGridView4.DataSource = dTable;
                    MyConn44.Close();
                }
                catch (Exception ex1)
                {
                    MessageBox.Show(ex1.Message);
                }
            }
        }

        private void BodyControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip5_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ID_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void PassNameLbl1_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip4_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void HomePage_Click_2(object sender, EventArgs e)
        {

        }

        private void PassNameLbl_Click(object sender, EventArgs e)
        {

        }

        private void employeeIDLabel2_Click_1(object sender, EventArgs e)
        {

        }

        private void EmployeeIDLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void StatusLabel_Click_2(object sender, EventArgs e)
        {

        }

        private void CompanyNameLabel2_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void AssignmentsLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView5_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void AssignmentsPage_Click_2(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            //H to H
            BodyControl.SelectedTab = HomePage;
        }

        private void assignmentsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //H to A
            BodyControl.SelectedTab = AssignmentsPage;
        }

        private void authorizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //H to Auth
            BodyControl.SelectedTab = AuthorizePage; 
        }

        private void homeToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            //A to h
            BodyControl.SelectedTab = HomePage;
        }

        private void assignmentsToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            //A to A
            BodyControl.SelectedTab = AssignmentsPage;
        }

        private void authorizationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //A to authu
            BodyControl.SelectedTab = AuthorizePage;
        }

        private void homeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //Auth to H
            BodyControl.SelectedTab = HomePage;
        }

        private void assignmentsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //Auth to A
            BodyControl.SelectedTab = AssignmentsPage;
        }

        private void authorizationToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //AUTH TO AUTH
            BodyControl.SelectedTab = AuthorizePage;
        }

        private void homeToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //D to H
            BodyControl.SelectedTab = HomePage;
        }

        private void assignmentsToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //D to a
            BodyControl.SelectedTab = AssignmentsPage;
        }

        private void authorizationToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //D to Auth
            BodyControl.SelectedTab = AuthorizePage;
        }

        private void helpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form f1 = new help();
            f1.Show();
        }

        private void helpToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Form f1 = new help();
            f1.Show();
        }

        private void helpToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form f1 = new help();
            f1.Show();
        }

        private void helpToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form f1 = new help();
            f1.Show();
        }

        private void MainDir_Load(object sender, EventArgs e)
        {

        }




        
    }

       
        }