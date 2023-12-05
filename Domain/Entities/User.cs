namespace Domain.Entities;
#nullable disable
public class User
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public string ChatId { get; set; }
    public virtual Basket Basket { get; set; }
    public Guid StateUserId { get; set; }
    public virtual StateUser StateUser { get; set; }
}
