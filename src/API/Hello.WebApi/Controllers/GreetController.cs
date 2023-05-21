using Hello.Application.Greet;
using Microsoft.AspNetCore.Mvc;

namespace Hello.WebApi.Controllers
{
    public class GreetController : BaseApiController
    {
        [HttpGet("{userId}")]
        public async Task<IActionResult> Greet(int userId)
        {
            var result = await Mediator.Send(new GreetRequest(new GreetRequestDto(userId)));

            return HandleResult(result);
        }
    }
}