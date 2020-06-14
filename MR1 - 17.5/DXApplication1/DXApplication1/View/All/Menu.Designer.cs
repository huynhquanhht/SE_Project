namespace DXApplication1
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.timeEdit1 = new DevExpress.XtraEditors.TimeEdit();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Sale = new DevExpress.XtraEditors.SimpleButton();
            this.btn_System = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Statistical = new DevExpress.XtraEditors.SimpleButton();
            this.panelChildForm = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.timeEdit1);
            this.panelControl2.Controls.Add(this.dateTimePicker1);
            this.panelControl2.Controls.Add(this.comboBox1);
            this.panelControl2.Controls.Add(this.pictureEdit1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(736, 66);
            this.panelControl2.TabIndex = 8;
            // 
            // timeEdit1
            // 
            this.timeEdit1.EditValue = new System.DateTime(2020, 6, 3, 0, 0, 0, 0);
            this.timeEdit1.Location = new System.Drawing.Point(215, 43);
            this.timeEdit1.Name = "timeEdit1";
            this.timeEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeEdit1.Size = new System.Drawing.Size(100, 20);
            this.timeEdit1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(338, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Xem thông tin cá nhân",
            "Thay đổi thông tin",
            "Đổi mật khẩu",
            "Thoát"});
            this.comboBox1.Location = new System.Drawing.Point(579, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "Huỳnh Văn Quân";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureEdit1.BackgroundImage")));
            this.pictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(2, 3);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(140, 60);
            this.pictureEdit1.TabIndex = 2;
            // 
            // panelControl3
            // 
            this.panelControl3.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelControl3.Appearance.Options.UseBackColor = true;
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl3.Controls.Add(this.btn_Sale);
            this.panelControl3.Controls.Add(this.btn_System);
            this.panelControl3.Controls.Add(this.btn_Statistical);
            this.panelControl3.Location = new System.Drawing.Point(0, 66);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(736, 35);
            this.panelControl3.TabIndex = 5;
            // 
            // btn_Sale
            // 
            this.btn_Sale.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Sale.Appearance.BorderColor = System.Drawing.Color.White;
            this.btn_Sale.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sale.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_Sale.Appearance.Options.UseBackColor = true;
            this.btn_Sale.Appearance.Options.UseBorderColor = true;
            this.btn_Sale.Appearance.Options.UseFont = true;
            this.btn_Sale.Appearance.Options.UseForeColor = true;
            this.btn_Sale.AppearancePressed.BackColor = System.Drawing.Color.Blue;
            this.btn_Sale.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sale.AppearancePressed.Options.UseBackColor = true;
            this.btn_Sale.AppearancePressed.Options.UseFont = true;
            this.btn_Sale.Location = new System.Drawing.Point(87, 0);
            this.btn_Sale.Name = "btn_Sale";
            this.btn_Sale.Size = new System.Drawing.Size(88, 34);
            this.btn_Sale.TabIndex = 10;
            this.btn_Sale.Text = "Bán hàng";
            this.btn_Sale.Click += new System.EventHandler(this.btn_Sale_Click);
            // 
            // btn_System
            // 
            this.btn_System.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_System.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.btn_System.Appearance.BorderColor = System.Drawing.Color.White;
            this.btn_System.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_System.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_System.Appearance.Options.UseBackColor = true;
            this.btn_System.Appearance.Options.UseBorderColor = true;
            this.btn_System.Appearance.Options.UseFont = true;
            this.btn_System.Appearance.Options.UseForeColor = true;
            this.btn_System.AppearancePressed.BackColor = System.Drawing.Color.Blue;
            this.btn_System.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_System.AppearancePressed.Options.UseBackColor = true;
            this.btn_System.AppearancePressed.Options.UseFont = true;
            this.btn_System.Location = new System.Drawing.Point(0, 0);
            this.btn_System.Name = "btn_System";
            this.btn_System.Size = new System.Drawing.Size(88, 34);
            this.btn_System.TabIndex = 9;
            this.btn_System.Text = "Hệ thống";
            this.btn_System.Click += new System.EventHandler(this.btn_System_Click);
            // 
            // btn_Statistical
            // 
            this.btn_Statistical.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Statistical.Appearance.BorderColor = System.Drawing.Color.White;
            this.btn_Statistical.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Statistical.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_Statistical.Appearance.Options.UseBackColor = true;
            this.btn_Statistical.Appearance.Options.UseBorderColor = true;
            this.btn_Statistical.Appearance.Options.UseFont = true;
            this.btn_Statistical.Appearance.Options.UseForeColor = true;
            this.btn_Statistical.AppearancePressed.BackColor = System.Drawing.Color.Blue;
            this.btn_Statistical.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Statistical.AppearancePressed.Options.UseBackColor = true;
            this.btn_Statistical.AppearancePressed.Options.UseFont = true;
            this.btn_Statistical.Location = new System.Drawing.Point(174, 0);
            this.btn_Statistical.Name = "btn_Statistical";
            this.btn_Statistical.Size = new System.Drawing.Size(88, 34);
            this.btn_Statistical.TabIndex = 11;
            this.btn_Statistical.Text = "Thống kê";
            this.btn_Statistical.Click += new System.EventHandler(this.btn_Statistical_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.Location = new System.Drawing.Point(0, 102);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(736, 474);
            this.panelChildForm.TabIndex = 9;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 575);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton btn_Sale;
        private DevExpress.XtraEditors.SimpleButton btn_System;
        private DevExpress.XtraEditors.SimpleButton btn_Statistical;
        private System.Windows.Forms.ComboBox comboBox1;
        private DevExpress.XtraEditors.PanelControl panelChildForm;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private DevExpress.XtraEditors.TimeEdit timeEdit1;
    }
}