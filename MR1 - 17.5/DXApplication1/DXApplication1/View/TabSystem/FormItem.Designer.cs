﻿namespace DXApplication1
{
    partial class frm_Item
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Item));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Search = new DevExpress.XtraEditors.SimpleButton();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl10 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.grd_Item = new DevExpress.XtraGrid.GridControl();
            this.dgv_Item = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdcol_IdItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdcol_NameItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdcol_Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grd_Category = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl14 = new DevExpress.XtraEditors.PanelControl();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl7 = new DevExpress.XtraEditors.PanelControl();
            this.cbb_CategoryDetail = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl9 = new DevExpress.XtraEditors.PanelControl();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lbl_ItemDetail = new DevExpress.XtraEditors.LabelControl();
            this.panelControl8 = new DevExpress.XtraEditors.PanelControl();
            this.cbb_Category = new System.Windows.Forms.ComboBox();
            this.lbl_Category = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl10)).BeginInit();
            this.panelControl10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl14)).BeginInit();
            this.panelControl14.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl7)).BeginInit();
            this.panelControl7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl9)).BeginInit();
            this.panelControl9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl8)).BeginInit();
            this.panelControl8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Controls.Add(this.panelControl10);
            this.panelControl1.Controls.Add(this.btn_Update);
            this.panelControl1.Controls.Add(this.grd_Item);
            this.panelControl1.Controls.Add(this.panelControl14);
            this.panelControl1.Controls.Add(this.panelControl8);
            this.panelControl1.Location = new System.Drawing.Point(0, -10);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(860, 542);
            this.panelControl1.TabIndex = 2;
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
            this.panelControl2.Location = new System.Drawing.Point(0, 11);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(857, 46);
            this.panelControl2.TabIndex = 23;
            // 
            // btn_Search
            // 
            this.btn_Search.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Search.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Appearance.Options.UseBackColor = true;
            this.btn_Search.Appearance.Options.UseFont = true;
            this.btn_Search.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search.ImageOptions.Image")));
            this.btn_Search.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_Search.Location = new System.Drawing.Point(208, 4);
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
            this.txt_Search.Location = new System.Drawing.Point(311, 11);
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
            this.btn_Update.Location = new System.Drawing.Point(753, 293);
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
            this.btn_Delete.Location = new System.Drawing.Point(108, 5);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(94, 37);
            this.btn_Delete.TabIndex = 15;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // panelControl10
            // 
            this.panelControl10.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelControl10.Appearance.Options.UseBackColor = true;
            this.panelControl10.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl10.Controls.Add(this.labelControl2);
            this.panelControl10.Location = new System.Drawing.Point(3, 95);
            this.panelControl10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl10.Name = "panelControl10";
            this.panelControl10.Size = new System.Drawing.Size(532, 42);
            this.panelControl10.TabIndex = 22;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(126, 11);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(269, 19);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "DANH SÁCH THÔNG TIN MÓN ĂN";
            // 
            // grd_Item
            // 
            this.grd_Item.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.True;
            this.grd_Item.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.White;
            this.grd_Item.EmbeddedNavigator.Appearance.Options.UseBackColor = true;
            this.grd_Item.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grd_Item.Location = new System.Drawing.Point(3, 96);
            this.grd_Item.MainView = this.dgv_Item;
            this.grd_Item.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grd_Item.Name = "grd_Item";
            this.grd_Item.Size = new System.Drawing.Size(532, 363);
            this.grd_Item.TabIndex = 21;
            this.grd_Item.UseEmbeddedNavigator = true;
            this.grd_Item.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgv_Item});
            // 
            // dgv_Item
            // 
            this.dgv_Item.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.dgv_Item.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.dgv_Item.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.dgv_Item.Appearance.HeaderPanel.Options.UseFont = true;
            this.dgv_Item.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.dgv_Item.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.dgv_Item.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdcol_IdItem,
            this.grdcol_NameItem,
            this.grdcol_Price,
            this.grd_Category});
            this.dgv_Item.DetailHeight = 431;
            this.dgv_Item.GridControl = this.grd_Item;
            this.dgv_Item.Name = "dgv_Item";
            this.dgv_Item.OptionsBehavior.Editable = false;
            this.dgv_Item.OptionsBehavior.ReadOnly = true;
            this.dgv_Item.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.dgv_Item_RowClick);
            // 
            // grdcol_IdItem
            // 
            this.grdcol_IdItem.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdcol_IdItem.AppearanceCell.Options.UseFont = true;
            this.grdcol_IdItem.AppearanceCell.Options.UseTextOptions = true;
            this.grdcol_IdItem.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.grdcol_IdItem.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.grdcol_IdItem.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdcol_IdItem.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.grdcol_IdItem.AppearanceHeader.Options.UseBackColor = true;
            this.grdcol_IdItem.AppearanceHeader.Options.UseFont = true;
            this.grdcol_IdItem.AppearanceHeader.Options.UseForeColor = true;
            this.grdcol_IdItem.AppearanceHeader.Options.UseTextOptions = true;
            this.grdcol_IdItem.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdcol_IdItem.Caption = "Mã món";
            this.grdcol_IdItem.FieldName = "Id";
            this.grdcol_IdItem.MinWidth = 23;
            this.grdcol_IdItem.Name = "grdcol_IdItem";
            this.grdcol_IdItem.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.grdcol_IdItem.Width = 77;
            // 
            // grdcol_NameItem
            // 
            this.grdcol_NameItem.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdcol_NameItem.AppearanceCell.Options.UseFont = true;
            this.grdcol_NameItem.AppearanceCell.Options.UseTextOptions = true;
            this.grdcol_NameItem.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.grdcol_NameItem.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.grdcol_NameItem.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdcol_NameItem.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.grdcol_NameItem.AppearanceHeader.Options.UseBackColor = true;
            this.grdcol_NameItem.AppearanceHeader.Options.UseFont = true;
            this.grdcol_NameItem.AppearanceHeader.Options.UseForeColor = true;
            this.grdcol_NameItem.AppearanceHeader.Options.UseTextOptions = true;
            this.grdcol_NameItem.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdcol_NameItem.Caption = "Tên món";
            this.grdcol_NameItem.FieldName = "Name";
            this.grdcol_NameItem.MinWidth = 23;
            this.grdcol_NameItem.Name = "grdcol_NameItem";
            this.grdcol_NameItem.Visible = true;
            this.grdcol_NameItem.VisibleIndex = 0;
            this.grdcol_NameItem.Width = 196;
            // 
            // grdcol_Price
            // 
            this.grdcol_Price.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdcol_Price.AppearanceCell.Options.UseFont = true;
            this.grdcol_Price.AppearanceCell.Options.UseTextOptions = true;
            this.grdcol_Price.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.grdcol_Price.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.grdcol_Price.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdcol_Price.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.grdcol_Price.AppearanceHeader.Options.UseBackColor = true;
            this.grdcol_Price.AppearanceHeader.Options.UseFont = true;
            this.grdcol_Price.AppearanceHeader.Options.UseForeColor = true;
            this.grdcol_Price.AppearanceHeader.Options.UseTextOptions = true;
            this.grdcol_Price.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdcol_Price.Caption = "Đơn giá";
            this.grdcol_Price.FieldName = "Price";
            this.grdcol_Price.MinWidth = 23;
            this.grdcol_Price.Name = "grdcol_Price";
            this.grdcol_Price.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.grdcol_Price.Visible = true;
            this.grdcol_Price.VisibleIndex = 1;
            this.grdcol_Price.Width = 93;
            // 
            // grd_Category
            // 
            this.grd_Category.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grd_Category.AppearanceCell.Options.UseFont = true;
            this.grd_Category.AppearanceCell.Options.UseTextOptions = true;
            this.grd_Category.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.grd_Category.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.grd_Category.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grd_Category.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.grd_Category.AppearanceHeader.Options.UseBackColor = true;
            this.grd_Category.AppearanceHeader.Options.UseFont = true;
            this.grd_Category.AppearanceHeader.Options.UseForeColor = true;
            this.grd_Category.AppearanceHeader.Options.UseTextOptions = true;
            this.grd_Category.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grd_Category.Caption = "Loại món";
            this.grd_Category.FieldName = "Name_Category";
            this.grd_Category.MinWidth = 23;
            this.grd_Category.Name = "grd_Category";
            this.grd_Category.Visible = true;
            this.grd_Category.VisibleIndex = 2;
            this.grd_Category.Width = 141;
            // 
            // panelControl14
            // 
            this.panelControl14.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl14.Controls.Add(this.flowLayoutPanel1);
            this.panelControl14.Controls.Add(this.lbl_ItemDetail);
            this.panelControl14.Location = new System.Drawing.Point(535, 95);
            this.panelControl14.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl14.Name = "panelControl14";
            this.panelControl14.Size = new System.Drawing.Size(316, 179);
            this.panelControl14.TabIndex = 20;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.panelControl4);
            this.flowLayoutPanel1.Controls.Add(this.panelControl7);
            this.flowLayoutPanel1.Controls.Add(this.panelControl9);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(7, 31);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(305, 145);
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
            this.panelControl4.Size = new System.Drawing.Size(297, 42);
            this.panelControl4.TabIndex = 2;
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(99, 6);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Name.Multiline = true;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(196, 29);
            this.txt_Name.TabIndex = 7;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(7, 10);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(71, 19);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Tên món";
            // 
            // panelControl7
            // 
            this.panelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl7.Controls.Add(this.cbb_CategoryDetail);
            this.panelControl7.Controls.Add(this.labelControl3);
            this.panelControl7.Location = new System.Drawing.Point(3, 54);
            this.panelControl7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl7.Name = "panelControl7";
            this.panelControl7.Size = new System.Drawing.Size(297, 38);
            this.panelControl7.TabIndex = 3;
            // 
            // cbb_CategoryDetail
            // 
            this.cbb_CategoryDetail.BackColor = System.Drawing.Color.White;
            this.cbb_CategoryDetail.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_CategoryDetail.FormattingEnabled = true;
            this.cbb_CategoryDetail.Location = new System.Drawing.Point(99, 5);
            this.cbb_CategoryDetail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbb_CategoryDetail.Name = "cbb_CategoryDetail";
            this.cbb_CategoryDetail.Size = new System.Drawing.Size(196, 27);
            this.cbb_CategoryDetail.TabIndex = 7;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(7, 10);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(86, 21);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Danh mục";
            // 
            // panelControl9
            // 
            this.panelControl9.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl9.Controls.Add(this.txt_Price);
            this.panelControl9.Controls.Add(this.labelControl4);
            this.panelControl9.Location = new System.Drawing.Point(3, 100);
            this.panelControl9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl9.Name = "panelControl9";
            this.panelControl9.Size = new System.Drawing.Size(297, 38);
            this.panelControl9.TabIndex = 3;
            // 
            // txt_Price
            // 
            this.txt_Price.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Price.Location = new System.Drawing.Point(99, 4);
            this.txt_Price.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Price.Multiline = true;
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(195, 29);
            this.txt_Price.TabIndex = 8;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(7, 10);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(62, 19);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Đơn giá";
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
            // panelControl8
            // 
            this.panelControl8.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl8.Controls.Add(this.cbb_Category);
            this.panelControl8.Controls.Add(this.lbl_Category);
            this.panelControl8.Location = new System.Drawing.Point(3, 55);
            this.panelControl8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl8.Name = "panelControl8";
            this.panelControl8.Size = new System.Drawing.Size(311, 38);
            this.panelControl8.TabIndex = 4;
            // 
            // cbb_Category
            // 
            this.cbb_Category.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Category.FormattingEnabled = true;
            this.cbb_Category.Location = new System.Drawing.Point(92, 5);
            this.cbb_Category.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbb_Category.Name = "cbb_Category";
            this.cbb_Category.Size = new System.Drawing.Size(210, 27);
            this.cbb_Category.TabIndex = 8;
            this.cbb_Category.SelectedIndexChanged += new System.EventHandler(this.cbb_Category_SelectedIndexChanged);
            // 
            // lbl_Category
            // 
            this.lbl_Category.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.Appearance.Options.UseFont = true;
            this.lbl_Category.Location = new System.Drawing.Point(7, 9);
            this.lbl_Category.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(79, 21);
            this.lbl_Category.TabIndex = 3;
            this.lbl_Category.Text = "Loại món";
            // 
            // frm_Item
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 546);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_Item";
            this.Text = "System_Item";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl10)).EndInit();
            this.panelControl10.ResumeLayout(false);
            this.panelControl10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl14)).EndInit();
            this.panelControl14.ResumeLayout(false);
            this.panelControl14.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl7)).EndInit();
            this.panelControl7.ResumeLayout(false);
            this.panelControl7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl9)).EndInit();
            this.panelControl9.ResumeLayout(false);
            this.panelControl9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl8)).EndInit();
            this.panelControl8.ResumeLayout(false);
            this.panelControl8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl8;
        private DevExpress.XtraEditors.LabelControl lbl_Category;
        private System.Windows.Forms.ComboBox cbb_Category;
        private DevExpress.XtraEditors.PanelControl panelControl14;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private System.Windows.Forms.TextBox txt_Name;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl7;
        private System.Windows.Forms.ComboBox cbb_CategoryDetail;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.GridControl grd_Item;
        private DevExpress.XtraGrid.Views.Grid.GridView dgv_Item;
        private DevExpress.XtraGrid.Columns.GridColumn grdcol_IdItem;
        private DevExpress.XtraGrid.Columns.GridColumn grdcol_NameItem;
        private DevExpress.XtraGrid.Columns.GridColumn grdcol_Price;
        private DevExpress.XtraEditors.LabelControl lbl_ItemDetail;
        private DevExpress.XtraEditors.PanelControl panelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_Search;
        private System.Windows.Forms.TextBox txt_Search;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private DevExpress.XtraEditors.SimpleButton btn_Update;
        private DevExpress.XtraEditors.SimpleButton btn_Delete;
        private DevExpress.XtraGrid.Columns.GridColumn grd_Category;
        private System.Windows.Forms.TextBox txt_Price;
    }
}