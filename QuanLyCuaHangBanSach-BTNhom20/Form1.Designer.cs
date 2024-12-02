namespace QuanLyCuaHangBanSach
{
    partial class FrmQuanLyBanSach
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpSach = new System.Windows.Forms.TabPage();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.numbGiaBan = new System.Windows.Forms.NumericUpDown();
            this.btnSachThem = new System.Windows.Forms.Button();
            this.btnSachSua = new System.Windows.Forms.Button();
            this.numbSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.btnSachXoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxLoaiSach = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.tpLoaiSach = new System.Windows.Forms.TabPage();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.btnThemLoaiSach = new System.Windows.Forms.Button();
            this.btnSuaLoaiSach = new System.Windows.Forms.Button();
            this.btnXoaLoaiSach = new System.Windows.Forms.Button();
            this.dgvLoaiSach = new System.Windows.Forms.DataGridView();
            this.txtTenLoaiSach = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tpHoaDon = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtSDTKhachHang = new System.Windows.Forms.TextBox();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNgayLapHoaDOn = new System.Windows.Forms.Label();
            this.DTPNgayLapHoaDon = new System.Windows.Forms.DateTimePicker();
            this.dtgvHoaDon = new System.Windows.Forms.DataGridView();
            this.tpPhieuNhap = new System.Windows.Forms.TabPage();
            this.refreshNCC_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addNCC_btn = new System.Windows.Forms.Button();
            this.fixNCC_btn = new System.Windows.Forms.Button();
            this.deleteNCC_btn = new System.Windows.Forms.Button();
            this.txtTenNhaCungCap = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DTPNgayLapPhieuNhap = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshBook_btn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numbGiaBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbSoLuong)).BeginInit();
            this.tpLoaiSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiSach)).BeginInit();
            this.tpHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHoaDon)).BeginInit();
            this.tpPhieuNhap.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpSach);
            this.tabControl1.Controls.Add(this.tpLoaiSach);
            this.tabControl1.Controls.Add(this.tpHoaDon);
            this.tabControl1.Controls.Add(this.tpPhieuNhap);
            this.tabControl1.Location = new System.Drawing.Point(2, 6);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(930, 514);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Tag = "";
            // 
            // tpSach
            // 
            this.tpSach.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.tpSach.Controls.Add(this.dgvSach);
            this.tpSach.Controls.Add(this.panel1);
            this.tpSach.Location = new System.Drawing.Point(4, 22);
            this.tpSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpSach.Name = "tpSach";
            this.tpSach.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpSach.Size = new System.Drawing.Size(922, 488);
            this.tpSach.TabIndex = 0;
            this.tpSach.Text = "Sách";
            // 
            // dgvSach
            // 
            this.dgvSach.BackgroundColor = System.Drawing.Color.PaleGoldenrod;
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Location = new System.Drawing.Point(4, 5);
            this.dgvSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.RowHeadersWidth = 51;
            this.dgvSach.RowTemplate.Height = 24;
            this.dgvSach.Size = new System.Drawing.Size(914, 340);
            this.dgvSach.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Controls.Add(this.refreshBook_btn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.numbGiaBan);
            this.panel1.Controls.Add(this.btnSachThem);
            this.panel1.Controls.Add(this.btnSachSua);
            this.panel1.Controls.Add(this.numbSoLuong);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTenSach);
            this.panel1.Controls.Add(this.btnSachXoa);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbxLoaiSach);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtTacGia);
            this.panel1.Location = new System.Drawing.Point(4, 348);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 137);
            this.panel1.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DodgerBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(458, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Giá Bán";
            // 
            // numbGiaBan
            // 
            this.numbGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numbGiaBan.Location = new System.Drawing.Point(545, 58);
            this.numbGiaBan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numbGiaBan.Name = "numbGiaBan";
            this.numbGiaBan.Size = new System.Drawing.Size(196, 26);
            this.numbGiaBan.TabIndex = 14;
            // 
            // btnSachThem
            // 
            this.btnSachThem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSachThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSachThem.Location = new System.Drawing.Point(760, 12);
            this.btnSachThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSachThem.Name = "btnSachThem";
            this.btnSachThem.Size = new System.Drawing.Size(140, 27);
            this.btnSachThem.TabIndex = 3;
            this.btnSachThem.Text = "Thêm ";
            this.btnSachThem.UseVisualStyleBackColor = false;
            this.btnSachThem.Click += new System.EventHandler(this.btnSachThem_Click);
            // 
            // btnSachSua
            // 
            this.btnSachSua.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSachSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSachSua.Location = new System.Drawing.Point(760, 58);
            this.btnSachSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSachSua.Name = "btnSachSua";
            this.btnSachSua.Size = new System.Drawing.Size(138, 27);
            this.btnSachSua.TabIndex = 2;
            this.btnSachSua.Text = "Sửa";
            this.btnSachSua.UseVisualStyleBackColor = false;
            this.btnSachSua.Click += new System.EventHandler(this.btnSachSua_Click);
            // 
            // numbSoLuong
            // 
            this.numbSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numbSoLuong.Location = new System.Drawing.Point(308, 58);
            this.numbSoLuong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numbSoLuong.Name = "numbSoLuong";
            this.numbSoLuong.Size = new System.Drawing.Size(128, 26);
            this.numbSoLuong.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Lime;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(222, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Số Lượng";
            // 
            // txtTenSach
            // 
            this.txtTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSach.Location = new System.Drawing.Point(90, 9);
            this.txtTenSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(128, 26);
            this.txtTenSach.TabIndex = 9;
            // 
            // btnSachXoa
            // 
            this.btnSachXoa.BackColor = System.Drawing.Color.Brown;
            this.btnSachXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSachXoa.Location = new System.Drawing.Point(760, 101);
            this.btnSachXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSachXoa.Name = "btnSachXoa";
            this.btnSachXoa.Size = new System.Drawing.Size(140, 27);
            this.btnSachXoa.TabIndex = 1;
            this.btnSachXoa.Text = "Xóa";
            this.btnSachXoa.UseVisualStyleBackColor = false;
            this.btnSachXoa.Click += new System.EventHandler(this.btnSachXoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên Sách";
            // 
            // cbxLoaiSach
            // 
            this.cbxLoaiSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLoaiSach.FormattingEnabled = true;
            this.cbxLoaiSach.Location = new System.Drawing.Point(545, 11);
            this.cbxLoaiSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxLoaiSach.Name = "cbxLoaiSach";
            this.cbxLoaiSach.Size = new System.Drawing.Size(198, 28);
            this.cbxLoaiSach.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Lime;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(458, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Loại Sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Lime;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(234, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tác Giả";
            // 
            // txtTacGia
            // 
            this.txtTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTacGia.Location = new System.Drawing.Point(308, 11);
            this.txtTacGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(128, 26);
            this.txtTacGia.TabIndex = 5;
            // 
            // tpLoaiSach
            // 
            this.tpLoaiSach.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.tpLoaiSach.Controls.Add(this.RefreshBtn);
            this.tpLoaiSach.Controls.Add(this.btnThemLoaiSach);
            this.tpLoaiSach.Controls.Add(this.btnSuaLoaiSach);
            this.tpLoaiSach.Controls.Add(this.btnXoaLoaiSach);
            this.tpLoaiSach.Controls.Add(this.dgvLoaiSach);
            this.tpLoaiSach.Controls.Add(this.txtTenLoaiSach);
            this.tpLoaiSach.Controls.Add(this.label8);
            this.tpLoaiSach.Location = new System.Drawing.Point(4, 22);
            this.tpLoaiSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpLoaiSach.Name = "tpLoaiSach";
            this.tpLoaiSach.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpLoaiSach.Size = new System.Drawing.Size(922, 488);
            this.tpLoaiSach.TabIndex = 1;
            this.tpLoaiSach.Text = "Loại Sách";
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.BackColor = System.Drawing.Color.Lime;
            this.RefreshBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshBtn.ForeColor = System.Drawing.Color.Black;
            this.RefreshBtn.Location = new System.Drawing.Point(789, 18);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(114, 41);
            this.RefreshBtn.TabIndex = 27;
            this.RefreshBtn.Text = "Làm mới";
            this.RefreshBtn.UseVisualStyleBackColor = false;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // btnThemLoaiSach
            // 
            this.btnThemLoaiSach.BackColor = System.Drawing.Color.Silver;
            this.btnThemLoaiSach.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLoaiSach.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThemLoaiSach.Location = new System.Drawing.Point(355, 408);
            this.btnThemLoaiSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThemLoaiSach.Name = "btnThemLoaiSach";
            this.btnThemLoaiSach.Size = new System.Drawing.Size(114, 43);
            this.btnThemLoaiSach.TabIndex = 26;
            this.btnThemLoaiSach.Text = "Thêm ";
            this.btnThemLoaiSach.UseVisualStyleBackColor = false;
            this.btnThemLoaiSach.Click += new System.EventHandler(this.btnThemLoaiSach_Click);
            // 
            // btnSuaLoaiSach
            // 
            this.btnSuaLoaiSach.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSuaLoaiSach.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaLoaiSach.ForeColor = System.Drawing.Color.Black;
            this.btnSuaLoaiSach.Location = new System.Drawing.Point(788, 77);
            this.btnSuaLoaiSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSuaLoaiSach.Name = "btnSuaLoaiSach";
            this.btnSuaLoaiSach.Size = new System.Drawing.Size(113, 38);
            this.btnSuaLoaiSach.TabIndex = 25;
            this.btnSuaLoaiSach.Text = "Sửa";
            this.btnSuaLoaiSach.UseVisualStyleBackColor = false;
            this.btnSuaLoaiSach.Click += new System.EventHandler(this.btnSuaLoaiSach_Click);
            // 
            // btnXoaLoaiSach
            // 
            this.btnXoaLoaiSach.BackColor = System.Drawing.Color.Red;
            this.btnXoaLoaiSach.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLoaiSach.ForeColor = System.Drawing.Color.Black;
            this.btnXoaLoaiSach.Location = new System.Drawing.Point(788, 130);
            this.btnXoaLoaiSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoaLoaiSach.Name = "btnXoaLoaiSach";
            this.btnXoaLoaiSach.Size = new System.Drawing.Size(113, 40);
            this.btnXoaLoaiSach.TabIndex = 24;
            this.btnXoaLoaiSach.Text = "Xóa";
            this.btnXoaLoaiSach.UseVisualStyleBackColor = false;
            this.btnXoaLoaiSach.Click += new System.EventHandler(this.btnXoaLoaiSach_Click);
            // 
            // dgvLoaiSach
            // 
            this.dgvLoaiSach.BackgroundColor = System.Drawing.Color.White;
            this.dgvLoaiSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiSach.Location = new System.Drawing.Point(4, 4);
            this.dgvLoaiSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvLoaiSach.Name = "dgvLoaiSach";
            this.dgvLoaiSach.RowHeadersWidth = 51;
            this.dgvLoaiSach.RowTemplate.Height = 24;
            this.dgvLoaiSach.Size = new System.Drawing.Size(780, 378);
            this.dgvLoaiSach.TabIndex = 23;
            // 
            // txtTenLoaiSach
            // 
            this.txtTenLoaiSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLoaiSach.Location = new System.Drawing.Point(158, 414);
            this.txtTenLoaiSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenLoaiSach.Name = "txtTenLoaiSach";
            this.txtTenLoaiSach.Size = new System.Drawing.Size(173, 26);
            this.txtTenLoaiSach.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 416);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Tên Loại Sách:";
            // 
            // tpHoaDon
            // 
            this.tpHoaDon.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.tpHoaDon.Controls.Add(this.button1);
            this.tpHoaDon.Controls.Add(this.button2);
            this.tpHoaDon.Controls.Add(this.button3);
            this.tpHoaDon.Controls.Add(this.txtSDTKhachHang);
            this.tpHoaDon.Controls.Add(this.txtTenKhachHang);
            this.tpHoaDon.Controls.Add(this.label7);
            this.tpHoaDon.Controls.Add(this.label6);
            this.tpHoaDon.Controls.Add(this.lblNgayLapHoaDOn);
            this.tpHoaDon.Controls.Add(this.DTPNgayLapHoaDon);
            this.tpHoaDon.Controls.Add(this.dtgvHoaDon);
            this.tpHoaDon.Location = new System.Drawing.Point(4, 22);
            this.tpHoaDon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpHoaDon.Name = "tpHoaDon";
            this.tpHoaDon.Size = new System.Drawing.Size(922, 488);
            this.tpHoaDon.TabIndex = 2;
            this.tpHoaDon.Text = "Hóa Đơn";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(593, 340);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 27);
            this.button1.TabIndex = 29;
            this.button1.Text = "Thêm ";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(595, 388);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 27);
            this.button2.TabIndex = 28;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Brown;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(593, 436);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 27);
            this.button3.TabIndex = 27;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // txtSDTKhachHang
            // 
            this.txtSDTKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDTKhachHang.Location = new System.Drawing.Point(230, 433);
            this.txtSDTKhachHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSDTKhachHang.Name = "txtSDTKhachHang";
            this.txtSDTKhachHang.Size = new System.Drawing.Size(195, 26);
            this.txtSDTKhachHang.TabIndex = 6;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhachHang.Location = new System.Drawing.Point(230, 384);
            this.txtTenKhachHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(195, 26);
            this.txtTenKhachHang.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 436);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "SDT Khách Hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 388);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tên Khách Hàng";
            // 
            // lblNgayLapHoaDOn
            // 
            this.lblNgayLapHoaDOn.AutoSize = true;
            this.lblNgayLapHoaDOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayLapHoaDOn.Location = new System.Drawing.Point(30, 347);
            this.lblNgayLapHoaDOn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgayLapHoaDOn.Name = "lblNgayLapHoaDOn";
            this.lblNgayLapHoaDOn.Size = new System.Drawing.Size(160, 20);
            this.lblNgayLapHoaDOn.TabIndex = 2;
            this.lblNgayLapHoaDOn.Text = "Ngày Lập Hóa Đơn";
            // 
            // DTPNgayLapHoaDon
            // 
            this.DTPNgayLapHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPNgayLapHoaDon.Location = new System.Drawing.Point(230, 343);
            this.DTPNgayLapHoaDon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DTPNgayLapHoaDon.Name = "DTPNgayLapHoaDon";
            this.DTPNgayLapHoaDon.Size = new System.Drawing.Size(195, 26);
            this.DTPNgayLapHoaDon.TabIndex = 1;
            // 
            // dtgvHoaDon
            // 
            this.dtgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHoaDon.Location = new System.Drawing.Point(4, 3);
            this.dtgvHoaDon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgvHoaDon.Name = "dtgvHoaDon";
            this.dtgvHoaDon.RowHeadersWidth = 51;
            this.dtgvHoaDon.RowTemplate.Height = 24;
            this.dtgvHoaDon.Size = new System.Drawing.Size(915, 318);
            this.dtgvHoaDon.TabIndex = 0;
            // 
            // tpPhieuNhap
            // 
            this.tpPhieuNhap.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.tpPhieuNhap.Controls.Add(this.refreshNCC_btn);
            this.tpPhieuNhap.Controls.Add(this.panel2);
            this.tpPhieuNhap.Controls.Add(this.dataGridView1);
            this.tpPhieuNhap.Location = new System.Drawing.Point(4, 22);
            this.tpPhieuNhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpPhieuNhap.Name = "tpPhieuNhap";
            this.tpPhieuNhap.Size = new System.Drawing.Size(922, 488);
            this.tpPhieuNhap.TabIndex = 3;
            this.tpPhieuNhap.Text = "Phiếu Nhập";
            // 
            // refreshNCC_btn
            // 
            this.refreshNCC_btn.BackColor = System.Drawing.Color.Lime;
            this.refreshNCC_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshNCC_btn.Location = new System.Drawing.Point(815, 21);
            this.refreshNCC_btn.Name = "refreshNCC_btn";
            this.refreshNCC_btn.Size = new System.Drawing.Size(100, 43);
            this.refreshNCC_btn.TabIndex = 33;
            this.refreshNCC_btn.Text = "Làm mới";
            this.refreshNCC_btn.UseVisualStyleBackColor = false;
            this.refreshNCC_btn.Click += new System.EventHandler(this.refreshNCC_btn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.addNCC_btn);
            this.panel2.Controls.Add(this.fixNCC_btn);
            this.panel2.Controls.Add(this.deleteNCC_btn);
            this.panel2.Controls.Add(this.txtTenNhaCungCap);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.DTPNgayLapPhieuNhap);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(5, 314);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(914, 171);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // addNCC_btn
            // 
            this.addNCC_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addNCC_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNCC_btn.Location = new System.Drawing.Point(452, 76);
            this.addNCC_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addNCC_btn.Name = "addNCC_btn";
            this.addNCC_btn.Size = new System.Drawing.Size(125, 43);
            this.addNCC_btn.TabIndex = 32;
            this.addNCC_btn.Text = "Thêm ";
            this.addNCC_btn.UseVisualStyleBackColor = false;
            this.addNCC_btn.Click += new System.EventHandler(this.addNCC_btn_Click);
            // 
            // fixNCC_btn
            // 
            this.fixNCC_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.fixNCC_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fixNCC_btn.Location = new System.Drawing.Point(581, 76);
            this.fixNCC_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fixNCC_btn.Name = "fixNCC_btn";
            this.fixNCC_btn.Size = new System.Drawing.Size(120, 43);
            this.fixNCC_btn.TabIndex = 31;
            this.fixNCC_btn.Text = "Sửa";
            this.fixNCC_btn.UseVisualStyleBackColor = false;
            this.fixNCC_btn.Click += new System.EventHandler(this.fixNCC_btn_Click);
            // 
            // deleteNCC_btn
            // 
            this.deleteNCC_btn.BackColor = System.Drawing.Color.Brown;
            this.deleteNCC_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteNCC_btn.Location = new System.Drawing.Point(705, 76);
            this.deleteNCC_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteNCC_btn.Name = "deleteNCC_btn";
            this.deleteNCC_btn.Size = new System.Drawing.Size(115, 43);
            this.deleteNCC_btn.TabIndex = 30;
            this.deleteNCC_btn.Text = "Xóa";
            this.deleteNCC_btn.UseVisualStyleBackColor = false;
            this.deleteNCC_btn.Click += new System.EventHandler(this.deleteNCC_btn_Click);
            // 
            // txtTenNhaCungCap
            // 
            this.txtTenNhaCungCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNhaCungCap.Location = new System.Drawing.Point(452, 31);
            this.txtTenNhaCungCap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenNhaCungCap.Name = "txtTenNhaCungCap";
            this.txtTenNhaCungCap.Size = new System.Drawing.Size(325, 26);
            this.txtTenNhaCungCap.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(447, 2);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(176, 25);
            this.label10.TabIndex = 2;
            this.label10.Text = "Tên Nhà Cung Cấp";
            // 
            // DTPNgayLapPhieuNhap
            // 
            this.DTPNgayLapPhieuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPNgayLapPhieuNhap.Location = new System.Drawing.Point(7, 29);
            this.DTPNgayLapPhieuNhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DTPNgayLapPhieuNhap.Name = "DTPNgayLapPhieuNhap";
            this.DTPNgayLapPhieuNhap.Size = new System.Drawing.Size(260, 26);
            this.DTPNgayLapPhieuNhap.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(2, 0);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(204, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ngày Lập Phiếu Nhập";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(796, 307);
            this.dataGridView1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // refreshBook_btn
            // 
            this.refreshBook_btn.Location = new System.Drawing.Point(90, 55);
            this.refreshBook_btn.Name = "refreshBook_btn";
            this.refreshBook_btn.Size = new System.Drawing.Size(75, 23);
            this.refreshBook_btn.TabIndex = 15;
            this.refreshBook_btn.Text = "Làm mới";
            this.refreshBook_btn.UseVisualStyleBackColor = true;
            this.refreshBook_btn.Click += new System.EventHandler(this.refreshBook_btn_Click);
            // 
            // FrmQuanLyBanSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 522);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmQuanLyBanSach";
            this.Text = "Quản Lý Bán Sách";
            this.tabControl1.ResumeLayout(false);
            this.tpSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numbGiaBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbSoLuong)).EndInit();
            this.tpLoaiSach.ResumeLayout(false);
            this.tpLoaiSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiSach)).EndInit();
            this.tpHoaDon.ResumeLayout(false);
            this.tpHoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHoaDon)).EndInit();
            this.tpPhieuNhap.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpSach;
        private System.Windows.Forms.TabPage tpLoaiSach;
        private System.Windows.Forms.TabPage tpHoaDon;
        private System.Windows.Forms.TabPage tpPhieuNhap;
        private System.Windows.Forms.Button btnSachXoa;
        private System.Windows.Forms.Button btnSachSua;
        private System.Windows.Forms.Button btnSachThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxLoaiSach;
        private System.Windows.Forms.NumericUpDown numbSoLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numbGiaBan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.TextBox txtTenLoaiSach;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvLoaiSach;
        private System.Windows.Forms.Button btnThemLoaiSach;
        private System.Windows.Forms.Button btnSuaLoaiSach;
        private System.Windows.Forms.Button btnXoaLoaiSach;
        private System.Windows.Forms.DataGridView dtgvHoaDon;
        private System.Windows.Forms.TextBox txtSDTKhachHang;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNgayLapHoaDOn;
        private System.Windows.Forms.DateTimePicker DTPNgayLapHoaDon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtTenNhaCungCap;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker DTPNgayLapPhieuNhap;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Button addNCC_btn;
        private System.Windows.Forms.Button fixNCC_btn;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Button refreshNCC_btn;
        internal System.Windows.Forms.Button deleteNCC_btn;
        private System.Windows.Forms.Button refreshBook_btn;
    }
}

