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
    }
}
