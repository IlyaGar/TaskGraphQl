using GraphQLAPI.Data.Models;
using GraphQLAPI.Data.Context;
using Microsoft.EntityFrameworkCore;
using GreenDonut.Data;

namespace GraphQLAPI.HotChocolate.Queries
{
    [ExtendObjectType("Query")]
    public class TaskQuery
    {
        [UsePaging(IncludeTotalCount = true)]
        [UseFiltering]
        [UseSorting]
        public IQueryable<TaskItem> GetTasks(TaskDbContext _context)
        {
            return _context.Tasks.Include(t => t.CreatedBy).Include(x => x.Status);
        }

        public async Task<TaskItem?> GetTaskById(TaskDbContext _context, int id)
        {
            return await _context.Tasks.Include(x => x.CreatedBy).Include(x => x.Status).FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
