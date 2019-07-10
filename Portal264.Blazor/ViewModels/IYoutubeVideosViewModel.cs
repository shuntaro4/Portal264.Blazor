using Portal264.Blazor.Domain;
using System.Collections.ObjectModel;

namespace Portal264.Blazor.ViewModels
{
    public interface IYoutubeVideosViewModel
    {
        ObservableCollection<YoutubeVideo> Videos { get; }
    }
}
