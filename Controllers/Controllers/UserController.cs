using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using iTechArt.Survey.BLL.Interfaces;

namespace iTechArt.Survey.WebApi.Controllers
{
    public class UserController : ApiController
    {
        private readonly IUserService _userService;


        public UserController(IUserService userService)
        {
            _userService = userService;
        }


        [HttpGet]
        public HttpResponseMessage Users()
        {
            try
            {
                var response = Request.CreateResponse(HttpStatusCode.OK, _userService.GetUsers());
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


        public HttpResponseMessage Exception()
        {
            try
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            catch (HttpResponseException exception)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, exception);
            }
        }
    }
}