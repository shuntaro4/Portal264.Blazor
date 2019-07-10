using Portal264.Blazor.Domain;
using System;
using System.Collections.ObjectModel;

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

        public YoutubeVideosViewModel()
        {
            // Videos = = new ObservableCollection<YoutubeVideo>();
            Videos = new ObservableCollection<YoutubeVideo>()
            {
                new YoutubeVideo("JGBLgWBXn_A", "テスト１", new DateTime(2000,12,1)),
                new YoutubeVideo("eyOhqCLLfKU", "テスト２", new DateTime(2000,12,2)),
                new YoutubeVideo("3aPCIDabY30", "テスト３", new DateTime(2000,12,3)),
            };
        }
    }
}
