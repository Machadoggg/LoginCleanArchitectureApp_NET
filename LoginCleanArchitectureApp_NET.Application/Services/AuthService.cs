using LoginCleanArchitectureApp_NET.Core.Entities;
using LoginCleanArchitectureApp_NET.Core.Interfaces;
using System.Threading.Tasks;

namespace LoginCleanArchitectureApp_NET.Application.Services
{
    public class AuthService
    {
        private readonly IUserRepository _userRepository;

        public AuthService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }


        public async Task<User> Authenticate(string username, string password)
        {
            return await _userRepository.AuthenticateAsync(username, password);
        }
    }
}
