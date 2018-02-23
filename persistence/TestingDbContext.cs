using Microsoft.EntityFrameworkCore;
using testing.Models;

namespace testing.persistence
{
    public class TestingDbContext:DbContext
    {
        public TestingDbContext(DbContextOptions<TestingDbContext> options)
            :base(options)
        {

        }
        public DbSet<Make> Make { get; set; }
        
        public DbSet<Model> Model { get; set; }
    }
}