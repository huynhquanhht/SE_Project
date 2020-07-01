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
    public partial class FormMessageBox : DevExpress.XtraEditors.XtraForm
    {
       

        public FormMessageBox(string message)
        {
            InitializeComponent();
            SetView(message);
        }
        public void SetView(string message)
        {
            lbl_MessageBox.Text = message;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}