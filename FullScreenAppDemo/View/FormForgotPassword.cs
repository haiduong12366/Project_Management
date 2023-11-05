using FullScreenAppDemo.DAO;
using FullScreenAppDemo;
using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using System.Linq;
using Project_Management;

namespace company_management.View
{
    public partial class FormForgotPassword : Form
    {
        company_management_Entities entity = new company_management_Entities();
        private int _otp;
        readonly Random _random = new Random();
        public FormForgotPassword()
        {

            InitializeComponent();
        }
        private bool ValidateEmail()
        {
            if (!string.IsNullOrEmpty(tbEmail.Text))
            {
                user user = entity.users.SingleOrDefault(u => u.email.Equals(tbEmail.Text));
                if (user != null)
                {
                    return true;
                }
                MessageBox.Show(@"Không tìm thấy địa chỉ email!");
            }
            else
            {
                MessageBox.Show(@"Email không được để trống!");
            }
            return false;
        }
        private void btnContinue_Click(object sender, EventArgs e)
        {

        }



        private void btnSendOTP_Click(object sender, EventArgs e)
        {
            if (ValidateEmail())
            {
                try
                {
                    _otp = _random.Next(100000, 1000000);

                    var fromAddress = new MailAddress("phamtrungnghia232@gmail.com");
                    var toAddress = new MailAddress(tbEmail.Text);
                    const string frompass = "mkfedlsgytikzfou";//mở xác thực 2 bước
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
                    MessageBox.Show("OPT đã được gửi qua mail");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }
    }
}
