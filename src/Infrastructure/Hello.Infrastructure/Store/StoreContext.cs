using Hello.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Hello.Infrastructure.Store
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {

        }

        public DbSet<UserModel> Users { get; set; } = null!;

        // seed on first migration
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserModel>().HasData(
                new UserModel { Id = 1, Name = "John Doe" },
                new UserModel { Id = 2, Name = "Jane Doe" }
            );
        }
    }
}