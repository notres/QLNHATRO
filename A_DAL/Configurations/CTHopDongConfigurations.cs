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
    public class CTHopDongConfigurations : IEntityTypeConfiguration<CTHopDong>
    {
        public void Configure(EntityTypeBuilder<CTHopDong> builder)
        {
            builder.ToTable("CTHopDong");
            builder.Property(x => x.HopDongId).IsRequired();
            builder.Property(x => x.PhongTroId).IsRequired();
            builder.Property(x => x.DichVuId).IsRequired();
            builder.HasOne(x => x.HopDong).WithMany().HasForeignKey(x => x.HopDongId);
            builder.HasOne(x => x.PhongTro).WithMany().HasForeignKey(x => x.PhongTroId);
            builder.HasOne(x => x.DichVu).WithMany().HasForeignKey(x => x.DichVuId);
        }
    }
}
