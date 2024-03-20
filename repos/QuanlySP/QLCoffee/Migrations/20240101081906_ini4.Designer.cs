﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QLCoffee.Model;

#nullable disable

namespace QLCoffee.Migrations
{
    [DbContext(typeof(CoffeDB))]
    [Migration("20240101081906_ini4")]
    partial class ini4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.14");

            modelBuilder.Entity("QLCoffee.Model.ChiTietHD", b =>
                {
                    b.Property<long>("MaChiTietHD")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long?>("DaMua")
                        .HasColumnType("INTEGER");

                    b.Property<long>("MaHD")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MaSanPham")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<long?>("SoLuongMua")
                        .HasColumnType("INTEGER");

                    b.HasKey("MaChiTietHD");

                    b.HasIndex("MaHD");

                    b.HasIndex("MaSanPham");

                    b.ToTable("ChiTietHD");
                });

            modelBuilder.Entity("QLCoffee.Model.Coffe", b =>
                {
                    b.Property<string>("MaSanPham")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<long?>("Gia")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LinkAnh")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("MaLoai")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MoTa")
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<long?>("SoLuong")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TenSanPHam")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("XuatXu")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.HasKey("MaSanPham");

                    b.HasIndex("MaLoai");

                    b.ToTable("Coffe");

                    b.HasData(
                        new
                        {
                            MaSanPham = "CS00001",
                            Gia = 125000L,
                            LinkAnh = "image_product/CS00001.jpg",
                            MaLoai = "COFFE01",
                            MoTa = "Cà phê phin lọc giấy con sóc đen, hộp đôi 20 phin lọc giấy + 20 đường que Khối lượng tịnh: 200gr Cafe + 120gr đường",
                            SoLuong = 100L,
                            TenSanPHam = "CÀ PHÊ CON SÓC ĐEN (HỘP ĐÔI)",
                            XuatXu = "Doanh Nghiệp TNX Trường Sơn"
                        },
                        new
                        {
                            MaSanPham = "CS00002",
                            Gia = 158000L,
                            LinkAnh = "image_product/CS00002.jpg",
                            MaLoai = "COFFE01",
                            MoTa = "CÀ PHÊ CON SÓC NÂU BỘT HỘP 500 gram 99,99% Arabica và Hazelut tổng hợp Khối lượng tịnh: 500gr Dạng thành phẩm: bao nhôm màu đen. Đặc tính: hạt cà phê nhỏ, mịn, màu nâu, mùi thơm nồng, vị nhẹ. Chỉ tiêu chất lượng: Độ ẩm <= 5% Chất tan trong nước >= 25% Cafein >= 1 %",
                            SoLuong = 100L,
                            TenSanPHam = "CÀ PHÊ CON SÓC NÂU BỘT HỘP 500 GR",
                            XuatXu = "TNX CN Trường Sơn"
                        },
                        new
                        {
                            MaSanPham = "CS00003",
                            Gia = 125000L,
                            LinkAnh = "image_product/CS00003.jpg",
                            MaLoai = "COFFE01",
                            MoTa = "Cà Phê Con Sóc Nâu Hộp Đôi có hương vị cân bằng giữa đậm đà và hương thơm thanh,dịu với thành phần: Arabica 49,95% Robusta 49,95% Hương hazelut tổng hợp 0,01% 20 phin lọc giấy + 20 đường que Khối lượng tịnh: 200gr Cafe + 120gr đường Sản phẩm phù hợp để làm quà biếu tặng",
                            SoLuong = 100L,
                            TenSanPHam = "Cà Phê Con Sóc Nâu Hộp Đôi",
                            XuatXu = "Doanh Nghiệp TNX Trường Sơn"
                        });
                });

            modelBuilder.Entity("QLCoffee.Model.Customer", b =>
                {
                    b.Property<string>("MaKH")
                        .HasColumnType("TEXT");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Hovaten")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Pass")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("SDT")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("TenDN")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("MaKH");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("QLCoffee.Model.HoaDon", b =>
                {
                    b.Property<long>("MaHD")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long?>("DaMua")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MaHDS")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MaKH")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("MaNV")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("NgayMua")
                        .HasColumnType("date");

                    b.Property<string>("nhanvienMaNV")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MaHD");

                    b.HasIndex("MaKH");

                    b.HasIndex("nhanvienMaNV");

                    b.ToTable("HoaDon");
                });

            modelBuilder.Entity("QLCoffee.Model.Loai", b =>
                {
                    b.Property<string>("MaLoai")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("TenLoai")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("MaLoai");

                    b.ToTable("Loai");

                    b.HasData(
                        new
                        {
                            MaLoai = "COFFE01",
                            TenLoai = "Cà phê phin giấy"
                        },
                        new
                        {
                            MaLoai = "COFFE02",
                            TenLoai = "Cà phê Rang xay"
                        });
                });

            modelBuilder.Entity("QLCoffee.Model.NhanVien", b =>
                {
                    b.Property<string>("MaNV")
                        .HasColumnType("TEXT");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Hovaten")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Ngaysinh")
                        .HasColumnType("TEXT");

                    b.Property<string>("Pass")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("SDT")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("TenDN")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("MaNV");

                    b.ToTable("NhanVien");
                });

            modelBuilder.Entity("QLCoffee.Model.UserAdmin", b =>
                {
                    b.Property<string>("TenDN")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Pass")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<bool?>("Quyen")
                        .HasColumnType("INTEGER");

                    b.HasKey("TenDN");

                    b.ToTable("UserAdmin");
                });

            modelBuilder.Entity("QLCoffee.Model.ChiTietHD", b =>
                {
                    b.HasOne("QLCoffee.Model.HoaDon", "HoaDon")
                        .WithMany("ChiTietHDs")
                        .HasForeignKey("MaHD")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QLCoffee.Model.Coffe", "Coffe")
                        .WithMany("ChiTietHDs")
                        .HasForeignKey("MaSanPham")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Coffe");

                    b.Navigation("HoaDon");
                });

            modelBuilder.Entity("QLCoffee.Model.Coffe", b =>
                {
                    b.HasOne("QLCoffee.Model.Loai", "Loai")
                        .WithMany("Coffes")
                        .HasForeignKey("MaLoai")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Loai");
                });

            modelBuilder.Entity("QLCoffee.Model.HoaDon", b =>
                {
                    b.HasOne("QLCoffee.Model.Customer", "Customer")
                        .WithMany("HoaDons")
                        .HasForeignKey("MaKH")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QLCoffee.Model.NhanVien", "nhanvien")
                        .WithMany("HoaDons")
                        .HasForeignKey("nhanvienMaNV")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("nhanvien");
                });

            modelBuilder.Entity("QLCoffee.Model.Coffe", b =>
                {
                    b.Navigation("ChiTietHDs");
                });

            modelBuilder.Entity("QLCoffee.Model.Customer", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("QLCoffee.Model.HoaDon", b =>
                {
                    b.Navigation("ChiTietHDs");
                });

            modelBuilder.Entity("QLCoffee.Model.Loai", b =>
                {
                    b.Navigation("Coffes");
                });

            modelBuilder.Entity("QLCoffee.Model.NhanVien", b =>
                {
                    b.Navigation("HoaDons");
                });
#pragma warning restore 612, 618
        }
    }
}
