namespace DXApplication1.GUI
{
    partial class frm_Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Employee));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Search = new DevExpress.XtraEditors.SimpleButton();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl11 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.grd_Employee = new DevExpress.XtraGrid.GridControl();
            this.dgv_Employee = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdcol_IdEmployee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdcol_NameItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grd_Gender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdcol_Birthday = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grd_Address = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grd_Phone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl14 = new DevExpress.XtraEditors.PanelControl();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl10 = new DevExpress.XtraEditors.PanelControl();
            this.rbtn_Female = new System.Windows.Forms.RadioButton();
            this.rbtn_Male = new System.Windows.Forms.RadioButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl7 = new DevExpress.XtraEditors.PanelControl();
            this.de_Birthday = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl9 = new DevExpress.XtraEditors.PanelControl();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl6 = new DevExpress.XtraEditors.PanelControl();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.lbl_ItemDetail = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl11)).BeginInit();
            this.panelControl11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Employee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl14)).BeginInit();
            this.panelControl14.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl10)).BeginInit();
            this.panelControl10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl7)).BeginInit();
            this.panelControl7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.de_Birthday.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_Birthday.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl9)).BeginInit();
            this.panelControl9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).BeginInit();
            this.panelControl6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Controls.Add(this.panelControl11);
            this.panelControl1.Controls.Add(this.btn_Update);
            this.panelControl1.Controls.Add(this.grd_Employee);
            this.panelControl1.Controls.Add(this.panelControl14);
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(861, 555);
            this.panelControl1.TabIndex = 3;
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.txt_Search);
            this.panelControl2.Controls.Add(this.btn_Search);
            this.panelControl2.Controls.Add(this.btn_Add);
            this.panelControl2.Controls.Add(this.btn_Delete);
            this.panelControl2.Location = new System.Drawing.Point(1, 2);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(860, 46);
            this.panelControl2.TabIndex = 26;
            // 
            // btn_Search
            // 
            this.btn_Search.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Search.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Appearance.Options.UseBackColor = true;
            this.btn_Search.Appearance.Options.UseFont = true;
            this.btn_Search.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search.ImageOptions.Image")));
            this.btn_Search.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_Search.Location = new System.Drawing.Point(210, 5);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(94, 37);
            this.btn_Search.TabIndex = 8;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(310, 8);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Search.Multiline = true;
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(128, 29);
            this.txt_Search.TabIndex = 8;
            // 
            // btn_Add
            // 
            this.btn_Add.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Add.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Appearance.Options.UseBackColor = true;
            this.btn_Add.Appearance.Options.UseFont = true;
            this.btn_Add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add.ImageOptions.Image")));
            this.btn_Add.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_Add.Location = new System.Drawing.Point(8, 4);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(94, 37);
            this.btn_Add.TabIndex = 12;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Update.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Appearance.Options.UseBackColor = true;
            this.btn_Update.Appearance.Options.UseFont = true;
            this.btn_Update.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Update.ImageOptions.Image")));
            this.btn_Update.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_Update.Location = new System.Drawing.Point(748, 344);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(94, 37);
            this.btn_Update.TabIndex = 14;
            this.btn_Update.Text = "Cập nhật";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Delete.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Appearance.Options.UseBackColor = true;
            this.btn_Delete.Appearance.Options.UseFont = true;
            this.btn_Delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete.ImageOptions.Image")));
            this.btn_Delete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_Delete.Location = new System.Drawing.Point(110, 4);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(94, 37);
            this.btn_Delete.TabIndex = 15;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // panelControl11
            // 
            this.panelControl11.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelControl11.Appearance.Options.UseBackColor = true;
            this.panelControl11.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl11.Controls.Add(this.labelControl6);
            this.panelControl11.Location = new System.Drawing.Point(0, 47);
            this.panelControl11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl11.Name = "panelControl11";
            this.panelControl11.Size = new System.Drawing.Size(586, 42);
            this.panelControl11.TabIndex = 25;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(111, 11);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(295, 19);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "DANH SÁCH THÔNG TIN NHÂN VIÊN";
            // 
            // grd_Employee
            // 
            this.grd_Employee.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grd_Employee.Location = new System.Drawing.Point(3, 48);
            this.grd_Employee.MainView = this.dgv_Employee;
            this.grd_Employee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grd_Employee.Name = "grd_Employee";
            this.grd_Employee.Size = new System.Drawing.Size(582, 407);
            this.grd_Employee.TabIndex = 21;
            this.grd_Employee.UseEmbeddedNavigator = true;
            this.grd_Employee.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgv_Employee});
            // 
            // dgv_Employee
            // 
            this.dgv_Employee.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.dgv_Employee.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.dgv_Employee.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.dgv_Employee.Appearance.HeaderPanel.Options.UseFont = true;
            this.dgv_Employee.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.dgv_Employee.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.dgv_Employee.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdcol_IdEmployee,
            this.grdcol_NameItem,
            this.grd_Gender,
            this.grdcol_Birthday,
            this.grd_Address,
            this.grd_Phone});
            this.dgv_Employee.DetailHeight = 431;
            this.dgv_Employee.GridControl = this.grd_Employee;
            this.dgv_Employee.Name = "dgv_Employee";
            this.dgv_Employee.OptionsBehavior.Editable = false;
            this.dgv_Employee.OptionsBehavior.ReadOnly = true;
            this.dgv_Employee.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.dgv_Employee_RowClick);
            // 
            // grdcol_IdEmployee
            // 
            this.grdcol_IdEmployee.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdcol_IdEmployee.AppearanceCell.Options.UseFont = true;
            this.grdcol_IdEmployee.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.grdcol_IdEmployee.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdcol_IdEmployee.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.grdcol_IdEmployee.AppearanceHeader.Options.UseBackColor = true;
            this.grdcol_IdEmployee.AppearanceHeader.Options.UseFont = true;
            this.grdcol_IdEmployee.AppearanceHeader.Options.UseForeColor = true;
            this.grdcol_IdEmployee.AppearanceHeader.Options.UseTextOptions = true;
            this.grdcol_IdEmployee.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdcol_IdEmployee.Caption = "Mã số";
            this.grdcol_IdEmployee.FieldName = "Id";
            this.grdcol_IdEmployee.MinWidth = 23;
            this.grdcol_IdEmployee.Name = "grdcol_IdEmployee";
            this.grdcol_IdEmployee.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.grdcol_IdEmployee.Width = 61;
            // 
            // grdcol_NameItem
            // 
            this.grdcol_NameItem.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdcol_NameItem.AppearanceCell.Options.UseFont = true;
            this.grdcol_NameItem.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.grdcol_NameItem.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdcol_NameItem.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.grdcol_NameItem.AppearanceHeader.Options.UseBackColor = true;
            this.grdcol_NameItem.AppearanceHeader.Options.UseFont = true;
            this.grdcol_NameItem.AppearanceHeader.Options.UseForeColor = true;
            this.grdcol_NameItem.AppearanceHeader.Options.UseTextOptions = true;
            this.grdcol_NameItem.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdcol_NameItem.Caption = "Họ tên";
            this.grdcol_NameItem.FieldName = "Name";
            this.grdcol_NameItem.MinWidth = 23;
            this.grdcol_NameItem.Name = "grdcol_NameItem";
            this.grdcol_NameItem.Visible = true;
            this.grdcol_NameItem.VisibleIndex = 0;
            this.grdcol_NameItem.Width = 133;
            // 
            // grd_Gender
            // 
            this.grd_Gender.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grd_Gender.AppearanceCell.Options.UseFont = true;
            this.grd_Gender.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.grd_Gender.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grd_Gender.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.grd_Gender.AppearanceHeader.Options.UseBackColor = true;
            this.grd_Gender.AppearanceHeader.Options.UseFont = true;
            this.grd_Gender.AppearanceHeader.Options.UseForeColor = true;
            this.grd_Gender.AppearanceHeader.Options.UseTextOptions = true;
            this.grd_Gender.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grd_Gender.Caption = "Giới tính";
            this.grd_Gender.FieldName = "Gender";
            this.grd_Gender.MinWidth = 23;
            this.grd_Gender.Name = "grd_Gender";
            this.grd_Gender.Visible = true;
            this.grd_Gender.VisibleIndex = 1;
            this.grd_Gender.Width = 101;
            // 
            // grdcol_Birthday
            // 
            this.grdcol_Birthday.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdcol_Birthday.AppearanceCell.Options.UseFont = true;
            this.grdcol_Birthday.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.grdcol_Birthday.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdcol_Birthday.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.grdcol_Birthday.AppearanceHeader.Options.UseBackColor = true;
            this.grdcol_Birthday.AppearanceHeader.Options.UseFont = true;
            this.grdcol_Birthday.AppearanceHeader.Options.UseForeColor = true;
            this.grdcol_Birthday.AppearanceHeader.Options.UseTextOptions = true;
            this.grdcol_Birthday.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdcol_Birthday.Caption = "Ngày sinh";
            this.grdcol_Birthday.FieldName = "Birthday";
            this.grdcol_Birthday.MinWidth = 23;
            this.grdcol_Birthday.Name = "grdcol_Birthday";
            this.grdcol_Birthday.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.grdcol_Birthday.Visible = true;
            this.grdcol_Birthday.VisibleIndex = 2;
            this.grdcol_Birthday.Width = 78;
            // 
            // grd_Address
            // 
            this.grd_Address.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grd_Address.AppearanceCell.Options.UseFont = true;
            this.grd_Address.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.grd_Address.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grd_Address.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.grd_Address.AppearanceHeader.Options.UseBackColor = true;
            this.grd_Address.AppearanceHeader.Options.UseFont = true;
            this.grd_Address.AppearanceHeader.Options.UseForeColor = true;
            this.grd_Address.AppearanceHeader.Options.UseTextOptions = true;
            this.grd_Address.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grd_Address.Caption = "Địa chỉ";
            this.grd_Address.FieldName = "Address";
            this.grd_Address.MinWidth = 23;
            this.grd_Address.Name = "grd_Address";
            this.grd_Address.Visible = true;
            this.grd_Address.VisibleIndex = 3;
            this.grd_Address.Width = 98;
            // 
            // grd_Phone
            // 
            this.grd_Phone.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grd_Phone.AppearanceCell.Options.UseFont = true;
            this.grd_Phone.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.grd_Phone.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grd_Phone.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.grd_Phone.AppearanceHeader.Options.UseBackColor = true;
            this.grd_Phone.AppearanceHeader.Options.UseFont = true;
            this.grd_Phone.AppearanceHeader.Options.UseForeColor = true;
            this.grd_Phone.AppearanceHeader.Options.UseTextOptions = true;
            this.grd_Phone.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grd_Phone.Caption = "Điện thoại";
            this.grd_Phone.FieldName = "Phone";
            this.grd_Phone.MinWidth = 23;
            this.grd_Phone.Name = "grd_Phone";
            this.grd_Phone.Visible = true;
            this.grd_Phone.VisibleIndex = 4;
            this.grd_Phone.Width = 90;
            // 
            // panelControl14
            // 
            this.panelControl14.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl14.Controls.Add(this.flowLayoutPanel1);
            this.panelControl14.Controls.Add(this.lbl_ItemDetail);
            this.panelControl14.Location = new System.Drawing.Point(589, 48);
            this.panelControl14.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl14.Name = "panelControl14";
            this.panelControl14.Size = new System.Drawing.Size(260, 277);
            this.panelControl14.TabIndex = 20;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.panelControl4);
            this.flowLayoutPanel1.Controls.Add(this.panelControl10);
            this.flowLayoutPanel1.Controls.Add(this.panelControl7);
            this.flowLayoutPanel1.Controls.Add(this.panelControl9);
            this.flowLayoutPanel1.Controls.Add(this.panelControl6);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 31);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(252, 242);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // panelControl4
            // 
            this.panelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl4.Controls.Add(this.txt_Name);
            this.panelControl4.Controls.Add(this.labelControl1);
            this.panelControl4.Location = new System.Drawing.Point(3, 4);
            this.panelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(243, 42);
            this.panelControl4.TabIndex = 2;
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(92, 6);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Name.Multiline = true;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(145, 29);
            this.txt_Name.TabIndex = 7;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(7, 10);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(57, 21);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Họ tên";
            // 
            // panelControl10
            // 
            this.panelControl10.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl10.Controls.Add(this.rbtn_Female);
            this.panelControl10.Controls.Add(this.rbtn_Male);
            this.panelControl10.Controls.Add(this.labelControl2);
            this.panelControl10.Location = new System.Drawing.Point(3, 54);
            this.panelControl10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl10.Name = "panelControl10";
            this.panelControl10.Size = new System.Drawing.Size(243, 38);
            this.panelControl10.TabIndex = 9;
            // 
            // rbtn_Female
            // 
            this.rbtn_Female.AutoSize = true;
            this.rbtn_Female.Location = new System.Drawing.Point(153, 7);
            this.rbtn_Female.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtn_Female.Name = "rbtn_Female";
            this.rbtn_Female.Size = new System.Drawing.Size(47, 21);
            this.rbtn_Female.TabIndex = 6;
            this.rbtn_Female.TabStop = true;
            this.rbtn_Female.Text = "Nữ";
            this.rbtn_Female.UseVisualStyleBackColor = true;
            // 
            // rbtn_Male
            // 
            this.rbtn_Male.AutoSize = true;
            this.rbtn_Male.Location = new System.Drawing.Point(92, 7);
            this.rbtn_Male.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtn_Male.Name = "rbtn_Male";
            this.rbtn_Male.Size = new System.Drawing.Size(57, 21);
            this.rbtn_Male.TabIndex = 5;
            this.rbtn_Male.TabStop = true;
            this.rbtn_Male.Text = "Nam";
            this.rbtn_Male.UseVisualStyleBackColor = true;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.CausesValidation = false;
            this.labelControl2.Location = new System.Drawing.Point(7, 10);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(73, 21);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Giới tính";
            // 
            // panelControl7
            // 
            this.panelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl7.Controls.Add(this.de_Birthday);
            this.panelControl7.Controls.Add(this.labelControl3);
            this.panelControl7.Location = new System.Drawing.Point(3, 100);
            this.panelControl7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl7.Name = "panelControl7";
            this.panelControl7.Size = new System.Drawing.Size(243, 38);
            this.panelControl7.TabIndex = 3;
            // 
            // de_Birthday
            // 
            this.de_Birthday.EditValue = null;
            this.de_Birthday.Location = new System.Drawing.Point(91, 5);
            this.de_Birthday.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.de_Birthday.Name = "de_Birthday";
            this.de_Birthday.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.de_Birthday.Properties.Appearance.Options.UseFont = true;
            this.de_Birthday.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_Birthday.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_Birthday.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
            this.de_Birthday.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            this.de_Birthday.Size = new System.Drawing.Size(147, 30);
            this.de_Birthday.TabIndex = 22;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(7, 10);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(79, 19);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Ngày sinh";
            // 
            // panelControl9
            // 
            this.panelControl9.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl9.Controls.Add(this.txt_Address);
            this.panelControl9.Controls.Add(this.labelControl4);
            this.panelControl9.Location = new System.Drawing.Point(3, 146);
            this.panelControl9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl9.Name = "panelControl9";
            this.panelControl9.Size = new System.Drawing.Size(243, 38);
            this.panelControl9.TabIndex = 3;
            // 
            // txt_Address
            // 
            this.txt_Address.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Address.Location = new System.Drawing.Point(91, 5);
            this.txt_Address.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Address.Multiline = true;
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(146, 29);
            this.txt_Address.TabIndex = 8;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.CausesValidation = false;
            this.labelControl4.Location = new System.Drawing.Point(7, 10);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(58, 21);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Địa chỉ";
            // 
            // panelControl6
            // 
            this.panelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl6.Controls.Add(this.txt_Phone);
            this.panelControl6.Controls.Add(this.labelControl7);
            this.panelControl6.Location = new System.Drawing.Point(3, 192);
            this.panelControl6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl6.Name = "panelControl6";
            this.panelControl6.Size = new System.Drawing.Size(243, 38);
            this.panelControl6.TabIndex = 10;
            // 
            // txt_Phone
            // 
            this.txt_Phone.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Phone.Location = new System.Drawing.Point(91, 5);
            this.txt_Phone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Phone.Multiline = true;
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(146, 29);
            this.txt_Phone.TabIndex = 8;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.CausesValidation = false;
            this.labelControl7.Location = new System.Drawing.Point(7, 10);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(88, 21);
            this.labelControl7.TabIndex = 4;
            this.labelControl7.Text = "Điện thoại";
            // 
            // lbl_ItemDetail
            // 
            this.lbl_ItemDetail.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ItemDetail.Appearance.Options.UseFont = true;
            this.lbl_ItemDetail.Location = new System.Drawing.Point(3, 4);
            this.lbl_ItemDetail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbl_ItemDetail.Name = "lbl_ItemDetail";
            this.lbl_ItemDetail.Size = new System.Drawing.Size(151, 21);
            this.lbl_ItemDetail.TabIndex = 4;
            this.lbl_ItemDetail.Text = "Thông tin chi tiết ";
            // 
            // frm_Employee
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 583);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_Employee";
            this.Text = "Employee";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl11)).EndInit();
            this.panelControl11.ResumeLayout(false);
            this.panelControl11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Employee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl14)).EndInit();
            this.panelControl14.ResumeLayout(false);
            this.panelControl14.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl10)).EndInit();
            this.panelControl10.ResumeLayout(false);
            this.panelControl10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl7)).EndInit();
            this.panelControl7.ResumeLayout(false);
            this.panelControl7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.de_Birthday.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_Birthday.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl9)).EndInit();
            this.panelControl9.ResumeLayout(false);
            this.panelControl9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).EndInit();
            this.panelControl6.ResumeLayout(false);
            this.panelControl6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl grd_Employee;
        private DevExpress.XtraGrid.Views.Grid.GridView dgv_Employee;
        private DevExpress.XtraGrid.Columns.GridColumn grdcol_IdEmployee;
        private DevExpress.XtraGrid.Columns.GridColumn grdcol_NameItem;
        private DevExpress.XtraGrid.Columns.GridColumn grdcol_Birthday;
        private DevExpress.XtraGrid.Columns.GridColumn grd_Address;
        private DevExpress.XtraGrid.Columns.GridColumn grd_Phone;
        private DevExpress.XtraEditors.PanelControl panelControl14;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private System.Windows.Forms.TextBox txt_Name;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl9;
        private System.Windows.Forms.TextBox txt_Address;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.PanelControl panelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lbl_ItemDetail;
        private DevExpress.XtraEditors.DateEdit de_Birthday;
        private DevExpress.XtraEditors.PanelControl panelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_Search;
        private System.Windows.Forms.TextBox txt_Search;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private DevExpress.XtraEditors.SimpleButton btn_Update;
        private DevExpress.XtraEditors.SimpleButton btn_Delete;
        private DevExpress.XtraGrid.Columns.GridColumn grd_Gender;
        private System.Windows.Forms.RadioButton rbtn_Female;
        private System.Windows.Forms.RadioButton rbtn_Male;
        private DevExpress.XtraEditors.PanelControl panelControl6;
        private System.Windows.Forms.TextBox txt_Phone;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}