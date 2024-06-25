using LoginCleanArchitectureApp_NET.Core.Entities;
using LoginCleanArchitectureApp_NET.Core.Interfaces;
using LoginCleanArchitectureApp_NET.Infrastructure.Data;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace LoginCleanArchitectureApp_NET.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }


        public async Task<User> AuthenticateAsync(string username, string password)
        {
            var user = await _context.Users.FindAsync(username, password);
            return await Task.FromResult(user);
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task AddAsync(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(User user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var user = await _context.Users.FindAsync(id);
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }

    }
}
