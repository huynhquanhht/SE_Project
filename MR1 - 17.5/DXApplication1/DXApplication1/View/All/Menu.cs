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
using DXApplication1.GUI.TabStatistic;
using DXApplication1.GUI;
using DXApplication1.GUI.TabSale;
using DXApplication1.DAL;

namespace DXApplication1
{
    public partial class Menu : DevExpress.XtraEditors.XtraForm
    {
        public Menu()
        {
            InitializeComponent();
            SetInterface();
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
        public void SetInterface()
        {
 
            btn_System_Click(btn_System, new EventArgs());
            
        }
        public void ResetColorButton()
        {
            
        }
        public void ChangeColorAllButton()
        {
                btn_System.Appearance.BackColor = Color.DodgerBlue;
                btn_Sale.Appearance.BackColor = Color.DodgerBlue;
                btn_Statistical.Appearance.BackColor = Color.DodgerBlue;
  
        }
        private void btn_System_Click(object sender, EventArgs e)
        {
            ChangeColorAllButton();
            btn_System.Appearance.BackColor = SystemColors.HotTrack;
            openChildForm(new TabSystem());
        }

        private void btn_Sale_Click(object sender, EventArgs e)
        {
            ChangeColorAllButton();
            btn_Sale.Appearance.BackColor = SystemColors.HotTrack;
            openChildForm(new XtraForm1());
        }

        private void btn_Statistical_Click(object sender, EventArgs e)
        {
            ChangeColorAllButton();
            btn_Statistical.Appearance.BackColor = SystemColors.HotTrack;
            openChildForm(new Sales());
        }



        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chartControl1_Click(object sender, EventArgs e)
        {

        }
    
    }
   
}