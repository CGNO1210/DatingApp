using Microsoft.EntityFrameworkCore;
using repos.Datingapp.API.Entities;

namespace repos.Datingapp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<AppUser> Users { get; set; }
    }
}