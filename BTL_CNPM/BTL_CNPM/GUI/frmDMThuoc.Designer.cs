namespace BTL_CNPM.GUI
{
    partial class frmDMThuoc
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxTKThuoc = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.radioButtonTKTenThuoc = new System.Windows.Forms.RadioButton();
            this.radioButtonTKMaThuoc = new System.Windows.Forms.RadioButton();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.groupBoxTTThuoc = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.cbxDonViTinh = new System.Windows.Forms.ComboBox();
            this.cbxCachDung = new System.Windows.Forms.ComboBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblDonViTinh = new System.Windows.Forms.Label();
            this.lblCachDung = new System.Windows.Forms.Label();
            this.txtTenThuoc = new System.Windows.Forms.TextBox();
            this.lblTenThuoc = new System.Windows.Forms.Label();
            this.txtMaThuoc = new System.Windows.Forms.TextBox();
            this.lblMaThuoc = new System.Windows.Forms.Label();
            this.groupBoxDSThuoc = new System.Windows.Forms.GroupBox();
            this.dgvDSThuoc = new System.Windows.Forms.DataGridView();
            this.groupBoxTKThuoc.SuspendLayout();
            this.groupBoxTTThuoc.SuspendLayout();
            this.groupBoxDSThuoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSThuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(528, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(540, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ DANH MỤC THUỐC";
            // 
            // groupBoxTKThuoc
            // 
            this.groupBoxTKThuoc.Controls.Add(this.btnTimKiem);
            this.groupBoxTKThuoc.Controls.Add(this.txtTimKiem);
            this.groupBoxTKThuoc.Controls.Add(this.radioButtonTKTenThuoc);
            this.groupBoxTKThuoc.Controls.Add(this.radioButtonTKMaThuoc);
            this.groupBoxTKThuoc.Controls.Add(this.lblTimKiem);
            this.groupBoxTKThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTKThuoc.Location = new System.Drawing.Point(12, 87);
            this.groupBoxTKThuoc.Name = "groupBoxTKThuoc";
            this.groupBoxTKThuoc.Size = new System.Drawing.Size(434, 271);
            this.groupBoxTKThuoc.TabIndex = 2;
            this.groupBoxTKThuoc.TabStop = false;
            this.groupBoxTKThuoc.Text = "Tìm kiếm thuốc";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(131, 180);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(120, 38);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(131, 46);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(266, 27);
            this.txtTimKiem.TabIndex = 2;
            // 
            // radioButtonTKTenThuoc
            // 
            this.radioButtonTKTenThuoc.AutoSize = true;
            this.radioButtonTKTenThuoc.Location = new System.Drawing.Point(33, 144);
            this.radioButtonTKTenThuoc.Name = "radioButtonTKTenThuoc";
            this.radioButtonTKTenThuoc.Size = new System.Drawing.Size(209, 24);
            this.radioButtonTKTenThuoc.TabIndex = 1;
            this.radioButtonTKTenThuoc.Text = "Tìm kiếm theo tên thuốc";
            this.radioButtonTKTenThuoc.UseVisualStyleBackColor = true;
            this.radioButtonTKTenThuoc.CheckedChanged += new System.EventHandler(this.radioButtonTKTenThuoc_CheckedChanged);
            // 
            // radioButtonTKMaThuoc
            // 
            this.radioButtonTKMaThuoc.AutoSize = true;
            this.radioButtonTKMaThuoc.Checked = true;
            this.radioButtonTKMaThuoc.Location = new System.Drawing.Point(33, 106);
            this.radioButtonTKMaThuoc.Name = "radioButtonTKMaThuoc";
            this.radioButtonTKMaThuoc.Size = new System.Drawing.Size(209, 24);
            this.radioButtonTKMaThuoc.TabIndex = 1;
            this.radioButtonTKMaThuoc.TabStop = true;
            this.radioButtonTKMaThuoc.Text = "Tìm kiếm theo mã thuốc";
            this.radioButtonTKMaThuoc.UseVisualStyleBackColor = true;
            this.radioButtonTKMaThuoc.CheckedChanged += new System.EventHandler(this.radioButtonTKMaThuoc_CheckedChanged);
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Location = new System.Drawing.Point(29, 46);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(83, 20);
            this.lblTimKiem.TabIndex = 0;
            this.lblTimKiem.Text = "Mã thuốc:";
            // 
            // groupBoxTTThuoc
            // 
            this.groupBoxTTThuoc.Controls.Add(this.btnLamMoi);
            this.groupBoxTTThuoc.Controls.Add(this.btnXoa);
            this.groupBoxTTThuoc.Controls.Add(this.btnCapNhat);
            this.groupBoxTTThuoc.Controls.Add(this.btnThemMoi);
            this.groupBoxTTThuoc.Controls.Add(this.cbxDonViTinh);
            this.groupBoxTTThuoc.Controls.Add(this.cbxCachDung);
            this.groupBoxTTThuoc.Controls.Add(this.txtDonGia);
            this.groupBoxTTThuoc.Controls.Add(this.lblDonGia);
            this.groupBoxTTThuoc.Controls.Add(this.lblDonViTinh);
            this.groupBoxTTThuoc.Controls.Add(this.lblCachDung);
            this.groupBoxTTThuoc.Controls.Add(this.txtTenThuoc);
            this.groupBoxTTThuoc.Controls.Add(this.lblTenThuoc);
            this.groupBoxTTThuoc.Controls.Add(this.txtMaThuoc);
            this.groupBoxTTThuoc.Controls.Add(this.lblMaThuoc);
            this.groupBoxTTThuoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.groupBoxTTThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTTThuoc.Location = new System.Drawing.Point(467, 87);
            this.groupBoxTTThuoc.Name = "groupBoxTTThuoc";
            this.groupBoxTTThuoc.Size = new System.Drawing.Size(1118, 271);
            this.groupBoxTTThuoc.TabIndex = 3;
            this.groupBoxTTThuoc.TabStop = false;
            this.groupBoxTTThuoc.Text = "Thông tin thuốc";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(772, 197);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(120, 38);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(590, 197);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(120, 38);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(408, 197);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(120, 38);
            this.btnCapNhat.TabIndex = 3;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(226, 197);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(120, 38);
            this.btnThemMoi.TabIndex = 3;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // cbxDonViTinh
            // 
            this.cbxDonViTinh.FormattingEnabled = true;
            this.cbxDonViTinh.Items.AddRange(new object[] {
            "Viên",
            "Chai",
            "Ống"});
            this.cbxDonViTinh.Location = new System.Drawing.Point(712, 35);
            this.cbxDonViTinh.Name = "cbxDonViTinh";
            this.cbxDonViTinh.Size = new System.Drawing.Size(385, 28);
            this.cbxDonViTinh.TabIndex = 5;
            // 
            // cbxCachDung
            // 
            this.cbxCachDung.FormattingEnabled = true;
            this.cbxCachDung.Items.AddRange(new object[] {
            "Uống",
            "Tiêm",
            "Truyền"});
            this.cbxCachDung.Location = new System.Drawing.Point(165, 130);
            this.cbxCachDung.Name = "cbxCachDung";
            this.cbxCachDung.Size = new System.Drawing.Size(416, 28);
            this.cbxCachDung.TabIndex = 5;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(712, 84);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(385, 27);
            this.txtDonGia.TabIndex = 4;
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(606, 84);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(71, 20);
            this.lblDonGia.TabIndex = 3;
            this.lblDonGia.Text = "Đơn giá:";
            // 
            // lblDonViTinh
            // 
            this.lblDonViTinh.AutoSize = true;
            this.lblDonViTinh.Location = new System.Drawing.Point(606, 43);
            this.lblDonViTinh.Name = "lblDonViTinh";
            this.lblDonViTinh.Size = new System.Drawing.Size(93, 20);
            this.lblDonViTinh.TabIndex = 3;
            this.lblDonViTinh.Text = "Đơn vị tính:";
            // 
            // lblCachDung
            // 
            this.lblCachDung.AutoSize = true;
            this.lblCachDung.Location = new System.Drawing.Point(56, 130);
            this.lblCachDung.Name = "lblCachDung";
            this.lblCachDung.Size = new System.Drawing.Size(94, 20);
            this.lblCachDung.TabIndex = 3;
            this.lblCachDung.Text = "Cách dùng:";
            // 
            // txtTenThuoc
            // 
            this.txtTenThuoc.Location = new System.Drawing.Point(165, 87);
            this.txtTenThuoc.Name = "txtTenThuoc";
            this.txtTenThuoc.Size = new System.Drawing.Size(416, 27);
            this.txtTenThuoc.TabIndex = 4;
            // 
            // lblTenThuoc
            // 
            this.lblTenThuoc.AutoSize = true;
            this.lblTenThuoc.Location = new System.Drawing.Point(56, 87);
            this.lblTenThuoc.Name = "lblTenThuoc";
            this.lblTenThuoc.Size = new System.Drawing.Size(88, 20);
            this.lblTenThuoc.TabIndex = 3;
            this.lblTenThuoc.Text = "Tên thuốc:";
            // 
            // txtMaThuoc
            // 
            this.txtMaThuoc.Location = new System.Drawing.Point(165, 46);
            this.txtMaThuoc.Name = "txtMaThuoc";
            this.txtMaThuoc.Size = new System.Drawing.Size(416, 27);
            this.txtMaThuoc.TabIndex = 4;
            // 
            // lblMaThuoc
            // 
            this.lblMaThuoc.AutoSize = true;
            this.lblMaThuoc.Location = new System.Drawing.Point(56, 46);
            this.lblMaThuoc.Name = "lblMaThuoc";
            this.lblMaThuoc.Size = new System.Drawing.Size(83, 20);
            this.lblMaThuoc.TabIndex = 3;
            this.lblMaThuoc.Text = "Mã thuốc:";
            // 
            // groupBoxDSThuoc
            // 
            this.groupBoxDSThuoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDSThuoc.Controls.Add(this.dgvDSThuoc);
            this.groupBoxDSThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDSThuoc.Location = new System.Drawing.Point(12, 384);
            this.groupBoxDSThuoc.Name = "groupBoxDSThuoc";
            this.groupBoxDSThuoc.Size = new System.Drawing.Size(1573, 409);
            this.groupBoxDSThuoc.TabIndex = 3;
            this.groupBoxDSThuoc.TabStop = false;
            this.groupBoxDSThuoc.Text = "Danh sách thuốc";
            // 
            // dgvDSThuoc
            // 
            this.dgvDSThuoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSThuoc.Location = new System.Drawing.Point(6, 26);
            this.dgvDSThuoc.Name = "dgvDSThuoc";
            this.dgvDSThuoc.RowTemplate.Height = 24;
            this.dgvDSThuoc.Size = new System.Drawing.Size(1561, 377);
            this.dgvDSThuoc.TabIndex = 0;
            // 
            // frmDMThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1597, 805);
            this.Controls.Add(this.groupBoxDSThuoc);
            this.Controls.Add(this.groupBoxTTThuoc);
            this.Controls.Add(this.groupBoxTKThuoc);
            this.Controls.Add(this.label1);
            this.Name = "frmDMThuoc";
            this.Text = "frmDMThuoc";
            this.Load += new System.EventHandler(this.frmDMThuoc_Load);
            this.groupBoxTKThuoc.ResumeLayout(false);
            this.groupBoxTKThuoc.PerformLayout();
            this.groupBoxTTThuoc.ResumeLayout(false);
            this.groupBoxTTThuoc.PerformLayout();
            this.groupBoxDSThuoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSThuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxTKThuoc;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.RadioButton radioButtonTKTenThuoc;
        private System.Windows.Forms.RadioButton radioButtonTKMaThuoc;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.GroupBox groupBoxTTThuoc;
        private System.Windows.Forms.GroupBox groupBoxDSThuoc;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.ComboBox cbxDonViTinh;
        private System.Windows.Forms.ComboBox cbxCachDung;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblDonViTinh;
        private System.Windows.Forms.Label lblCachDung;
        private System.Windows.Forms.TextBox txtTenThuoc;
        private System.Windows.Forms.Label lblTenThuoc;
        private System.Windows.Forms.TextBox txtMaThuoc;
        private System.Windows.Forms.Label lblMaThuoc;
        private System.Windows.Forms.DataGridView dgvDSThuoc;
    }
}