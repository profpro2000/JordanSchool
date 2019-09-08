using Domain;
using Domain.Model.Users;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using School.ServiceLayer.Helper.Auth;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace School.Controllers.Auth
{


    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private SchoolDbContext _db;
        private readonly IConfiguration _config;

        public AuthController(SchoolDbContext db, IConfiguration config)
        {
            _db = db;
            _config = config;
        }


        // GET: api/Auth
        [HttpGet]
        
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpPost("Login")]
        public IActionResult GetAuth()
        {
            var user = _db.Users.FirstOrDefault();

            var claims = new[]
                   {
                        new Claim(JwtRegisteredClaimNames.Sub, user.Username),
                        new Claim(JwtRegisteredClaimNames.Jti, user.Id.ToString()),
                    };

            var _securityKey = _config["SecurityKey"];
            var _Issuer = _config.GetSection("JwtIssuerOptions:Issuer").Value;
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_securityKey)); //Secret
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);



            var token = new JwtSecurityToken(_Issuer,
  _Issuer,
  claims,
  expires: DateTime.Now.AddMinutes(30),
  signingCredentials: creds);

            return Ok(new
            {
                access_token = new JwtSecurityTokenHandler().WriteToken(token),
                expires_in = DateTime.Now.AddMinutes(30),
                token_type = "bearer"
            });


        }

        [HttpPost("IsAuthenticated")]
        public SysUsers IsAuthenticated([FromBody]SecurityTokenWrapper securityTokenWrapper)
        {
            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();

            JwtSecurityToken decodedToken = handler.ReadToken(securityTokenWrapper.SecurityToken) as JwtSecurityToken;

            int.TryParse(decodedToken.Claims.FirstOrDefault(claim => claim.Type == "employeeId")?.Value, out int employeeId);

            SysUsers user = new SysUsers
            {
                Username = decodedToken.Claims.FirstOrDefault(claim => claim.Type == JwtRegisteredClaimNames.GivenName)?.Value,
                Email = decodedToken.Claims.FirstOrDefault(claim => claim.Type == "email")?.Value,
                EmployeeId = employeeId,
                IsSuperAdmin = bool.Parse(decodedToken.Claims.FirstOrDefault(claim => claim.Type == "isSuperAdmin")?.Value),
             //   NeedResetPassword = bool.Parse(decodedToken.Claims.FirstOrDefault(claim => claim.Type == "needResetPassword")?.Value)
            };

            return user;
        }

        // GET: api/Auth/5
        /*   [HttpGet("{id}", Name = "Get")]
           public string Get(int id)
           {
               return "value";
           }
   */
        // POST: api/Auth
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Auth/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
