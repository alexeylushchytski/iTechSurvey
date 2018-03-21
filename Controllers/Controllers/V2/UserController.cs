using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using iTechArt.Common.Logger.LoggerContext;
using iTechArt.Survey.BLL.Interfaces;
using Microsoft.Web.Http;

namespace iTechArt.Survey.WebApi.Controllers.V2
{
    [EnableCors("*", "*", "*")]
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
                LoggerContext.Current.Log(Request.ToString());
                var response = Request.CreateResponse(HttpStatusCode.OK, await _userService.GetUsers());
                if (response != null)
                {
                    LoggerContext.Current.Log(response.ToString());
                    return response;
                }
                throw new HttpResponseException(HttpStatusCode.NoContent);
            }
            catch (HttpResponseException exception)
            {
                LoggerContext.Current.LogError(exception);
                return Request.CreateErrorResponse(HttpStatusCode.NoContent, exception);
            }
        }
    }
}