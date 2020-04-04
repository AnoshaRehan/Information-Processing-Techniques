using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Configuration;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.IO;

namespace k163833_Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bodyBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void subjectBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            EmailMessage mail = new EmailMessage();
            string to = toBox.Text;
            mail.Email(subjectBox.Text, to, bodyBox.Text);
            string xmlFile = "c:\\users\\New\\Desktop\\k163833\\k163833_Q2\\test2.xml";
            XmlSerializer serializer = new XmlSerializer(typeof(EmailMessage));
            TextWriter writer = new StreamWriter(xmlFile);
            serializer.Serialize(writer, mail);
            writer.Close();
        }

        [Serializable]
        public class EmailMessage
        {
            public string To;
            public String Subject;
            public String MessageBody;
            public void Email(string _subject, string _to, string body)
            {
                To = _to;
                Subject = _subject;
                MessageBody = body;
                string filename = ConfigurationManager.AppSettings.Get("xmlFile");
                MailMessage msgMail;
                msgMail = new MailMessage();
                msgMail.To.Add(To);
                msgMail.Subject = Subject;
                msgMail.Body = MessageBody;
                msgMail.Dispose();
            }
        }
    }
}
