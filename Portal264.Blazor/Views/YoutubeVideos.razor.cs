using Microsoft.AspNetCore.Components;
using Portal264.Blazor.ViewModels;
using System.Threading.Tasks;

namespace Portal264.Blazor.Views
{
    public class YouTubeVideosBase : ComponentBase
    {
        [Inject]
        public IYouTubeVideosViewModel ViewModel { get; set; }

        protected override async Task OnInitAsync()
        {
            await ViewModel.LoadYouTubeVideos();
        }
    }
}
