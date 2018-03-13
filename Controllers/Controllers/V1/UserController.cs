using iTechArt.Survey.BLL.Interfaces;
using Microsoft.Web.Http;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using iTechArt.Common.Logger.LoggerContext;

namespace iTechArt.Survey.WebApi.Controllers.V1
{
    [ApiVersion("1")]
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
        public HttpResponseMessage Users()
        {
            try
            {
                LoggerContext.Current.Log(Request);
                var response = Request.CreateResponse(HttpStatusCode.OK);
                if (response != null)
                {
                    LoggerContext.Current.Log(response);
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