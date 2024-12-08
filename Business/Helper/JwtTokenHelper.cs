namespace backend.Business.Helper
{
    using System;
    using System.IdentityModel.Tokens.Jwt;
    using System.Security.Claims;
    using System.Text;
    using Microsoft.IdentityModel.Tokens;

    public class JwtTokenHelper
    {
        private const string SECRET_KEY = "YouAreEnteringRedZone2343";
        private const int TOKEN_EXPIRY_MINUTES = 60;

        public static string GenerateToken(string userId, string role)
        {
            // 1. Create security key using the secret
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SECRET_KEY));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            // 2. Define claims (data about the user)
            var claims = new[]
            {
            new Claim(JwtRegisteredClaimNames.Sub, userId),  // Standard claims like Subject (userId here)
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()), // Unique identifier for token
            new Claim(ClaimTypes.Role, role)  // Custom claim for the user's role
        };

            // 3. Define the token
            var token = new JwtSecurityToken(
                issuer: "ShopVault", // Replace with your app's name or domain
                audience: "YourAppName", // Replace with your app's audience
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(TOKEN_EXPIRY_MINUTES),
                signingCredentials: credentials
            );

            // 4. Generate the token string
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }

}
