using GraphQLAPI.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQLAPI.Data.Context
{
    public class TaskDbContext : DbContext
    {
        public DbSet<TaskItem> Tasks { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        public TaskDbContext(DbContextOptions<TaskDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Status>(entity =>
            {
                entity.HasKey(s => s.Id);
                entity.Property(s => s.Id)
                      .ValueGeneratedNever();
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasKey(s => s.Id);
                entity.Property(s => s.Id)
                      .ValueGeneratedNever();
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(u => u.Email)
                      .IsUnique();
            });
        }
    }
}
