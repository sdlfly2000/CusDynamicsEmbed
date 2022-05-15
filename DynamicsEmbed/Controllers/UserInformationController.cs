using Domain.Services.UserInformation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace DynamicsEmbed.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class UserInformationController : ControllerBase
    {
        private readonly IUserInformationGateway _userInformationGateway;

        public UserInformationController(
            ILogger<UserInformationController> logger,
            IUserInformationGateway userInformationGateway)
        {
            _userInformationGateway = userInformationGateway;
        }

        [HttpGet("{Id}")]
        public IActionResult GetById(string Id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            return new JsonResult(_userInformationGateway.LoadById(Guid.Parse(Id)));
        }
    }
}
