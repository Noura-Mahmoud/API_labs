using InsDeptAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace InsDeptAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<AppIdentityUser> userManager;
        private readonly IConfiguration configuration;

        public AccountController(UserManager<AppIdentityUser> userManager, IConfiguration configuration)
        {
            this.userManager = userManager;
            this.configuration = configuration;
        }
        //Create new user (Registeration) //post
        [HttpPost("register")]
        public async Task<IActionResult> Registeration(RegisterUserDTO userDto)
        {
            if(ModelState.IsValid)
            {
                //save
                AppIdentityUser user = new AppIdentityUser();
                user.UserName = userDto.UserName;
                user.Email = userDto.Email;
                IdentityResult result = await userManager.CreateAsync(user, userDto.Password);
                if(result.Succeeded)
                {
                    return Ok("Accounr Added");
                }
                return BadRequest(result.Errors);
            }
            return BadRequest(ModelState);
        }
        //Check Account is valid // Login "post
        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginUserDTO userDto)
        { 
            if(ModelState.IsValid)
            {
                AppIdentityUser user = await userManager.FindByNameAsync(userDto.UserName);
                if(user!= null)
                {
                    bool isFound = await userManager.CheckPasswordAsync(user, userDto.Password);
                    if(isFound)
                    {
                        //claims Token
                        var claims = new List<Claim>();
                        claims.Add(new Claim(ClaimTypes.Name, user.UserName));
                        claims.Add(new Claim(ClaimTypes.NameIdentifier, user.Id));
                        claims.Add(new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()));

                        //get role
                        var roles = await userManager.GetRolesAsync(user);
                        foreach(var role in roles) 
                        {
                            claims.Add(new Claim(ClaimTypes.Role, role));
                        }

                        //credentials
                        SecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Secret"]));
                        //it need the used algo and the key
                        SigningCredentials signingCredentials = new SigningCredentials(securityKey ,SecurityAlgorithms.HmacSha256);


                        //create token
                        //design token
                        JwtSecurityToken myToken = new JwtSecurityToken(
                            issuer: configuration["JWT:ValidIssuer"], // link of Web API 
                            audience: configuration["JWT:ValidAudience"], // default path for audience // consumer
                            claims: claims,
                            expires: DateTime.UtcNow.AddDays(1),
                            signingCredentials: signingCredentials
                            );
                        return Ok(new
                        {
                           token = new JwtSecurityTokenHandler().WriteToken(myToken),   
                           expiration = myToken.ValidTo
                        });
                    }
                }
                return Unauthorized(); // couldn't be found
                //check, create token
            }
            return Unauthorized();
        }
    }
}
