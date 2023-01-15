using Microsoft.AspNetCore.Mvc;
using WorkoutCounter.Handler;

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
        public async Task<IActionResult> Get()
        {
            var counters = await _handler.GetCounters();
            return Ok(counters);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var counter = await _handler.GetCounter(id);
            return Ok(counter);
        }


    }
}
