using Microsoft.AspNetCore.Components;
using Portal264.Blazor.ViewModels;

namespace Portal264.Blazor.Views
{
    public class ConcertsBase : ComponentBase
    {
        [Inject]
        public IConcertsViewModel ViewModel { get; set; }
    }
}
