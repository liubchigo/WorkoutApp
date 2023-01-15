using Microsoft.EntityFrameworkCore;
using WorkoutCounter.Models;
using WorkOutCounter.DataAccessLayer;

namespace WorkoutCounter.Repos
{
    public class Repository: IRepository
    {
        private readonly CounterDbContext _context;

        public Repository(CounterDbContext context)
        {
            _context = context;
        }
        public async Task<List<Counter>> GetCounters()
        {
            return await _context.Counters.ToListAsync();
        }
        public async Task<Counter> GetCounter(int id)
        {
            return await _context.Counters.FindAsync(id);
        }
    }
}
