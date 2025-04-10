using RocketAuction.API.Contracts;
using RocketAuction.API.Entities;

namespace RocketAuction.API.Repositories.DataAccess;

public class UserRepository : IUserRepository
{
    private readonly RocketAuctionDbContext _dbContext;

    public UserRepository(RocketAuctionDbContext dbContext) => _dbContext = dbContext;

    public bool ExistsUserWithEmail (string email)
    {
        return _dbContext.Users.Any(user => user.Email.Equals(email));
    }

    public User GetUserByEmail (string email) => _dbContext.Users.First(user => user.Email.Equals(email));
}
