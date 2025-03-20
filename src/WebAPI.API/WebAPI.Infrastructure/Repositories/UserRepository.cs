using MongoDB.Driver;
using WebAPI.Core.Entities;
using WebAPI.Core.Interfaces.Repositories;
using WebAPI.Infrastructure.Data;

namespace WebAPI.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IMongoCollection<User> _users;

        public UserRepository(MongoDbContext context)
        {
            _users = context.GetCollection<User>("Users");
        }
        public Task<User> GetUserById(string id)
        {
            return _users.Find(u => u.Id == id).FirstOrDefaultAsync();
        }

        public Task<IEnumerable<User>> GetAllUsers()
        {
            IEnumerable<User> users = _users.Find(u => true).ToList();
            return Task.FromResult(users);
        }

        public async Task<User> GetUserByUsername(string username)
        {
            return await _users.Find(u => u.Username == username).FirstOrDefaultAsync();
        }

        public Task<User> GetUserByEmail(string email)
        {
            User user = _users.Find(u => u.Email == email).FirstOrDefault();

            return Task.FromResult(user);
        }
    }
}
