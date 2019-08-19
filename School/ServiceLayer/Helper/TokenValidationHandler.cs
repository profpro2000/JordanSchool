using Microsoft.IdentityModel.Tokens;
using Model.Users;
using School.MiddlewareAndServices.Services;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace School.ServiceLayer.Helper
{
    public class TokenValidationHandler : ISecurityTokenValidator
    {

        private readonly ApiService _apiService;
        private readonly HttpClient _client;

        public bool CanValidateToken { get => throw new NotImplementedException(); }
        public int MaximumTokenSizeInBytes { get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public TokenValidationHandler(ApiService apiService)
        {
            _apiService = apiService;
            _client = new HttpClient
            {
                BaseAddress = new Uri(_apiService.IdentityServiceUrl)
            };
        }

        public bool CanReadToken(string securityToken) => true;

        public ClaimsPrincipal ValidateToken(string securityToken, TokenValidationParameters validationParameters, out SecurityToken validatedToken)
        {
            validatedToken = null;

            //your logic here
            StringContent content = new StringContent($"{{\"securityToken\":\"{securityToken}\"}}", Encoding.UTF8, "application/json");

            HttpResponseMessage response = _client.PostAsync("/api/Auth/IsAuthenticated", content).GetAwaiter().GetResult();

            if (response == null || !response.IsSuccessStatusCode)
                throw new SecurityTokenException("invalid");

            validationParameters.ValidateTokenReplay = true;

            string tokenJson = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            IList<MediaTypeFormatter> formatters = new List<MediaTypeFormatter>
            {
                new JsonMediaTypeFormatter(),
                new XmlMediaTypeFormatter()
            };

            UsersVw user = response.Content.ReadAsAsync<UsersVw>(formatters).GetAwaiter().GetResult();

            //create your identity by generating its claims
            List<Claim> claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, ""),
                new Claim(JwtRegisteredClaimNames.GivenName, user.Username),
                new Claim("email", user.Email ?? ""),
                new Claim("employeeId", user.EmployeeId.ToString()),
               // new Claim("needResetPassword", user.NeedResetPassword.ToString()),
            };

            return new ClaimsPrincipal(new ClaimsIdentity(new GenericIdentity(user.Username, "Token"), claims));
        }

        public bool LifetimeValidator(DateTime? notBefore, DateTime? expires, SecurityToken securityToken, TokenValidationParameters validationParameters)
        {
            if (expires != null)
                if (DateTime.Now < expires)
                    return true;

            return false;
        }

        private static long ToUnixEpochDate(DateTime date) => (long)Math.Round(
            (date.ToUniversalTime() - new DateTimeOffset(1970, 1, 1, 0, 0, 0, TimeSpan.Zero)).TotalSeconds);
    }
}
