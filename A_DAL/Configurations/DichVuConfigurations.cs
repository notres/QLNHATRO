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
    public class DichVuConfigurations : IEntityTypeConfiguration<DichVu>
    {
        public void Configure(EntityTypeBuilder<DichVu> builder)
        {
            builder.ToTable("DichVu");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ChuTroId).IsRequired();
            builder.Property(x => x.Ten).HasColumnName("Ten").HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x => x.DonGia).HasColumnName("DonGia").HasColumnType("float").IsRequired();
            builder.HasOne(x => x.ChuTro).WithMany().HasForeignKey(x => x.ChuTroId);
        }
    }
}
