using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace devitemapi.Common
{
    public abstract class JWTService
    {
        public static string GetJWTToken(string userName, string securityKey)
        {
            var claims = new Claim[] {
                new Claim(ClaimTypes.Name,userName)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                    audience: AppConfig.Config.Audience,
                    issuer: AppConfig.Config.Issuer,
                    claims: claims,
                    signingCredentials: creds,
                    expires: DateTime.Now.AddMinutes(AppConfig.Config.Expire)
                ) ;
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
