using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WebApplication1.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly Dek9s8aheu55lvContext _dbContext;
        private readonly IConfiguration _configuration;

        public AuthController(Dek9s8aheu55lvContext dbContext, IConfiguration configuration)
        {
            _dbContext = dbContext;
            _configuration = configuration;
        }

        // POST: api/users/login
        [HttpPost("login")]
        public async Task<ActionResult<LoginResponse>> Login(Models.LoginRequest model)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(u => u.Email == model.Email && u.PasswordDigest == model.Password && u.Active);
            Console.WriteLine(model.Email);
            Console.WriteLine(model.Password);
            Console.WriteLine($"Query: SELECT * FROM Users WHERE Email = '{model.Email}' AND PasswordDigest = '{model.Password}' AND Active = true;");
            Console.WriteLine($"Found user: {user?.Firstname} ({user?.Email})");
            Console.WriteLine(user.Firstname);
            if (user == null)
            {
                return Unauthorized(new { message = "Invalid email or password." });
            }

            // Genera il token JWT
            var token = GenerateJwtToken(user);
            Console.WriteLine(token);
            // Ritorna il token insieme ad altre informazioni utente
            return Ok(new LoginResponse
            {
                Token = token,
                Username = user.Firstname,
                Role = user.Role
            });
        }

        private string GenerateJwtToken(User user)
        {
            var key = Encoding.ASCII.GetBytes(_configuration["JwtSettings:Secret"]);
            var tokenHandler = new JwtSecurityTokenHandler();
            var expires = DateTime.UtcNow.AddMinutes(Convert.ToDouble(_configuration["JwtSettings:ExpirationInMinutes"]));

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                 new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                 new Claim(ClaimTypes.Name, user.Firstname),
                 new Claim(ClaimTypes.Role, user.Role)
                }),
                Expires = expires,
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
