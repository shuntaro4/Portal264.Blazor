using System.Threading.Tasks;

namespace Portal264.Blazor.YouTube
{
    public interface IYouTubePlaylistReader
    {
        Task<YouTubeJsonObject> GetAsync();
    }
}
