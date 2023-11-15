
﻿using Project_Management.View;
using Project_Management.DAO;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using company_management.DTO;

namespace Project_Management.Utils
{
    internal class Util
    {
        private static Util instance;
        public static Util Instance
        {
            get { if (instance == null) instance = new Util(); return Util.instance; }
            private set => Util.instance = value;
        }

        public Util() { }
        public bool IsPhoneNumber(string number)
        {
            // Loại bỏ các ký tự trống và dấu gạch ngang
            number = number.Replace(" ", "").Replace("-", "");

            // Kiểm tra chuỗi bắt đầu bằng "+" nếu là số điện thoại quốc tế
            if (number.StartsWith("+"))
            {
                // Chuỗi phải có ít nhất 8 ký tự sau dấu "+"
                return Regex.IsMatch(number.Substring(1), @"^\d{8,}$");
            }
            else
            {
                // Chuỗi phải có ít nhất 10 ký tự và không vượt quá 11 ký tự
                return Regex.IsMatch(number, @"^\d{10,11}$");
            }
        }
        public void Alert(string msg, FormAlert.enmType type)
        {
            FormAlert frm = new FormAlert();
            frm.showAlert(msg, type);
        }
        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                string[] allowedDomains = { "gmail.com", "yahoo.com", "hotmail.com", "outlook.com" };
                return addr.Address == email && allowedDomains.Any(d => addr.Host.EndsWith(d));
            }
            catch
            {
                return false;
            }
        }

        public void LoadProgressChart<T>(Chart chart, Label todo, Label inprogress, Label done, List<T> list)
        {
            TaskStatusPercentage taskStatus;

            if (typeof(T) == typeof(task))
            {
                List<task> taskList = list.Cast<task>().ToList();
                taskStatus = TaskDAO.Instance.GetTaskStatusPercentage(taskList);
            }
            else
            {
                List<project> projects = list.Cast<project>().ToList();
                taskStatus = ProjectDAO.Instance.GetProjectStatusPercentage(projects);
            }

            double todoPercent = taskStatus.TodoPercent;
            double inprogressPercent = taskStatus.InprogressPercent;
            double donePercent = taskStatus.DonePercent;

            // Định dạng giá trị với 2 chữ số sau dấu thập phân
            string todoPercentFormatted = todoPercent.ToString("0.00");
            string inprogressPercentFormatted = inprogressPercent.ToString("0.00");
            string donePercentFormatted = donePercent.ToString("0.00");

            chart.Series["SeriesProgress"].Points.Clear();

            // Thêm các phần tử vào danh sách
            chart.Series["SeriesProgress"].Points.AddXY("", todoPercent);
            chart.Series["SeriesProgress"].Points.AddXY("", inprogressPercent);
            chart.Series["SeriesProgress"].Points.AddXY("", donePercent);

            // Ẩn nhãn trên biểu đồ tròn
            chart.Series["SeriesProgress"].IsValueShownAsLabel = false;

            chart.Legends.Clear();

            chart.Series["SeriesProgress"].Points[0].Color = Color.FromArgb(214, 40, 40);
            chart.Series["SeriesProgress"].Points[1].Color = Color.FromArgb(0, 255, 0);
            chart.Series["SeriesProgress"].Points[2].Color = Color.FromArgb(67, 97, 238);

            todo.Text = todoPercentFormatted + @"%";
            inprogress.Text = inprogressPercentFormatted + @"%";
            done.Text = donePercentFormatted + @"%";
        }
        public byte[] ImageToByteArray(Image image)
        {
            if (image == null)
                return null;

            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        public Image ByteArrayToImage(byte[] byteArray)
        {
            if (byteArray == null)
                return null;

            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }


    }
}
