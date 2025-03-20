using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Core.DTO.Request;
using WebAPI.Core.DTO.Responses;

namespace WebAPI.Core.Interfaces.Services
{
    public interface IAuthService
    {
        Task<BaseResponse<TokenResponseDTO>> Accesstoken(TokenRequestDTO requestDto);
        public string HashPassword(string password);
        public bool VerifyPassword(string password, string hashedPassword);
    }
}
