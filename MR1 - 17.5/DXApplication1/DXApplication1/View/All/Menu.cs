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
using DXApplication1.GUI.TabStatistic;
using DXApplication1.GUI;
using DXApplication1.GUI.TabSale;
using DXApplication1.DAL;
using DXApplication1.GUI.All;
using DXApplication1.DTO;
using DXApplication1.View.All;

namespace DXApplication1
{
    public partial class Menu : DevExpress.XtraEditors.XtraForm
    {
        private int Id_Employee { get; set; }
        private int ID_Type { get; set; }
        public Menu(int Id, int IDType)
        {
            this.Id_Employee = Id;
            this.ID_Type = IDType;
            InitializeComponent();
            SetView();
            LoadAll();
        }
        private Form activeForm = null;

        private void LoadAll()
        {

            DateTime today = DateTime.Now;
            blDay.Text = today.DayOfWeek + " - " + today.Day + "/" + today.Month + "/" + today.Year;
            blDay.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;

            timer1.Tick += timer1_Tick;
            timer1.Interval += 1000;
            timer1.Start();


        }
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
        public void SetView()
        {
            if (ID_Type==3)
            { openChildForm(new fSale(this.Id_Employee)); }
            else
            {
                openChildForm(new TabSystem(this.ID_Type));
            }
                      
          
            if (BUS_Employee.Instance.GetEmployee(Id_Employee) != null)
            {
                Employee em = BUS_Employee.Instance.GetEmployee(Id_Employee);
                ddbtn_Menu.Text = em.Name;
            }
            else
            {
                FormMessageBox mess = new FormMessageBox("Lỗi tải dữ liệu tài khoản! Vui lòng kiểm tra lại!");
            }
        }
        public void ChangeColorAllButton()
        {
            btn_System.Appearance.BackColor = Color.DodgerBlue;
            btn_Sale.Appearance.BackColor = Color.DodgerBlue;
            btn_Statistical.Appearance.BackColor = Color.DodgerBlue;

        }
        private void btn_System_Click(object sender, EventArgs e)
        {
            if (ID_Type == 3)
            {
                new FormMessageBox("Tài khoản của bạn không có quyền truy cập tab này").ShowDialog();
            }
            else
            {
                ChangeColorAllButton();
                btn_System.Appearance.BackColor = SystemColors.HotTrack;
                openChildForm(new TabSystem(this.ID_Type));
            }
          
        }

        private void btn_Sale_Click(object sender, EventArgs e)
        {
            ChangeColorAllButton();
            btn_Sale.Appearance.BackColor = SystemColors.HotTrack;
            openChildForm(new fSale(this.Id_Employee));
        }

        private void btn_Statistical_Click(object sender, EventArgs e)
        {
            ChangeColorAllButton();
            btn_Statistical.Appearance.BackColor = SystemColors.HotTrack;
            openChildForm(new fStatistic());
        }

        private void bbi_InfoPerson_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PersonalInfo fpi = new PersonalInfo(Id_Employee);
            fpi.ShowDialog();
        }

        private void bbi_ChangePass_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChangePass cp = new ChangePass(Id_Employee);
            cp.ShowDialog();
        }

        private void bbi_Exit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormYesNoBox formYesNoBox = new FormYesNoBox("Bạn chắc chắn muốn thoát?");
            formYesNoBox.ShowDialog();
            if (formYesNoBox.GetValue() == 1)
            {
                this.Close();

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToLongTimeString();

        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }

}