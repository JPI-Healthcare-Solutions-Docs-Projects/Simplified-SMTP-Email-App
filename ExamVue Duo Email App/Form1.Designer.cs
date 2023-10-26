namespace ExamVue_Duo_Email_App
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.emailProvider = new System.Windows.Forms.Label();
            this.emailAddress = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.authentication = new System.Windows.Forms.LinkLabel();
            this.appPassword = new System.Windows.Forms.LinkLabel();
            this.gmailLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.close = new System.Windows.Forms.Button();
            this.send = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(34, 150);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.UseSystemPasswordChar = true;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(34, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(181, 22);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "gmail",
            "yahoo",
            "outlook"});
            this.comboBox1.Location = new System.Drawing.Point(34, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(94, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // emailProvider
            // 
            this.emailProvider.AutoSize = true;
            this.emailProvider.Location = new System.Drawing.Point(35, 9);
            this.emailProvider.Name = "emailProvider";
            this.emailProvider.Size = new System.Drawing.Size(95, 16);
            this.emailProvider.TabIndex = 4;
            this.emailProvider.Text = "Email Provider";
            // 
            // emailAddress
            // 
            this.emailAddress.AutoSize = true;
            this.emailAddress.Location = new System.Drawing.Point(31, 70);
            this.emailAddress.Name = "emailAddress";
            this.emailAddress.Size = new System.Drawing.Size(95, 16);
            this.emailAddress.TabIndex = 5;
            this.emailAddress.Text = "Email Address";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(35, 131);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(67, 16);
            this.password.TabIndex = 6;
            this.password.Text = "Password";
            this.password.Click += new System.EventHandler(this.label3_Click);
            // 
            // authentication
            // 
            this.authentication.AutoSize = true;
            this.authentication.Location = new System.Drawing.Point(211, 31);
            this.authentication.Name = "authentication";
            this.authentication.Size = new System.Drawing.Size(176, 16);
            this.authentication.TabIndex = 7;
            this.authentication.TabStop = true;
            this.authentication.Text = "Gmail 2 Step Authenthication";
            this.authentication.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.authentication_LinkClicked);
            // 
            // appPassword
            // 
            this.appPassword.AutoSize = true;
            this.appPassword.Location = new System.Drawing.Point(170, 52);
            this.appPassword.Name = "appPassword";
            this.appPassword.Size = new System.Drawing.Size(217, 16);
            this.appPassword.TabIndex = 8;
            this.appPassword.TabStop = true;
            this.appPassword.Text = "Generate app password from gmail";
            this.appPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.appPassword_LinkClicked);
            // 
            // gmailLabel
            // 
            this.gmailLabel.AutoSize = true;
            this.gmailLabel.Location = new System.Drawing.Point(260, 9);
            this.gmailLabel.Name = "gmailLabel";
            this.gmailLabel.Size = new System.Drawing.Size(127, 16);
            this.gmailLabel.TabIndex = 9;
            this.gmailLabel.Text = "Mandatory for Gmail";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(32, 300);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(94, 29);
            this.close.TabIndex = 12;
            this.close.Text = "Close App";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(32, 271);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(94, 23);
            this.send.TabIndex = 13;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(34, 208);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(181, 22);
            this.textBox3.TabIndex = 14;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Send To Email Address:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 29);
            this.button1.TabIndex = 16;
            this.button1.Text = "Attachment";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 338);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.send);
            this.Controls.Add(this.close);
            this.Controls.Add(this.gmailLabel);
            this.Controls.Add(this.appPassword);
            this.Controls.Add(this.authentication);
            this.Controls.Add(this.password);
            this.Controls.Add(this.emailAddress);
            this.Controls.Add(this.emailProvider);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label emailProvider;
        private System.Windows.Forms.Label emailAddress;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.LinkLabel authentication;
        private System.Windows.Forms.LinkLabel appPassword;
        private System.Windows.Forms.Label gmailLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

