using LoginCleanArchitectureApp_NET.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml;

namespace LoginCleanArchitectureApp_NET.Core.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllAsync();
        Task<User> GetByIdAsync(int id);
        Task AddAsync(User user);
        Task UpdateAsync(User user);
        Task DeleteAsync(int id);
    }
}
