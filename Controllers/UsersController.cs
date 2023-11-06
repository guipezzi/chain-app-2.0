using ChainAppBack.Services;
using Microsoft.AspNetCore.Mvc;

namespace ChainAppBack.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    { 

        private readonly IUsersService _usersService;

        public UsersController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        [HttpGet("Hello")]
        public async Task<string> Get()
        {
            return await _usersService.Get();
        }
    }
}