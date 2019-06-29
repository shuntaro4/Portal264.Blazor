using Firebase.Auth;
using Portal264.Blazor.Models;
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
            try
            {
                var auth = new FirebaseAuthProvider(new FirebaseConfig(FirebaseToken.ApiKey));
                var authLink = await auth.SignInWithEmailAndPasswordAsync(MailAddress, Password);
                Console.WriteLine("Login Succeeded!");
            }
            catch (FirebaseAuthException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
