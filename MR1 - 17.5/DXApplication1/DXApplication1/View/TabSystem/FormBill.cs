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
using DXApplication1.DAL;
using DXApplication1.View.TabSystem;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;

namespace DXApplication1.GUI
{
    public partial class Bill : DevExpress.XtraEditors.XtraForm
    {
        public Bill()
        {
            InitializeComponent();
            LoadAll();
        }

        private void grd_Item_Click(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }
        private void LoadAll()
        {
            LoadBillDetail();
            dgv_Item.OptionsBehavior.Editable = false;
            dgv_Item.OptionsSelection.EnableAppearanceFocusedCell = false;
            dgv_Item.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;

        }


        private void LoadBillDetail()
        {
            grd_Item.DataSource = BUS_Bill.Instance.GetBillDetail();
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            List<int> list_Dell = new List<int>();

            int[] selectedRows = dgv_Item.GetSelectedRows();

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
                for (int i = 0; i < list_Dell.Count; ++i)
                {
                    if (BUS_Bill.Instance.DelBill(list_Dell[i]))
                    {

                        LoadBillDetail();
                        FormMessageBox formMessageBox = new FormMessageBox("Xóa thành công!");
                    }
                    else
                    {
                        FormMessageBox form = new FormMessageBox("Xóa thất bại! Vui lòng kiểm tra lại dữ liệu");
                        form.ShowDialog();
                    }
                }
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string str_Search = txtSearch.Text;
            if (BUS_Bill.Instance.Search_DAL(str_Search) != null)
            {

                grd_Item.DataSource = BUS_Bill.Instance.Search_DAL(str_Search);
            }
            else
            {

                FormMessageBox form = new FormMessageBox("Dữ liệu tìm kiếm không tồn tại!");
                form.ShowDialog();
            }
        }

        private void grd_Item_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void dgv_Item_DoubleClick(object sender, EventArgs e)
        {
            GridView view = sender as GridView;
            Point pt = view.GridControl.PointToClient(Control.MousePosition);
            GridHitInfo info = view.CalcHitInfo(pt);
            if (info.InRow)
            {
                FormBillDetail f = new FormBillDetail((int)dgv_Item.GetRowCellValue(info.RowHandle, grdcol_IdItem));
                f.ShowDialog();
            }
        }
    }
}