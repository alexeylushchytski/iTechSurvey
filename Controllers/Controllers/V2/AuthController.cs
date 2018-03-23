using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using iTechArt.Common.Logger.LoggerContext;
using iTechArt.Survey.BLL.DTO.ViewModels;
using iTechArt.Survey.BLL.Interfaces;
using Microsoft.Web.Http;

namespace iTechArt.Survey.WebApi.Controllers.V2
{
    [ApiVersion("2")]
    [RoutePrefix("api/v{version:ApiVersion}/Auth")]
    [EnableCors("*", "*", "*")]
    public class AuthController : ApiController
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost]
        [Route("Login")]
        [AllowAnonymous]
        public async Task<HttpResponseMessage> Login(LoginUserViewModel user)
        {
            LoggerContext.Current.Log(Request.ToString());
            try
            {
                if (ModelState.IsValid)
                {
                    var response = Request.CreateResponse(HttpStatusCode.OK, await _authService.Login(user));
                    return response;
                }

                return new HttpResponseMessage(HttpStatusCode.Accepted);
            }
            catch (HttpResponseException ex)
            {
                return Request.CreateResponse(HttpStatusCode.Forbidden);
            }
        }

    }
}