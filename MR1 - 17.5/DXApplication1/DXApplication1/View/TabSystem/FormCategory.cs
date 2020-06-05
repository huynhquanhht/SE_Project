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

namespace DXApplication1.GUI
{
    public partial class frm_Category : DevExpress.XtraEditors.XtraForm
    {
        public frm_Category()
        {
            InitializeComponent();
            Start();
        }
        public void Start()
        {
            SE_08 db = new SE_08();
            grd_Item.DataSource = db.Categories.Select(p => p).ToList();
        }
    }
}