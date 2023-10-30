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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.close = new System.Windows.Forms.Button();
            this.send = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.emailBox = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gmailBox = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.step1Label = new System.Windows.Forms.Label();
            this.functionEmail = new System.Windows.Forms.GroupBox();
            this.emailBox.SuspendLayout();
            this.gmailBox.SuspendLayout();
            this.functionEmail.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 154);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.UseSystemPasswordChar = true;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 55);
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
            "outlook"});
            this.comboBox1.Location = new System.Drawing.Point(18, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(94, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // emailProvider
            // 
            this.emailProvider.AutoSize = true;
            this.emailProvider.Location = new System.Drawing.Point(15, 23);
            this.emailProvider.Name = "emailProvider";
            this.emailProvider.Size = new System.Drawing.Size(95, 16);
            this.emailProvider.TabIndex = 4;
            this.emailProvider.Text = "Email Provider";
            // 
            // emailAddress
            // 
            this.emailAddress.AutoSize = true;
            this.emailAddress.Location = new System.Drawing.Point(6, 36);
            this.emailAddress.Name = "emailAddress";
            this.emailAddress.Size = new System.Drawing.Size(95, 16);
            this.emailAddress.TabIndex = 5;
            this.emailAddress.Text = "Email Address";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(6, 132);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(67, 16);
            this.password.TabIndex = 6;
            this.password.Text = "Password";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(130, 361);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(118, 38);
            this.close.TabIndex = 12;
            this.close.Text = "Close App";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(6, 360);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(118, 40);
            this.send.TabIndex = 13;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 267);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(236, 22);
            this.textBox3.TabIndex = 14;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Send To (Testing only)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 38);
            this.button1.TabIndex = 16;
            this.button1.Text = "Attachment";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // emailBox
            // 
            this.emailBox.Controls.Add(this.label10);
            this.emailBox.Controls.Add(this.label9);
            this.emailBox.Controls.Add(this.label8);
            this.emailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.emailBox.Location = new System.Drawing.Point(306, 85);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(285, 148);
            this.emailBox.TabIndex = 28;
            this.emailBox.TabStop = false;
            this.emailBox.Text = "Setup Instructions";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(6, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 20);
            this.label10.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(6, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(265, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Step 3. Enter your email password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(6, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(242, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Step 2. Add your email address";
            // 
            // gmailBox
            // 
            this.gmailBox.Controls.Add(this.button2);
            this.gmailBox.Controls.Add(this.textBox4);
            this.gmailBox.Controls.Add(this.label5);
            this.gmailBox.Controls.Add(this.label3);
            this.gmailBox.Controls.Add(this.label2);
            this.gmailBox.Controls.Add(this.linkLabel2);
            this.gmailBox.Controls.Add(this.linkLabel1);
            this.gmailBox.Controls.Add(this.label4);
            this.gmailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gmailBox.Location = new System.Drawing.Point(306, 239);
            this.gmailBox.Name = "gmailBox";
            this.gmailBox.Size = new System.Drawing.Size(460, 252);
            this.gmailBox.TabIndex = 29;
            this.gmailBox.TabStop = false;
            this.gmailBox.Text = "Gmail Setup Instructions";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(307, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 30);
            this.button2.TabIndex = 10;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(10, 215);
            this.textBox4.Name = "textBox4";
            this.textBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox4.Size = new System.Drawing.Size(291, 30);
            this.textBox4.TabIndex = 9;
            this.textBox4.UseSystemPasswordChar = true;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(6, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(307, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Step 4. Enter your App Password Below";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(6, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(343, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "NOTE: Make sure to save the App Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(6, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Step 3. Must create an APP Password***";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.linkLabel2.Location = new System.Drawing.Point(6, 155);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(295, 20);
            this.linkLabel2.TabIndex = 5;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Click Here to create an App Password";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.linkLabel1.Location = new System.Drawing.Point(6, 60);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(316, 20);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Click Here to verify 2 Step Authentication";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(6, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(414, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Step 2. Verify that your 2 Step Authentication is ON ***";
            // 
            // step1Label
            // 
            this.step1Label.AutoSize = true;
            this.step1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.step1Label.Location = new System.Drawing.Point(312, 41);
            this.step1Label.Name = "step1Label";
            this.step1Label.Size = new System.Drawing.Size(261, 20);
            this.step1Label.TabIndex = 30;
            this.step1Label.Text = "Step 1: Choose an Email Provider";
            // 
            // functionEmail
            // 
            this.functionEmail.Controls.Add(this.button1);
            this.functionEmail.Controls.Add(this.send);
            this.functionEmail.Controls.Add(this.close);
            this.functionEmail.Controls.Add(this.textBox3);
            this.functionEmail.Controls.Add(this.emailAddress);
            this.functionEmail.Controls.Add(this.password);
            this.functionEmail.Controls.Add(this.label1);
            this.functionEmail.Controls.Add(this.textBox1);
            this.functionEmail.Controls.Add(this.textBox2);
            this.functionEmail.Location = new System.Drawing.Point(12, 85);
            this.functionEmail.Name = "functionEmail";
            this.functionEmail.Size = new System.Drawing.Size(260, 406);
            this.functionEmail.TabIndex = 31;
            this.functionEmail.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 510);
            this.Controls.Add(this.functionEmail);
            this.Controls.Add(this.step1Label);
            this.Controls.Add(this.gmailBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.emailProvider);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.emailBox.ResumeLayout(false);
            this.emailBox.PerformLayout();
            this.gmailBox.ResumeLayout(false);
            this.gmailBox.PerformLayout();
            this.functionEmail.ResumeLayout(false);
            this.functionEmail.PerformLayout();
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
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox emailBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gmailBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label step1Label;
        private System.Windows.Forms.GroupBox functionEmail;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button2;
    }
}

