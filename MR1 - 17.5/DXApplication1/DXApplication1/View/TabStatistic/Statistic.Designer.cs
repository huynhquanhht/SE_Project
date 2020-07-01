namespace DXApplication1.GUI.TabStatistic
{
    partial class fStatistic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fStatistic));
            this.dtgvRevenue = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl11 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.chartControl = new DevExpress.XtraCharts.ChartControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btnDrink = new DevExpress.XtraEditors.SimpleButton();
            this.btnFood = new DevExpress.XtraEditors.SimpleButton();
            this.btnBill = new DevExpress.XtraEditors.SimpleButton();
            this.btnTotal = new DevExpress.XtraEditors.SimpleButton();
            this.cbbYear = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbbMonth = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl11)).BeginInit();
            this.panelControl11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbMonth.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvRevenue
            // 
            this.dtgvRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvRevenue.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvRevenue.Location = new System.Drawing.Point(0, 0);
            this.dtgvRevenue.MainView = this.gridView1;
            this.dtgvRevenue.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvRevenue.Name = "dtgvRevenue";
            this.dtgvRevenue.Size = new System.Drawing.Size(301, 274);
            this.dtgvRevenue.TabIndex = 2;
            this.dtgvRevenue.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView1.DetailHeight = 431;
            this.gridView1.GridControl = this.dtgvRevenue;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "STT";
            this.gridColumn1.FieldName = "STT";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 54;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Ngày";
            this.gridColumn2.FieldName = "DatePay";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 94;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Doanh thu";
            this.gridColumn3.FieldName = "Total";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 94;
            // 
            // panelControl11
            // 
            this.panelControl11.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelControl11.Appearance.Options.UseBackColor = true;
            this.panelControl11.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl11.Controls.Add(this.labelControl6);
            this.panelControl11.Location = new System.Drawing.Point(0, 0);
            this.panelControl11.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl11.Name = "panelControl11";
            this.panelControl11.Size = new System.Drawing.Size(301, 41);
            this.panelControl11.TabIndex = 26;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(35, 12);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(202, 19);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "DOANH THU THEO NGÀY";
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.chartControl);
            this.panelControl2.Location = new System.Drawing.Point(307, 139);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(657, 274);
            this.panelControl2.TabIndex = 29;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(145, 11);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(289, 21);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "BIỂU ĐỒ DOANH THU THEO NGÀY";
            // 
            // chartControl
            // 
            this.chartControl.Legend.Name = "Default Legend";
            this.chartControl.Legend.Title.Text = "Doanh thu";
            this.chartControl.Legend.Title.TextColor = System.Drawing.Color.Black;
            this.chartControl.Location = new System.Drawing.Point(4, 38);
            this.chartControl.Margin = new System.Windows.Forms.Padding(4);
            this.chartControl.Name = "chartControl";
            this.chartControl.PaletteName = "Green";
            this.chartControl.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl.SeriesTemplate.SeriesColorizer = null;
            this.chartControl.Size = new System.Drawing.Size(649, 231);
            this.chartControl.TabIndex = 1;
            // 
            // panelControl4
            // 
            this.panelControl4.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl4.Appearance.Options.UseBackColor = true;
            this.panelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl4.Controls.Add(this.panelControl11);
            this.panelControl4.Controls.Add(this.dtgvRevenue);
            this.panelControl4.Location = new System.Drawing.Point(2, 139);
            this.panelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(301, 274);
            this.panelControl4.TabIndex = 31;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.cbbYear);
            this.panelControl1.Controls.Add(this.cbbMonth);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Location = new System.Drawing.Point(0, -1);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(964, 132);
            this.panelControl1.TabIndex = 32;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(15, 6);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(127, 23);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Báo cáo ngày";
            // 
            // panelControl3
            // 
            this.panelControl3.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl3.Appearance.Options.UseBackColor = true;
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl3.Controls.Add(this.btnDrink);
            this.panelControl3.Controls.Add(this.btnFood);
            this.panelControl3.Controls.Add(this.btnBill);
            this.panelControl3.Controls.Add(this.btnTotal);
            this.panelControl3.Location = new System.Drawing.Point(7, 34);
            this.panelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(957, 90);
            this.panelControl3.TabIndex = 0;
            // 
            // btnDrink
            // 
            this.btnDrink.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDrink.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrink.Appearance.Options.UseBackColor = true;
            this.btnDrink.Appearance.Options.UseFont = true;
            this.btnDrink.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDrink.ImageOptions.Image")));
            this.btnDrink.Location = new System.Drawing.Point(762, 7);
            this.btnDrink.Margin = new System.Windows.Forms.Padding(4);
            this.btnDrink.Name = "btnDrink";
            this.btnDrink.Size = new System.Drawing.Size(191, 78);
            this.btnDrink.TabIndex = 5;
            this.btnDrink.Text = "Thức uống\r\n";
            // 
            // btnFood
            // 
            this.btnFood.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnFood.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFood.Appearance.Options.UseBackColor = true;
            this.btnFood.Appearance.Options.UseFont = true;
            this.btnFood.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFood.ImageOptions.Image")));
            this.btnFood.Location = new System.Drawing.Point(515, 6);
            this.btnFood.Margin = new System.Windows.Forms.Padding(4);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(191, 78);
            this.btnFood.TabIndex = 4;
            this.btnFood.Text = "Món ăn\r\n";
            // 
            // btnBill
            // 
            this.btnBill.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBill.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.Appearance.Options.UseBackColor = true;
            this.btnBill.Appearance.Options.UseFont = true;
            this.btnBill.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBill.ImageOptions.Image")));
            this.btnBill.Location = new System.Drawing.Point(251, 7);
            this.btnBill.Margin = new System.Windows.Forms.Padding(4);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(191, 76);
            this.btnBill.TabIndex = 3;
            this.btnBill.Text = "Hóa đơn\r";
            // 
            // btnTotal
            // 
            this.btnTotal.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTotal.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotal.Appearance.Options.UseBackColor = true;
            this.btnTotal.Appearance.Options.UseFont = true;
            this.btnTotal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTotal.ImageOptions.Image")));
            this.btnTotal.Location = new System.Drawing.Point(1, 7);
            this.btnTotal.Margin = new System.Windows.Forms.Padding(4);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(191, 76);
            this.btnTotal.TabIndex = 2;
            this.btnTotal.Text = "Doanh thu";
            // 
            // cbbYear
            // 
            this.cbbYear.Location = new System.Drawing.Point(307, 9);
            this.cbbYear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbYear.Name = "cbbYear";
            this.cbbYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbYear.Size = new System.Drawing.Size(101, 22);
            this.cbbYear.TabIndex = 50;
            this.cbbYear.SelectedIndexChanged += new System.EventHandler(this.cbbYear_SelectedIndexChanged);
            // 
            // cbbMonth
            // 
            this.cbbMonth.Location = new System.Drawing.Point(168, 9);
            this.cbbMonth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbMonth.Name = "cbbMonth";
            this.cbbMonth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbMonth.Size = new System.Drawing.Size(107, 22);
            this.cbbMonth.TabIndex = 51;
            this.cbbMonth.SelectedIndexChanged += new System.EventHandler(this.cbbMonth_SelectedIndexChanged);
            // 
            // fStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(973, 618);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.panelControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fStatistic";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl11)).EndInit();
            this.panelControl11.ResumeLayout(false);
            this.panelControl11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbbYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbMonth.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl dtgvRevenue;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnBill;
        private DevExpress.XtraEditors.SimpleButton btnTotal;
        private DevExpress.XtraEditors.SimpleButton btnDrink;
        private DevExpress.XtraEditors.SimpleButton btnFood;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraCharts.ChartControl chartControl;
        private DevExpress.XtraEditors.ComboBoxEdit cbbYear;
        private DevExpress.XtraEditors.ComboBoxEdit cbbMonth;
    }
}