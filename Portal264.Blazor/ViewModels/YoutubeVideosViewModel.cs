using Portal264.Blazor.ApplicationServices;
using Portal264.Blazor.Domain;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Portal264.Blazor.ViewModels
{
    public class YoutubeVideosViewModel : IYoutubeVideosViewModel
    {
        private ObservableCollection<YoutubeVideo> _videos;

        public ObservableCollection<YoutubeVideo> Videos
        {
            get => _videos;
            set => _videos = value;
        }

        public async Task LoadYoutubeVideos()
        {
            IYoutubeVideoService youtubeVideoService = new YoutubeVideoService();
            Videos = new ObservableCollection<YoutubeVideo>(await youtubeVideoService.GetVideosAsync());
        }
    }
}
