using Microsoft.AspNetCore.Mvc;
using WorkoutCounter.Handler;
using WorkoutCounter.Models;

namespace WorkoutCounter.Controllers
{
    [ApiController]
    [Route("workout")]
    public class WorkoutCounterController : Controller
    {
        private readonly IHandler _handler;

        public WorkoutCounterController(IHandler handler)
        {
            _handler = handler;
        }

        [HttpGet]
        public async Task<IActionResult> GetCounters()
        {
            var counters = await _handler.GetCounters();
            return Ok(counters);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCounter(int id)
        {
            var counter = await _handler.GetCounter(id);
            return Ok(counter);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCounter([FromBody] Counter counter)
        {
            var newCounter = await _handler.CreateCounter(counter);
            return Ok(newCounter);
        }
    }
}
