using Microsoft.EntityFrameworkCore;
using TinderRevamped.API.Models;

namespace TinderRevamped.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options){}

        public DbSet<Value> Values { get; set; }

        public DbSet<User> Users { get; set; }
    }
}