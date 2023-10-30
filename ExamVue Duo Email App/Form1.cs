using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using MailKit;
using MailKit.Security;
using System.Runtime.Remoting.Messaging;
using MailKit.Net.Smtp;
using MimeKit;
using MimeKit.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.IO;


namespace ExamVue_Duo_Email_App
{
    public partial class Form1 : Form
    {
        string emailAddressText;
        string emailAddressPassword;
        string emailAddressSend;
        string smtpServer;
        string filePath;
        int smtpPort;

        public Form1()
        {
            InitializeComponent();
            gmailBox.Visible = false;  
            emailBox.Visible = false;
            functionEmail.Visible = false;
        }
        //Linked Labels
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://security.google.com/settings/security/signinoptions/two-step-verification");
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://security.google.com/settings/security/apppasswords");
        }
        // ComboBox Dropdown for Email Provider
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    //Set up gmail smtp
                    smtpServer = "smtp.gmail.com";
                    smtpPort = 587;
                    gmailBox.Visible = true;
                    textBox1.Hide();
                    password.Hide();
                    break;

                case 1:
                    //Set up yahoo smtp
                    smtpServer = "smtp-mail.outlook.com";
                    smtpPort = 587;
                    emailBox.Visible = true;
                    functionEmail.Visible = true;
                    break;
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            emailAddressText = textBox2.Text;
        }
        //GMAIL 2FA and App Password Requirement
        private void appPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://security.google.com/settings/security/apppasswords");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            gmailBox.Visible=false;
            emailBox.Visible = true;
            functionEmail.Visible = true;
        }
        //Input and attachment
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            emailAddressPassword = textBox1.Text;
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            emailAddressPassword = textBox4.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            emailAddressSend = textBox3.Text;
        }
        private void Attachment_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string y = openFileDialog1.FileName;
                Console.WriteLine(y);
            }
        }
        //Close app
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //SMTP Server request
        private void send_Click(object sender, EventArgs e)
        {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(emailAddressText));
            email.To.Add(MailboxAddress.Parse(emailAddressSend));
            email.Subject = "Test Email Subject";

            var builder = new BodyBuilder();

            builder.TextBody = @"TEST JPI EMAIL - ABC";
            builder.Attachments.Add(filePath);

            email.Body = builder.ToMessageBody();

            using (var client = new SmtpClient())
            {
                client.Connect(smtpServer, smtpPort, SecureSocketOptions.StartTlsWhenAvailable);
                client.Authenticate(emailAddressText, emailAddressPassword);
                client.Send(email);
                client.Disconnect(true);
            }
        }

    }
}
