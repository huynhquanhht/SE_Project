using DevExpress.XtraCharts;
using DXApplication1.DAL;
using System;
using System.Collections.Generic;
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
            try
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
            catch { }
        }

        private void LoadRevenuePerDay()
        {
            //SE_08 db = new SE_08();
            //var q = db.Bills.Select(p => new { total = p.Items.Select(x => x.Amount * x.Item.Price).Sum(), p.Date_Pay }).GroupBy(p => p.Date_Pay).FirstOrDefault();
            //dtgvRevenue.DataSource = GetRevenuePerDay();

            dtgvRevenue.DataSource = GetRevenuePerDay();
        }


        public object GetRevenuePerDay()
        {
            SE_08 db = new SE_08();
            int currMonth = DateTime.Now.Month;
            DateTime today = DateTime.Now;
            DateTime dBegin = new DateTime(today.Year, today.Month, 1);
            DateTime dEnd = dBegin.AddMonths(1).AddDays(-1);
            List<object> list = new List<object>();
            int cnt = 0;
            DateTime _today = DateTime.Today;
            DateTime d = dBegin;
            
            Series series = new Series("Ngày", ViewType.Bar);
            for (; d <= dEnd;)
            {
                var q = db.Bills.Where(p => p.Date_Pay.Day == d.Day && p.Date_Pay.Month == d.Month && p.Date_Pay.Year == d.Year && p.Status == true).Select(p => p).ToList();
                int total = 0;
                foreach (var item in q)
                {
                    total += db.BillInfos.Where(p => p.Id_Bill == item.Id).Select(p => p.Item.Price * p.Amount).Sum();
                }
                if (q.Count != 0)
                {
                    ++cnt;
                    var amonyousType = new { _cnt = cnt, _d = d, _total = total };
                    list.Add(amonyousType);
                }
                if (d<=_today)
                {
                    series.Points.Add(new SeriesPoint(d.Day.ToString(), total));
                }
                

                d = d.AddDays(1);
            }
            chartControl.Series.Add(series);
            return list;
        }

       

    }
}
