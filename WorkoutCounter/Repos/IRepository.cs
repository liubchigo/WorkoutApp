using WorkoutCounter.Models;

namespace WorkoutCounter.Repos
{
    public interface IRepository
    {
        Task<List<Counter>> GetCounters();
        Task<Counter> GetCounter(int id);
        Task<int> AddCounter(Counter counter);
    }
}
