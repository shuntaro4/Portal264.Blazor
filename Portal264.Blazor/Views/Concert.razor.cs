using Microsoft.AspNetCore.Components;
using Portal264.Blazor.ViewModels;

namespace Portal264.Blazor.Views
{
    public class ConcertBase : ComponentBase
    {
        public IConcertViewModel ViewModel { get; set; }

        [Parameter]
        public int Id { get; set; }

        public ConcertBase()
        {
            ViewModel = new ConcertViewModel(Id);
        }
    }
}
