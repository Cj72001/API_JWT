using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Core.Entities;

namespace WebAPI.Core.Interfaces.Repositories
{
    public interface IDteRepository
    {
        Task<List<Dte>> GetAllAsync();
        Task<Dte> GetByCodigoGeneracionAsync(string codigoGeneracion);
    }
}
