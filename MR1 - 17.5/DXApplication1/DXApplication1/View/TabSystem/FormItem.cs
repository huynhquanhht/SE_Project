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
using DXApplication1.DTO;
using DXApplication1.DAL;
using DXApplication1.View.All;

namespace DXApplication1
{
    public partial class frm_Item : DevExpress.XtraEditors.XtraForm
    {

        public frm_Item()
        {
            InitializeComponent();
            SetCBB();
            SetView();
            LoadBinding();
            LoadFirst();

        }
        public void SetView()
        {
            //txt_Id.Enabled = false;
            string category = cbb_Category.SelectedItem.ToString();
            foreach (CBBItem i in cbb_Category.Items)
            {
                if (i.Text == category)
                {

                    if (BUS_Item.Instance.Show_DAL(i.Value) != null)
                    {
                        grd_Item.DataSource = BUS_Item.Instance.Show_DAL(i.Value);
                    }
                    else
                    {

                        FormMessageBox form = new FormMessageBox("Tải dữ liệu món thất bại!");
                        form.ShowDialog();
                    }
                    break;
                }
            }
        }
        public void SetCBB()
        {
            if (cbb_Category.Items != null)
            {
                cbb_Category.Items.Clear();
            }
            cbb_Category.Items.Add(new CBBItem { Value = 0, Text = "Tất cả" });
            List<dynamic> list_Category = BUS_Category.Instance.GetCategory_DAL().ToList();
            if (list_Category != null)
            {
                for (int i = 0; i < list_Category.Count; i++)
                {
                    cbb_Category.Items.Add(new CBBItem
                    {
                        Value = list_Category[i].Id,
                        Text = list_Category[i].Name
                    });
                    cbb_CategoryDetail.Items.Add(new CBBItem
                    {
                        Value = list_Category[i].Id,
                        Text = list_Category[i].Name
                    });
                }
                cbb_Category.SelectedIndex = 0;
            }
            else
            {
                FormMessageBox form = new FormMessageBox("Lỗi! Tải dữ liệu loại món thất bại!");
                form.ShowDialog();
            }
        }
        public void LoadBinding()
        {
            string Name_Category = cbb_Category.SelectedItem.ToString();
            int Id_Category = 0;
            foreach (CBBItem i in cbb_Category.Items)
            {
                if (i.Text == Name_Category)
                {
                    Id_Category = i.Value;
                    break;
                }
            }
            if (BUS_Item.Instance.Show_DAL(Id_Category) != null)
            {
                DeleteBinding();
                //   txt_Id.DataBindings.Add(new Binding("Text", dgv_Item.DataSource, "Id"));
                txt_Name.DataBindings.Add(new Binding("Text", dgv_Item.DataSource, "Name"));
                cbb_CategoryDetail.DataBindings.Add(new Binding("Text", dgv_Item.DataSource, "Name_Category"));
                txt_Price.DataBindings.Add(new Binding("Text", dgv_Item.DataSource, "Price"));
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
            //txt_Id.DataBindings.Clear();
            txt_Name.DataBindings.Clear();
            cbb_CategoryDetail.DataBindings.Clear();
            txt_Price.DataBindings.Clear();

            //  txt_Id.ResetText();
            txt_Name.ResetText();
            cbb_CategoryDetail.ResetText();
            txt_Price.ResetText();
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            string name_Item = txt_Name.Text;
            string name_Category = "";
            int price_Item = 0;
            int Id_Category = 0;

            if (cbb_CategoryDetail.SelectedItem != null)
            {
                name_Category = cbb_CategoryDetail.SelectedItem.ToString();
            }
            if (txt_Price.Text.ToString() != "")
            {
                price_Item = Convert.ToInt32(txt_Price.Text);
            }
            foreach (CBBItem i in cbb_Category.Items)
            {
                if (i.Text == name_Category)
                {
                    Id_Category = i.Value;
                    break;
                }
            }
            if (price_Item != 0)
            {
                if (BUS_Item.Instance.Add_DAL(name_Item, Id_Category, price_Item))
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
        private void btn_Search_Click(object sender, EventArgs e)
        {
            string Name_Category = cbb_Category.SelectedItem.ToString();
            string str_Search = txt_Search.Text.Trim();
            int Id_Category = 0;
            foreach (CBBItem i in cbb_Category.Items)
            {
                if (i.Text == Name_Category)
                {
                    Id_Category = i.Value;
                    break;
                }
            }
            if (BUS_Item.Instance.Search_DAL(Id_Category, str_Search) != null)
            {
                DeleteBinding();
                grd_Item.DataSource = BUS_Item.Instance.Search_DAL(Id_Category, str_Search);
            }
            else
            {
                DeleteBinding();
                FormMessageBox form = new FormMessageBox("Dữ liệu tìm kiếm không tồn tại!");
                form.ShowDialog();
            }
        }
        private void dgv_Item_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            LoadBinding();
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            // Lôi không có giá, nó tự load lại giá cũ
            //string Id = txt_Id.Text;
            int focusedRow = -1;
            try
            {
                focusedRow = dgv_Item.FocusedRowHandle;

            }
            catch { }
            int id = -1;
            try
            {
                id = (int)dgv_Item.GetRowCellValue(dgv_Item.FocusedRowHandle, grdcol_IdItem);
            }
            catch { id = -1; }
            string name_Update = txt_Name.Text;
            string name_Category = "";
            string price_Item = txt_Price.Text;
            int price_Update = 0;
            int Id_Category_Update = 0;
            if (cbb_CategoryDetail.SelectedItem != null)
            {
                name_Category = cbb_CategoryDetail.SelectedItem.ToString();
            }
            if (price_Item != "")
            {
                price_Update = Convert.ToInt32(price_Item);
            }
            foreach (CBBItem i in cbb_Category.Items)
            {
                if (i.Text == name_Category)
                {
                    Id_Category_Update = i.Value;
                    break;
                }
            }
            if (id != -1)
            {
                FormYesNoBox formYesNoBox = new FormYesNoBox("Bạn chắc chắn muốn cập nhật?");
                formYesNoBox.ShowDialog();
                if (formYesNoBox.GetValue() == 1)
                {
                    if (price_Update != 0)
                    {
                        if (BUS_Item.Instance.Update_DAL(id, name_Update, Id_Category_Update, price_Update))
                        {
                            DeleteBinding();
                            SetView();
                            LoadBinding();
                            dgv_Item.FocusedRowHandle = focusedRow;
                            dgv_Item.SelectRow(focusedRow);
                            dgv_Item.Focus();
                            FormMessageBox form = new FormMessageBox("Cập nhật thành công!");
                            form.ShowDialog();
                        }
                        else
                        {
                            FormMessageBox form = new FormMessageBox("Cập nhật thất bại! Vui lòng kiểm tra lại dữ liệu");
                            form.ShowDialog();
                        }
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

            int[] selectedRows = dgv_Item.GetSelectedRows();
            int id = -1;
            try
            {
                id = (int)dgv_Item.GetRowCellValue(dgv_Item.FocusedRowHandle, grdcol_IdItem);
            }
            catch { id = -1; }
            if (id != -1)
            {
                foreach (int rowHandle in selectedRows)
                {
                    if (rowHandle >= 0)
                    {
                        object cellValue = dgv_Item.GetRowCellValue(rowHandle, grdcol_IdItem);
                        list_Dell.Add((int)cellValue);
                    }
                }
                FormYesNoBox formYesNoBox = new FormYesNoBox("Bạn chắc chắn muốn xóa?");
                formYesNoBox.ShowDialog();
                if (formYesNoBox.GetValue() == 1)
                {
                    if (BUS_Item.Instance.Delete_DAL(list_Dell))
                    {
                        FormMessageBox formMessageBox = new FormMessageBox("Xóa thành công!");
                        DeleteBinding();
                        SetView();
                        formMessageBox.ShowDialog();

                    }
                    else
                    {
                        FormMessageBox formMessageBox = new FormMessageBox("Xóa thất bại! Vui lòng kiểm tra lại dữ liệu!");
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
        private void LoadFirst()
        {
            try
            {
                int focusedRow = dgv_Item.FocusedRowHandle;
                dgv_Item.FocusedRowHandle = focusedRow;
                dgv_Item.SelectRow(focusedRow);
                dgv_Item.Focus();
            }
            catch { }
        }
        private void cbb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            int IDCategory = (cbb_Category.SelectedItem as CBBItem).Value;
            grd_Item.DataSource = BUS_Item.Instance.GetFoodByIDCategory(IDCategory);
        }
    }
}