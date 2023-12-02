namespace Infrastructure.Persistance.Services;

public class UserService : Repository<User>, IUserService
{
    private readonly IApplicatonDbcontext _db;

    public UserService(IApplicatonDbcontext db) : base(db)
    {
        _db = db;
    }
}
