using Portal264.Blazor.ApplicationServices;
using Portal264.Blazor.Domain;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Portal264.Blazor.ViewModels
{
    public class YouTubeVideosViewModel : IYouTubeVideosViewModel
    {
        private ObservableCollection<YouTubeVideo> _videos;

        public ObservableCollection<YouTubeVideo> Videos
        {
            get => _videos;
            set => _videos = value;
        }

        public async Task LoadYouTubeVideos()
        {
            IYouTubeVideoService youtubeVideoService = new YouTubeVideoService();
            Videos = new ObservableCollection<YouTubeVideo>(await youtubeVideoService.GetVideosAsync());
        }
    }
}
