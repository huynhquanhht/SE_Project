using DXApplication1.DAL;
using DXApplication1.View.All;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1.GUI
{
    public partial class frm_Account : Form
    {
        public frm_Account()
        {
            InitializeComponent();
            SetCBB();
            SetView();
            LoadBinding();
            LoadFirst();
        }
        private void SetCBB()
        {
            cbb_TypeAccount.Items.Clear();
            cbb_TypeAccountDe.Items.Clear();
            if (cbb_TypeAccount.Items != null)
            {
                cbb_TypeAccount.Items.Clear();
            }
            cbb_TypeAccount.Items.Add(new CBBItem { Value = 0, Text = "Tất cả" });
            List<dynamic> list_TypeAccount = BUS_Account.Instance.GetTypeAccount_DAL().ToList();
            if (list_TypeAccount != null)
            {
                for (int i = 0; i < list_TypeAccount.Count; i++)
                {
                    cbb_TypeAccountDe.Items.Add(new CBBItem
                    {
                        Value = list_TypeAccount[i].Id,
                        Text = list_TypeAccount[i].Name
                    });
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
        private void SetView()
        {
            string type = cbb_TypeAccount.SelectedItem.ToString();
            foreach (CBBItem i in cbb_TypeAccount.Items)
            {
                if (i.Text == type)
                {
                    grd_Account.DataSource = BUS_Account.Instance.Show_DAL(i.Value);
                    break;
                }
            }
        }
        private void LoadBinding()
        {
            string Name_Type = cbb_TypeAccount.SelectedItem.ToString();
            int Id_Type = 0;
            foreach (CBBItem i in cbb_TypeAccount.Items)
            {
                if (i.Text == Name_Type)
                {
                    Id_Type = i.Value;
                    break;
                }
            }
            if (BUS_Account.Instance.Show_DAL(Id_Type) != null)
            {
                DeleteBinding();
                txt_Name.DataBindings.Add(new Binding("Text", dgv_Account.DataSource, "Name"));
                txt_Phone.DataBindings.Add(new Binding("Text", dgv_Account.DataSource, "Phone"));
                txt_Username.DataBindings.Add(new Binding("Text", dgv_Account.DataSource, "Username"));
                cbb_TypeAccountDe.DataBindings.Add(new Binding("Text", dgv_Account.DataSource, "NameType"));
            }
            else
            {
                FormMessageBox form = new FormMessageBox("Lỗi! Nạp dữ liệu tài khoản thất bại!");
                form.ShowDialog();
                DeleteBinding();
            }
        }

        private void LoadFirst()
        {
            try
            {
                int focusedRow = dgv_Account.FocusedRowHandle;
                dgv_Account.FocusedRowHandle = focusedRow;
                dgv_Account.SelectRow(focusedRow);
                dgv_Account.Focus();
            }
            catch { }
        }
        private void DeleteBinding()
        {
            txt_Name.DataBindings.Clear();
            txt_Phone.DataBindings.Clear();
            txt_Username.DataBindings.Clear();
            cbb_TypeAccountDe.DataBindings.Clear();
            txt_Name.ResetText();
            txt_Phone.ResetText();
            txt_Username.ResetText();
            cbb_TypeAccountDe.ResetText();
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            string Name_Type = cbb_TypeAccount.SelectedItem.ToString();
            string str_Search = txt_Search.Text.Trim();
            int Id_Type = 0;
            foreach (CBBItem i in cbb_TypeAccount.Items)
            {
                if (i.Text == Name_Type)
                {
                    Id_Type = i.Value;
                    break;
                }
            }
            if (BUS_Account.Instance.Search_DAL(Id_Type, str_Search) != null)
            {
                DeleteBinding();
                grd_Account.DataSource = BUS_Account.Instance.Search_DAL(Id_Type, str_Search);
            }
            else
            {
                DeleteBinding();
                FormMessageBox form = new FormMessageBox("Dữ liệu tìm kiếm không tồn tại!");
                form.ShowDialog();

            }
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            FormAddAccount f = new FormAddAccount();
            f.ShowDialog();
            SetCBB();
            SetView();
            LoadBinding();


        }
        private void dgv_Account_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            LoadBinding();
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int IDAccount = (int)dgv_Account.GetRowCellValue(dgv_Account.FocusedRowHandle, grdcol_Id);
            FormYesNoBox formYesNoBox = new FormYesNoBox("Bạn chắc chắn muốn xóa?");
            formYesNoBox.ShowDialog();
            if (formYesNoBox.GetValue() == 1)
            {
                if (BUS_Account.Instance.DeleteAccount(IDAccount))
                {
                    FormMessageBox formMessageBox = new FormMessageBox("Xóa thành công!");
                    DeleteBinding();
                    SetView();
                    formMessageBox.ShowDialog();
                }
            }
            else
            {
                FormMessageBox form = new FormMessageBox("Vui lòng chọn tài khoản muốn xóa!");
                form.ShowDialog();
            }
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            string username = txt_Username.Text;
            // Lôi không có giá, nó tự load lại giá cũ
            int focusedRow = 0;
            try
            {
                 focusedRow = dgv_Account.FocusedRowHandle;
               
            }
            catch { }
            int IDAccount = (int)dgv_Account.GetRowCellValue(dgv_Account.FocusedRowHandle, grdcol_Id);
            FormYesNoBox formYesNoBox = new FormYesNoBox("Bạn chắc chắn muốn cập nhật?");
            formYesNoBox.ShowDialog();
            if (formYesNoBox.GetValue() == 1)
            {
                if (BUS_Account.Instance.CheckExistUserName(username))
                {
                    new FormMessageBox("Tên đăng nhập đã tồn tại, vui lòng thử tên khác").ShowDialog();
                }
                else
                {
                    string name = txt_Name.Text;
                    string phone = txt_Phone.Text;
                    string name_Type = "";
                    int Id_Type = 0;
                    if (cbb_TypeAccountDe.SelectedItem != null)
                    {
                        name_Type = cbb_TypeAccountDe.SelectedItem.ToString();
                    }
                    foreach (CBBItem i in cbb_TypeAccountDe.Items)
                    {
                        if (i.Text == name_Type)
                        {
                            Id_Type = i.Value;
                            break;
                        }
                    }
                    if (BUS_Account.Instance.UpdateAccount(IDAccount, name, phone, username, Id_Type))
                    {
                        DeleteBinding();
                        SetView();
                        FormMessageBox form = new FormMessageBox("Cập nhật thành công!");
                        form.ShowDialog();
                        LoadBinding();
                        dgv_Account.FocusedRowHandle = focusedRow;
                        dgv_Account.SelectRow(focusedRow);
                        dgv_Account.Focus();
                    }
                    else
                    {
                        FormMessageBox form = new FormMessageBox("Cập nhật thất bại! Vui lòng kiểm tra lại dữ liệu");
                        form.ShowDialog();
                    }
                }

            }

        }

        private void cbb_TypeAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            int IDType = (cbb_TypeAccount.SelectedItem as CBBItem).Value;
            grd_Account.DataSource = BUS_Account.Instance.GetAccountByIDType(IDType);
        }

        private void btnResetPass_Click(object sender, EventArgs e)
        {
            if (BUS_Account.Instance.ResetPasWord((int)dgv_Account.GetRowCellValue(dgv_Account.FocusedRowHandle, grdcol_Id)))
            {
                new FormMessageBox("Đặt lại mật khẩu thành công!").ShowDialog();
            }
            else
            {
                new FormMessageBox("Đặt lại mật khẩu không thành công!").ShowDialog();
            }
        }
    }
}
