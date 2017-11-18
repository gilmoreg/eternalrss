using System;
using System.IdentityModel.Tokens.Jwt;
using Newtonsoft.Json;

namespace EternalRSSAPI.Utilities
{
    public class JWT
    {
        public JWT()
        {
        }

        public static string CreateToken()
        {
            // var token = new JwtSecurityToken(JwtHeader, JwtPayload)
            return "token!";
        }
    }
}
