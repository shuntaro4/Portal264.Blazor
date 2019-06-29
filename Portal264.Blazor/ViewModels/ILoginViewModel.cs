using System.Threading.Tasks;

namespace Portal264.Blazor.ViewModels
{
    public interface ILoginViewModel
    {
        string MailAddress { get; set; }

        string Password { get; set; }

        Task LoginAsync();
    }
}
