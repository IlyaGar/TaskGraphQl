using GraphQLAPI.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace GraphQLAPI.HotChocolate.Mutations
{
    [ExtendObjectType("Mutation")]
    public class AuthMutation()
    {
        public async Task<string> Login(IConfiguration _configuration, TaskDbContext _dbContext, string email)
        {
            var user = await _dbContext.Users.Include(x => x.Role).FirstOrDefaultAsync(u => u.Email == email);
            if (user == null)
            {
                throw new GraphQLException("User not found");
            }

            var claims = new[]
            {
                new Claim(ClaimTypes.Name, user.Email),
                new Claim(ClaimTypes.Role, user.Role.Title)
            };

            var keyString = _configuration["Jwt:Key"]
                ?? throw new InvalidOperationException("JWT Key is not configured in appsettings.json.");

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(keyString));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddHours(1),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
