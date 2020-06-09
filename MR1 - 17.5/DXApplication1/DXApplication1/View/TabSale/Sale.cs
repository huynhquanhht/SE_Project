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
        private Employee employee = new Employee() { Id = 3, Id_Account = 1 };
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
            List<DTO.Table> listTable = GetListTable();
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



        void LoadAll()
        {
            LoadPnTable();
            LoadListCategory();
            LoadColumnBill();
        }


        private void LoadListCategory()
        {
            List<DTO.Category> listCategory = GetListCategory();
            foreach (DTO.Category c in listCategory)
            {
                cbbCategory.Items.Add(new CbbItem(c.Id, c.Name));
            }

        }

        private void LoadListFood(int IDCategory)
        {
            List<DTO.Item> listFood = GetListFood();
            foreach (DTO.Item i in listFood)
            {
                cbbFood.Items.Add(new CbbItem(i.Id, i.Name));
            }

        }
        private int GetTotal(int Id_Bill)
        {

            using (SE_08 db = new SE_08())
            {
                var q = db.BillInfos.Where(p => p.Id_Bill == Id_Bill && p.Id_Item == p.Item.Id && p.Is_Deleted == false).Select(p => p.Amount * p.Item.Price).ToString();
                return Int32.Parse(q);
            }
        }


        private List<DTO.Table> GetListTable()
        {
            List<DTO.Table> listTable = new List<DTO.Table>();
            using (SE_08 db = new SE_08())
            {
                listTable = db.Tables.Select(p => p).ToList();
            }
            return listTable;
        }
        private int GetIDBillByIDTable(int IDTable)
        {

            using (SE_08 db = new SE_08())
            {
                var q = db.Bills.Where(p => p.Id_Table == IDTable && p.Is_Deleted == false && p.Status == false).Select(p => p.Id).FirstOrDefault();
                //  MessageBox.Show("q: " + q);
                return q;
            }
        }

        private int CountTable()
        {
            using (SE_08 db = new SE_08())
            {
                return db.Tables.Count();
            }
        }

        private List<DTO.Category> GetListCategory()
        {
            List<DTO.Category> listCategory = new List<DTO.Category>();
            using (SE_08 db = new SE_08())
            {
                listCategory = db.Categories.Select(p => p).ToList();
            }
            return listCategory;
        }

        private List<DTO.Item> GetListFood()
        {
            List<DTO.Item> listFood = new List<DTO.Item>();
            using (SE_08 db = new SE_08())
            {
                listFood = db.Items.Select(p => p).ToList();
            }
            return listFood;
        }

        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadListFood((int)(cbbCategory.SelectedItem as CbbItem).Key);
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
                        int IDBill = GetIDBillByIDTable(IDTable);
                        if (IDBill == 0)
                        {
                            if (AddBill(IDTable))
                            {
                                IDBill = GetIDBillByIDTable(IDTable);
                                // MessageBox.Show("Tạo mới hoá đơn thành công");
                            }
                            else
                            {
                                MessageBox.Show("Tạo mới hoá đơn không thành công");
                            }

                        }
                        int IDFood = (int)(cbbFood.SelectedItem as CbbItem).Key;
                        Item food = GetFoodByIDFood(IDFood);
                        if (AddFood(IDBill, IDFood, amount))
                        {
                            gridView1.AddNewRow();
                            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0], food.Name);
                            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[1], amount);
                            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[2], food.Price);
                            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[3], food.Price * amount);
                            //MessageBox.Show("Thêm món thành công");
                            LoadTotalPrice(IDTable);
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
                    // MessageBox.Show(iDTable + "\n" + employee.Id);
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
            // int IDBill = GetIDBillByIDTable(Convert.ToInt32(dtgvBill.Tag));
            // MessageBox.Show("IDBill: " + IDBill);
            //  MessageBox.Show(idTable.ToString());
            showBill(IdTable);
            LoadTotalPrice(IdTable);
        }
        private List<BillInfo> GetListBillInfoByIDTable(int IDTable)
        {


            List<BillInfo> listBillInfo = new List<BillInfo>();

            using (SE_08 db = new SE_08())
            {
                int IDBill = GetIDBillByIDTable(IDTable);
                listBillInfo = db.BillInfos.Where(p => p.Id_Bill == IDBill && p.Bill.Is_Deleted == false).Select(p => p).ToList();
            }
            return listBillInfo;
        }
        private void LoadColumnBill()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Tên món", Type.GetType("System.String"));
            dt.Columns.Add("Số lượng", Type.GetType("System.Int32"));
            dt.Columns.Add("Đơn giá", Type.GetType("System.Int32"));
            dt.Columns.Add("Tổng tiền", Type.GetType("System.Int32"));

            DataRow dr = dt.NewRow();
            dtgvBill.DataSource = dt;

        }
        private void showBill(int IDTable)
        {
            //dtgvBill.DataSource = null;
            //gridView1.DataSource = null;
            // MessageBox.Show(gridView1.RowCount + "");
            //for (int i = 0; i <10; i++)
            //{
            //    gridView1.DeleteRow(i);
            LoadColumnBill();

            List<BillInfo> listBillInfo = new List<BillInfo>();
            using (SE_08 db = new SE_08())
            {
                int IDBill = GetIDBillByIDTable(IDTable);
                listBillInfo = db.BillInfos.Where(p => p.Id_Bill == IDBill && p.Bill.Id_Table == IDTable && p.Bill.Status == false).Select(p => p).ToList();
                foreach (BillInfo item in listBillInfo)
                {

                    int IDFood = item.Id_Item;
                    Item food = GetFoodByIDFood(IDFood);
                    gridView1.AddNewRow();
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0], food.Name);
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[1], item.Amount);
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[2], food.Price);
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[3], food.Price * item.Amount);
                    //MessageBox.Show(food.Name+"\n"+item.Amount+"\n"+food.Price);
                }

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
                    //  MessageBox.Show(IDBill + "\n" + IDFood + "\n" + amount);
                    db.BillInfos.Add(new BillInfo { Id_Bill = IDBill, Id_Item = IDFood, Amount = amount });
                    return db.SaveChanges() > 0;
                    //db.SubmitChanges();
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
                    int IDBill = GetIDBillByIDTable(IDTable);
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
                int IDBill = GetIDBillByIDTable(IDTable);
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
                int IDBill = GetIDBillByIDTable(IDTable);
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
                LoadColumnBill();
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
                    LoadColumnBill();
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
                int IDBill = GetIDBillByIDTable(IDTable);
                using (SE_08 db = new SE_08())
                {
                    var q = db.Bills.Where(p => p.Id == IDBill && p.Status == false).Select(p=>p).FirstOrDefault();
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
            int IDBill = GetIDBillByIDTable(IDTable);
            if (IDBill != 0)
            {
                using (SE_08 db = new SE_08())
                {
                    return db.BillInfos.Where(p => p.Id_Bill == IDBill && p.Bill.Status == false).Sum(p => p.Amount * p.Item.Price);
                }
            }
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
    }
}