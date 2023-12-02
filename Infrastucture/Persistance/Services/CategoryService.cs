namespace Infrastructure.Persistance.Services;

public class CategoryService : Repository<Category>, ICategoryService
{
    private readonly IApplicatonDbcontext _db;

    public CategoryService(IApplicatonDbcontext db) : base(db)
    {
        _db = db;
    }
}
