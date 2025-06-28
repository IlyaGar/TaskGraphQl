using GraphQLAPI.Data.Models;

namespace GraphQLAPI.Data.Authentication
{
    public interface ITokenService
    {
        string GenerateToken(User user);
    }
}
