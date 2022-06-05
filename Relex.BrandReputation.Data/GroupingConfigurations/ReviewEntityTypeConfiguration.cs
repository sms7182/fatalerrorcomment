namespace Relex.BrandReputation.Data.GroupingConfigurations
{
    public class ReviewEntityTypeConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.ToTable(nameof(Review),"Domain");
            
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).HasMaxLength(120).IsRequired();
            builder.Property(p => p.Content).IsRequired();
            builder.Property(p => p.CreatedDate).IsRequired();
            builder.Property(p => p.StartDate);
            builder.Property(p => p.EndDate);

        }
    }
}
