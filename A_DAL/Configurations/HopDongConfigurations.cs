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
    public class HopDongConfigurations : IEntityTypeConfiguration<HopDong>
    {
        public void Configure(EntityTypeBuilder<HopDong> builder)
        {
            builder.ToTable("HopDong");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ChuTroId).IsRequired();
            builder.Property(x => x.MaHopDong).HasColumnName("MaHopDong").HasColumnType("nvarchar(10)").IsRequired();
            builder.Property(x => x.NgayTao).HasColumnName("NgayTao").HasColumnType("Datetime").IsRequired();
            builder.Property(x => x.NgayThanhToan).HasColumnName("NgayThanhToan").HasColumnType("Datetime").IsRequired();
            builder.Property(x => x.TongTien).HasColumnName("TongTien").HasColumnType("float").IsRequired();
            builder.Property(x => x.TrangThai).HasColumnName("TrangThai").HasColumnType("int").IsRequired();
            builder.HasOne(x => x.ChuTro).WithMany().HasForeignKey(x => x.ChuTroId);
        }
    }
}
