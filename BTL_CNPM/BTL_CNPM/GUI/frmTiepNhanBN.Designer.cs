﻿namespace BTL_CNPM.GUI
{
    partial class frmTiepNhanBN
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
            this.groupBoxTTBN = new System.Windows.Forms.GroupBox();
            this.radioBtnNu = new System.Windows.Forms.RadioButton();
            this.radioBtnNam = new System.Windows.Forms.RadioButton();
            this.dateTimePickerNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtDiaChiBN = new System.Windows.Forms.TextBox();
            this.txtCMNDBN = new System.Windows.Forms.TextBox();
            this.txtTenBN = new System.Windows.Forms.TextBox();
            this.lblDiaChiBN = new System.Windows.Forms.Label();
            this.lblCMNDBN = new System.Windows.Forms.Label();
            this.lblGioiTinhBN = new System.Windows.Forms.Label();
            this.lblNgaySinhBN = new System.Windows.Forms.Label();
            this.lblHoTenBN = new System.Windows.Forms.Label();
            this.groupBoxTTTN = new System.Windows.Forms.GroupBox();
            this.txtSDTTN = new System.Windows.Forms.TextBox();
            this.lblTenTN = new System.Windows.Forms.Label();
            this.lblCMNDTN = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtCMNDTN = new System.Windows.Forms.TextBox();
            this.txtTenTN = new System.Windows.Forms.TextBox();
            this.groupBoxDSBN = new System.Windows.Forms.GroupBox();
            this.dgvDSBenhNhan = new System.Windows.Forms.DataGridView();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTiemKiem = new System.Windows.Forms.TextBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.btnTiepNhan = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblCanhBao1 = new System.Windows.Forms.Label();
            this.lblCanhBao2 = new System.Windows.Forms.Label();
            this.lblCanhBao3 = new System.Windows.Forms.Label();
            this.lblCanhBao4 = new System.Windows.Forms.Label();
            this.lblCanhBao5 = new System.Windows.Forms.Label();
            this.lblCanhBao6 = new System.Windows.Forms.Label();
            this.lblCanhBao7 = new System.Windows.Forms.Label();
            this.groupBoxTTBN.SuspendLayout();
            this.groupBoxTTTN.SuspendLayout();
            this.groupBoxDSBN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBenhNhan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(484, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "TIẾP NHẬN BỆNH NHÂN";
            // 
            // groupBoxTTBN
            // 
            this.groupBoxTTBN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBoxTTBN.Controls.Add(this.lblCanhBao4);
            this.groupBoxTTBN.Controls.Add(this.lblCanhBao3);
            this.groupBoxTTBN.Controls.Add(this.lblCanhBao2);
            this.groupBoxTTBN.Controls.Add(this.lblCanhBao1);
            this.groupBoxTTBN.Controls.Add(this.radioBtnNu);
            this.groupBoxTTBN.Controls.Add(this.radioBtnNam);
            this.groupBoxTTBN.Controls.Add(this.dateTimePickerNgaySinh);
            this.groupBoxTTBN.Controls.Add(this.txtDiaChiBN);
            this.groupBoxTTBN.Controls.Add(this.txtCMNDBN);
            this.groupBoxTTBN.Controls.Add(this.txtTenBN);
            this.groupBoxTTBN.Controls.Add(this.lblDiaChiBN);
            this.groupBoxTTBN.Controls.Add(this.lblCMNDBN);
            this.groupBoxTTBN.Controls.Add(this.lblGioiTinhBN);
            this.groupBoxTTBN.Controls.Add(this.lblNgaySinhBN);
            this.groupBoxTTBN.Controls.Add(this.lblHoTenBN);
            this.groupBoxTTBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTTBN.Location = new System.Drawing.Point(42, 87);
            this.groupBoxTTBN.Name = "groupBoxTTBN";
            this.groupBoxTTBN.Size = new System.Drawing.Size(812, 242);
            this.groupBoxTTBN.TabIndex = 1;
            this.groupBoxTTBN.TabStop = false;
            this.groupBoxTTBN.Text = "Thông tin bệnh nhân";
            // 
            // radioBtnNu
            // 
            this.radioBtnNu.AutoSize = true;
            this.radioBtnNu.Location = new System.Drawing.Point(305, 111);
            this.radioBtnNu.Name = "radioBtnNu";
            this.radioBtnNu.Size = new System.Drawing.Size(51, 24);
            this.radioBtnNu.TabIndex = 3;
            this.radioBtnNu.Text = "Nữ";
            this.radioBtnNu.UseVisualStyleBackColor = true;
            // 
            // radioBtnNam
            // 
            this.radioBtnNam.AutoSize = true;
            this.radioBtnNam.Checked = true;
            this.radioBtnNam.Location = new System.Drawing.Point(232, 110);
            this.radioBtnNam.Name = "radioBtnNam";
            this.radioBtnNam.Size = new System.Drawing.Size(65, 24);
            this.radioBtnNam.TabIndex = 3;
            this.radioBtnNam.TabStop = true;
            this.radioBtnNam.Text = "Nam";
            this.radioBtnNam.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerNgaySinh
            // 
            this.dateTimePickerNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgaySinh.Location = new System.Drawing.Point(232, 77);
            this.dateTimePickerNgaySinh.Name = "dateTimePickerNgaySinh";
            this.dateTimePickerNgaySinh.Size = new System.Drawing.Size(519, 27);
            this.dateTimePickerNgaySinh.TabIndex = 2;
            // 
            // txtDiaChiBN
            // 
            this.txtDiaChiBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChiBN.Location = new System.Drawing.Point(232, 176);
            this.txtDiaChiBN.Name = "txtDiaChiBN";
            this.txtDiaChiBN.Size = new System.Drawing.Size(519, 27);
            this.txtDiaChiBN.TabIndex = 1;
            // 
            // txtCMNDBN
            // 
            this.txtCMNDBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMNDBN.Location = new System.Drawing.Point(232, 143);
            this.txtCMNDBN.Name = "txtCMNDBN";
            this.txtCMNDBN.Size = new System.Drawing.Size(519, 27);
            this.txtCMNDBN.TabIndex = 1;
            // 
            // txtTenBN
            // 
            this.txtTenBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenBN.Location = new System.Drawing.Point(232, 39);
            this.txtTenBN.Name = "txtTenBN";
            this.txtTenBN.Size = new System.Drawing.Size(519, 27);
            this.txtTenBN.TabIndex = 1;
            // 
            // lblDiaChiBN
            // 
            this.lblDiaChiBN.AutoSize = true;
            this.lblDiaChiBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChiBN.Location = new System.Drawing.Point(61, 183);
            this.lblDiaChiBN.Name = "lblDiaChiBN";
            this.lblDiaChiBN.Size = new System.Drawing.Size(66, 20);
            this.lblDiaChiBN.TabIndex = 0;
            this.lblDiaChiBN.Text = "Địa chỉ:";
            // 
            // lblCMNDBN
            // 
            this.lblCMNDBN.AutoSize = true;
            this.lblCMNDBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMNDBN.Location = new System.Drawing.Point(61, 150);
            this.lblCMNDBN.Name = "lblCMNDBN";
            this.lblCMNDBN.Size = new System.Drawing.Size(65, 20);
            this.lblCMNDBN.TabIndex = 0;
            this.lblCMNDBN.Text = "CMND:";
            // 
            // lblGioiTinhBN
            // 
            this.lblGioiTinhBN.AutoSize = true;
            this.lblGioiTinhBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinhBN.Location = new System.Drawing.Point(61, 113);
            this.lblGioiTinhBN.Name = "lblGioiTinhBN";
            this.lblGioiTinhBN.Size = new System.Drawing.Size(76, 20);
            this.lblGioiTinhBN.TabIndex = 0;
            this.lblGioiTinhBN.Text = "Giới tính:";
            // 
            // lblNgaySinhBN
            // 
            this.lblNgaySinhBN.AutoSize = true;
            this.lblNgaySinhBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinhBN.Location = new System.Drawing.Point(61, 80);
            this.lblNgaySinhBN.Name = "lblNgaySinhBN";
            this.lblNgaySinhBN.Size = new System.Drawing.Size(88, 20);
            this.lblNgaySinhBN.TabIndex = 0;
            this.lblNgaySinhBN.Text = "Ngày sinh:";
            // 
            // lblHoTenBN
            // 
            this.lblHoTenBN.AutoSize = true;
            this.lblHoTenBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTenBN.Location = new System.Drawing.Point(61, 42);
            this.lblHoTenBN.Name = "lblHoTenBN";
            this.lblHoTenBN.Size = new System.Drawing.Size(146, 20);
            this.lblHoTenBN.TabIndex = 0;
            this.lblHoTenBN.Text = "Họ tên bệnh nhân:";
            // 
            // groupBoxTTTN
            // 
            this.groupBoxTTTN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBoxTTTN.Controls.Add(this.lblCanhBao7);
            this.groupBoxTTTN.Controls.Add(this.lblCanhBao6);
            this.groupBoxTTTN.Controls.Add(this.lblCanhBao5);
            this.groupBoxTTTN.Controls.Add(this.txtSDTTN);
            this.groupBoxTTTN.Controls.Add(this.lblTenTN);
            this.groupBoxTTTN.Controls.Add(this.lblCMNDTN);
            this.groupBoxTTTN.Controls.Add(this.lblSDT);
            this.groupBoxTTTN.Controls.Add(this.txtCMNDTN);
            this.groupBoxTTTN.Controls.Add(this.txtTenTN);
            this.groupBoxTTTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTTTN.Location = new System.Drawing.Point(889, 87);
            this.groupBoxTTTN.Name = "groupBoxTTTN";
            this.groupBoxTTTN.Size = new System.Drawing.Size(537, 242);
            this.groupBoxTTTN.TabIndex = 2;
            this.groupBoxTTTN.TabStop = false;
            this.groupBoxTTTN.Text = "Thông tin thân nhân";
            // 
            // txtSDTTN
            // 
            this.txtSDTTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDTTN.Location = new System.Drawing.Point(186, 103);
            this.txtSDTTN.Name = "txtSDTTN";
            this.txtSDTTN.Size = new System.Drawing.Size(305, 27);
            this.txtSDTTN.TabIndex = 1;
            // 
            // lblTenTN
            // 
            this.lblTenTN.AutoSize = true;
            this.lblTenTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenTN.Location = new System.Drawing.Point(23, 37);
            this.lblTenTN.Name = "lblTenTN";
            this.lblTenTN.Size = new System.Drawing.Size(142, 20);
            this.lblTenTN.TabIndex = 0;
            this.lblTenTN.Text = "Họ tên thân nhân:";
            // 
            // lblCMNDTN
            // 
            this.lblCMNDTN.AutoSize = true;
            this.lblCMNDTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMNDTN.Location = new System.Drawing.Point(23, 77);
            this.lblCMNDTN.Name = "lblCMNDTN";
            this.lblCMNDTN.Size = new System.Drawing.Size(65, 20);
            this.lblCMNDTN.TabIndex = 0;
            this.lblCMNDTN.Text = "CMND:";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.Location = new System.Drawing.Point(23, 110);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(111, 20);
            this.lblSDT.TabIndex = 0;
            this.lblSDT.Text = "Số điện thoại:";
            // 
            // txtCMNDTN
            // 
            this.txtCMNDTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMNDTN.Location = new System.Drawing.Point(186, 70);
            this.txtCMNDTN.Name = "txtCMNDTN";
            this.txtCMNDTN.Size = new System.Drawing.Size(305, 27);
            this.txtCMNDTN.TabIndex = 1;
            // 
            // txtTenTN
            // 
            this.txtTenTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTN.Location = new System.Drawing.Point(186, 34);
            this.txtTenTN.Name = "txtTenTN";
            this.txtTenTN.Size = new System.Drawing.Size(305, 27);
            this.txtTenTN.TabIndex = 1;
            // 
            // groupBoxDSBN
            // 
            this.groupBoxDSBN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDSBN.Controls.Add(this.dgvDSBenhNhan);
            this.groupBoxDSBN.Controls.Add(this.btnTimKiem);
            this.groupBoxDSBN.Controls.Add(this.txtTiemKiem);
            this.groupBoxDSBN.Controls.Add(this.lblTimKiem);
            this.groupBoxDSBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDSBN.Location = new System.Drawing.Point(12, 378);
            this.groupBoxDSBN.Name = "groupBoxDSBN";
            this.groupBoxDSBN.Size = new System.Drawing.Size(1420, 372);
            this.groupBoxDSBN.TabIndex = 3;
            this.groupBoxDSBN.TabStop = false;
            this.groupBoxDSBN.Text = "Danh sách bệnh nhân";
            // 
            // dgvDSBenhNhan
            // 
            this.dgvDSBenhNhan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSBenhNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSBenhNhan.Location = new System.Drawing.Point(6, 76);
            this.dgvDSBenhNhan.Name = "dgvDSBenhNhan";
            this.dgvDSBenhNhan.RowTemplate.Height = 24;
            this.dgvDSBenhNhan.Size = new System.Drawing.Size(1408, 290);
            this.dgvDSBenhNhan.TabIndex = 5;
            this.dgvDSBenhNhan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSBenhNhan_CellClick);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(777, 23);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(158, 33);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTiemKiem
            // 
            this.txtTiemKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTiemKiem.Location = new System.Drawing.Point(232, 26);
            this.txtTiemKiem.Name = "txtTiemKiem";
            this.txtTiemKiem.Size = new System.Drawing.Size(519, 27);
            this.txtTiemKiem.TabIndex = 1;
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiem.Location = new System.Drawing.Point(11, 31);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(192, 20);
            this.lblTimKiem.TabIndex = 0;
            this.lblTimKiem.Text = "Tìm kiếm tên bệnh nhân:";
            // 
            // btnTiepNhan
            // 
            this.btnTiepNhan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTiepNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiepNhan.Location = new System.Drawing.Point(448, 335);
            this.btnTiepNhan.Name = "btnTiepNhan";
            this.btnTiepNhan.Size = new System.Drawing.Size(158, 37);
            this.btnTiepNhan.TabIndex = 4;
            this.btnTiepNhan.Text = "Tiếp nhận";
            this.btnTiepNhan.UseVisualStyleBackColor = true;
            this.btnTiepNhan.Click += new System.EventHandler(this.btnTiepNhan_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(651, 335);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(158, 37);
            this.btnCapNhat.TabIndex = 4;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(842, 335);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(158, 37);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Làm mới";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lblCanhBao1
            // 
            this.lblCanhBao1.AutoSize = true;
            this.lblCanhBao1.ForeColor = System.Drawing.Color.Red;
            this.lblCanhBao1.Location = new System.Drawing.Point(758, 44);
            this.lblCanhBao1.Name = "lblCanhBao1";
            this.lblCanhBao1.Size = new System.Drawing.Size(15, 20);
            this.lblCanhBao1.TabIndex = 4;
            this.lblCanhBao1.Text = "*";
            // 
            // lblCanhBao2
            // 
            this.lblCanhBao2.AutoSize = true;
            this.lblCanhBao2.ForeColor = System.Drawing.Color.Red;
            this.lblCanhBao2.Location = new System.Drawing.Point(758, 82);
            this.lblCanhBao2.Name = "lblCanhBao2";
            this.lblCanhBao2.Size = new System.Drawing.Size(15, 20);
            this.lblCanhBao2.TabIndex = 4;
            this.lblCanhBao2.Text = "*";
            // 
            // lblCanhBao3
            // 
            this.lblCanhBao3.AutoSize = true;
            this.lblCanhBao3.ForeColor = System.Drawing.Color.Red;
            this.lblCanhBao3.Location = new System.Drawing.Point(757, 146);
            this.lblCanhBao3.Name = "lblCanhBao3";
            this.lblCanhBao3.Size = new System.Drawing.Size(15, 20);
            this.lblCanhBao3.TabIndex = 4;
            this.lblCanhBao3.Text = "*";
            // 
            // lblCanhBao4
            // 
            this.lblCanhBao4.AutoSize = true;
            this.lblCanhBao4.ForeColor = System.Drawing.Color.Red;
            this.lblCanhBao4.Location = new System.Drawing.Point(758, 176);
            this.lblCanhBao4.Name = "lblCanhBao4";
            this.lblCanhBao4.Size = new System.Drawing.Size(15, 20);
            this.lblCanhBao4.TabIndex = 4;
            this.lblCanhBao4.Text = "*";
            // 
            // lblCanhBao5
            // 
            this.lblCanhBao5.AutoSize = true;
            this.lblCanhBao5.ForeColor = System.Drawing.Color.Red;
            this.lblCanhBao5.Location = new System.Drawing.Point(501, 34);
            this.lblCanhBao5.Name = "lblCanhBao5";
            this.lblCanhBao5.Size = new System.Drawing.Size(15, 20);
            this.lblCanhBao5.TabIndex = 4;
            this.lblCanhBao5.Text = "*";
            // 
            // lblCanhBao6
            // 
            this.lblCanhBao6.AutoSize = true;
            this.lblCanhBao6.ForeColor = System.Drawing.Color.Red;
            this.lblCanhBao6.Location = new System.Drawing.Point(501, 70);
            this.lblCanhBao6.Name = "lblCanhBao6";
            this.lblCanhBao6.Size = new System.Drawing.Size(15, 20);
            this.lblCanhBao6.TabIndex = 4;
            this.lblCanhBao6.Text = "*";
            // 
            // lblCanhBao7
            // 
            this.lblCanhBao7.AutoSize = true;
            this.lblCanhBao7.ForeColor = System.Drawing.Color.Red;
            this.lblCanhBao7.Location = new System.Drawing.Point(501, 103);
            this.lblCanhBao7.Name = "lblCanhBao7";
            this.lblCanhBao7.Size = new System.Drawing.Size(15, 20);
            this.lblCanhBao7.TabIndex = 4;
            this.lblCanhBao7.Text = "*";
            // 
            // frmTiepNhanBN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 750);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnTiepNhan);
            this.Controls.Add(this.groupBoxDSBN);
            this.Controls.Add(this.groupBoxTTTN);
            this.Controls.Add(this.groupBoxTTBN);
            this.Controls.Add(this.label1);
            this.Name = "frmTiepNhanBN";
            this.Text = "frmTiepNhanBN";
            this.Load += new System.EventHandler(this.frmTiepNhanBN_Load);
            this.groupBoxTTBN.ResumeLayout(false);
            this.groupBoxTTBN.PerformLayout();
            this.groupBoxTTTN.ResumeLayout(false);
            this.groupBoxTTTN.PerformLayout();
            this.groupBoxDSBN.ResumeLayout(false);
            this.groupBoxDSBN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBenhNhan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxTTBN;
        private System.Windows.Forms.GroupBox groupBoxTTTN;
        private System.Windows.Forms.GroupBox groupBoxDSBN;
        private System.Windows.Forms.RadioButton radioBtnNu;
        private System.Windows.Forms.RadioButton radioBtnNam;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgaySinh;
        private System.Windows.Forms.TextBox txtDiaChiBN;
        private System.Windows.Forms.TextBox txtCMNDBN;
        private System.Windows.Forms.TextBox txtTenBN;
        private System.Windows.Forms.Label lblDiaChiBN;
        private System.Windows.Forms.Label lblCMNDBN;
        private System.Windows.Forms.Label lblGioiTinhBN;
        private System.Windows.Forms.Label lblNgaySinhBN;
        private System.Windows.Forms.Label lblHoTenBN;
        private System.Windows.Forms.Button btnTiepNhan;
        private System.Windows.Forms.TextBox txtSDTTN;
        private System.Windows.Forms.Label lblTenTN;
        private System.Windows.Forms.Label lblCMNDTN;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtCMNDTN;
        private System.Windows.Forms.TextBox txtTenTN;
        private System.Windows.Forms.DataGridView dgvDSBenhNhan;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTiemKiem;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lblCanhBao4;
        private System.Windows.Forms.Label lblCanhBao3;
        private System.Windows.Forms.Label lblCanhBao2;
        private System.Windows.Forms.Label lblCanhBao1;
        private System.Windows.Forms.Label lblCanhBao7;
        private System.Windows.Forms.Label lblCanhBao6;
        private System.Windows.Forms.Label lblCanhBao5;
    }
}