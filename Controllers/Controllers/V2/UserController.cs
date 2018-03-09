using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using iTechArt.Survey.BLL.Interfaces;
using Microsoft.Web.Http;

namespace iTechArt.Survey.WebApi.Controllers.V2
{
    [ApiVersion("2")]
    [RoutePrefix("api/v{version:ApiVersion}/User")]
    public class UserController : ApiController
    {
        private readonly IUserService _userService;


        public UserController(IUserService userService)
        {
            _userService = userService;
        }


        [HttpGet]
        [Route("Users")]
        public async Task<HttpResponseMessage> Users()
        {
            try
            {
                var response = Request.CreateResponse(HttpStatusCode.OK, await _userService.GetUsers());
                if (response != null)
                {
                    return response;
                }
                throw new HttpResponseException(HttpStatusCode.NoContent);
            }
            catch (HttpResponseException exception)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NoContent, exception);
            }
        }
    }
}