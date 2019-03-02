using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BBC.API.RequestProxy;
using BBC.Services.IService;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BBC.API.Controllers
{
    [Route("api/[controller]")]
    public class UserSubscriptionController : Controller
    {
        private IUserService _userService;
        public UserSubscriptionController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [Route("subscribe")]
        public async Task<IActionResult> Subscribe([FromBody] SubscriptionRequestProxy request)
        {
            var response = await _userService.Subscribe();
            return  Ok("Done Success!");
        }
    }
}
