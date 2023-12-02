namespace Infrastructure.Persistance.Services;

public class FoodService : Repository<Food>, IFoodService
{
    private readonly IApplicatonDbcontext _db;

    public FoodService(IApplicatonDbcontext db) : base(db)
    {
        _db = db;
    }
}
