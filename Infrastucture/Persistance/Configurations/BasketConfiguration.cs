namespace Infrastructure.Persistance.Configurations;

public class BasketConfiguration : IEntityTypeConfiguration<Basket>
{
    public void Configure(EntityTypeBuilder<Basket> builder)
    {
        builder.Property(x => x.Id).IsRequired();

        builder.Property(x => x.UserId).IsRequired();
    }
}
