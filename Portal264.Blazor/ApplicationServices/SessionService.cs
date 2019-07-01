using Portal264.Blazor.Firebase;
using System.Threading.Tasks;

namespace Portal264.Blazor.ApplicationServices
{
    public class SessionService : ISessionService
    {
        private readonly IAuthenticateRepository _authenticateRepository;

        public SessionService(IAuthenticateRepository authenticateRepository)
        {
            _authenticateRepository = authenticateRepository;
        }

        public async Task<bool> LoginAsync(string mailAddress, string password)
        {
            return await _authenticateRepository.LoginAsync(mailAddress, password);
        }

        public async Task LogoutAsync()
        {
            await _authenticateRepository.LogoutAsync();
        }
    }
}
