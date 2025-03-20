using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Core.Constants;
using WebAPI.Core.DTO.Responses;
using WebAPI.Core.Entities;
using WebAPI.Core.Interfaces.Repositories;
using WebAPI.Core.Interfaces.Services;

namespace WebAPI.Core.Services
{
    public class DteService : IDteService
    {
        private readonly IDteRepository _dteRepository;

        public DteService(IDteRepository dteRepository)
        {
            _dteRepository = dteRepository;
        }

        public async Task<BaseResponse<List<Dte>>> GetAllDtesAsync()
        {
            BaseResponse<List<Dte>> response = new BaseResponse<List<Dte>>();

            try
            {
                var dtes = await _dteRepository.GetAllAsync();

                if(dtes.Count == 0)
                {
                    response.StatusCode = 404;
                    response.Success = false;
                    response.Message = ReplyMessage.MESSAGE_QUERY_EMPTY;
                    response.Data = null;

                    return response;
                }

                response.StatusCode = 200;
                response.Success = true;
                response.Message = ReplyMessage.MESSAGE_QUERY;
                response.Data = dtes;

                return response;
            }
            catch (Exception ex)
            {
                response.StatusCode = 500;
                response.Success = false;
                response.Message = ReplyMessage.MESSAGE_FAILED + ": " + ex.Message;
                response.Data = null;
            }

            return response;
        }

        public async Task<BaseResponse<Dte>> GetDteByCodigoGeneracionAsync(string codigoGeneracion)
        {
            
            BaseResponse<Dte> response = new BaseResponse<Dte>();

            try
            {
                var dte = await _dteRepository.GetByCodigoGeneracionAsync(codigoGeneracion);

                if (dte == null)
                {
                    response.StatusCode = 404;
                    response.Success = false;
                    response.Message = ReplyMessage.MESSAGE_QUERY_EMPTY;
                    response.Data = null;

                    return response;
                }

                response.StatusCode = 200;
                response.Success = true;
                response.Message = ReplyMessage.MESSAGE_QUERY;
                response.Data = dte;

                return response;
            }
            catch (Exception ex)
            {
                response.StatusCode = 500;
                response.Success = false;
                response.Message = ReplyMessage.MESSAGE_FAILED + ": " + ex.Message;
                response.Data = null;
            }

            return response;

        }
    }

}
