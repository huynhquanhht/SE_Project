﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DXApplication1
{
    public partial class TabSystem : DevExpress.XtraEditors.XtraForm
    {
        public TabSystem()
        {
            InitializeComponent();
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;

            childForm.TopLevel = false;
            childForm.TopMost = true;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btn_Item_Click(object sender, EventArgs e)
        {
            openChildForm(new System_Item());
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            openChildForm(new GUI.Category());
        }

        private void btn_Table_Click(object sender, EventArgs e)
        {
            openChildForm(new GUI.Table());
        }

        private void btn_Bill_Click(object sender, EventArgs e)
        {
            openChildForm(new GUI.Bill());
        }

        private void btn_Employee_Click(object sender, EventArgs e)
        {
            openChildForm(new GUI.Employee());
        }

        private void btn_Account_Click(object sender, EventArgs e)
        {
            openChildForm(new GUI.Account());
        }
    }
    

}