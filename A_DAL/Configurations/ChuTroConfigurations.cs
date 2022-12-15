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
    public class ChuTroConfigurations : IEntityTypeConfiguration<ChuTro>
    {
        public void Configure(EntityTypeBuilder<ChuTro> builder)
        {
            builder.ToTable("ChuTro");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Username).HasColumnName("Username").HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x => x.Password).HasColumnName("Password").HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x => x.Ten).HasColumnName("Ten").HasColumnType("nvarchar(47)").IsRequired();
            builder.Property(x => x.Sdt).HasColumnName("SDT").HasColumnType("nvarchar(15)").IsRequired();
            builder.Property(x => x.Diachi).HasColumnName("DiaChi").HasColumnType("nvarchar(200)").IsRequired();
            builder.Property(x => x.Email).HasColumnName("Email").HasColumnType("nvarchar(100)").IsRequired();
        }
    }
}
