
CREATE DATABASE QuanLyCuaHangBanSach;
GO


USE QuanLyCuaHangBanSach;
GO



CREATE TABLE LoaiSach (
    MaLoaiSach INT PRIMARY KEY IDENTITY(1,1), -- Khóa chính và tự động tăng
    TenLoaiSach NVARCHAR(100) NOT NULL -- Tên loại sách, không được để trống
);
GO



CREATE TABLE Sach (
    MaSach INT PRIMARY KEY IDENTITY(1,1), -- Khóa chính và tự động tăng
    TenSach NVARCHAR(200) NOT NULL, -- Tên sách, không được để trống
    TacGia NVARCHAR(100), -- Tác giả (có thể để trống)
    GiaBan DECIMAL(18, 2), -- Giá bán (cho phép số thập phân)
    MaLoaiSach INT NOT NULL, -- Khóa ngoại tham chiếu đến bảng LoaiSach
    FOREIGN KEY (MaLoaiSach) REFERENCES LoaiSach(MaLoaiSach) -- Ràng buộc khóa ngoại
);
GO



INSERT INTO LoaiSach (TenLoaiSach) VALUES
('Văn học'),
('Khoa học'),
('Công nghệ'),
('Tiểu thuyết');

-- Thêm dữ liệu vào bảng Sach
INSERT INTO Sach (TenSach, TacGia, GiaBan, MaLoaiSach) VALUES
('Sách Văn học 1', 'Tác giả A', 100000, 1),
('Sách Văn học 2', 'Tác giả B', 120000, 1),
('Sách Khoa học 1', 'Tác giả C', 150000, 2),
('Sách Công nghệ 1', 'Tác giả D', 200000, 3);
GO


-- xem bảng LoaiSach
SELECT * FROM LoaiSach;

-- xem bảng Sach
SELECT * FROM Sach;


SELECT 
    Sach.MaSach, 
    Sach.TenSach, 
    Sach.TacGia, 
    Sach.GiaBan, 
    LoaiSach.TenLoaiSach
FROM Sach
INNER JOIN LoaiSach ON Sach.MaLoaiSach = LoaiSach.MaLoaiSach;
