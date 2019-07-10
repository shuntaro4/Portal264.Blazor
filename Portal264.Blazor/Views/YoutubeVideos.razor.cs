using Microsoft.AspNetCore.Components;
using Portal264.Blazor.ViewModels;

namespace Portal264.Blazor.Views
{
    public class YoutubeVideosBase : ComponentBase
    {
        [Inject]
        public IYoutubeVideosViewModel ViewModel { get; set; }
    }
}
