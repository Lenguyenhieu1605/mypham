using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WebMyPham.Data.Entities;

namespace WebMyPham.Data.Configurations
{
    public class ProductDetailConfiguration : IEntityTypeConfiguration<ProductDetail>
    {
        public void Configure(EntityTypeBuilder<ProductDetail> builder)
        {
            builder.ToTable("ProductDetails");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);

            builder.Property(x => x.Details).HasMaxLength(500);

            builder.HasOne(x => x.Product).WithMany(x => x.ProductDetails).HasForeignKey(x => x.ProductId);
        }
    }
}
