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
        public fSale()
        {
            InitializeComponent();
            LoadAll();
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
                    Text = i.ToString(),
                    AutoSize = true,
                    Size = new Size(size - 10, size - 10),
                    BackColor = color[i % 2],
                    Tag = listTable[i].Id
                };
                btn.Click += btn_Click;

                pnlTable.Controls.Add(btn);
            }
        }

        //void LoadPnlFood()
        //{
        //    int sizeImg = 65;
        //    int sizeBtn = 90;
        //    for (int i = 0; i < 10; ++i)
        //    {
        //        Image img = System.Drawing.Image.FromFile(@"E:\DoAn\MR1 - 17.5\DXApplication1\DXApplication1\Image\FoodImg\TomHum.jpg");
        //        img = (Image)(new Bitmap(img, sizeImg, sizeImg));
        //        Button btn = new Button() { Size = new Size(sizeBtn, sizeBtn), FlatStyle = FlatStyle.Flat, BackgroundImageLayout = ImageLayout.Zoom, Image = img, Text = "300.000", TextAlign = ContentAlignment.BottomCenter, ImageAlign = ContentAlignment.TopCenter };
        //        btn.BackColor = Color.White;

        //        pnlTable.Controls.Add(btn);
        //    }
        //}

        void LoadAll()
        {
            LoadPnTable();
            LoadListCategory();
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
                var q = db.Bills.Where(p => p.Id_Table == IDTable && p.Is_Deleted == false).Select(p => p.Id).FirstOrDefault();
                // MessageBox.Show(q + "");
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
                // int IDCategory = (int)(cbbCategory.SelectedItem as CbbItem).Key;
                if (cbbFood.SelectedItem == null || cbbCategory.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn món");

                }
                else
                {
                    MessageBox.Show("AA");
                    int IDFood = (int)(cbbFood.SelectedItem as CbbItem).Key;
                    int amount = Int32.Parse(nmAmount.Value.ToString());
                    int IDBill = Convert.ToInt32(dtgvBill.Tag);
                    AddFood(IDBill, IDFood, amount);
                    gridView1.AddNewRow();
                    (dtgvBill.MainView as DevExpress.XtraGrid.Views.Grid.GridView).AddNewRow();
                    int rowHandle = gridView1.GetRowHandle(gridView1.DataRowCount);
                    Item food = GetFoodByIDFood(IDFood);
                  //  if (gridView1.IsNewItemRow(rowHandle))
                    {
                        MessageBox.Show(GetNameFoodByIDFood(IDFood) + "\n" + nmAmount.Value + "\n" + food.Price+"\n"+ rowHandle);
                        gridView1.SetRowCellValue(rowHandle, gridView1.Columns["Tên món"], GetNameFoodByIDFood(IDFood));
                        gridView1.SetRowCellValue(rowHandle, gridView1.Columns["Số lượng"], nmAmount.Value);
                        gridView1.SetRowCellValue(rowHandle, gridView1.Columns["Đơn giá"], food.Price);
                        //(dtgvBill.MainView as DevExpress.XtraGrid.Views.Grid.GridView).SetRowCellValue(rowHandle, gridView1.Columns["Thành tiền"], (food.Price * nmAmount.Value));
                        gridView1.SetRowCellValue(rowHandle, gridView1.Columns["Thành tiền"], (food.Price * nmAmount.Value));

                    }
                }

            }


        }
        private void btn_Click(object sender, EventArgs e)
        {
            int idTable = (int)(sender as Button).Tag;
            dtgvBill.Tag = idTable;
            showBill(idTable);
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

        private void showBill(int IDTable)
        {
            //dtgvBill.ItemClear();
            List<DTO.BillInfo> listInfo = GetListBillInfoByIDTable(IDTable);
            // int totalPrice = 0;
            foreach (BillInfo bi in listInfo)
            {
                Item food = GetFoodByIDFood(bi.Id_Item);
                ListViewItem lsvItem = new ListViewItem(food.Name);
                lsvItem.SubItems.Add(food.Price.ToString());
                lsvItem.SubItems.Add(bi.Amount.ToString());
                //lsvItem.SubItems.Add(item.TotalPrice.ToString());
                //dtgvBill.Items.Add(lsvItem);
                //totalPrice += item.TotalPrice;
            }
            //CultureInfo culture = new CultureInfo("vi-VN");
            //txtTotalPrice.Text = totalPrice.ToString("c", culture);
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
        private void AddFood(int IDBill, int IDFood, int amount)
        {
            using (SE_08 db = new SE_08())
            {
                db.BillInfos.Add(new BillInfo { Id_Bill = IDBill, Id_Item = IDFood, Amount = amount });
                db.SaveChanges();
            }
        }
    }
}