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
using DXApplication1.DAL;

namespace DXApplication1.View.All
{
    public partial class FormAddAccount : DevExpress.XtraEditors.XtraForm
    {
        public FormAddAccount()
        {
            InitializeComponent();
            LoadAll();
        }
        private void LoadAll()
        {
            SetCBB();
            LoadCbbName();

        }

        private void LoadCbbName()
        {
            cbbNameE.DataSource = BUS_Employee.Instance.GetListEmployeeDontHaveAccount();
            try
            {
                cbbNameE.SelectedIndex = 0;
            }
            catch { }

        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void SetCBB()
        {
            if (cbb_TypeAccount.Items != null)
            {
                cbb_TypeAccount.Items.Clear();
            }

            List<dynamic> list_TypeAccount = BUS_Account.Instance.GetTypeAccount_DAL().ToList();
            if (list_TypeAccount != null)
            {
                for (int i = 0; i < list_TypeAccount.Count; i++)
                {
                    cbb_TypeAccount.Items.Add(new CBBItem
                    {
                        Value = list_TypeAccount[i].Id,
                        Text = list_TypeAccount[i].Name
                    });
                }
                cbb_TypeAccount.SelectedIndex = 0;
            }
            else
            {
                FormMessageBox form = new FormMessageBox("Lỗi! Tải dữ liệu quyền truy cập thất bại!");
                form.ShowDialog();
            }
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            string username = txt_UserName.Text;
            if (BUS_Account.Instance.CheckExistUserName(username))
            {
                new FormMessageBox("Tên đăng nhập đã tồn tại, vui lòng thử tên khác").ShowDialog();
            }
            else
            {
                // String phone = txtPhone.Text;
                //String name = txt_Name.Text;
                int IDEmployee = (int)(cbbNameE.SelectedItem as CbbItem).Key;
                int Id_Type = (cbb_TypeAccount.SelectedItem as CBBItem).Value;

                if (BUS_Account.Instance.AddAccount(IDEmployee, username, Id_Type))
                {
                    FormMessageBox form = new FormMessageBox("Thêm thành công!");
                    form.ShowDialog();
                }
                else
                {
                    FormMessageBox form = new FormMessageBox("Thêm thất bại! Vui lòng kiểm tra lại dữ liệu");
                    form.ShowDialog();
                }
                this.Dispose();
            }
                
        }

        private void cbbNameE_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPhone.Text = BUS_Employee.Instance.GetEmployee((int)(cbbNameE.SelectedItem as CbbItem).Key).Phone;
        }
    }
}