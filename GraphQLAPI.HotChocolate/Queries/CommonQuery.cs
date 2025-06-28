using GraphQLAPI.Data.Context;
using GraphQLAPI.Data.Models;

namespace GraphQLAPI.HotChocolate.Queries
{
    [ExtendObjectType("Query")]
    public class CommonQuery
    {
        public IQueryable<Status> GetStatuses(TaskDbContext _context)
        {
            return _context.Statuses;
        }

        public IQueryable<UserRole> GetUserRoles(TaskDbContext _context)
        {
            return _context.UserRoles;
        }
    }
}
