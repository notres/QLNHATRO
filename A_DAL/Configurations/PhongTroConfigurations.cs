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
    public class PhongTroConfigurations : IEntityTypeConfiguration<PhongTro>
    {
        public void Configure(EntityTypeBuilder<PhongTro> builder)
        {
            builder.ToTable("PhongTro");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ChuTroId).IsRequired();
            builder.Property(x => x.MaPhong).HasColumnName("MaPhong").HasColumnType("nvarchar(10)").IsRequired();
            builder.Property(x => x.SoNguoi).HasColumnName("SoNguoi").HasColumnType("int").IsRequired();
            builder.Property(x => x.DienTich).HasColumnName("DienTich").HasColumnType("float").IsRequired();
            builder.Property(x => x.DiaChi).HasColumnName("DiaChi").HasColumnType("nvarchar(200)").IsRequired();
            builder.Property(x => x.DonGiaPhong).HasColumnName("DonGiaPhong").HasColumnType("float").IsRequired();
            builder.Property(x => x.TrangThai).HasColumnName("TrangThai").HasColumnType("int").IsRequired();
            builder.HasOne(x => x.ChuTro).WithMany().HasForeignKey(x => x.ChuTroId);
        }
    }
}
