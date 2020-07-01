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
using DXApplication1.DTO;
using DXApplication1.View.All;

namespace DXApplication1.GUI.All
{
    public partial class PersonalInfo : DevExpress.XtraEditors.XtraForm
    {
        int Id_Employee { get; set; }
        public PersonalInfo(int Id)
        {
            Id_Employee = Id;
            InitializeComponent();
            SetView(Id_Employee);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void SetView(int Id_Em)
        {
            if (BUS_Employee.Instance.GetEmployee(Id_Em) != null)
            {
                Employee em = BUS_Employee.Instance.GetEmployee(Id_Em);
                txt_Name.Text = em.Name;
                rbtn_Female.Checked = (rbtn_Male.Checked = (em.Gender == true ? true : false)) ? false : true;
                de_Birthday.EditValue = em.Birthday.Date;
                txt_Address.Text = em.Address;
                txt_Phone.Text = em.Phone;
            }
            else
            {
                FormMessageBox mess = new FormMessageBox("Lỗi! Không thể tải dữ liệu của bạn");
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            int Id = Id_Employee;
            string name_Update = txt_Name.Text;
            DateTime birthday_Update = de_Birthday.DateTime.Date;
            bool gender_Update = rbtn_Male.Checked ? true : false;
            string address_Update = txt_Address.Text;
            string phone_Update = txt_Phone.Text;


            if (name_Update != "")
            {
                FormYesNoBox formYesNoBox = new FormYesNoBox("Bạn chắc chắn muốn cập nhật?");
                formYesNoBox.ShowDialog();
                if (formYesNoBox.GetValue() == 1)
                {

                    if (BUS_Employee.Instance.Update_DAL(Convert.ToInt32(Id), name_Update, birthday_Update, gender_Update, address_Update, phone_Update))
                    {
                        FormMessageBox form = new FormMessageBox("Cập nhật thành công!");
                        form.ShowDialog();
                    }
                    else
                    {
                        FormMessageBox form = new FormMessageBox("Cập nhật thất bại! Vui lòng kiểm tra lại dữ liệu");
                        form.ShowDialog();
                    }
                }
            }
            else
            {
                FormMessageBox form = new FormMessageBox("Không thể tải dữ liệu của bạn! Không thể cập nhật");
                form.ShowDialog();
            }
        }
    }
}