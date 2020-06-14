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
using DXApplication1.View.All;

namespace DXApplication1.GUI
{
    public partial class frm_Employee : DevExpress.XtraEditors.XtraForm
    {
        public frm_Employee()
        {
            InitializeComponent();
            SetView();
        }
        public void SetView()
        {
            txt_Id.Enabled = false;
            grd_Employee.DataSource = BLL_Employee.Instance.Show_BLL();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string str_Search = txt_Search.Text;
            if (BLL_Employee.Instance.Search_BLL(str_Search) != null)
            {
                //DeleteBinding();
                grd_Employee.DataSource = BLL_Employee.Instance.Search_BLL(str_Search);
            }
            else
            {
                //DeleteBinding();
                FormMessageBox form = new FormMessageBox("Dữ liệu tìm kiếm không tồn tại!");
                form.ShowDialog();
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string name_Category = txt_Name.Text;
            DateTime birthday = de_Birthday.V
            if (BLL_Category.Instance.Add_BLL(name_Category))
            {
                SetView();
                FormMessageBox form = new FormMessageBox("Thêm thành công!");
                form.ShowDialog();
            }
            else
            {
                FormMessageBox form = new FormMessageBox("Thêm thất bại! Vui lòng kiểm tra lại dữ liệu");
                form.ShowDialog();
            }
        }
    }
  
}