using Portal264.Blazor.Domain;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Portal264.Blazor.ViewModels
{
    public interface IYoutubeVideosViewModel
    {
        ObservableCollection<YoutubeVideo> Videos { get; }

        Task LoadYoutubeVideos();
    }
}
