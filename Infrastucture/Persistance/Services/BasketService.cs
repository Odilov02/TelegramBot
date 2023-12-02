

namespace Infrastructure.Persistance.Services;

public class BasketService : Repository<Basket>, IBasketService
{
    private readonly IApplicatonDbcontext _db;

    public BasketService(IApplicatonDbcontext db) : base(db)
    {
        _db = db;
    }
}
