namespace Infrastructure.Persistance.Configurations;

public class FoodConfiguration : IEntityTypeConfiguration<Food>
{
    public void Configure(EntityTypeBuilder<Food> builder)
    {
        builder.Property(x => x.Id).IsRequired();

        builder.Property(x => x.Name).IsRequired().HasMaxLength(50);

        builder.Property(x => x.ImgUrl).IsRequired();

        builder.Property(x => x.Description).IsRequired().HasMaxLength(500);

        builder.Property(x => x.Salary).IsRequired();

        builder.Property(x => x.CategoryId).IsRequired();
    }
}
