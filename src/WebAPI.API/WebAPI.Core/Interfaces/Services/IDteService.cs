using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Core.DTO.Responses;
using WebAPI.Core.Entities;

namespace WebAPI.Core.Interfaces.Services
{
    public interface IDteService
    {
        Task<BaseResponse<List<Dte>>> GetAllDtesAsync();
        Task<BaseResponse<Dte>> GetDteByCodigoGeneracionAsync(string codigoGeneracion);
    }

}
