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

namespace ExamVue_Duo_Email_App
{
    public partial class Form1 : Form
    {
        string emailAddressText;
        string emailAddressPassword;
        string smtpServer;
        int smtpPort;

        public Form1()
        {
            InitializeComponent();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            emailAddressText = textBox2.Text;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            emailAddressPassword = textBox1.Text;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    //Set up gmail smtp
                    smtpServer = "smtp.gmail.com";
                    smtpPort = 587;
                    break;

                case 1:
                    //Set up yahoo smtp
                    smtpServer = "smtp.mail.yahoo.com";
                    smtpPort = 587;
                    break;

                case 2:
                    //Set up outlook smtp
                    smtpServer = "smtp-mail.outlook.com";
                    smtpPort = 587;
                    break;
            }
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        private void Attachment_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string y = openFileDialog1.FileName;
                Console.WriteLine(y);
            }
        }
        //GMAIL 2FA and App Password Requirement
        private void authentication_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://security.google.com/settings/security/signinoptions/two-step-verification");
        }

        private void appPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://security.google.com/settings/security/apppasswords");
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
            email.To.Add(MailboxAddress.Parse("brandon.chin@jpihealthcare.com"));
            email.Subject = "Test Email Subject";
            email.Body = new TextPart(TextFormat.Html) { Text = "<h1>Example HTML Message Body</h1>" };

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
