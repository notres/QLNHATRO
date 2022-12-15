using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A_DAL.Configurations
{
    public class KhachHangConfigurations : IEntityTypeConfiguration<KhachHang>
    {
        public void Configure(EntityTypeBuilder<KhachHang> builder)
        {
            builder.ToTable("KhachHang");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.HopDongId).IsRequired();
            builder.Property(x => x.Ten).HasColumnName("Ten").HasColumnType("nvarchar(47)").IsRequired();
            builder.Property(x => x.GioiTinh).HasColumnName("GioiTinh").HasColumnType("int").IsRequired();
            builder.Property(x => x.Sdt).HasColumnName("SDT").HasColumnType("nvarchar(15)").IsRequired();
            builder.Property(x => x.Email).HasColumnName("Email").HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x => x.Quequan).HasColumnName("QueQuan").HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x => x.CMND).HasColumnName("CMND").HasColumnType("nvarchar(12)").IsRequired();
            builder.HasOne(x => x.HopDong).WithMany().HasForeignKey(x => x.HopDongId);
        }
    }
}
