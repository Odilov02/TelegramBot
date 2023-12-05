namespace Infrastructure.Persistance.Configurations;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.Property(x => x.Id).IsRequired();

        builder.Property(x => x.Name).IsRequired().HasMaxLength(50);

        builder.Property(x => x.Description).IsRequired().HasMaxLength(500);

        builder.HasData(new Category()
        {
            Id = Guid.NewGuid(),
            Name = "Baliq",
            Description = "faqat Baliqli taomlar"
        },
        new Category()
        {
            Id = Guid.NewGuid(),
            Name = "Donar",
            Description = "faqat Donar taomlar"
        },
        new Category()
        {
            Id = Guid.NewGuid(),
            Name = "Pizza",
            Description = "faqat Pizza taomlar"
        });
    }
}
