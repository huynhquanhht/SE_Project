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
namespace DXApplication1.GUI.TabSale
{

    public partial class fSale : DevExpress.XtraEditors.XtraForm
    {
        private int IDEmployee;
        public fSale()
        {
            InitializeComponent();
            LoadAll();
        }
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
            List<DTO.Table> listTable = BUS_Table.Instance.GetListTable();
            int maxTable = BUS_Table.Instance.CountTable();
            Color[] color = new Color[] { Color.Orange, System.Drawing.Color.DodgerBlue};
            pnlTable.BackColor = Color.Azure;
            pnlTable.AutoScroll = true;
            int size = 100;
            for (int i = 0; i < maxTable; ++i)
            {
                Button btn = new Button()
                {
                    Text = (i + 1).ToString(),
                    AutoSize = true,
                    Size = new Size(size - 10, size - 10),
                    BackColor = color[i % 2],
                    Tag = listTable[i].Id
                };
                btn.Click += btn_Click;
                pnlTable.Controls.Add(btn);
            }
        }
        private void LoadAll()
        {
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
                MessageBox.Show("Vui lòng chọn bàn");
            }
            else
            {
                if (cbbFood.SelectedItem == null || cbbCategory.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn món");
                }
                else
                {
                    int amount = (int)nmAmount.Value;
                    if (amount == 0)
                    {
                        MessageBox.Show("Vui lòng nhập số lượng khác 0");
                    }
                    else
                    {
                        int IDTable = Convert.ToInt32(dtgvBill.Tag);
                        int IDBill = BUS_Bill.Instance.GetIDBillByIDTable(IDTable);
                        if (IDBill == 0)
                        {
                            if (BUS_Bill.Instance.AddBill(IDTable, this.IDEmployee))
                            {
                                IDBill = BUS_Bill.Instance.GetIDBillByIDTable(IDTable);
                                // MessageBox.Show("Tạo mới hoá đơn thành công");
                            }
                            else
                            {
                                MessageBox.Show("Tạo mới hoá đơn không thành công");
                            }
                        }
                        int IDFood = (int)(cbbFood.SelectedItem as CbbItem).Key; ;
                        if (BUS_Item.Instance.AddFood(IDBill, IDFood, amount))
                        {
                            showBill(IDTable);
                            LoadTotalPrice(IDTable);
                            // MessageBox.Show("Thêm món thành công");
                        }
                        else
                        {
                            MessageBox.Show("Thêm món không thành công");
                        }
                    }
                }
            }
        }
        private void btn_Click(object sender, EventArgs e)
        {
            int IdTable = (int)(sender as Button).Tag;
            dtgvBill.Tag = IdTable;
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
                BUS_Bill.Instance.RemoveBillNotExistItem((int)dtgvBill.Tag);
                showBill((int)dtgvBill.Tag);
                LoadTotalPrice((int)dtgvBill.Tag);
            }
            else
            {
                MessageBox.Show("Xoá món không thành công");
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
                //MessageBox.Show("Huỷ hoá đơn thành công");
            }
            else
            {
                MessageBox.Show("Huỷ hoá đơn không thành công");
            }
        }
        private void btnPay_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thanh toán cho bàn " + BUS_Table.Instance.GetNameTableByIDTable((int)dtgvBill.Tag), "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (BUS_Bill.Instance.Pay((int)dtgvBill.Tag))
                {
                    showBill((int)dtgvBill.Tag);
                    LoadTotalPrice((int)dtgvBill.Tag);
                    MessageBox.Show("Thanh toán thành công");
                }
                else
                {
                    MessageBox.Show("Thanh toán không thành công");
                }
            }
        }
        private void LoadTotalPrice(int IDTable)
        {
            lbTotalPrice.Text = BUS_BillInfo.Instance.GetTotalPrice(IDTable).ToString();
        }
        private void btnChangeMerge_Click(object sender, EventArgs e)
        {
            int IDBill1 = BUS_Bill.Instance.GetIDBillByIDTable((int)(cbbTable1.SelectedItem as CbbItem).Key);
            int IDBill2 = BUS_Bill.Instance.GetIDBillByIDTable((int)(cbbTable2.SelectedItem as CbbItem).Key);
            if (IDBill1 == 0)
            {
                MessageBox.Show("Bàn bạn muốn thao tác hiện đang hiện đang trống, không thể thực hiện.");
            }
            else
            {
                if (IDBill2 == 0)
                {
                    if (DialogResult.Yes == MessageBox.Show("Bạn sẽ chuyển " + (cbbTable1.SelectedItem as CbbItem).Value.ToString() + " đến " + (cbbTable2.SelectedItem as CbbItem).Value.ToString(), "Thông báo", MessageBoxButtons.YesNo))
                    {
                        if (BUS_Table.Instance.UpdateIDTableOfBillByIDTable(IDBill1, (int)(cbbTable2.SelectedItem as CbbItem).Key))
                        {
                            showBill((int)dtgvBill.Tag);
                            MessageBox.Show("Chuyển bàn thành công", "Thông báo", MessageBoxButtons.YesNo);
                        }
                        else
                        {
                            MessageBox.Show("Chuyển bàn không thành công", "Thông báo", MessageBoxButtons.YesNo);
                        }
                    }
                }
                else
                {
                    if (DialogResult.Yes == MessageBox.Show("Bạn sẽ gộp " + (cbbTable1.SelectedItem as CbbItem).Value.ToString() + " vào " + (cbbTable2.SelectedItem as CbbItem).Value.ToString(), "Thông báo", MessageBoxButtons.YesNo))
                    {
                        if (BUS_Bill.Instance.UpdateIDBillOfBillInfoByIDBill(IDBill1, IDBill2))
                        {
                            showBill((int)dtgvBill.Tag);
                            MessageBox.Show("Gộp bàn thành công", "Thông báo", MessageBoxButtons.YesNo);
                        }
                        else
                        {
                            MessageBox.Show("Gộp bàn không thành công", "Thông báo", MessageBoxButtons.YesNo);
                        }
                    }
                }
            }
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}