using Microsoft.EntityFrameworkCore;
using WorkoutCounter.Models;

namespace WorkOutCounter.DataAccessLayer
{
    public class CounterDbContext : DbContext
    {
        public CounterDbContext(DbContextOptions<CounterDbContext> options)
            : base(options) { }
        public DbSet<Counter> Counters { get; set; }
    }
}