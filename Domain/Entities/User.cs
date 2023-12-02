namespace Domain.Entities;
#nullable disable
public class User
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public virtual ICollection<Order> Orders { get; set; }
    public Guid BasketId { get; set; }
    public virtual Basket Basket { get; set; }
}
