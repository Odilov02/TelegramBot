namespace Domain.Entities;
#nullable disable
public class Basket
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public virtual User User { get; set; }
    public virtual ICollection<Food> Foods { get; set; }
}
