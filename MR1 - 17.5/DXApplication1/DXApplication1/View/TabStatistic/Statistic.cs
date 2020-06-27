using DXApplication1.DAL;
using DXApplication1.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            //int cntFood = db.BillInfos.Where(p=>p.Id)


        }
    }
}
