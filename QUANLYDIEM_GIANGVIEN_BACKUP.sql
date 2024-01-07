create database QUANLYDIEM_GIANGVIEN;

use QUANLYDIEM_GIANGVIEN;

CREATE TABLE [dbo].[tai_khoan](
	[id] [uniqueidentifier] NOT NULL,
	[tai_khoan] [varchar](20) NOT NULL,
	[mat_khau] [varchar](255) NOT NULL,
	[email] [varchar](50) NULL,
	[ngay_tao] [datetime] NULL,
	[ngay_dang_nhap] [datetime] NULL,
	[trang_thai] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tai_khoan] ADD  DEFAULT (getdate()) FOR [ngay_tao]
GO

ALTER TABLE [dbo].[tai_khoan] ADD  DEFAULT (getdate()) FOR [ngay_dang_nhap]
GO

ALTER TABLE [dbo].[tai_khoan] ADD  CONSTRAINT [DF__tai_khoan__trang__398D8EEE]  DEFAULT ((0)) FOR [trang_thai]
GO


CREATE TABLE [dbo].[quyen](
	[id] [uniqueidentifier] NOT NULL,
	[code] [varchar](100) NULL,
	[ten_quyen] [nvarchar](100) NOT NULL,
	[ngay_tao] [datetime] NULL,
	[trang_thai] [bit] NULL,
 CONSTRAINT [PK__quyen__3213E83FE212DC6E] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[quyen] ADD  CONSTRAINT [DF__quyen__ngay_tao__3C69FB99]  DEFAULT (getdate()) FOR [ngay_tao]
GO

ALTER TABLE [dbo].[quyen] ADD  CONSTRAINT [DF__quyen__trang_tha__3D5E1FD2]  DEFAULT ((1)) FOR [trang_thai]
GO


CREATE TABLE [dbo].[quyen_taikhoan](
	[id_quyen] [uniqueidentifier] NOT NULL,
	[id_taikhoan] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_quyen_taikhoan] PRIMARY KEY CLUSTERED 
(
	[id_quyen] ASC,
	[id_taikhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[quyen_taikhoan]  WITH CHECK ADD  CONSTRAINT [FK__quyen_tai__id_qu__403A8C7D] FOREIGN KEY([id_quyen])
REFERENCES [dbo].[quyen] ([id])
GO

ALTER TABLE [dbo].[quyen_taikhoan] CHECK CONSTRAINT [FK__quyen_tai__id_qu__403A8C7D]
GO

ALTER TABLE [dbo].[quyen_taikhoan]  WITH CHECK ADD FOREIGN KEY([id_taikhoan])
REFERENCES [dbo].[tai_khoan] ([id])
GO


CREATE TABLE [dbo].[khoa_hoc](
	[ma_khoahoc] [varchar](10) NOT NULL,
	[ten_khoahoc] [nvarchar](50) NOT NULL,
	[ngay_tao] [datetime] NULL,
	[nam_batdau] [int] NULL,
	[nam_ketthuc] [int] NULL,
	[trang_thai] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ma_khoahoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[khoa_hoc] ADD  DEFAULT (getdate()) FOR [ngay_tao]
GO

ALTER TABLE [dbo].[khoa_hoc] ADD  DEFAULT ((1)) FOR [trang_thai]
GO


CREATE TABLE [dbo].[nghanh](
	[ma_nghanh] [varchar](10) NOT NULL,
	[ten_nghanh] [nvarchar](100) NOT NULL,
	[ngay_tao] [datetime] NULL,
	[trang_thai] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ma_nghanh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[nghanh] ADD  DEFAULT (getdate()) FOR [ngay_tao]
GO

ALTER TABLE [dbo].[nghanh] ADD  DEFAULT ((1)) FOR [trang_thai]
GO

CREATE TABLE [dbo].[nghanh_khoahoc](
	[id_khoahoc] [varchar](10) NOT NULL,
	[id_nghanh] [varchar](10) NOT NULL,
 CONSTRAINT [PK_nghanh_khoahoc] PRIMARY KEY CLUSTERED 
(
	[id_khoahoc] ASC,
	[id_nghanh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[nghanh_khoahoc]  WITH CHECK ADD FOREIGN KEY([id_khoahoc])
REFERENCES [dbo].[khoa_hoc] ([ma_khoahoc])
GO

ALTER TABLE [dbo].[nghanh_khoahoc]  WITH CHECK ADD FOREIGN KEY([id_nghanh])
REFERENCES [dbo].[nghanh] ([ma_nghanh])
GO

CREATE TABLE [dbo].[hoc_ky](
	[ma_hocky] [varchar](10) NOT NULL,
	[ten_hocky] [nvarchar](50) NOT NULL,
	[ngay_tao] [datetime] NULL,
	[trang_thai] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ma_hocky] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[hoc_ky] ADD  DEFAULT (getdate()) FOR [ngay_tao]
GO

ALTER TABLE [dbo].[hoc_ky] ADD  DEFAULT ((1)) FOR [trang_thai]
GO

CREATE TABLE [dbo].[hocky_khoahoc](
	[id_khoahoc] [varchar](10) NOT NULL,
	[id_hocky] [varchar](10) NOT NULL,
 CONSTRAINT [PK_hocky_khoahoc] PRIMARY KEY CLUSTERED 
(
	[id_khoahoc] ASC,
	[id_hocky] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[hocky_khoahoc]  WITH CHECK ADD FOREIGN KEY([id_hocky])
REFERENCES [dbo].[hoc_ky] ([ma_hocky])
GO

ALTER TABLE [dbo].[hocky_khoahoc]  WITH CHECK ADD FOREIGN KEY([id_khoahoc])
REFERENCES [dbo].[khoa_hoc] ([ma_khoahoc])
GO

CREATE TABLE [dbo].[lop](
	[ma_lop] [varchar](10) NOT NULL,
	[ten_lop] [nvarchar](50) NOT NULL,
	[id_khoahoc] [varchar](10) NULL,
	[id_nghanh] [varchar](10) NULL,
	[ngay_tao] [datetime] NULL,
	[trang_thai] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ma_lop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[lop] ADD  DEFAULT (getdate()) FOR [ngay_tao]
GO

ALTER TABLE [dbo].[lop] ADD  DEFAULT ((1)) FOR [trang_thai]
GO

ALTER TABLE [dbo].[lop]  WITH CHECK ADD FOREIGN KEY([id_khoahoc])
REFERENCES [dbo].[khoa_hoc] ([ma_khoahoc])
GO

ALTER TABLE [dbo].[lop]  WITH CHECK ADD FOREIGN KEY([id_nghanh])
REFERENCES [dbo].[nghanh] ([ma_nghanh])
GO

CREATE TABLE [dbo].[mon_hoc](
	[ma_monhoc] [varchar](10) NOT NULL,
	[ten_monhoc] [nvarchar](100) NOT NULL,
	[id_nghanh] [varchar](10) NULL,
	[ngay_tao] [datetime] NULL,
	[trang_thai] [bit] NULL,
	[ngay_ket_thuc] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ma_monhoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[mon_hoc]  WITH CHECK ADD FOREIGN KEY([id_nghanh])
REFERENCES [dbo].[nghanh] ([ma_nghanh])
GO

CREATE TABLE [dbo].[monhoc_hocky](
	[ma_monhoc] [varchar](10) NOT NULL,
	[id_hocky] [varchar](10) NOT NULL,
 CONSTRAINT [PK_mon_hoc_hocky] PRIMARY KEY CLUSTERED 
(
	[ma_monhoc] ASC,
	[id_hocky] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[monhoc_hocky]  WITH CHECK ADD FOREIGN KEY([id_hocky])
REFERENCES [dbo].[hoc_ky] ([ma_hocky])
GO

ALTER TABLE [dbo].[monhoc_hocky]  WITH CHECK ADD FOREIGN KEY([ma_monhoc])
REFERENCES [dbo].[mon_hoc] ([ma_monhoc])
GO

CREATE TABLE [dbo].[sinh_vien](
	[ma_sv] [varchar](10) NOT NULL,
	[ten_sv] [nvarchar](100) NOT NULL,
	[gioi_tinh] [bit] NOT NULL,
	[ngay_sinh] [datetime] NULL,
	[id_nghanh] [varchar](10) NULL,
	[id_lop] [varchar](10) NULL,
	[ngay_tao] [datetime] NULL,
	[trang_thai] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ma_sv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[sinh_vien] ADD  DEFAULT (getdate()) FOR [ngay_tao]
GO

ALTER TABLE [dbo].[sinh_vien] ADD  DEFAULT ((1)) FOR [trang_thai]
GO

ALTER TABLE [dbo].[sinh_vien]  WITH CHECK ADD FOREIGN KEY([id_lop])
REFERENCES [dbo].[lop] ([ma_lop])
GO

ALTER TABLE [dbo].[sinh_vien]  WITH CHECK ADD FOREIGN KEY([id_nghanh])
REFERENCES [dbo].[nghanh] ([ma_nghanh])
GO

CREATE TABLE [dbo].[diem](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_sv] [varchar](10) NULL,
	[id_monhoc] [varchar](10) NULL,
	[DiemQT1] [decimal](18, 0) NULL,
	[DiemQT2] [decimal](18, 0) NULL,
	[DiemThilan1] [decimal](18, 0) NULL,
	[DiemThilan2] [decimal](18, 0) NULL,
	[ngay_tao] [datetime] NULL,
	[trang_thai] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[diem] ADD  DEFAULT (getdate()) FOR [ngay_tao]
GO

ALTER TABLE [dbo].[diem] ADD  DEFAULT ((1)) FOR [trang_thai]
GO

ALTER TABLE [dbo].[diem]  WITH CHECK ADD FOREIGN KEY([id_monhoc])
REFERENCES [dbo].[mon_hoc] ([ma_monhoc])
GO

ALTER TABLE [dbo].[diem]  WITH CHECK ADD FOREIGN KEY([id_sv])
REFERENCES [dbo].[sinh_vien] ([ma_sv])
GO

CREATE TABLE [dbo].[thoigian_thi](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_taikhoan] [uniqueidentifier] NULL,
	[id_monhoc] [varchar](10) NULL,
	[id_hocky] [varchar](10) NULL,
	[ngay_thi] [datetime] NULL,
	[trang_thai] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[thoigian_thi] ADD  DEFAULT ((1)) FOR [trang_thai]
GO

ALTER TABLE [dbo].[thoigian_thi]  WITH CHECK ADD FOREIGN KEY([id_hocky])
REFERENCES [dbo].[hoc_ky] ([ma_hocky])
GO

ALTER TABLE [dbo].[thoigian_thi]  WITH CHECK ADD FOREIGN KEY([id_monhoc])
REFERENCES [dbo].[mon_hoc] ([ma_monhoc])
GO

ALTER TABLE [dbo].[thoigian_thi]  WITH CHECK ADD FOREIGN KEY([id_taikhoan])
REFERENCES [dbo].[tai_khoan] ([id])
GO

CREATE TABLE [dbo].[thoigian_chamthi](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_taikhoan] [uniqueidentifier] NULL,
	[id_monhoc] [varchar](10) NULL,
	[id_hocky] [varchar](10) NULL,
	[ngay_cham] [datetime] NULL,
	[trang_thai] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[thoigian_chamthi] ADD  DEFAULT ((1)) FOR [trang_thai]
GO

ALTER TABLE [dbo].[thoigian_chamthi]  WITH CHECK ADD FOREIGN KEY([id_hocky])
REFERENCES [dbo].[hoc_ky] ([ma_hocky])
GO

ALTER TABLE [dbo].[thoigian_chamthi]  WITH CHECK ADD FOREIGN KEY([id_monhoc])
REFERENCES [dbo].[mon_hoc] ([ma_monhoc])
GO

ALTER TABLE [dbo].[thoigian_chamthi]  WITH CHECK ADD FOREIGN KEY([id_taikhoan])
REFERENCES [dbo].[tai_khoan] ([id])
GO