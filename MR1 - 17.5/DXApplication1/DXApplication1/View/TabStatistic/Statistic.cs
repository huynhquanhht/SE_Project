using DXApplication1.DAL;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DXApplication1.GUI.TabStatistic
{
    public partial class fStatistic : Form
    {
        public fStatistic()
        {
            InitializeComponent();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            LoadAll();
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
        }
        private void LoadAll()
        {
            LoadInfo();
            LoadRevenuePerDay();

        }
        private void LoadInfo()
        {
            SE_08 db = new SE_08();
            var q = db.Bills.Where(p => p.Status == true).Select(p => p);
            long total = 0;
            foreach (var item in q)
            {
                int? tmp = db.BillInfos.Where(p => p.Id_Bill == item.Id).Sum(p => p.Amount * p.Item.Price);
                total += (tmp == null ? 0 : (long)tmp);
            }

            btnTotal.Text = "Doanh thu\n" + total.ToString();
            int cntBill = db.Bills.Where(p => p.Status == true).Count();
            btnBill.Text = "Hoá đơn\n" + cntBill.ToString();
            int cntDrink = db.BillInfos.Where(p => p.Item.Category.Id == 5).Select(p => p.Amount).Sum();
            btnDrink.Text = "Thức uống\n" + cntDrink.ToString();
            int cntFood = db.BillInfos.Select(p => p.Amount).Sum() - cntDrink;
            btnFood.Text = "Món ăn\n" + cntFood.ToString();
        }

        private void LoadRevenuePerDay()
        {
            //SE_08 db = new SE_08();
            //var q = db.Bills.Select(p => new { total = p.Items.Select(x => x.Amount * x.Item.Price).Sum(), p.Date_Pay }).GroupBy(p => p.Date_Pay).FirstOrDefault();
            //dtgvRevenue.DataSource = GetRevenuePerDay();
            gridView1.RefreshData();
            dtgvRevenue.RefreshDataSource();
            dtgvRevenue.DataSource = GetRevenuePerDay(); 
        }

       
        public object GetRevenuePerDay()
        {
            SE_08 db = new SE_08();

            object q =
                ( from b in db.Bills
                  where b.Status == true
                  join bi in db.BillInfos
                 on b.Id equals bi.Id_Bill

                 join i in db.Items
                 on bi.Id_Item equals i.Id
                into tmp
                 group tmp by b.Date_Pay
                 into g
                 select new
                 {
                     
                     Total = bi.Amount * bi.Item.Price,
                     DatePay = b.Date_Pay
                 }).ToList()     ;
            // object listBillInfo = db.Bills.Join(db.BillInfos, (b => b.Id), (bi => bi.Id_Bill), (b, bi) => new { _payDate = b.Date_Pay, _amount = bi.Amount, _item = bi.Item }).Join(db.Items, (bi => bi._item.Id), (i => i.Id), (bi, i) => new { __payDate = bi._payDate, __Total = bi._amount * bi._item.Price }).Select(p => new { p.__Total, p.__payDate }).GroupBy(p => p.__payDate);
            //object q = from b in Bills
            //object listBillInfo = db.Bills.Join(db.BillInfos, (b => b.Id), (bi => bi.Id_Bill), (b, bi) => new { _payDate = b.Date_Pay, _amount = bi.Amount, _item = bi.Item }).Select(p => new { Total = p._item.Price * p._amount, p._payDate }).GroupBy(p=>p._payDate).ToList();
          
            //                      join bi in Bill
            //                      on b.ID equal bi.id_BIllID
            return q;
        }
    }
}
