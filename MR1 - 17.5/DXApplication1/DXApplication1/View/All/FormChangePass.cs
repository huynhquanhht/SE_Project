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
using DXApplication1.View.All;
using DXApplication1.DTO;
using DXApplication1.DAL;
using System.Security.Cryptography;

namespace DXApplication1.GUI.All
{
    public partial class ChangePass : DevExpress.XtraEditors.XtraForm
    {
        int Id_Employee;
        public ChangePass(int Id_Em)
        {
            Id_Employee = Id_Em;
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            string oldpass = txt_OldPass.Text;
            string newpass = txt_NewPass.Text;
            string againpass = txt_AgainPass.Text;
            Account acc = new Account();
            acc = BUS_Account.Instance.GetAccountByIdEmployee(Id_Employee);
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(oldpass);
            byte[] hashData = new MD5CryptoServiceProvider().ComputeHash(temp);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashData.Length; i++)
            {
                sb.Append(hashData[i].ToString("x2"));

            }
            if (acc != null)
            {
                if (oldpass != "" && newpass != "" && againpass != "")
                {
                    if (sb.ToString() == acc.Password)
                    {
                        if (newpass == againpass)
                        {
                            if (BUS_Account.Instance.ChangePassword(newpass, Id_Employee))
                            {
                                this.Close();
                                FormMessageBox mess = new FormMessageBox("Đổi mật khẩu thành công!");
                                lbl_ChangePass.ResetText();
                                mess.ShowDialog();
                                this.Close();
                            }
                            else
                            {
                                FormMessageBox mess = new FormMessageBox("Lỗi! Thay đổi thất bại!");
                                mess.ShowDialog();
                            }
                        }
                        else
                        {
                            lbl_ChangePass.Text = "Lỗi! Mật khẩu nhập lại khác mật khẩu mới!";
                        }
                    }
                    else
                    {
                        lbl_ChangePass.Text = "Lỗi! Vui lòng kiểm tra lại thông tin bạn nhập!";
                    }
                }
                else
                {
                    lbl_ChangePass.Text = "Lỗi! Bạn phải điền đầy đủ thông tin!";
                }
            }else
            {
                FormMessageBox mess = new FormMessageBox("Lỗi! Không thể lấy dữ liệu mật khẩu!");
                mess.ShowDialog();
            }
        }
    }
}