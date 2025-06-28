using GraphQLAPI.Data.Context;
using GraphQLAPI.Data.Models;
using GraphQLAPI.HotChocolate.Inputs;
using HotChocolate.Authorization;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace GraphQLAPI.HotChocolate.Mutations
{

    [ExtendObjectType("Mutation")]
    public class TaskMutation
    {
        [Authorize]
        public async Task<TaskItem> CreateTask(CreateTaskInput input, TaskDbContext _context, ClaimsPrincipal userClaims)
        {
            var userEmail = userClaims.Identity?.Name;
            var user = await _context.Users.Include(x => x.Role).FirstOrDefaultAsync(u => u.Email == userEmail);
            if (user == null)
            {
                throw new GraphQLException("User not found");
            }

            Guid createdById;
            if (user.Role.Title == "Admin")
            {
                createdById = input.CreatedById ?? user.Id;
            }
            else
            {
                createdById = user.Id;
                if (input.CreatedById != null && input.CreatedById != user.Id)
                {
                    throw new GraphQLException("You can only create tasks for yourself");
                }
            }

            var task = new TaskItem
            {
                Title = input.Title,
                Description = input.Description,
                StatusId = input.StatusId,
                CreatedById = createdById,
                CreatedAt = DateTime.UtcNow
            };

            _context.Tasks.Add(task);
            await _context.SaveChangesAsync();

            return task;
        }


        [Authorize]
        public async Task<TaskItem> UpdateTask(UpdateTaskInput input, TaskDbContext _context, ClaimsPrincipal userClaims)
        {
            var userEmail = userClaims.Identity?.Name;
            var user = await _context.Users.Include(x => x.Role).FirstOrDefaultAsync(u => u.Email == userEmail);
            if (user == null)
            {
                throw new GraphQLException("User not found");
            }

            var task = await _context.Tasks.FirstOrDefaultAsync(x => x.Id == input.Id);
            if (task == null)
            {
                throw new GraphQLException("Task not found");
            }

            if (user.Role.Title != "Admin" && task.CreatedById != user.Id)
            {
                throw new GraphQLException("You do not have permission to edit this task");
            }

            task.Title = input.Title;
            task.Description = input.Description;
            task.StatusId = input.StatusId;

            if (user.Role.Title == "Admin")
            {
                if (input.CreatedById != null)
                {
                    task.CreatedById = input.CreatedById.Value;
                }
            }
            else
            {
                if (input.CreatedById != null && input.CreatedById != task.CreatedById)
                {
                    throw new GraphQLException("You cannot change the creator of this task");
                }
            }

            await _context.SaveChangesAsync();

            return task;
        }


        [Authorize(Roles = ["Admin"])]
        public async Task<bool> DeleteTask(int id, TaskDbContext _context)
        {
            var task = await _context.Tasks.FirstOrDefaultAsync(x => x.Id == id);
            if (task == null)
            {
                throw new GraphQLException("Task not found");
            }

            _context.Tasks.Remove(task);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
