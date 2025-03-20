using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Core.Entities;
using WebAPI.Core.Interfaces.Repositories;
using WebAPI.Infrastructure.Data;

namespace WebAPI.Infrastructure.Repositories
{
    public class DteRepository : IDteRepository
    {
        private readonly IMongoCollection<Dte> _collection;

        public DteRepository(MongoDbContext database)
        {
            _collection = database.GetCollection<Dte>("DTE");
        }

        public async Task<List<Dte>> GetAllAsync()
        {
            return await _collection.Find(_ => true).ToListAsync();
        }

        public async Task<Dte> GetByCodigoGeneracionAsync(string codigoGeneracion)
        {
            return await _collection.Find(d => d.DteData.Identificacion.CodigoGeneracion == codigoGeneracion).FirstOrDefaultAsync();
        }
    }

}
