using Portal264.Blazor.Domain;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Portal264.Blazor.ViewModels
{
    public interface IYouTubeVideosViewModel
    {
        ObservableCollection<YouTubeVideo> Videos { get; }

        Task LoadYouTubeVideos();
    }
}
