using Microsoft.EntityFrameworkCore;

namespace Repository.Configurations
{

    public class ImageConfiguration : IEntityTypeConfiguration<Image>
    {

        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasKey(item => item.Id);

            builder.Property (item => item.Descripion).HasMaxLength(155).IsRequired ();
           
            builder.ToTable("Images");
        }
    }
}