using WorkoutCounter.Models;

namespace WorkoutCounter.Handler
{
    public interface IHandler
    {
        public Task<Counter> GetCounter(int id);
        public Task<List<Counter>> GetCounters();
    }
}
