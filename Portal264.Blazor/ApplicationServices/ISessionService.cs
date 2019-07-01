using System.Threading.Tasks;

namespace Portal264.Blazor.ApplicationServices
{
    public interface ISessionService
    {
        Task<bool> LoginAsync(string mailAddress, string password);

        Task LogoutAsync();
    }
}