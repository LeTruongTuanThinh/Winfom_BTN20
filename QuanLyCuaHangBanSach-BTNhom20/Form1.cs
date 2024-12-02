using System;
using System.Data;
using System.Data.SqlClient;  // Sử dụng SQL Server
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyCuaHangBanSach
{
    public partial class FrmQuanLyBanSach : Form
    {
        // Chuỗi kết nối đến SQL Server
        private string connectionString = @"Server=IT03\SQLEXPRESS;Database=QuanLyCuaHangBanSach;Trusted_Connection=True;";

        public FrmQuanLyBanSach()
        {
            InitializeComponent();
        }

        // Khi form được load
        private void FrmQuanLyBanSach_Load(object sender, EventArgs e)
        {
            LoadDataLoaiSach(); // Hiển thị danh sách loại sách
            //LoadNhaCungCap();   // Hiển thị danh sách nhà cung cấp (cần thêm hàm nếu chưa có)
        }

        // Kiểm tra kết nối cơ sở dữ liệu
        private bool CheckDatabaseConnection()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    return true; // Kết nối thành công
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu. Lỗi: " + ex.Message, "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Lỗi kết nối
            }
        }

        private void LoadLoaiSach()
        {
            try
            {
                // Kết nối đến cơ sở dữ liệu
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT MaLoaiSach, TenLoaiSach FROM LoaiSach"; // Lấy mã và tên loại sách
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    // Đổ dữ liệu vào ComboBox
                    cbxLoaiSach.DataSource = table;
                    cbxLoaiSach.DisplayMember = "TenLoaiSach"; // Hiển thị tên loại sách trong ComboBox
                    cbxLoaiSach.ValueMember = "MaLoaiSach"; // Lưu giá trị MaLoaiSach khi người dùng chọn
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách loại sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Tải dữ liệu loại sách từ cơ sở dữ liệu
        private void LoadDataLoaiSach()
        {
            try
            {
                if (CheckDatabaseConnection())
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "SELECT * FROM LoaiSach";
                        SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        dgvLoaiSach.DataSource = table;

                        // Tùy chỉnh DataGridView
                        dgvLoaiSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgvLoaiSach.Columns["MaLoaiSach"].HeaderText = "Mã Loại Sách";
                        dgvLoaiSach.Columns["TenLoaiSach"].HeaderText = "Tên Loại Sách";
                        dgvLoaiSach.Columns["MaLoaiSach"].Width = 100;

                        dgvLoaiSach.DefaultCellStyle.BackColor = Color.LightBlue;
                        dgvLoaiSach.DefaultCellStyle.ForeColor = Color.Black;
                        dgvLoaiSach.RowTemplate.Height = 35;
                        dgvLoaiSach.DefaultCellStyle.Font = new Font("Arial", 12);
                        dgvLoaiSach.AutoGenerateColumns = true;
                        dgvLoaiSach.AllowUserToOrderColumns = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu loại sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Thêm loại sách mới
        private void btnThemLoaiSach_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTenLoaiSach.Text))
                {
                    MessageBox.Show("Tên loại sách không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (CheckDatabaseConnection())
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "INSERT INTO LoaiSach (TenLoaiSach) VALUES (@TenLoaiSach)";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@TenLoaiSach", txtTenLoaiSach.Text.Trim());
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Thêm loại sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataLoaiSach();  // Cập nhật dữ liệu sau khi thêm
                        txtTenLoaiSach.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm loại sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Xóa loại sách
        private void btnXoaLoaiSach_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvLoaiSach.SelectedRows.Count > 0)
                {
                    int maLoaiSach = Convert.ToInt32(dgvLoaiSach.SelectedRows[0].Cells["MaLoaiSach"].Value);

                    if (CheckDatabaseConnection())
                    {
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            conn.Open();
                            string query = "DELETE FROM LoaiSach WHERE MaLoaiSach = @MaLoaiSach";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@MaLoaiSach", maLoaiSach);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Xóa loại sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDataLoaiSach();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa loại sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sửa loại sách
        private void btnSuaLoaiSach_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvLoaiSach.SelectedRows.Count > 0)
                {
                    int maLoaiSach = Convert.ToInt32(dgvLoaiSach.SelectedRows[0].Cells["MaLoaiSach"].Value);

                    if (string.IsNullOrWhiteSpace(txtTenLoaiSach.Text))
                    {
                        MessageBox.Show("Tên loại sách không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (CheckDatabaseConnection())
                    {
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            conn.Open();
                            string query = "UPDATE LoaiSach SET TenLoaiSach = @TenLoaiSach WHERE MaLoaiSach = @MaLoaiSach";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@TenLoaiSach", txtTenLoaiSach.Text.Trim());
                            cmd.Parameters.AddWithValue("@MaLoaiSach", maLoaiSach);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Sửa loại sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDataLoaiSach();
                            txtTenLoaiSach.Clear();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn dòng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa loại sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Làm mới danh sách loại sách
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckDatabaseConnection())
                {
                    LoadDataLoaiSach();
                    MessageBox.Show("Danh sách đã được làm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu!", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi làm mới danh sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // Bạn có thể thêm logic vẽ hoặc để trống nếu không cần thiết
        }


        // Tải dữ liệu Nhà Cung Cấp từ cơ sở dữ liệu
        private void LoadNhaCungCap()
        {
            try
            {
                if (CheckDatabaseConnection())
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "SELECT * FROM NhaCungCap";
                        SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        dataGridView1.DataSource = table;

                        // Cấu hình DataGridView
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridView1.Columns["MaNCC"].HeaderText = "Mã NCC";
                        dataGridView1.Columns["TenNCC"].HeaderText = "Tên Nhà Cung Cấp";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu nhà cung cấp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Thêm nhà cung cấp
      
        // Sửa nhà cung cấp
      

       
        

        // Làm mới danh sách Nhà Cung Cấp
        private void btnLamMoiNCC_Click(object sender, EventArgs e)
        {
            LoadNhaCungCap();
            MessageBox.Show("Danh sách đã được làm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }




        private void refreshNCC_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckDatabaseConnection())
                {
                    LoadNhaCungCap();
                    MessageBox.Show("Danh sách đã được làm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu!", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi làm mới danh sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteNCC_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int maNCC = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["MaNCC"].Value);

                    if (CheckDatabaseConnection())
                    {
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            conn.Open();
                            string query = "DELETE FROM NhaCungCap WHERE MaNCC = @MaNCC";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@MaNCC", maNCC);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Xóa nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadNhaCungCap();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (SqlException ex) when (ex.Number == 547)
            {
                MessageBox.Show("Không thể xóa nhà cung cấp này vì dữ liệu liên quan đang được sử dụng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa nhà cung cấp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fixNCC_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int maNCC = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["MaNCC"].Value);

                    if (string.IsNullOrWhiteSpace(txtTenNhaCungCap.Text))
                    {
                        MessageBox.Show("Tên nhà cung cấp không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Lấy giá trị thời gian từ DateTimePicker
                    DateTime ngayTao = DTPNgayLapPhieuNhap.Value;

                    if (CheckDatabaseConnection())
                    {
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            conn.Open();
                            string query = @"
                        UPDATE NhaCungCap 
                        SET TenNCC = @TenNCC, 
                            NgayTao = @NgayTao 
                        WHERE MaNCC = @MaNCC";

                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@TenNCC", txtTenNhaCungCap.Text.Trim());
                            cmd.Parameters.AddWithValue("@NgayTao", ngayTao); // Thêm thời gian vào truy vấn
                            cmd.Parameters.AddWithValue("@MaNCC", maNCC);

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Sửa nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadNhaCungCap();
                            txtTenNhaCungCap.Clear();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn dòng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa nhà cung cấp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void addNCC_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTenNhaCungCap.Text))
                {
                    MessageBox.Show("Tên nhà cung cấp không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (CheckDatabaseConnection())
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        // Kiểm tra trùng lặp tên nhà cung cấp
                        string checkQuery = "SELECT COUNT(*) FROM NhaCungCap WHERE TenNCC = @TenNCC";
                        SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                        checkCmd.Parameters.AddWithValue("@TenNCC", txtTenNhaCungCap.Text.Trim());
                        int exists = (int)checkCmd.ExecuteScalar();

                        if (exists > 0)
                        {
                            MessageBox.Show("Nhà cung cấp này đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Thêm nhà cung cấp
                        string query = "INSERT INTO NhaCungCap (TenNCC) VALUES (@TenNCC)";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@TenNCC", txtTenNhaCungCap.Text.Trim());
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Thêm nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadNhaCungCap();
                        txtTenNhaCungCap.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm nhà cung cấp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void refreshBook_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckDatabaseConnection())
                {
                    // Đổ dữ liệu loại sách vào ComboBox
                    LoadLoaiSach();

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "SELECT MaSach, TenSach, TacGia, GiaBan, MaLoaiSach, SoLuong FROM Sach";
                        SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        // Đổ dữ liệu vào DataGridView
                        dgvSach.DataSource = table;

                        // Cấu hình DataGridView
                        dgvSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgvSach.Columns["MaSach"].HeaderText = "Mã Sách";
                        dgvSach.Columns["TenSach"].HeaderText = "Tên Sách";
                        dgvSach.Columns["TacGia"].HeaderText = "Tác Giả";
                        dgvSach.Columns["GiaBan"].HeaderText = "Giá Bán";
                        dgvSach.Columns["MaLoaiSach"].HeaderText = "Mã Loại Sách";
                        dgvSach.Columns["SoLuong"].HeaderText = "Số Lượng";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnSachSua_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra các thông tin nhập liệu
                if (string.IsNullOrEmpty(txtTenSach.Text) || string.IsNullOrEmpty(txtTacGia.Text) ||
                    cbxLoaiSach.SelectedIndex == -1 || numbGiaBan.Value <= 0 || numbSoLuong.Value < 0)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin sách.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra xem người dùng đã chọn sách nào để sửa
                if (dgvSach.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn sách cần sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int maSach = Convert.ToInt32(dgvSach.SelectedRows[0].Cells["MaSach"].Value); // Lấy MaSach từ DataGridView

                string query = "UPDATE Sach SET TenSach = @TenSach, TacGia = @TacGia, GiaBan = @GiaBan, MaLoaiSach = @MaLoaiSach, SoLuong = @SoLuong WHERE MaSach = @MaSach";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TenSach", txtTenSach.Text);
                    cmd.Parameters.AddWithValue("@TacGia", txtTacGia.Text);
                    cmd.Parameters.AddWithValue("@GiaBan", numbGiaBan.Value);
                    cmd.Parameters.AddWithValue("@MaLoaiSach", cbxLoaiSach.SelectedValue);
                    cmd.Parameters.AddWithValue("@SoLuong", numbSoLuong.Value);
                    cmd.Parameters.AddWithValue("@MaSach", maSach);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa sách thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Làm mới DataGridView sau khi sửa
                    refreshBook_btn_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnSachThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTenSach.Text) || string.IsNullOrEmpty(txtTacGia.Text) ||
                    cbxLoaiSach.SelectedIndex == -1 || numbGiaBan.Value <= 0 || numbSoLuong.Value < 0)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin sách.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = "INSERT INTO Sach (TenSach, TacGia, GiaBan, MaLoaiSach, SoLuong) VALUES (@TenSach, @TacGia, @GiaBan, @MaLoaiSach, @SoLuong)";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TenSach", txtTenSach.Text);
                    cmd.Parameters.AddWithValue("@TacGia", txtTacGia.Text);
                    cmd.Parameters.AddWithValue("@GiaBan", numbGiaBan.Value);
                    cmd.Parameters.AddWithValue("@MaLoaiSach", cbxLoaiSach.SelectedValue); // SelectedValue sẽ trả về giá trị MaLoaiSach
                    cmd.Parameters.AddWithValue("@SoLuong", numbSoLuong.Value);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm sách thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Làm mới DataGridView sau khi thêm
                    refreshBook_btn_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnSachXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem người dùng đã chọn sách nào để xóa
                if (dgvSach.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn sách cần xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int maSach = Convert.ToInt32(dgvSach.SelectedRows[0].Cells["MaSach"].Value); // Lấy MaSach từ DataGridView

                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa sách này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string query = "DELETE FROM Sach WHERE MaSach = @MaSach";

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@MaSach", maSach);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa sách thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Làm mới DataGridView sau khi xóa
                        refreshBook_btn_Click(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
