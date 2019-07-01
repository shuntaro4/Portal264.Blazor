using Portal264.Blazor.ApplicationServices;
using System;
using System.Threading.Tasks;

namespace Portal264.Blazor.ViewModels
{
    public class LoginViewModel : ILoginViewModel
    {
        private string _mailAddress;

        public string MailAddress
        {
            get => _mailAddress;
            set => _mailAddress = value;
        }

        private string _password;

        public string Password
        {
            get => _password;
            set => _password = value;
        }

        private readonly ISessionService _sessionService;

        public LoginViewModel(ISessionService sessionService)
        {
            _sessionService = sessionService;
        }

        public async Task LoginAsync()
        {
            try
            {
                var result = await _sessionService.LoginAsync(MailAddress, Password);
                if (!result)
                {
                    Console.WriteLine("Login Failed...");
                    return;
                }
                Console.WriteLine("Login Succeeded!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public async Task LogoutAsync()
        {
            try
            {
                await _sessionService.LogoutAsync();
                Console.WriteLine("Logout Succeeded!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
