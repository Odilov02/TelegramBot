namespace Domain.Entities;
#nullable disable
public class Order
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime Created { get; set; } = DateTime.Now;
    public bool IsDeliver { get; set; } = false;
    public Guid UserId { get; set; }
    public virtual User User { get; set; }

}
