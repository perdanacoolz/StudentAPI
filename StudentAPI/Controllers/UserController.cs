using Microsoft.AspNetCore.Mvc;
using StudentAPI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace StudentAPI.Controllers
{
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            this._userRepository = userRepository;
        }

        [HttpPost("user")]
        public async Task<ActionResult<User>> PostUser(User user)
        {
            var apiResult = new ApiResult<Object>();
            try
            {
                var isExist = await _userRepository.UserIsExist(user.Name);
                if (isExist)
                {
                    apiResult.Success = false;
                    apiResult.Message = "The user has already exists!";
                }
                else
                {
                    _userRepository.Create(user);
                    await _userRepository.SaveAsync();
                }
                return Ok(apiResult);
            }
            catch (Exception ex)
            {
                apiResult.Success = false;
                apiResult.Message = ex.Message;
                return StatusCode(500, apiResult);
            }
        }
    }
}
