using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace QuanLyCofffee
{
    public partial class Model1 : DbContext
    {
        public Model1()
           
        {
        }

        public virtual DbSet<ChiTietHD> ChiTietHDs { get; set; }
        public virtual DbSet<Coffe> Coffes { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<Loai> Loais { get; set; }
        public virtual DbSet<LichSuMuaHang> LichSuMuaHangs { get; set; }
        public virtual DbSet<VXacNhan> VXacNhans { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
         
            string connectionString = @"Data Source=LENNOVO\\SQLEXPRESS;Initial Catalog=QLCOFFE;Integrated Security=True";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserAdmin>()
                .Property(e => e.TenDN)
                .IsFixedLength();

            modelBuilder.Entity<UserAdmin>()
                .Property(e => e.Pass)
                .IsFixedLength();
        }
    }
}
