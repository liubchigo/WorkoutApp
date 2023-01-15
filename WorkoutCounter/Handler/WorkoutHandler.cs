using WorkoutCounter.Models;
using WorkoutCounter.Repos;

namespace WorkoutCounter.Handler
{
    public class WorkoutHandler: IHandler
    {
        private readonly IRepository _repository;

        public WorkoutHandler(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<Counter> GetCounter(int id)
        {
            var counter = await _repository.GetCounter(id);
            return counter;
        }
        public async Task<List<Counter>> GetCounters()
        {
            var counters = await _repository.GetCounters();
            return counters;
        }
    }
}
