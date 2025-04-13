using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TaskManagemnetAPI.Data
{
    public class TaskDbContext(DbContextOptions<TaskDbContext> options) : DbContext(options)
    {
        public DbSet<Task> Tasks { get; set; }
    }
}
