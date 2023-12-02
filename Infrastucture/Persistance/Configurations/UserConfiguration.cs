namespace Infrastructure.Persistance.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.Property(x => x.Id).IsRequired();

        builder.Property(x => x.PhoneNumber).IsRequired();
        builder.HasIndex(x => x.PhoneNumber).IsUnique();

        builder.Property(x => x.Name).IsRequired().HasMaxLength(500);

        builder.Property(x => x.BasketId).IsRequired();

    }
}
