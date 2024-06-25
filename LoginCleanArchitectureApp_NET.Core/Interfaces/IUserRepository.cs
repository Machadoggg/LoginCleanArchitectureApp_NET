using LoginCleanArchitectureApp_NET.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LoginCleanArchitectureApp_NET.Core.Interfaces
{
    public interface IUserRepository
    {
        Task<User> Authenticate(string username, string password);
        Task<IEnumerable<User>> GetAllAsync();
        Task<User> GetByIdAsync(int id);
        Task AddAsync(User user);
        Task UpdateAsync(User user);
        Task DeleteAsync(int id);
    }
}
