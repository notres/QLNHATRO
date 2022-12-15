using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace A_DAL.Models
{
    public class QLNhaTroDbContext : DbContext
    {
        public QLNhaTroDbContext()
        {
        }
        public QLNhaTroDbContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<ChuTro> ChuTros { get; set; }
        public virtual DbSet<HopDong> HopDongs { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<PhongTro> PhongTros { get; set; }
        public virtual DbSet<DichVu> DichVus { get; set; }
        public virtual DbSet<CTHopDong> CTHopDongs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder.
                UseSqlServer(@"Data Source=TUNG;Initial Catalog=QLNhatTro;Integrated Security=True"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
