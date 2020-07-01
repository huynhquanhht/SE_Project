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
using DXApplication1.DTO;
using DXApplication1.View.All;
using System.Collections;

namespace DXApplication1.GUI
{
    public partial class frm_Category : DevExpress.XtraEditors.XtraForm
    {
        public frm_Category()
        {
            InitializeComponent();
            SetView();
            LoadBinding();
            LoadFirst();
        }
        public void SetView()
        {
            txt_Id.Enabled = false;
            grd_Category.DataSource = BUS_Category.Instance.Show_DAL();
        }
        public void LoadBinding()
        {
            if (BUS_Category.Instance.Show_DAL() != null)
            {
                DeleteBinding();
                txt_Id.DataBindings.Add(new Binding("Text", dgv_Category.DataSource, "Id"));
                txt_Name.DataBindings.Add(new Binding("Text", dgv_Category.DataSource, "Name"));
                
            }
            else
            {
                DeleteBinding();
            }
          
        }
        public void DeleteBinding()
        {
            txt_Name.DataBindings.Clear();
            txt_Id.DataBindings.Clear();
            txt_Name.ResetText();
            txt_Id.ResetText();
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            string name_Category = txt_Name.Text;
            if (BUS_Category.Instance.Add_DAL(name_Category))
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
            if (BUS_Category.Instance.Search_DAL(str_Search) != null)
            {
                DeleteBinding();
                grd_Category.DataSource = BUS_Category.Instance.Search_DAL(str_Search);
            }
            else
            {
                DeleteBinding();
                FormMessageBox form = new FormMessageBox("Dữ liệu tìm kiếm không tồn tại!");
                form.ShowDialog();
            }
        }
        private void dgv_Category_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            LoadBinding();
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            String name_update = txt_Name.Text;
            String Id = txt_Id.Text;
            if (Id != "")
            {
                FormYesNoBox formYesNoBox = new FormYesNoBox("Bạn chắc chắn muốn cập nhật?");
                formYesNoBox.ShowDialog();
                if (formYesNoBox.GetValue() == 1)
                {
                    if (BUS_Category.Instance.Update_DAL(Convert.ToInt32(Id), name_update))
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
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            List<int> list_Dell = new List<int>();

            int[] selectedRows = dgv_Category.GetSelectedRows();
            if (txt_Id.Text != "")
            {
                foreach (int rowHandle in selectedRows)
                {
                    if (rowHandle >= 0)
                    {
                        object cellValue = dgv_Category.GetRowCellValue(rowHandle, grdcol_IdCategory);
                        list_Dell.Add((int)cellValue);
                    }
                }
                FormYesNoBox formYesNoBox = new FormYesNoBox("Bạn chắc chắn muốn xóa?");
                formYesNoBox.ShowDialog();
                if (formYesNoBox.GetValue() == 1)
                {
                    if (BUS_Category.Instance.Delete_DAL(list_Dell))
                    {
                        FormMessageBox formMessageBox = new FormMessageBox("Xóa thành công!");
                        DeleteBinding();
                        formMessageBox.ShowDialog();
                        SetView();
                    }
                    else
                    {
                        FormMessageBox formMessageBox = new FormMessageBox("Xóa thất bại! Vui lòng kiểm tra lại!");
                        formMessageBox.ShowDialog();

                    }
                }
            }
            else
            {
                FormMessageBox form = new FormMessageBox("Vui lòng chọn loại món muốn xóa!");
                form.ShowDialog();
            }

           
        }
        private void LoadFirst()
        {
            try
            {
                int focusedRow = dgv_Category.FocusedRowHandle;
                dgv_Category.FocusedRowHandle = focusedRow;
                dgv_Category.SelectRow(focusedRow);
                dgv_Category.Focus();
            }
            catch { }
        }
    }
}