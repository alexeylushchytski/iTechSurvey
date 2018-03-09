using iTechArt.Survey.BLL.Interfaces;
using Microsoft.Web.Http;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using NLog;

namespace iTechArt.Survey.WebApi.Controllers.V1
{
    [ApiVersion("1")]
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
        public HttpResponseMessage Users()
        {
            try
            {
                _logger.Log(LogLevel.Info, Request);
                var response = Request.CreateResponse(HttpStatusCode.OK);
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