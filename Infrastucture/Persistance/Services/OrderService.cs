namespace Infrastructure.Persistance.Services;

public class OrderService : Repository<Order>, IOrderService
{
    private readonly IApplicatonDbcontext _db;

    public OrderService(IApplicatonDbcontext db) : base(db)
    {
        _db = db;
    }
}
