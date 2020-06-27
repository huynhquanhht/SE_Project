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
namespace DXApplication1.GUI.TabSale
{

    public partial class fSale : DevExpress.XtraEditors.XtraForm
    {
        private Employee employee = new Employee() { Id = 3 };
        public fSale()
        {
            InitializeComponent();
            LoadAll();
        }
        public fSale(Employee employee)
        {
            InitializeComponent();
            LoadAll();

            //tmp
            this.employee = employee;
            this.employee.Id = 3;
        }



        void LoadPnTable()
        {
            List<DTO.Table> listTable = BUS_Table.Instance.GetListTable();
            int maxTable = CountTable();
            Color[] color = new Color[] { Color.Aqua, Color.BlueViolet };
            pnlTable.BackColor = Color.Azure;
            pnlTable.AutoScroll = true;
            int size = 60;
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



       
       

        private int CountTable()
        {
            using (SE_08 db = new SE_08())
            {
                return db.Tables.Count();
            }
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
                            if (AddBill(IDTable))
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
                        if (AddFood(IDBill, IDFood, amount))
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

        private bool AddBill(int iDTable)
        {
            try
            {
                using (SE_08 db = new SE_08())
                {
                    db.Bills.Add(new DTO.Bill { Id_Table = iDTable, Id_Employee = employee.Id, Date_Order = DateTime.Now, Date_Pay = DateTime.Now });

                    return db.SaveChanges() > 0;
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
                MessageBox.Show("Có lỗi khi tạo mới hoá đơn");
                return false;
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            int IdTable = (int)(sender as Button).Tag;
            dtgvBill.Tag = IdTable;
            showBill(IdTable);
            LoadTotalPrice(IdTable);
        }
        private List<BillInfo> GetListBillInfoByIDTable(int IDTable)
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();
            using (SE_08 db = new SE_08())
            {
                int IDBill = BUS_Bill.Instance.GetIDBillByIDTable(IDTable);
                listBillInfo = db.BillInfos.Where(p => p.Id_Bill == IDBill && p.Bill.Is_Deleted == false).Select(p => p).ToList();
            }
            return listBillInfo;
        }

        private void showBill(int IDTable)
        {
            using (SE_08 db = new SE_08())
            {
                int IDBill = BUS_Bill.Instance.GetIDBillByIDTable(IDTable);
                object listBillInfo = db.BillInfos.Where(p => p.Id_Bill == IDBill && p.Bill.Id_Table == IDTable && p.Bill.Status == false).Select(p => new { p.Item.Name, p.Amount, p.Item.Price, Total = p.Amount * p.Item.Price }).ToList();
                dtgvBill.DataSource = listBillInfo;

            }
        }

        private int GetIDFoodByNameFood(String NameFood)
        {
            using (SE_08 db = new SE_08())
            {
                return db.Items.Where(p => p.Name == NameFood).Select(p => p.Id).FirstOrDefault();
            }
        }
        private String GetNameFoodByIDFood(int IDFood)
        {
            using (SE_08 db = new SE_08())
            {
                return db.Items.Where(p => p.Id == IDFood).Select(p => p.Name).FirstOrDefault().ToString();
            }
        }

        private int GetPriceFoodByIDFood(int IDFood)
        {
            using (SE_08 db = new SE_08())
            {
                return (int)db.Items.Where(p => p.Id == IDFood).Select(p => p.Price).FirstOrDefault();
            }
        }
        private DTO.Item GetFoodByIDFood(int IDFood)
        {
            using (SE_08 db = new SE_08())
            {
                return (DTO.Item)db.Items.Where(p => p.Id == IDFood).Select(p => p).FirstOrDefault();
            }
        }
        private bool AddFood(int IDBill, int IDFood, int amount)
        {
            try
            {
                using (SE_08 db = new SE_08())
                {
                    int cnt = db.BillInfos.Where(p => p.Id_Item == IDFood && p.Id_Bill == IDBill).Count();
                    if (cnt <= 0 && amount > 0)
                    {
                        db.BillInfos.Add(new BillInfo { Id_Bill = IDBill, Id_Item = IDFood, Amount = amount });
                    }
                    else if (cnt > 0)
                    {
                        var q = db.BillInfos.Where(p => p.Id_Item == IDFood && p.Id_Bill == IDBill).Select(p => p).FirstOrDefault();
                        if (q.Amount + amount <= 0)
                        {
                            db.BillInfos.Remove(q);
                        }
                        else
                        {
                            q.Amount += amount;
                        }
                    }
                    return db.SaveChanges() > 0;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show("Có lỗi trong quá trình thêm món");
                return false;
            }
        }

        private void btnDell_Click(object sender, EventArgs e)
        {
            int[] selectedRowHandles = gridView1.GetSelectedRows();
            if (RemoveFood(selectedRowHandles))
            {
                foreach (int row in selectedRowHandles)
                {
                    gridView1.DeleteRow(row);
                    lbTotalPrice.Text = GetTotalPrice((int)dtgvBill.Tag).ToString();
                }
                RemoveBillNotExistItem((int)dtgvBill.Tag);
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
                        String foodName = (String)gridView1.GetRowCellValue(row, "Tên món");
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

        public bool RemoveBillNotExistItem(int IDTable)
        {
            try
            {
                int IDBill = BUS_Bill.Instance.GetIDBillByIDTable(IDTable);
                using (SE_08 db = new SE_08())
                {
                    //MessageBox.Show("Count: " + db.BillInfos.Where(p => p.Id_Bill == IDBill).Count().ToString());
                    if (db.BillInfos.Where(p => p.Id_Bill == IDBill).Count() <= 0)
                    {
                        var y = db.Bills.Where(p => p.Id == IDBill).Select(p => p).FirstOrDefault();
                        db.Bills.Remove(y);
                    }
                    return db.SaveChanges() > 0;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show("Có lỗi xảy ra khi xoá hoá đơn");
                return false;
            }
        }

        public bool RemoveBill(int IDTable)
        {
            try
            {
                int IDBill = BUS_Bill.Instance.GetIDBillByIDTable(IDTable);
                using (SE_08 db = new SE_08())
                {
                    //MessageBox.Show("Count: " + db.BillInfos.Where(p => p.Id_Bill == IDBill).Count().ToString());
                    var y = db.Bills.Where(p => p.Id == IDBill).Select(p => p).FirstOrDefault();
                    db.Bills.Remove(y);
                    return db.SaveChanges() > 0;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show("Có lỗi xảy ra khi huỷ hoá đơn");
                return false;
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            if (RemoveBill((int)dtgvBill.Tag))
            {
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
            if (MessageBox.Show("Bạn chắc chắn muốn thanh toán cho bàn " + GetNameTableByIDTable((int)dtgvBill.Tag), "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (Pay((int)dtgvBill.Tag))
                {
                    MessageBox.Show("Thanh toán thành công");
                }
                else
                {
                    MessageBox.Show("Thanh toán không thành công");
                }
            }
        }

        private bool Pay(int IDTable)
        {
            try
            {
                int IDBill = BUS_Bill.Instance.GetIDBillByIDTable(IDTable);
                using (SE_08 db = new SE_08())
                {
                    var q = db.Bills.Where(p => p.Id == IDBill && p.Status == false).Select(p => p).FirstOrDefault();
                    q.Status = true;
                    return db.SaveChanges() > 0;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show("Xảy ra lỗi khi thanh toán");
                return false;
            }
        }
        private int GetTotalPrice(int IDTable)
        {
            try
            {
                int IDBill = BUS_Bill.Instance.GetIDBillByIDTable(IDTable);
                if (IDBill != 0)
                {
                    using (SE_08 db = new SE_08())
                    {
                        return db.BillInfos.Where(p => p.Id_Bill == IDBill && p.Bill.Status == false).Sum(p => p.Amount * p.Item.Price);
                    }
                }
            }
            catch
            { }
            return 0;

        }

        private void LoadTotalPrice(int IDTable)
        {
            lbTotalPrice.Text = GetTotalPrice(IDTable).ToString();
        }
        private String GetNameTableByIDTable(int IDTable)
        {
            using (SE_08 db = new SE_08())
            {
                return db.Tables.Where(p => p.Id == IDTable).Select(p => p.Name).FirstOrDefault();
            }
        }
        private bool UpdateIDTableOfBillByIDTable(int IDBill, int IDTableU)
        {
            SE_08 db = new SE_08();
            var q = db.Bills.Where(p => p.Id == IDBill).Select(p => p).FirstOrDefault();
            q.Id_Table = IDTableU;
            return db.SaveChanges() > 0;
        }

        private bool UpdateIDBillOfBillInfoByIDBill(int IDBill1, int IDBill2)
        {
            SE_08 db = new SE_08();
            var q = db.BillInfos.Where(p => p.Id_Bill == IDBill1).Select(p => p);
            foreach (var item in q)
            {
                AddFood(IDBill2, item.Id_Item, item.Amount);
            }
            var d = db.Bills.Where(p => p.Id == IDBill1).Select(p => p).FirstOrDefault();
            db.Bills.Remove(d);
            return db.SaveChanges() > 0;
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
                        if (UpdateIDTableOfBillByIDTable(IDBill1, (int)(cbbTable2.SelectedItem as CbbItem).Key))
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
                        if (UpdateIDBillOfBillInfoByIDBill(IDBill1, IDBill2))
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

        private void cbbTable1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}