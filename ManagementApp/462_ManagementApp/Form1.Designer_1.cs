namespace _462_ManagementApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SignInPage = new System.Windows.Forms.TabPage();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.companynamelabel = new System.Windows.Forms.Label();
            this.PasswordTxtBox = new System.Windows.Forms.TextBox();
            this.UsernameTxtBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.SignInButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.SignInPage.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SignInPage
            // 
            this.SignInPage.BackColor = System.Drawing.Color.Transparent;
            this.SignInPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SignInPage.BackgroundImage")));
            this.SignInPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SignInPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SignInPage.Controls.Add(this.textBoxID);
            this.SignInPage.Controls.Add(this.companynamelabel);
            this.SignInPage.Controls.Add(this.PasswordTxtBox);
            this.SignInPage.Controls.Add(this.UsernameTxtBox);
            this.SignInPage.Controls.Add(this.PasswordLabel);
            this.SignInPage.Controls.Add(this.UsernameLabel);
            this.SignInPage.Controls.Add(this.SignInButton);
            this.SignInPage.Location = new System.Drawing.Point(4, 25);
            this.SignInPage.Margin = new System.Windows.Forms.Padding(4);
            this.SignInPage.Name = "SignInPage";
            this.SignInPage.Padding = new System.Windows.Forms.Padding(4);
            this.SignInPage.Size = new System.Drawing.Size(1292, 682);
            this.SignInPage.TabIndex = 0;
            this.SignInPage.Text = "SignIn";
            this.SignInPage.Click += new System.EventHandler(this.SignInPage_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(1173, 649);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 22);
            this.textBoxID.TabIndex = 7;
            this.textBoxID.Visible = false;
            // 
            // companynamelabel
            // 
            this.companynamelabel.BackColor = System.Drawing.Color.Transparent;
            this.companynamelabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companynamelabel.Location = new System.Drawing.Point(44, 50);
            this.companynamelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.companynamelabel.Name = "companynamelabel";
            this.companynamelabel.Size = new System.Drawing.Size(428, 87);
            this.companynamelabel.TabIndex = 6;
            this.companynamelabel.Text = "Assignex Inc.";
            this.companynamelabel.Click += new System.EventHandler(this.companynamelabel_Click);
            // 
            // PasswordTxtBox
            // 
            this.PasswordTxtBox.BackColor = System.Drawing.Color.CornflowerBlue;
            this.PasswordTxtBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTxtBox.Location = new System.Drawing.Point(948, 274);
            this.PasswordTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordTxtBox.Name = "PasswordTxtBox";
            this.PasswordTxtBox.Size = new System.Drawing.Size(285, 39);
            this.PasswordTxtBox.TabIndex = 4;
            this.PasswordTxtBox.TextChanged += new System.EventHandler(this.PasswordTxtBox_TextChanged);
            // 
            // UsernameTxtBox
            // 
            this.UsernameTxtBox.BackColor = System.Drawing.Color.CornflowerBlue;
            this.UsernameTxtBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTxtBox.Location = new System.Drawing.Point(948, 184);
            this.UsernameTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.UsernameTxtBox.Name = "UsernameTxtBox";
            this.UsernameTxtBox.Size = new System.Drawing.Size(285, 39);
            this.UsernameTxtBox.TabIndex = 3;
            this.UsernameTxtBox.TextChanged += new System.EventHandler(this.UsernameTxtBox_TextChanged);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(942, 236);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(160, 32);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Password:";
            this.PasswordLabel.Click += new System.EventHandler(this.PasswordLabel_Click);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UsernameLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(938, 145);
            this.UsernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(165, 32);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "Username:";
            this.UsernameLabel.Click += new System.EventHandler(this.UsernameLabel_Click);
            // 
            // SignInButton
            // 
            this.SignInButton.BackColor = System.Drawing.Color.GreenYellow;
            this.SignInButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SignInButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInButton.Location = new System.Drawing.Point(946, 338);
            this.SignInButton.Margin = new System.Windows.Forms.Padding(4);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(287, 49);
            this.SignInButton.TabIndex = 0;
            this.SignInButton.Text = "Sign in";
            this.SignInButton.UseVisualStyleBackColor = false;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.SignInPage);
            this.tabControl1.Location = new System.Drawing.Point(-7, -22);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1300, 711);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 690);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "ManagementApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SignInPage.ResumeLayout(false);
            this.SignInPage.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage SignInPage;
        private System.Windows.Forms.Label companynamelabel;
        private System.Windows.Forms.TextBox PasswordTxtBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TextBox UsernameTxtBox;
        private System.Windows.Forms.TextBox textBoxID;


    }
}

