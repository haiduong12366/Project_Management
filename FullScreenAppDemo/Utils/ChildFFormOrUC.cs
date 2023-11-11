﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management.Utils
{
    internal class ChildFormOrUC
    {
        private Form currentChildForm;
        private Panel pnlLoad;

        public Form CurrentChildForm { get => currentChildForm; set => currentChildForm = value; }

        public ChildFormOrUC(Panel pnlLoad)
        {
            this.pnlLoad = pnlLoad;
            currentChildForm = null;
        }

        public void Open(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            try
            {
                currentChildForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                pnlLoad.Controls.Add(childForm);
                pnlLoad.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
            catch
            {
                MessageBox.Show("Error!!!");
            }
        }

        public void AddUc(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;

            pnlLoad.Controls.Clear();
            pnlLoad.Controls.Add(uc);

            uc.BringToFront();
        }
    }
}
