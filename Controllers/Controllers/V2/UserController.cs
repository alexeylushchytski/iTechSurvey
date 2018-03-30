using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using iTechArt.Common.Logger.LoggerContext;
using iTechArt.Survey.BLL.DTO.ViewModels;
using iTechArt.Survey.BLL.Interfaces;
using iTechArt.Survey.WebApi.Attributes;
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
        [ClaimsAuthorization(ClaimType = "Role", ClaimValue = "Admin")]
        public async Task<HttpResponseMessage> Users(int page = 1)
        {
            try
            {
                LoggerContext.Current.Log(Request.ToString());
                List<UserViewModel> users = (List<UserViewModel>)await _userService.GetUserViewModels();
                int limit = 2 >= users.Count ? users.Count : 2;
                int offset = (page - 1) * limit;
                var resultUsers = (from user in users select user).AsQueryable().Skip(offset).Take(limit).ToList();
                var responseData = new
                {
                    resultUsers,
                    page,
                    totalPages = (int)Math.Ceiling(users.Count / (double)limit)
                };
                var response = Request.CreateResponse(HttpStatusCode.OK, responseData);
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