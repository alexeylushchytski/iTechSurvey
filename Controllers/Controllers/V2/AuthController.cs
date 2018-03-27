using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using iTechArt.Common.Logger.LoggerContext;
using iTechArt.Survey.BLL.DTO.ViewModels;
using iTechArt.Survey.BLL.Interfaces;
using Microsoft.Web.Http;
using Newtonsoft.Json;

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


        [AllowAnonymous]
        [HttpPost]
        [Route("Signup")]
        public async Task<HttpResponseMessage> Register(RegisterUserViewModel user)
        {
            LoggerContext.Current.Log(Request.ToString());
            if (ModelState.IsValid && !Request.Headers.Contains("Authorization"))
            {
                if (await _authService.UserExist(user.Email))
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, "Email already exists!");
                }
                await _authService.CreateUserAsync(user);

                return Request.CreateResponse(HttpStatusCode.OK);
            }

            return Request.CreateResponse(HttpStatusCode.BadRequest, JsonConvert.SerializeObject(ModelState));
        }
    }
}