using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    //Este controlador lo usamos para que cuando heredemos de BaseApiController podamos usar la inyección de dependencia de Mediator
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public abstract class BaseApiController : ControllerBase
    {
        private IMediator _mediator;
        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
    }
}
