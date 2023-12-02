using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Application.Common.Interfaces
{
    public interface IApplicatonDbcontext
    {
        EntityEntry Entry(object entity);
        DbSet<T> Set<T>() where T : class;
        DbSet<Basket> Baskets { get; }
        DbSet<Category> Categories { get; }
        DbSet<Food> Foods { get; }
        DbSet<Order> Orders { get; }
        DbSet<User> Users { get; set; }
        Task<int> SaveChangesAsync(CancellationToken token = default);
    }
}
