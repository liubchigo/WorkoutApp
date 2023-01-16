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
        public async Task<int> AddCounter(Counter counter)
        {
            _context.Counters.Add(counter);
            await _context.SaveChangesAsync();
            return counter.Id;
        }
    }
}
