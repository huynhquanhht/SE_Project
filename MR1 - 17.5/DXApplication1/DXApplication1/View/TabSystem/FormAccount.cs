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
        }
        public void SetCBB()
        {
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
        public void SetView()
        {
            txt_Id.Enabled = false;
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
        public void LoadBinding()
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
                txt_Id.DataBindings.Add(new Binding("Text", dgv_Account.DataSource, "Id"));
                txt_Name.DataBindings.Add(new Binding("Text", dgv_Account.DataSource, "Name"));
                txt_Phone.DataBindings.Add(new Binding("Text", dgv_Account.DataSource, "Phone"));
                txt_Username.DataBindings.Add(new Binding("Text", dgv_Account.DataSource, "Username"));
                txt_Password.DataBindings.Add(new Binding("Text", dgv_Account.DataSource, "Password"));
                cbb_TypeAccountDe.DataBindings.Add(new Binding("Text", dgv_Account.DataSource, "NameType"));
            }
            else
            {
                FormMessageBox form = new FormMessageBox("Lỗi! Nạp dữ liệu tài khoản thất bại!");
                form.ShowDialog();
                DeleteBinding();
            }
        }
        public void DeleteBinding()
        {

            txt_Id.DataBindings.Clear();
            txt_Name.DataBindings.Clear();
            txt_Phone.DataBindings.Clear();
            txt_Username.DataBindings.Clear();
            txt_Password.DataBindings.Clear();
            cbb_TypeAccountDe.DataBindings.Clear();

            txt_Id.ResetText();
            txt_Name.ResetText();
            txt_Phone.ResetText();
            txt_Username.ResetText();
            txt_Password.ResetText();
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
            string name = txt_Name.Text;
            string username = txt_Username.Text;
            string password = txt_Password.Text;
            string passwordagain = txt_PasswordAgain.Text;
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
           
            if (password == passwordagain)
            {
                if (Id_Type != 0)
                {
                    byte[] temp = ASCIIEncoding.ASCII.GetBytes(password);
                    byte[] hashData = new MD5CryptoServiceProvider().ComputeHash(temp);
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < hashData.Length; i++)
                    {
                        sb.Append(hashData[i].ToString("x2"));
                    }
                    if (BUS_Account.Instance.Add_DAL(name, phone, username, sb.ToString(), Id_Type))
                    {
                        SetView();
                        FormMessageBox form = new FormMessageBox("Thêm thành công!");
                        form.ShowDialog();
                    }
                    else
                    {
                        FormMessageBox form = new FormMessageBox("Thêm thất bại! Vui lòng kiểm tra lại dữ liệu");
                        form.ShowDialog();
                    }
                }
                else
                {
                    FormMessageBox form = new FormMessageBox("Thêm thất bại! Vui lòng kiểm tra lại dữ liệu");
                    form.ShowDialog();
                }
            }
            else
            {
                FormMessageBox form = new FormMessageBox("Lỗi! Mật khẩu khác mật khẩu nhập lại!");
                form.ShowDialog();
            }
        }
        private void dgv_Account_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            LoadBinding();
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            List<int> list_Dell = new List<int>();

            int[] selectedRows = dgv_Account.GetSelectedRows();
            if (txt_Id.Text != "")
            {
                foreach (int rowHandle in selectedRows)
                {
                    if (rowHandle >= 0)
                    {
                        object cellValue = dgv_Account.GetRowCellValue(rowHandle, grdcol_Id);
                        list_Dell.Add((int)cellValue);
                    }
                }
                FormYesNoBox formYesNoBox = new FormYesNoBox("Bạn chắc chắn muốn xóa?");
                formYesNoBox.ShowDialog();
                if (formYesNoBox.GetValue() == 1)
                {
                    if (BUS_Account.Instance.Delete_DAL(list_Dell))
                    {
                        FormMessageBox formMessageBox = new FormMessageBox("Xóa thành công!");
                        DeleteBinding();
                        SetView();
                        formMessageBox.ShowDialog();

                    }
                }
            }
            else
            {
                FormMessageBox form = new FormMessageBox("Vui lòng chọn món muốn xóa!");
                form.ShowDialog();
            }
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            // Lôi không có giá, nó tự load lại giá cũ
            string Id = txt_Id.Text;
            string name = txt_Name.Text;
            string username = txt_Username.Text;
            string password = txt_Password.Text;
            string passwordagain = txt_PasswordAgain.Text;
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
            if (password == passwordagain)
            {

                if (Id != "")
                {

                    byte[] temp = ASCIIEncoding.ASCII.GetBytes(password);
                    byte[] hashData = new MD5CryptoServiceProvider().ComputeHash(temp);
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < hashData.Length; i++)
                    {
                        sb.Append(hashData[i].ToString("x2"));

                    }
                    FormYesNoBox formYesNoBox = new FormYesNoBox("Bạn chắc chắn muốn cập nhật?");
                    formYesNoBox.ShowDialog();
                    if (formYesNoBox.GetValue() == 1)
                    {
                        if (BUS_Account.Instance.Update_DAL(Convert.ToInt32(Id), name, phone, username, sb.ToString(), Id_Type))
                        {
                            DeleteBinding();
                            SetView();
                            FormMessageBox form = new FormMessageBox("Cập nhật thành công!");
                            form.ShowDialog();
                        }
                        else
                        {
                            FormMessageBox form = new FormMessageBox("Cập nhật thất bại! Vui lòng kiểm tra lại dữ liệu");
                            form.ShowDialog();
                        }
                    }
                }
                else
                {
                    FormMessageBox form = new FormMessageBox("Vui lòng chọn loại món muốn cập nhật");
                    form.ShowDialog();
                }
            }else
            {
                FormMessageBox form = new FormMessageBox("Lỗi! Mật khẩu khác mật khẩu nhập lại!");
                form.ShowDialog();
            }
        }
    }
}
