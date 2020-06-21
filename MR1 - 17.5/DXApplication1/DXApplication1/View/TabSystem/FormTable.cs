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

namespace DXApplication1.GUI
{
    public partial class frm_Table : DevExpress.XtraEditors.XtraForm
    {
        public frm_Table()
        {
            InitializeComponent();
            SetView();
        }
        public void LoadBinding()
        {
            if (BUS_Table.Instance.Show_DAL() != null)
            {
                DeleteBinding();
                txt_Id.DataBindings.Add(new Binding("Text", dgv_Table.DataSource, "Id"));
                txt_Name.DataBindings.Add(new Binding("Text", dgv_Table.DataSource, "Name"));
                ckb_Status.DataBindings.Add(new Binding("Checked", dgv_Table.DataSource, "Status"));
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
            txt_Name.DataBindings.Clear();
            txt_Id.DataBindings.Clear();
            ckb_Status.DataBindings.Clear();
            txt_Name.ResetText();
            txt_Id.ResetText();
            ckb_Status.Reset();
        }
        public void SetView()
        {
            txt_Id.Enabled = false;
            if (BUS_Table.Instance.Show_DAL() != null)
            {
                grd_Table.DataSource = BUS_Table.Instance.Show_DAL();
            }
            else
            {
                FormMessageBox form = new FormMessageBox("Lỗi! Tải dữ liệu bàn ăn thất bại!");
                form.ShowDialog();
            }
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            string name_Table = txt_Name.Text;
            bool status = ckb_Status.Checked == true ? true : false;
            if (BUS_Table.Instance.Add_DAL(name_Table, status))
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
        private void btn_Search_Click(object sender, EventArgs e)
        {
            string str_Search = txt_Search.Text;
            if (BUS_Table.Instance.Search_DAL(str_Search) != null)
            {
                DeleteBinding();
                grd_Table.DataSource = BUS_Table.Instance.Search_DAL(str_Search);

            }
            else
            {
                DeleteBinding();
                FormMessageBox form = new FormMessageBox("Dữ liệu tìm kiếm không tồn tại!");
                form.ShowDialog();
            }
        }
        private void dgv_Table_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            LoadBinding();
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            String name_update = txt_Name.Text;
            String Id = txt_Id.Text;
            bool status_update = ckb_Status.Checked ? true : false;
            if (Id != "")
            {
                FormYesNoBox formYesNoBox = new FormYesNoBox("Bạn chắc chắn muốn cập nhật?");
                formYesNoBox.ShowDialog();
                if (formYesNoBox.GetValue() == 1)
                {
                    if (BUS_Table.Instance.Update_DAL(Convert.ToInt32(Id), name_update, status_update))
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
                FormMessageBox form = new FormMessageBox("Vui lòng chọn bàn ăn muốn cập nhật");
                form.ShowDialog();
            }
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            List<int> list_Dell = new List<int>();

            int[] selectedRows = dgv_Table.GetSelectedRows();
            if (txt_Id.Text != "")
            {
                foreach (int rowHandle in selectedRows)
                {
                    if (rowHandle >= 0)
                    {
                        object cellValue = dgv_Table.GetRowCellValue(rowHandle, grdcol_Id);
                        list_Dell.Add((int)cellValue);
                    }
                }
                FormYesNoBox formYesNoBox = new FormYesNoBox("Bạn chắc chắn muốn xóa?");
                formYesNoBox.ShowDialog();
                if (formYesNoBox.GetValue() == 1)
                {
                    if (BUS_Table.Instance.Delete_DAL(list_Dell))
                    {
                        FormMessageBox form = new FormMessageBox("Xóa thành công!");
                        form.ShowDialog();
                        DeleteBinding();
                        SetView();
                    }
                    else
                    {
                        FormMessageBox form = new FormMessageBox("Xóa thất bại! Vui lòng kiểm tra lại!");
                        form.ShowDialog();
                    }
                }
            }
            else
            {
                FormMessageBox form = new FormMessageBox("Vui lòng chọn bàn ăn muốn xóa!");
                form.ShowDialog();
            }


        }
    }
}