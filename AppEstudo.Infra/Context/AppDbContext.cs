using AppEstudo.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace AppEstudo.Infra.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) { }

        public AppDbContext() { }

        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Priority> Priority { get; set; }
        public DbSet<Status> Status { get; set; }
    }
}
