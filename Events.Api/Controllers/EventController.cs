using Events.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Events.Api.Controllers
{
    [ApiController]
    [Route("api/events")]
    public class EventController : ControllerBase
    {
        private readonly IEventAppService _service;

        public EventController(IEventAppService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("getall")]
        public IActionResult GetAll()
        {
            //TODO: Validation result
            var result = _service.GetEventList();
            return Ok(result);
        }
    }
}
