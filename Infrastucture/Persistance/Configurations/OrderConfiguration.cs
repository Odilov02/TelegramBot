namespace Infrastructure.Persistance.Configurations;

public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.Property(x => x.Id).IsRequired();

        builder.Property(x => x.UserId).IsRequired();

        builder.Property(x => x.Description).IsRequired().HasMaxLength(200);

    }
}
