namespace DXApplication1
{
    partial class TabSystem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabSystem));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelChildForm = new DevExpress.XtraEditors.PanelControl();
            this.frm_TabSystem = new DevExpress.XtraEditors.PanelControl();
            this.btn_Category = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Account = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Employee = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Item = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Bill = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Table = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelChildForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frm_TabSystem)).BeginInit();
            this.frm_TabSystem.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelChildForm);
            this.panel1.Controls.Add(this.frm_TabSystem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 474);
            this.panel1.TabIndex = 0;
            // 
            // panelChildForm
            // 
            this.panelChildForm.Location = new System.Drawing.Point(0, 75);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(736, 396);
            this.panelChildForm.TabIndex = 3;
            // 
            // frm_TabSystem
            // 
            this.frm_TabSystem.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.frm_TabSystem.Appearance.BorderColor = System.Drawing.Color.White;
            this.frm_TabSystem.Appearance.Options.UseBackColor = true;
            this.frm_TabSystem.Appearance.Options.UseBorderColor = true;
            this.frm_TabSystem.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.frm_TabSystem.Controls.Add(this.btn_Category);
            this.frm_TabSystem.Controls.Add(this.btn_Account);
            this.frm_TabSystem.Controls.Add(this.btn_Employee);
            this.frm_TabSystem.Controls.Add(this.btn_Item);
            this.frm_TabSystem.Controls.Add(this.btn_Bill);
            this.frm_TabSystem.Controls.Add(this.btn_Table);
            this.frm_TabSystem.Dock = System.Windows.Forms.DockStyle.Top;
            this.frm_TabSystem.Location = new System.Drawing.Point(0, 0);
            this.frm_TabSystem.Name = "frm_TabSystem";
            this.frm_TabSystem.Size = new System.Drawing.Size(736, 77);
            this.frm_TabSystem.TabIndex = 2;
            // 
            // btn_Category
            // 
            this.btn_Category.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Category.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Category.Appearance.Options.UseBackColor = true;
            this.btn_Category.Appearance.Options.UseFont = true;
            this.btn_Category.AppearanceHovered.BackColor = System.Drawing.Color.White;
            this.btn_Category.AppearanceHovered.Options.UseBackColor = true;
            this.btn_Category.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btn_Category.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btn_Category.Location = new System.Drawing.Point(76, 1);
            this.btn_Category.Name = "btn_Category";
            this.btn_Category.Size = new System.Drawing.Size(78, 75);
            this.btn_Category.TabIndex = 10;
            this.btn_Category.Text = "Loại món";
            this.btn_Category.Click += new System.EventHandler(this.btn_Category_Click);
            // 
            // btn_Account
            // 
            this.btn_Account.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Account.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Account.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_Account.Appearance.Options.UseBackColor = true;
            this.btn_Account.Appearance.Options.UseFont = true;
            this.btn_Account.Appearance.Options.UseForeColor = true;
            this.btn_Account.AppearanceHovered.BackColor = System.Drawing.Color.White;
            this.btn_Account.AppearanceHovered.Options.UseBackColor = true;
            this.btn_Account.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Account.ImageOptions.Image")));
            this.btn_Account.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btn_Account.Location = new System.Drawing.Point(384, 0);
            this.btn_Account.Name = "btn_Account";
            this.btn_Account.Size = new System.Drawing.Size(78, 76);
            this.btn_Account.TabIndex = 0;
            this.btn_Account.Text = "Tài khoản";
            this.btn_Account.Click += new System.EventHandler(this.btn_Account_Click);
            // 
            // btn_Employee
            // 
            this.btn_Employee.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Employee.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Employee.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_Employee.Appearance.Options.UseBackColor = true;
            this.btn_Employee.Appearance.Options.UseFont = true;
            this.btn_Employee.Appearance.Options.UseForeColor = true;
            this.btn_Employee.AppearanceHovered.BackColor = System.Drawing.Color.White;
            this.btn_Employee.AppearanceHovered.Options.UseBackColor = true;
            this.btn_Employee.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Employee.ImageOptions.Image")));
            this.btn_Employee.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btn_Employee.Location = new System.Drawing.Point(307, 0);
            this.btn_Employee.Name = "btn_Employee";
            this.btn_Employee.Size = new System.Drawing.Size(78, 75);
            this.btn_Employee.TabIndex = 0;
            this.btn_Employee.Text = "Nhân viên";
            this.btn_Employee.Click += new System.EventHandler(this.btn_Employee_Click);
            // 
            // btn_Item
            // 
            this.btn_Item.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Item.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Item.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Item.Appearance.Options.UseBackColor = true;
            this.btn_Item.Appearance.Options.UseBorderColor = true;
            this.btn_Item.Appearance.Options.UseFont = true;
            this.btn_Item.AppearanceHovered.BackColor = System.Drawing.Color.White;
            this.btn_Item.AppearanceHovered.Options.UseBackColor = true;
            this.btn_Item.BackgroundImage = global::DXApplication1.Properties.Resources.Food_Icon;
            this.btn_Item.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Item.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Item.ImageOptions.Image")));
            this.btn_Item.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btn_Item.Location = new System.Drawing.Point(0, 1);
            this.btn_Item.Name = "btn_Item";
            this.btn_Item.Size = new System.Drawing.Size(77, 75);
            this.btn_Item.TabIndex = 0;
            this.btn_Item.Text = "Món";
            this.btn_Item.Click += new System.EventHandler(this.btn_Item_Click);
            // 
            // btn_Bill
            // 
            this.btn_Bill.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Bill.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bill.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_Bill.Appearance.Options.UseBackColor = true;
            this.btn_Bill.Appearance.Options.UseFont = true;
            this.btn_Bill.Appearance.Options.UseForeColor = true;
            this.btn_Bill.AppearanceHovered.BackColor = System.Drawing.Color.White;
            this.btn_Bill.AppearanceHovered.Options.UseBackColor = true;
            this.btn_Bill.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Bill.ImageOptions.Image")));
            this.btn_Bill.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btn_Bill.Location = new System.Drawing.Point(230, 0);
            this.btn_Bill.Name = "btn_Bill";
            this.btn_Bill.Size = new System.Drawing.Size(78, 75);
            this.btn_Bill.TabIndex = 0;
            this.btn_Bill.Text = "Hóa đơn";
            this.btn_Bill.Click += new System.EventHandler(this.btn_Bill_Click);
            // 
            // btn_Table
            // 
            this.btn_Table.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Table.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Table.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_Table.Appearance.Options.UseBackColor = true;
            this.btn_Table.Appearance.Options.UseFont = true;
            this.btn_Table.Appearance.Options.UseForeColor = true;
            this.btn_Table.AppearanceHovered.BackColor = System.Drawing.Color.White;
            this.btn_Table.AppearanceHovered.Options.UseBackColor = true;
            this.btn_Table.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Table.ImageOptions.Image")));
            this.btn_Table.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btn_Table.Location = new System.Drawing.Point(153, 1);
            this.btn_Table.Name = "btn_Table";
            this.btn_Table.Size = new System.Drawing.Size(78, 75);
            this.btn_Table.TabIndex = 0;
            this.btn_Table.Text = "Bàn ăn";
            this.btn_Table.Click += new System.EventHandler(this.btn_Table_Click);
            // 
            // TabSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 474);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TabSystem";
            this.Text = "TabSystem";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelChildForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frm_TabSystem)).EndInit();
            this.frm_TabSystem.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.PanelControl frm_TabSystem;
        private DevExpress.XtraEditors.SimpleButton btn_Account;
        private DevExpress.XtraEditors.SimpleButton btn_Item;
        private DevExpress.XtraEditors.SimpleButton btn_Employee;
        private DevExpress.XtraEditors.SimpleButton btn_Table;
        private DevExpress.XtraEditors.SimpleButton btn_Bill;
        private DevExpress.XtraEditors.SimpleButton btn_Category;
        private DevExpress.XtraEditors.PanelControl panelChildForm;

    }
}