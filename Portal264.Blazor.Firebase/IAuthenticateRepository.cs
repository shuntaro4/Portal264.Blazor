using System.Threading.Tasks;

namespace Portal264.Blazor.Firebase
{
    public interface IAuthenticateRepository
    {
        Task<bool> LoginAsync(string mailAddress, string password);

        Task Logout();
    }
}
