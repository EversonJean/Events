using Events.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Events.Api.Controllers
{
    [ApiController]
    [Route("api/event")]
    public class EventController : ControllerBase
    {
        private readonly IEventAppService _service;

        public EventController(IEventAppService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("all")]
        public IActionResult GetAll()
        {
            //TODO: Validation result
            var result = _service.GetAll();
            return Ok(result);
        }
    }
}
