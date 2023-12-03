namespace Infrastructure.Persistance.Configurations
{
    public class StateUserConfiguration : IEntityTypeConfiguration<StateUser>
    {
        public void Configure(EntityTypeBuilder<StateUser> builder)
        {
            builder.Property(x => x.Id).IsRequired();

            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);

        }
    }
}
