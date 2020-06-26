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
using DXApplication1.View.All;
using DXApplication1.DTO;

namespace DXApplication1.GUI
{
    public partial class frm_Employee : DevExpress.XtraEditors.XtraForm
    {
        public frm_Employee()
        {
            InitializeComponent();
            SetView();
            
        }
        public void SetView()
        {
            txt_Id.Enabled = false;
            if (BUS_Employee.Instance.Show_DAL() != null)
            {
                grd_Employee.DataSource = BUS_Employee.Instance.Show_DAL();
            }
            else
            {
                FormMessageBox form = new FormMessageBox("Lỗi! Tải dữ liệu nhân viên thất bại!");
                form.ShowDialog();
            }
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            string str_Search = txt_Search.Text;
            if (BUS_Employee.Instance.Search_DAL(str_Search) != null)
            {
                DeleteBinding();
                grd_Employee.DataSource = BUS_Employee.Instance.Search_DAL(str_Search);
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
            DateTime birthday = de_Birthday.DateTime.Date;
            bool gender = rbtn_Male.Checked ? true : false;
            string address = txt_Address.Text;
            string phone = txt_Phone.Text;

            if (BUS_Employee.Instance.Add_DAL(name, birthday, gender, address, phone))
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
        public void LoadBinding()
        {
            if (BUS_Employee.Instance.Show_DAL() != null)
            {
                DeleteBinding();
                txt_Id.DataBindings.Add(new Binding("Text", dgv_Employee.DataSource, "Id"));
                txt_Name.DataBindings.Add(new Binding("Text", dgv_Employee.DataSource, "Name"));
                var maleBinding = new Binding("Checked", dgv_Employee.DataSource, "Gender");
                maleBinding.Format += (s, args) => args.Value = Convert.ToString(args.Value);
                maleBinding.Parse += (s, args) => args.Value = (bool)args.Value ? true : false;
                // add the binding
                rbtn_Male.DataBindings.Add(maleBinding);
                rbtn_Male.CheckedChanged += (s, args) => rbtn_Female.Checked = !rbtn_Male.Checked;
                
                de_Birthday.DataBindings.Add(new Binding("DateTime", dgv_Employee.DataSource, "Birthday"));
                txt_Address.DataBindings.Add(new Binding("Text", dgv_Employee.DataSource, "Address"));
                txt_Phone.DataBindings.Add(new Binding("Text", dgv_Employee.DataSource, "Phone"));

            }
            else
            {
                FormMessageBox form = new FormMessageBox("Lỗi! Nạp dữ liệu thất bại!");
                form.ShowDialog();
                DeleteBinding();
            }
        }
        public void DeleteBinding()
        {
            txt_Id.DataBindings.Clear();
            txt_Name.DataBindings.Clear();
            rbtn_Male.DataBindings.Clear();
            rbtn_Female.DataBindings.Clear();
            de_Birthday.DataBindings.Clear();
            txt_Address.DataBindings.Clear();
            txt_Phone.DataBindings.Clear();

            txt_Id.ResetText();
            txt_Name.ResetText();
            rbtn_Male.Checked = false;
            rbtn_Female.Checked = false;
            de_Birthday.ResetText();
            txt_Address.ResetText();
            txt_Phone.ResetText();


        }
        private void dgv_Employee_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            LoadBinding();
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            List<int> list_Dell = new List<int>();

            int[] selectedRows = dgv_Employee.GetSelectedRows();
            if (txt_Id.Text != "")
            {
                foreach (int rowHandle in selectedRows)
                {
                    if (rowHandle >= 0)
                    {
                        object cellValue = dgv_Employee.GetRowCellValue(rowHandle, grdcol_IdEmployee);
                        list_Dell.Add((int)cellValue);
                    }
                }
                FormYesNoBox formYesNoBox = new FormYesNoBox("Bạn chắc chắn muốn xóa?");
                formYesNoBox.ShowDialog();
                if (formYesNoBox.GetValue() == 1)
                {
                    if (BUS_Employee.Instance.Delete_DAL(list_Dell))
                    {
                        FormMessageBox formMessageBox = new FormMessageBox("Xóa thành công!");
                        DeleteBinding();
                        formMessageBox.ShowDialog();
                        SetView();
                    }
                    else
                    {
                        FormMessageBox form = new FormMessageBox("Xóa thất bại! Vui lòng kiểm tra lại dữ liệu");
                        form.ShowDialog();
                    }
                }
            }
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            String Id = txt_Id.Text;
            string name_Update = txt_Name.Text;
            DateTime birthday_Update = de_Birthday.DateTime.Date;
            bool gender_Update = rbtn_Male.Checked ? true : false;
            string address_Update = txt_Address.Text;
            string phone_Update = txt_Phone.Text;
            if (Id != "")
            {
                FormYesNoBox formYesNoBox = new FormYesNoBox("Bạn chắc chắn muốn cập nhật?");
                formYesNoBox.ShowDialog();
                if (formYesNoBox.GetValue() == 1)
                {

                    if (BUS_Employee.Instance.Update_DAL(Convert.ToInt32(Id), name_Update, birthday_Update, gender_Update, address_Update, phone_Update))
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
        }
    }

}