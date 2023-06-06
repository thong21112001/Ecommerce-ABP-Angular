using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;

namespace EcommerceABP.Products
{
    public class TagConfiguration : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.ToTable(EcommerceABPConsts.DbTablePrefix + "Tags");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
             .HasMaxLength(50)
             .IsRequired();
            builder.Property(x => x.Name)
               .HasMaxLength(50)
               .IsRequired();

        }
    }
}
