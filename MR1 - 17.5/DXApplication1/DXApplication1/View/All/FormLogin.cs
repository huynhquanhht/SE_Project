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

namespace DXApplication1.GUI.All
{
    public partial class frm_Login : DevExpress.XtraEditors.XtraForm
    {
        SE_08 db = new SE_08();

        public frm_Login()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
           

            var q = db.Categories.Select(p => p).ToList();
            MessageBox.Show("Database was created");

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = txt_Username.Text;
            string password = txt_Password.Text;
            if(Login(username, password))
            {
                this.Hide();
                Menu menu = new Menu();
                menu.ShowDialog();
            }
            else
            {
                lbl_Login.Text = "Tên đăng nhập hoặc mật khẩu không đúng. Vui lòng kiểm tra lại";
            }
        }
        public bool Login(string username, string password)
        {
            //byte[] temp = ASCIIEncoding.ASCII.GetBytes(password);
            //byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
            //string hasPass = "";
            //foreach(byte item in hasData)
            //{
            //    hasPass += item;
            //}

            var result = db.Accounts.Where(p => p.Username == username && p.Password == password);
            if(result.ToList().Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
 
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}