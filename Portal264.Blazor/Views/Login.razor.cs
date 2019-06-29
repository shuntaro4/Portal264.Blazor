using Microsoft.AspNetCore.Components;
using Portal264.Blazor.ViewModels;

namespace Portal264.Blazor.Views
{
    public class LoginBase : ComponentBase
    {
        [Inject]
        public ILoginViewModel ViewModel { get; set; }
    }
}
