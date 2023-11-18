using Project_Management.View;
using Project_Management.DAO;
using Project_Management.DTO;
using Project_Management;
using Project_Management.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management.View
{
    public partial class FormViewProfile : Form
    {
        byte[] pic;
        public FormViewProfile()
        {
            InitializeComponent();
            Load();
        }
        byte[] ImageToByteArray(Image img)
        {
            MemoryStream m = new MemoryStream();
            img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }
        Image ByteArrayToImage(byte[] b)
        {
            MemoryStream m = new MemoryStream(b);
            return Image.FromStream(m);
        }

        void Load()
        {
            tbUsername.Text = UserSession.LoggedInUser.username;
            tbAddress.Text = UserSession.LoggedInUser.address;
            tbEmail.Text = UserSession.LoggedInUser.email;
            tbFullname.Text = UserSession.LoggedInUser.fullName;
            tbPhone.Text = UserSession.LoggedInUser.phoneNumber;
            tbRole.Text = UserDAO.Instance.IdPositionToString((int)UserSession.LoggedInUser.idPosition);
            if (UserDAO.Instance.IsHumanResources() || UserDAO.Instance.IsManager())
            {
                tbTeam.Visible = false;
                lbTeam.Visible = false;
            }
            else
            {
                List<user_team> list = User_teamDAO.Instance.GetTeamByID(UserSession.LoggedInUser.id);
                foreach (user_team team in list)
                {
                    tbTeam.Text = TeamDAO.Instance.idTeamToString((int)team.idTeam);
                }
            }
            pic = UserSession.LoggedInUser.avatar;
            if(pic != null)
                PbAvatar.Image = ByteArrayToImage(pic);
        }

        private void btnUpdateAvatar_Click(object sender, EventArgs e)
        {
            ODL.Title = "Image";
            ODL.Filter = "Image|*.png;*.jpg;*.gif";
            if (ODL.ShowDialog() == DialogResult.OK)
            {
                pic = ImageToByteArray(Image.FromFile(ODL.FileName));
                PbAvatar.Image = ByteArrayToImage(pic);
                ODL.Dispose();//thu hồi bộ nhớ
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            user user = UserDAO.Instance.GetUserByUserName(UserSession.LoggedInUser.username);
            if (user != null)
            {
                user.email = tbEmail.Text;
                user.address = tbAddress.Text;
                user.fullName = tbFullname.Text;
                user.phoneNumber = tbPhone.Text;
                user.avatar = pic;
                UserDAO.Instance.UpdateUser(user);
                Util.Instance.Alert("Update user success", FormAlert.enmType.Success);

            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            FormPasswordChange formPasswordChange = new FormPasswordChange();
            formPasswordChange.ShowDialog();
        }
    }
}
