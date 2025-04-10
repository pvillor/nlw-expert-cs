using RocketAuction.API.Entities;

namespace RocketAuction.API.Contracts;

public interface IUserRepository
{
    public bool ExistsUserWithEmail(string email);
    User GetUserByEmail(string email);
}
