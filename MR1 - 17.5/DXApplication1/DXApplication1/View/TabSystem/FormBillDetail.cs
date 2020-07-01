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

namespace DXApplication1.View.TabSystem
{
    public partial class FormBillDetail : DevExpress.XtraEditors.XtraForm
    {
        private int IDBill;
        public FormBillDetail(int IDBill)
        {
            this.IDBill = IDBill;
            InitializeComponent();
            LoadAll();
        }
        private void LoadAll()
        {
            LoaddBIllDetail(this.IDBill);
        }


        private void LoaddBIllDetail(int IDBill)
        {
            grv_BillDetail.DataSource = BUS_BillInfo.Instance.GetBillInfoByIDBill(IDBill);
        }
    }
}