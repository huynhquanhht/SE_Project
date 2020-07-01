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

        }
        private void LoadAll()
        {
            LoadCbbMonth();
            LoadCbbYear();
            LoadInfo((int)(cbbMonth.SelectedItem as CbbItem).Key, (int)(cbbYear.SelectedItem as CbbItem).Value);
         
           // LoadRevenuePerDay(DateTime.Now.Month, DateTime.Now.Year);

            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;

        }
        private void LoadInfo(int month, int year)
        {
            try
            {
                SE_08 db = new SE_08();
                btnTotal.Text = "Doanh thu\n" + BUS_Bill.Instance.GetTotal(month, year).ToString();
                btnBill.Text = "Hoá đơn\n" + BUS_Bill.Instance.GetCntBill(month, year).ToString();
                btnDrink.Text = "Thức uống\n" + BUS_Bill.Instance.GetCntDrink(month, year).ToString();
                btnFood.Text = "Món ăn\n" + BUS_Bill.Instance.GetCntFood(month, year).ToString();
            }
            catch { }
        }

        private void LoadRevenuePerDay(int month, int year)
        {
            chartControl.Series.Clear();
            try
            {
                Series series = new Series("VND/Ngày", ViewType.Bar);
                SE_08 db = new SE_08();
                //  DateTime today = DateTime.Now;
                DateTime dBegin = new DateTime(year, month, 1);
                DateTime dEnd = dBegin.AddMonths(1).AddDays(-1);
                long[] total = new long[dEnd.Day];
                for (int i = 0; i < total.Length; ++i) total[i] = 0;
                var q = db.BillInfos.Where(p => p.Bill.Date_Pay.Day >= 1 && p.Bill.Date_Pay.Day <= dEnd.Day && p.Bill.Date_Pay.Month == dBegin.Month && p.Bill.Date_Pay.Year == dBegin.Year && p.Bill.Status == true && p.Bill.Is_Deleted == false).GroupBy(x => x.Bill.Date_Pay.Day).Select(p => new { DatePay = p.Key, Total = p.Sum(x => x.Amount * x.Item.Price) }).ToList();
                List<Object> list = new List<object>();
                int cnt = 0;
                foreach (var item in q)
                {
                    var amonyousType = new { STT = ++cnt, DatePay = item.DatePay + "/" + dBegin.Month + "/" + dBegin.Year, Total = item.Total };
                    list.Add(amonyousType);
                    total[item.DatePay - 1] = Convert.ToInt32(item.Total);
                }
                for (int i = 0; i < dEnd.Day; ++i)
                {
                    series.Points.Add(new SeriesPoint((i + 1).ToString(), total[i]));
                }
                chartControl.Series.Add(series);
                dtgvRevenue.DataSource = list;
            }
            catch { }
        }

        private void LoadCbbMonth()
        {
            for (int i = 0; i < 12; ++i)
            {
                cbbMonth.Properties.Items.Add(new CbbItem((i + 1), "Tháng " + (i + 1).ToString()));
            }
            cbbMonth.SelectedIndex = DateTime.Now.Month - 1;
        }
        private void LoadCbbYear()
        {
            int currentYear = DateTime.Now.Year;
            for (int i = 2015; i <= currentYear; ++i)
            {
                cbbYear.Properties.Items.Add(new CbbItem((i), (i)));
            }
            cbbYear.SelectedIndex = cbbYear.Properties.Items.Count - 1;
        }

        private void cbbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { LoadRevenuePerDay((int)(cbbMonth.SelectedItem as CbbItem).Key, (int)(cbbYear.SelectedItem as CbbItem).Value); }
            catch { }

        }

        private void cbbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { LoadRevenuePerDay((int)(cbbMonth.SelectedItem as CbbItem).Key, (int)(cbbYear.SelectedItem as CbbItem).Value); }
            catch { }
        }
    }
}
