using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management.DAO
{
    public class ImageDAO
    {
        company_management_Entities entity = new company_management_Entities();

        public ImageDAO()
        {
        }

        public void ChooseImageToPictureBox(Guna2CirclePictureBox pictureBox)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = @"Image Files (*.bmp;*.jpg;*.jpeg,*.png,*.gif)|*.BMP;*.JPG;*.JPEG;*.PNG;*.GIF";

            // Cho phép chọn nhiều tệp cùng lúc
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;

                pictureBox.Image = Image.FromFile(imagePath);
            }
        }

        public void ShowImageInPictureBox(byte[] imageBytes, Guna2CirclePictureBox pictureBox)
        {
            if (imageBytes != null)
            {
                using (var ms = new MemoryStream(imageBytes))
                {
                    pictureBox.Image = Image.FromStream(ms);
                }
            }
        }

        public void SaveUserAvatar(byte[] imageBytes, int userId)
        {
            var user = entity.users.FirstOrDefault(u => u.id == userId);

            if (user != null)
            {
                user.avatar = imageBytes;
                entity.SaveChanges();
                MessageBox.Show("Lưu ảnh thành công!");
            }
            else
            {
                MessageBox.Show("Lưu ảnh thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SaveTeamAvatar(byte[] imageBytes, int idTeam)
        {
            var team = entity.teams.FirstOrDefault(t => t.id == idTeam);

            if (team != null)
            {
                team.avatar = imageBytes;
                entity.SaveChanges();
                MessageBox.Show("Lưu ảnh thành công!");
            }
            else
            {
                MessageBox.Show("Lưu ảnh thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public byte[] ImageToByte(Guna2CirclePictureBox pictureBox)
        {
            Bitmap bmp = new Bitmap(pictureBox.Image);
            using (MemoryStream ms = new MemoryStream())
            {
                bmp.Save(ms, ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
    }
}
