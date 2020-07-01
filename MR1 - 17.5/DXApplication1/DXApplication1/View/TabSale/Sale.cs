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
using System.Drawing.Drawing2D;
using DXApplication1.View.All;

namespace DXApplication1.GUI.TabSale
{

    public partial class fSale : DevExpress.XtraEditors.XtraForm
    {
        private int IDEmployee;
        //public fSale()
        //{
        //    InitializeComponent();
        //    LoadAll();
        //}
        public fSale(int IDEmployee)
        {
            InitializeComponent();
            LoadAll();
            this.IDEmployee = IDEmployee;
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
        }

        void LoadPnTable()
        {
            pnlTable.Controls.Clear();
            List<DTO.Table> listTable = BUS_Table.Instance.GetListTable();

            Color[] color = new Color[] { System.Drawing.Color.DodgerBlue, Color.Orange };
            pnlTable.BackColor = Color.Azure;
            pnlTable.AutoScroll = true;
            int size = 100;
            for (int i = 0; i < listTable.Count(); ++i)
            {
                Button btn = new Button()
                {
                    Text = (listTable[i].Name + "\n" + (listTable[i].Status == true ? "Đã đặt" : "Trống")).ToString(),
                    AutoSize = true,
                    Size = new Size(size - 10, size - 10),
                    BackColor = color[Convert.ToInt32(listTable[i].Status == true)],
                    Tag = listTable[i].Id,
                    ForeColor = Color.White
                };
                try
                {
                    if ((int)btn.Tag == (int)(dtgvBill.Tag))
                    {
                        btn.BackColor = Color.Red;
                        //  TagID = btn;
                    }
                }
                catch { }

                btn.Font = new Font(btn.Font.Name, btn.Font.Size, FontStyle.Bold);
                btn.Click += btn_Click;
                pnlTable.Controls.Add(btn);
            }
        }
        private void LoadAll()
        {
            TagID = -1;
            LoadPnTable();
            LoadListCategory();
            LoadCbbTable1();
            LoadCbbTable2();

        }
        private void LoadCbbTable1()
        {
            List<Table> listTable = BUS_Table.Instance.GetListTable();
            List<CbbItem> listItem = new List<CbbItem>();
            foreach (Table t in listTable)
            {
                listItem.Add(new CbbItem(t.Id, t.Name));
            }
            cbbTable1.DataSource = listItem;
        }
        private void LoadCbbTable2()
        {
            List<Table> listTable = BUS_Table.Instance.GetListTable();
            List<CbbItem> listItem = new List<CbbItem>();
            foreach (Table t in listTable)
            {
                listItem.Add(new CbbItem(t.Id, t.Name));
            }
            cbbTable2.DataSource = listItem;
        }
        private void LoadListCategory()
        {
            List<DTO.Category> listCategory = BUS_Category.Instance.GetListCategory();
            List<CbbItem> listItem = new List<CbbItem>();
            foreach (DTO.Category i in listCategory)
            {
                listItem.Add(new CbbItem(i.Id, i.Name));
            }
            cbbCategory.DataSource = listItem;
        }
        private void LoadCbbFood(int IDCategory)
        {
            List<DTO.Item> listFood = BUS_Item.Instance.GetListFoodByIDCategory(IDCategory);
            List<CbbItem> listItem = new List<CbbItem>();
            foreach (DTO.Item i in listFood)
            {
                listItem.Add(new CbbItem(i.Id, i.Name));
            }
            cbbFood.DataSource = listItem;
        }
        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCbbFood((int)(cbbCategory.SelectedItem as CbbItem).Key);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dtgvBill.Tag == null)
            {
                new FormMessageBox("Vui lòng chọn bàn").ShowDialog();
            }
            else
            {
                if (cbbFood.SelectedItem == null || cbbCategory.SelectedItem == null)
                {
                    new FormMessageBox("Vui lòng chọn món").ShowDialog();
                }
                else
                {
                    int amount = (int)nmAmount.Value;
                    if (amount == 0)
                    {
                        new FormMessageBox("Vui lòng nhập số lượng khác 0").ShowDialog();
                    }
                    else
                    {

                        int IDTable = Convert.ToInt32(dtgvBill.Tag);
                        int IDBill = BUS_Bill.Instance.GetIDBillByIDTable(IDTable);
                        if (IDBill == 0)
                        {
                            if (BUS_Bill.Instance.AddBill(IDTable, this.IDEmployee, (int)nmDiscount.Value))
                            {
                                IDBill = BUS_Bill.Instance.GetIDBillByIDTable(IDTable);

                            }
                            else
                            {
                                new FormMessageBox("Tạo mới hoá đơn không thành công").ShowDialog();
                            }
                        }
                        int IDFood = (int)(cbbFood.SelectedItem as CbbItem).Key; ;
                        if (BUS_Item.Instance.AddFood(IDBill, IDFood, amount))
                        {
                            BUS_Table.Instance.SetStatusTableByIDTable((int)dtgvBill.Tag, true);
                            showBill(IDTable);
                            LoadTotalPrice(IDTable);
                            LoadPnTable();
                        }
                        else
                        {
                            new FormMessageBox("Thêm món không thành công").ShowDialog();
                        }
                    }
                }
            }
        }
        //  private Button preButton = null;
        private int TagID = -1;
        private void btn_Click(object sender, EventArgs e)
        {
            int IdTable = (int)(sender as Button).Tag;
            dtgvBill.Tag = IdTable;
            //   MessageBox.Show(IdTable.ToString());
            if (TagID == -1) TagID = (int)(sender as Button).Tag;
            else
            {
                Color[] color = new Color[] { System.Drawing.Color.DodgerBlue, Color.Orange };
                Table t = BUS_Table.Instance.GetTableByIDTable(TagID);
                foreach (Control control in pnlTable.Controls)
                {
                    if (control is Button)
                    {
                        Button btn = control as Button;
                        if ((int)btn.Tag == TagID)
                        {
                            btn.Tag = TagID;
                            btn.Text = t.Name + "\n" + (t.Status == true ? "Đã đặt" : "Trống").ToString();
                            btn.BackColor = color[Convert.ToInt32(t.Status == true)];
                            btn.Font = new Font((sender as Button).Font.Name, (sender as Button).Font.Size, FontStyle.Bold);
                        }
                    }
                }

            }
            (sender as Button).BackColor = Color.Red;
            TagID = (int)(sender as Button).Tag;
            showBill(IdTable);
            LoadTotalPrice(IdTable);
        }
        private void showBill(int IDTable)
        {
            dtgvBill.DataSource = BUS_BillInfo.Instance.GetBillInfoDetail(IDTable);
        }
        private void btnDell_Click(object sender, EventArgs e)
        {
            int[] selectedRowHandles = gridView1.GetSelectedRows();
            if (RemoveFood(selectedRowHandles))
            {
                foreach (int row in selectedRowHandles)
                {
                    gridView1.DeleteRow(row);
                    lbTotalPrice.Text = BUS_BillInfo.Instance.GetTotalPrice((int)dtgvBill.Tag).ToString();
                }
                if (BUS_Bill.Instance.RemoveBillNotExistItem((int)dtgvBill.Tag))
                {
                    BUS_Table.Instance.SetStatusTableByIDTable((int)dtgvBill.Tag, false);
                }
                showBill((int)dtgvBill.Tag);
                LoadTotalPrice((int)dtgvBill.Tag);
                LoadPnTable();
            }
            else
            {
                new FormMessageBox("Xoá món không thành công").ShowDialog();
            }
        }
        private bool RemoveFood(int[] selectedRowHandles)
        {
            try
            {
                using (SE_08 db = new SE_08())
                {
                    int IDTable = (int)(dtgvBill.Tag);
                    int IDBill = BUS_Bill.Instance.GetIDBillByIDTable(IDTable);
                    foreach (int row in selectedRowHandles)
                    {
                        String foodName = (String)gridView1.GetRowCellValue(row, "Name");
                        var x = db.BillInfos.Where(p => p.Id_Bill == IDBill && p.Item.Name == foodName).Select(p => p).FirstOrDefault();
                        db.BillInfos.Remove(x);
                    }
                    return db.SaveChanges() > 0;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show("Có lỗi xảy ra khi xoá món từ hoá đơn");
                return false;
            }
        }
        private void btnCancle_Click(object sender, EventArgs e)
        {
            if (BUS_Bill.Instance.RemoveBill((int)dtgvBill.Tag))
            {
                showBill((int)dtgvBill.Tag);
                LoadTotalPrice((int)dtgvBill.Tag);
                lbTotalPrice.Text = "0";
                LoadPnTable();
                //MessageBox.Show("Huỷ hoá đơn thành công");
            }
            else
            {
                new FormMessageBox("Huỷ hoá đơn không thành công").ShowDialog();
            }
        }
        private void btnPay_Click(object sender, EventArgs e)
        {
            FormYesNoBox f = new FormYesNoBox("Bạn chắc chắn muốn thanh toán cho bàn " + BUS_Table.Instance.GetNameTableByIDTable((int)dtgvBill.Tag));
            f.ShowDialog();
            if (f.GetValue() == 1)
            {
                if (BUS_Bill.Instance.Pay((int)dtgvBill.Tag))
                {

                    showBill((int)dtgvBill.Tag);
                    LoadTotalPrice((int)dtgvBill.Tag);
                    new FormMessageBox("Thanh toán thành công").ShowDialog();
                    LoadPnTable();
                }
                else
                {
                    new FormMessageBox("Thanh toán không thành công").ShowDialog();
                }
            }
        }
        private void LoadTotalPrice(int IDTable)
        {
            lbTotalPrice.Text = BUS_Bill.Instance.GetTotalPrice(IDTable).ToString();
        }
        private void btnChangeMerge_Click(object sender, EventArgs e)
        {
            int IDTable1 = (int)(cbbTable1.SelectedItem as CbbItem).Key;
            int IDTable2 = (int)(cbbTable2.SelectedItem as CbbItem).Key;
            int IDBill1 = BUS_Bill.Instance.GetIDBillByIDTable(IDTable1);
            int IDBill2 = BUS_Bill.Instance.GetIDBillByIDTable(IDTable2);
            if (IDBill1 == 0)
            {
                new FormMessageBox("Bàn bạn muốn thao tác hiện đang hiện đang trống, không thể thực hiện").ShowDialog();
            }
            else
            {
                if (IDBill2 == 0)
                {
                    FormYesNoBox f = new FormYesNoBox("Bạn sẽ chuyển " + (cbbTable1.SelectedItem as CbbItem).Value.ToString() + " đến " + (cbbTable2.SelectedItem as CbbItem).Value.ToString());
                    f.ShowDialog();
                    if (f.GetValue() == 1)
                    {
                        if (BUS_Table.Instance.UpdateIDTableOfBillByIDTable(IDTable1, IDTable2))
                        {
                            showBill((int)dtgvBill.Tag);
                            LoadPnTable();
                            new FormMessageBox("Chuyển bàn thành công").ShowDialog();
                        }
                        else
                        {
                            new FormMessageBox("Chuyển bàn không thành công").ShowDialog();
                        }
                    }
                }
                else
                {
                    FormYesNoBox f = new FormYesNoBox("Bạn sẽ gộp " + (cbbTable1.SelectedItem as CbbItem).Value.ToString() + " vào " + (cbbTable2.SelectedItem as CbbItem).Value.ToString());
                    f.ShowDialog();
                    if (f.GetValue() == 1)
                    {
                        if (BUS_Bill.Instance.UpdateIDBillOfBillInfoByIDBill(IDTable1, IDTable2))
                        {
                            showBill((int)dtgvBill.Tag);
                            LoadPnTable();
                            new FormMessageBox("Gộp bàn thành công").ShowDialog();
                        }
                        else
                        {
                            new FormMessageBox("Gộp bàn không thành công").ShowDialog();
                        }
                    }
                }

            }
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nmDiscount_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                BUS_Bill.Instance.SetDiscount((int)dtgvBill.Tag, (int)nmDiscount.Value);
                LoadTotalPrice((int)dtgvBill.Tag);
            }
            catch { }

        }
    }
}