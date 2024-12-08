using backend.Abstraction.Models;
using backend.Business.Interface;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("user")]
    [ApiController]
    public class UserController: ControllerBase
    {
        private readonly IUserBusiness business;
        public UserController(IUserBusiness business)
        {
            this.business = business;
        }
        [HttpPost("add")]
        public async Task<IActionResult> AddUser([FromBody] User user)
        {
            try
            {
                var result = await this.business.AddUser(user);
                if (result)
                {
                    return this.Ok(new { result= true});
                }
                return this.BadRequest();
            }
            catch (Exception ex) 
            {
                throw;
            }
        }
        [HttpPost("login")]
        public async Task<IActionResult> LoginUser([FromBody] User user)
        {
            try
            {
                var result = await this.business.AddUser(user);
                if (result)
                {
                    return this.Ok(new { result = true });
                }
                return this.BadRequest();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
