using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Security.Claims;
using WebAPI.Core.DTO.Request;
using WebAPI.Core.DTO.Responses;
using WebAPI.Core.Constants;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using WebAPI.Core.Interfaces.Repositories;
using WebAPI.Core.Interfaces.Services;


namespace WebAPI.Core.Services
{
    public class AuthService : IAuthService
    {
        private readonly IConfiguration _configuration;
        private readonly IUserRepository _userRepository;
        private readonly ILogger<AuthService> _logger;

        public AuthService(IConfiguration configuration, IUserRepository userRepository, ILogger<AuthService> logger)
        {
            _configuration = configuration;
            _userRepository = userRepository;
            _logger = logger;
        }

        public async Task<BaseResponse<TokenResponseDTO>> Accesstoken(TokenRequestDTO requestDto)
        {
            var response = new BaseResponse<TokenResponseDTO>();

            try
            {
                var user = await _userRepository.GetUserByEmail(requestDto.Email!);
                if (user is null)
                {
                    response.Data = null;
                    response.StatusCode = 500;
                    response.Success = false;
                    response.Message = ReplyMessage.MESSAGE_TOKEN_ERROR;
                    return response;
                }

                if (VerifyPassword(requestDto.Password!, user.Password))
                {
                    var claims = new List<Claim>
                                {
                                    new Claim(JwtRegisteredClaimNames.Name, user.Username!),
                                    new Claim(JwtRegisteredClaimNames.UniqueName, user.Id),
                                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                                    new Claim(JwtRegisteredClaimNames.Iat, Guid.NewGuid().ToString(), ClaimValueTypes.Integer64),
                                    new Claim("idUser", user.Id)
                                };

                    var token = GenerateToken(claims);


                    response.StatusCode = 200;
                    response.Success = true;
                    response.Message = ReplyMessage.MESSAGE_TOKEN;
                    response.Data = new TokenResponseDTO()
                    {
                        AccessToken = new JwtSecurityTokenHandler().WriteToken(token)
                    };
                }
                else
                {
                    response.Data = null;
                    response.StatusCode = 500;
                    response.Success = false;
                    response.Message = ReplyMessage.MESSAGE_TOKEN_ERROR;
                    return response;
                }
            }
            catch (Exception ex)
            {
                response.StatusCode = 500;
                response.Success = false;
                response.Message = ReplyMessage.MESSAGE_TOKEN_ERROR_REFRESH;
                response.Data = null;

                _logger.LogError(ex.ToString());

                return response;
            }

            return response;
        }

        private JwtSecurityToken GenerateToken(List<Claim> authClaims)
        {
            var key = _configuration["Jwt:Key"] ?? Environment.GetEnvironmentVariable("JWT_SECRET", EnvironmentVariableTarget.User);
            
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));

            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);



            var token = new JwtSecurityToken(
                //issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: authClaims,
                expires: DateTime.Now.AddMinutes(int.Parse(_configuration["Jwt:TokenValidityInMinutes"]!)),
                notBefore: DateTime.Now,
                signingCredentials: credentials);

            return token;
        }

        public string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
        public bool VerifyPassword(string password, string hashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        }


    }
}
