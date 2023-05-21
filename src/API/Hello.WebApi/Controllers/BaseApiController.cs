using Hello.Application.Templates;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Hello.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseApiController : ControllerBase
    {
        private IMediator _mediator = null!;
        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>()!;

        protected ActionResult HandleResult<T>(Result<T>? result)
        {
            if (result == null)
            {
                return NotFound();
            }
            if (result.Success && result.Data != null)
            {
                return Ok(result);
            }
            if (result.Success && result.Data == null)
            {
                return NotFound();
            }
            return BadRequest(result);
        }
    }
}