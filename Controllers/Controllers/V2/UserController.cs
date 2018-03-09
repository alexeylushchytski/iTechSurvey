using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using iTechArt.Survey.BLL.Interfaces;
using Microsoft.Web.Http;
using NLog;

namespace iTechArt.Survey.WebApi.Controllers.V2
{
    [ApiVersion("2")]
    [RoutePrefix("api/v{version:ApiVersion}/User")]
    public class UserController : ApiController
    {
        private readonly IUserService _userService;
        private readonly ILoggerBase _logger;

        public UserController(IUserService userService, ILoggerBase logger)
        {
            _userService = userService;
            _logger = logger;
        }


        [HttpGet]
        [Route("Users")]
        public async Task<HttpResponseMessage> Users()
        {
            try
            {
                _logger.Log(LogLevel.Info, Request);
                var response = Request.CreateResponse(HttpStatusCode.OK, await _userService.GetUsers());
                if (response != null)
                {
                    _logger.Log(LogLevel.Info, response);
                    return response;
                }
                throw new HttpResponseException(HttpStatusCode.NoContent);
            }
            catch (HttpResponseException exception)
            {
                _logger.Log(LogLevel.Error, exception);
                return Request.CreateErrorResponse(HttpStatusCode.NoContent, exception);
            }
        }
    }
}