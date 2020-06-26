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
using System.Security.Cryptography;
using DXApplication1.DTO;

namespace DXApplication1.GUI.All
{
    public partial class frm_Login : DevExpress.XtraEditors.XtraForm
    {
        public frm_Login()
        {
            InitializeComponent();
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = txt_Username.Text;
            string password = txt_Password.Text;
            if(BUS_Account.Instance.Login(username, password) != null)
            {
                this.Hide();
                Account account = BUS_Account.Instance.Login(username, password);
                Menu menu = new Menu(account.Id_Employee);
                menu.ShowDialog();
            }
            else
            {
                lbl_Login.Text = "Tên đăng nhập hoặc mật khẩu không đúng!";
            }
        }
       
 
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

  
    }
}