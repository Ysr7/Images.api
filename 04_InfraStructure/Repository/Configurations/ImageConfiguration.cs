using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configurations
{

    public class ImageConfiguration : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasKey(item => item.Id);

            builder.Property (item => item.Title).HasMaxLength(155);

            builder.Property (item => item.Descripion).HasMaxLength(155).IsRequired();
           
            builder.ToTable("Images");
        }
    }
}