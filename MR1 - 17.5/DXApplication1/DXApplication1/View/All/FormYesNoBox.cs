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

namespace DXApplication1.View.All
{
    public partial class FormYesNoBox : DevExpress.XtraEditors.XtraForm
    {
        private int key { get; set; }
        public FormYesNoBox(string message)
        {
            InitializeComponent();
            SetView(message);
        }

        public void SetView(string message)
        {
            lbl_YesNoBox.Text = message;
        }
        private void btn_No_Click(object sender, EventArgs e)
        {
            key = 0 ;
            this.Close();
        }

        private void btn_Yes_Click(object sender, EventArgs e)
        {
            key = 1;
            this.Close();
        }
        public int GetValue()
        {
            return key;
        }
    }
}