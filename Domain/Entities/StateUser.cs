#nullable disable
namespace Domain.Entities;

public class StateUser
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public virtual ICollection<User> Users { get; set; }
}
