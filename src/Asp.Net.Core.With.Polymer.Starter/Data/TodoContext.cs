using Asp.Net.Core.With.Polymer.Starter.Models;
using Microsoft.EntityFrameworkCore;

namespace Asp.Net.Core.With.Polymer.Starter.Data
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }
        public DbSet<Todo> Todos { get; set; }
    }
}
