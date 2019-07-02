using Microsoft.AspNetCore.Components;
using Portal264.Blazor.ViewModels;

namespace Portal264.Blazor.Views
{
    public class NewsBase : ComponentBase
    {
        [Inject]
        public INewsViewModel ViewModel { get; set; }
    }
}
