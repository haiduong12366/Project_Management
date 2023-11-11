using Project_Management.DAO;
using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using System.Linq;
using Project_Management;
using Project_Management.DTO;
using Project_Management.View;

namespace Project_Management.View
{
    public partial class FormForgotPassword : Form
    {

        private int _otp;
        readonly Random _random = new Random();
        public FormForgotPassword()
        {

            InitializeComponent();
        }
        private bool ValidateEmail()
        {
            using (company_management_Entities entity = new company_management_Entities())
            {
                if (!string.IsNullOrEmpty(tbEmail.Text))
                {
                    user user = entity.users.SingleOrDefault(u => u.email.Equals(tbEmail.Text));
                    UserSession.LoggedInUser = user;
                    if (user != null)
                    {
                        return true;
                    }
                    MessageBox.Show(@"Not found mail!");
                }
                else
                {
                    MessageBox.Show(@"Email not empty!");
                }
                return false;
            }
        }
        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (tbOtp.Text == _otp.ToString())
            {
                FormChangePasswordByEmail passwordChange = new FormChangePasswordByEmail();
                this.Hide();
                passwordChange.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("OTP not correct!");
            }
        }



        private void btnSendOTP_Click(object sender, EventArgs e)
        {
            if (ValidateEmail())
            {
                try
                {
                    _otp = _random.Next(100000, 1000000);

                    var fromAddress = new MailAddress("hdun1236@gmail.com");
                    var toAddress = new MailAddress(tbEmail.Text);
                    const string frompass = "gnck pran fpxq anch";//mở xác thực 2 bước
                    const string subject = "OTP code";
                    string body = _otp.ToString();

                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(fromAddress.Address, frompass),
                        Timeout = 200000
                    };

                    using (var message = new MailMessage(fromAddress, toAddress)
                    {
                        Subject = subject,
                        Body = body,
                    })
                    {
                        smtp.Send(message);
                    }
                    MessageBox.Show("OPT sent via mail");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }
    }
}
