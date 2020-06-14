namespace DXApplication1.GUI
{
    partial class frm_Category
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Category));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Search = new DevExpress.XtraEditors.SimpleButton();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl11 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl14 = new DevExpress.XtraEditors.PanelControl();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lbl_ItemDetail = new DevExpress.XtraEditors.LabelControl();
            this.grd_Category = new DevExpress.XtraGrid.GridControl();
            this.dgv_Category = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdcol_IdCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdcol_NameCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl11)).BeginInit();
            this.panelControl11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl14)).BeginInit();
            this.panelControl14.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Category)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Category)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Controls.Add(this.panelControl11);
            this.panelControl1.Controls.Add(this.panelControl14);
            this.panelControl1.Controls.Add(this.grd_Category);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(741, 290);
            this.panelControl1.TabIndex = 13;
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.panelControl5);
            this.panelControl2.Controls.Add(this.btn_Add);
            this.panelControl2.Controls.Add(this.btn_Update);
            this.panelControl2.Controls.Add(this.btn_Delete);
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(741, 37);
            this.panelControl2.TabIndex = 26;
            // 
            // panelControl5
            // 
            this.panelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl5.Controls.Add(this.btn_Search);
            this.panelControl5.Controls.Add(this.txt_Search);
            this.panelControl5.Location = new System.Drawing.Point(265, 0);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(201, 33);
            this.panelControl5.TabIndex = 19;
            // 
            // btn_Search
            // 
            this.btn_Search.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Search.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Appearance.Options.UseBackColor = true;
            this.btn_Search.Appearance.Options.UseFont = true;
            this.btn_Search.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search.ImageOptions.Image")));
            this.btn_Search.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_Search.Location = new System.Drawing.Point(2, 2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(81, 30);
            this.btn_Search.TabIndex = 8;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(87, 5);
            this.txt_Search.Multiline = true;
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(110, 24);
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
            this.btn_Add.Location = new System.Drawing.Point(7, 3);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(81, 30);
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
            this.btn_Update.Location = new System.Drawing.Point(94, 3);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(81, 30);
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
            this.btn_Delete.Location = new System.Drawing.Point(181, 3);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(81, 30);
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
            this.panelControl11.Location = new System.Drawing.Point(4, 39);
            this.panelControl11.Name = "panelControl11";
            this.panelControl11.Size = new System.Drawing.Size(415, 33);
            this.panelControl11.TabIndex = 25;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(95, 9);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(211, 16);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "DANH SÁCH THÔNG TIN LOẠI MÓN";
            // 
            // panelControl14
            // 
            this.panelControl14.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl14.Controls.Add(this.flowLayoutPanel1);
            this.panelControl14.Controls.Add(this.lbl_ItemDetail);
            this.panelControl14.Location = new System.Drawing.Point(425, 39);
            this.panelControl14.Name = "panelControl14";
            this.panelControl14.Size = new System.Drawing.Size(301, 113);
            this.panelControl14.TabIndex = 19;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.panelControl4);
            this.flowLayoutPanel1.Controls.Add(this.panelControl3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 25);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(282, 85);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // panelControl4
            // 
            this.panelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl4.Controls.Add(this.txt_Id);
            this.panelControl4.Controls.Add(this.labelControl1);
            this.panelControl4.Location = new System.Drawing.Point(3, 3);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(271, 34);
            this.panelControl4.TabIndex = 9;
            // 
            // txt_Id
            // 
            this.txt_Id.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Id.Location = new System.Drawing.Point(78, 5);
            this.txt_Id.Multiline = true;
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(186, 24);
            this.txt_Id.TabIndex = 7;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(6, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Mã loại";
            // 
            // panelControl3
            // 
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl3.Controls.Add(this.txt_Name);
            this.panelControl3.Controls.Add(this.labelControl5);
            this.panelControl3.Location = new System.Drawing.Point(3, 43);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(271, 34);
            this.panelControl3.TabIndex = 8;
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(78, 5);
            this.txt_Name.Multiline = true;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(186, 24);
            this.txt_Name.TabIndex = 7;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(6, 8);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(49, 16);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "Tên loại";
            // 
            // lbl_ItemDetail
            // 
            this.lbl_ItemDetail.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ItemDetail.Appearance.Options.UseFont = true;
            this.lbl_ItemDetail.Location = new System.Drawing.Point(3, 3);
            this.lbl_ItemDetail.Name = "lbl_ItemDetail";
            this.lbl_ItemDetail.Size = new System.Drawing.Size(113, 16);
            this.lbl_ItemDetail.TabIndex = 4;
            this.lbl_ItemDetail.Text = "Thông tin chi tiết ";
            // 
            // grd_Category
            // 
            this.grd_Category.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.True;
            this.grd_Category.EmbeddedNavigator.Appearance.ForeColor = System.Drawing.Color.Black;
            this.grd_Category.EmbeddedNavigator.Appearance.Options.UseForeColor = true;
            this.grd_Category.Location = new System.Drawing.Point(4, 39);
            this.grd_Category.MainView = this.dgv_Category;
            this.grd_Category.Name = "grd_Category";
            this.grd_Category.Size = new System.Drawing.Size(415, 248);
            this.grd_Category.TabIndex = 13;
            this.grd_Category.UseEmbeddedNavigator = true;
            this.grd_Category.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgv_Category});
            // 
            // dgv_Category
            // 
            this.dgv_Category.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.dgv_Category.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.dgv_Category.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.dgv_Category.Appearance.HeaderPanel.Options.UseFont = true;
            this.dgv_Category.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.dgv_Category.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.dgv_Category.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdcol_IdCategory,
            this.grdcol_NameCategory});
            this.dgv_Category.GridControl = this.grd_Category;
            this.dgv_Category.Name = "dgv_Category";
            this.dgv_Category.OptionsBehavior.Editable = false;
            this.dgv_Category.OptionsBehavior.ReadOnly = true;
            this.dgv_Category.OptionsSelection.MultiSelect = true;
            this.dgv_Category.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.grdcol_IdCategory, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.dgv_Category.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.dgv_Category_RowClick);
            // 
            // grdcol_IdCategory
            // 
            this.grdcol_IdCategory.AppearanceCell.BackColor2 = System.Drawing.Color.Transparent;
            this.grdcol_IdCategory.AppearanceCell.BorderColor = System.Drawing.Color.Black;
            this.grdcol_IdCategory.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdcol_IdCategory.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.grdcol_IdCategory.AppearanceCell.Options.HighPriority = true;
            this.grdcol_IdCategory.AppearanceCell.Options.UseBackColor = true;
            this.grdcol_IdCategory.AppearanceCell.Options.UseBorderColor = true;
            this.grdcol_IdCategory.AppearanceCell.Options.UseFont = true;
            this.grdcol_IdCategory.AppearanceCell.Options.UseForeColor = true;
            this.grdcol_IdCategory.AppearanceCell.Options.UseTextOptions = true;
            this.grdcol_IdCategory.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.grdcol_IdCategory.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.grdcol_IdCategory.AppearanceHeader.BorderColor = System.Drawing.Color.Black;
            this.grdcol_IdCategory.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdcol_IdCategory.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.grdcol_IdCategory.AppearanceHeader.Options.UseBackColor = true;
            this.grdcol_IdCategory.AppearanceHeader.Options.UseBorderColor = true;
            this.grdcol_IdCategory.AppearanceHeader.Options.UseFont = true;
            this.grdcol_IdCategory.AppearanceHeader.Options.UseForeColor = true;
            this.grdcol_IdCategory.AppearanceHeader.Options.UseTextOptions = true;
            this.grdcol_IdCategory.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdcol_IdCategory.Caption = "Mã loại";
            this.grdcol_IdCategory.FieldName = "Id";
            this.grdcol_IdCategory.Name = "grdcol_IdCategory";
            this.grdcol_IdCategory.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.grdcol_IdCategory.Visible = true;
            this.grdcol_IdCategory.VisibleIndex = 0;
            this.grdcol_IdCategory.Width = 48;
            // 
            // grdcol_NameCategory
            // 
            this.grdcol_NameCategory.AppearanceCell.BackColor2 = System.Drawing.Color.Transparent;
            this.grdcol_NameCategory.AppearanceCell.BorderColor = System.Drawing.Color.Black;
            this.grdcol_NameCategory.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdcol_NameCategory.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.grdcol_NameCategory.AppearanceCell.Options.HighPriority = true;
            this.grdcol_NameCategory.AppearanceCell.Options.UseBackColor = true;
            this.grdcol_NameCategory.AppearanceCell.Options.UseBorderColor = true;
            this.grdcol_NameCategory.AppearanceCell.Options.UseFont = true;
            this.grdcol_NameCategory.AppearanceCell.Options.UseForeColor = true;
            this.grdcol_NameCategory.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.grdcol_NameCategory.AppearanceHeader.BorderColor = System.Drawing.Color.Black;
            this.grdcol_NameCategory.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdcol_NameCategory.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.grdcol_NameCategory.AppearanceHeader.Options.UseBackColor = true;
            this.grdcol_NameCategory.AppearanceHeader.Options.UseBorderColor = true;
            this.grdcol_NameCategory.AppearanceHeader.Options.UseFont = true;
            this.grdcol_NameCategory.AppearanceHeader.Options.UseForeColor = true;
            this.grdcol_NameCategory.AppearanceHeader.Options.UseTextOptions = true;
            this.grdcol_NameCategory.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdcol_NameCategory.Caption = "Tên loại";
            this.grdcol_NameCategory.FieldName = "Name";
            this.grdcol_NameCategory.Name = "grdcol_NameCategory";
            this.grdcol_NameCategory.Visible = true;
            this.grdcol_NameCategory.VisibleIndex = 1;
            this.grdcol_NameCategory.Width = 126;
            // 
            // frm_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 290);
            this.Controls.Add(this.panelControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Category";
            this.Text = "Category";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            this.panelControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl11)).EndInit();
            this.panelControl11.ResumeLayout(false);
            this.panelControl11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl14)).EndInit();
            this.panelControl14.ResumeLayout(false);
            this.panelControl14.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Category)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Category)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl grd_Category;
        private DevExpress.XtraGrid.Views.Grid.GridView dgv_Category;
        private DevExpress.XtraGrid.Columns.GridColumn grdcol_IdCategory;
        private DevExpress.XtraGrid.Columns.GridColumn grdcol_NameCategory;
        private DevExpress.XtraEditors.PanelControl panelControl14;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.TextBox txt_Name;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl lbl_ItemDetail;
        private DevExpress.XtraEditors.PanelControl panelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DevExpress.XtraEditors.SimpleButton btn_Search;
        private System.Windows.Forms.TextBox txt_Search;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private DevExpress.XtraEditors.SimpleButton btn_Update;
        private DevExpress.XtraEditors.SimpleButton btn_Delete;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private System.Windows.Forms.TextBox txt_Id;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}