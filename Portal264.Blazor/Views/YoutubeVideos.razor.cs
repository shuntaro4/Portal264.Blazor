using Microsoft.AspNetCore.Components;
using Portal264.Blazor.ViewModels;
using System.Threading.Tasks;

namespace Portal264.Blazor.Views
{
    public class YoutubeVideosBase : ComponentBase
    {
        [Inject]
        public IYoutubeVideosViewModel ViewModel { get; set; }

        protected override async Task OnInitAsync()
        {
            await ViewModel.LoadYoutubeVideos();
        }
    }
}
