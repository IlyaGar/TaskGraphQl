using GraphQLAPI.Data.Context;
using GraphQLAPI.Data.Models;
using HotChocolate.Authorization;
using Microsoft.EntityFrameworkCore;

namespace GraphQLAPI.HotChocolate.Queries
{
    [ExtendObjectType("Query")]
    public class UserQuery
    {
        [Authorize(Roles = ["Admin"])]
        [UsePaging]
        [UseFiltering]
        [UseSorting]
        public IQueryable<User> GetUsers(TaskDbContext _context)
        {
            return _context.Users.Include(x => x.Role);
        }
    }
}
