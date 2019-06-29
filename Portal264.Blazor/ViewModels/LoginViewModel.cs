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

        public LoginViewModel()
        {
        }

        public async Task LoginAsync()
        {
            await Task.Delay(500);
            Console.WriteLine($"MailAddress={MailAddress}");
            Console.WriteLine($"MailAddress={Password}");
        }
    }
}
