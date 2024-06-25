using LoginCleanArchitectureApp_NET.Core.Entities;
using LoginCleanArchitectureApp_NET.Core.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LoginCleanArchitectureApp_NET.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        public Task AddAsync(User user)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<User> GetByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(User user)
        {
            throw new System.NotImplementedException();
        }
    }
}
