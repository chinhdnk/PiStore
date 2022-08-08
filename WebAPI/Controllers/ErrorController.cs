using Microsoft.AspNetCore.Mvc;
using WebAPI.Errors;

namespace WebAPI.Controllers
{
    [Route("errors/{code}")]
    [ApiExplorerSettings(IgnoreApi=true)] //don't show Api in swagger, can't call
    public class ErrorController : BaseApiController
    {
        public IActionResult Error(int code)
        {
            return new ObjectResult(new ApiResponse(code));
        }
    }
}
