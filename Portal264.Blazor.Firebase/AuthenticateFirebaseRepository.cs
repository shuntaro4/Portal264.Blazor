using System;
using System.Threading.Tasks;

namespace Portal264.Blazor.Firebase
{
    public class AuthenticateFirebaseRepository : IAuthenticateRepository
    {
        public async Task<bool> LoginAsync(string mailAddress, string password)
        {
            // todo: rewrite in JavaScript.
            throw new NotImplementedException();
        }

        public Task LogoutAsync()
        {
            throw new NotImplementedException();
        }
    }
}
