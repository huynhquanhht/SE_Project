using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DXApplication1.View.All;

namespace DXApplication1
{
    public partial class TabSystem : DevExpress.XtraEditors.XtraForm
    {
        private int IDType = -1;
        public TabSystem(int IDType)
        {
            InitializeComponent();
            SetInterface();
            this.IDType = IDType;
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
            btn_Item_Click(btn_Item, new EventArgs());
        }
        public void ResetColorButton()
        {
            btn_Item.Appearance.BackColor = Color.DodgerBlue;
            btn_Category.Appearance.BackColor = Color.DodgerBlue;
            btn_Table.Appearance.BackColor = Color.DodgerBlue;
            btn_Account.Appearance.BackColor = Color.DodgerBlue;
            btn_Bill.Appearance.BackColor = Color.DodgerBlue;
            btn_Employee.Appearance.BackColor = Color.DodgerBlue;
        }
        private void btn_Item_Click(object sender, EventArgs e)
        {
            ResetColorButton();
            btn_Item.Appearance.BackColor = SystemColors.HotTrack;
            openChildForm(new frm_Item());

        }

        private void btn_Category_Click(object sender, EventArgs e)
        {
            ResetColorButton();
            btn_Category.Appearance.BackColor = SystemColors.HotTrack;
            openChildForm(new GUI.frm_Category());
        }

        private void btn_Table_Click(object sender, EventArgs e)
        {
            ResetColorButton();
            btn_Table.Appearance.BackColor = SystemColors.HotTrack;
            openChildForm(new GUI.frm_Table());
        }

        private void btn_Bill_Click(object sender, EventArgs e)
        {
            ResetColorButton();
            btn_Bill.Appearance.BackColor = SystemColors.HotTrack;
            openChildForm(new GUI.Bill());
        }

        private void btn_Employee_Click(object sender, EventArgs e)
        {
            ResetColorButton();
            btn_Employee.Appearance.BackColor = SystemColors.HotTrack;
            openChildForm(new GUI.frm_Employee());
        }

        private void btn_Account_Click(object sender, EventArgs e)
        {
            if (this.IDType == 1)
            {
                ResetColorButton();
                btn_Account.Appearance.BackColor = SystemColors.HotTrack;
                openChildForm(new GUI.frm_Account());
            }
            else
            {
                new FormMessageBox("Tài khoản của bạn không có quyền truy cập tab này").ShowDialog();
            }
        }
    }


}

