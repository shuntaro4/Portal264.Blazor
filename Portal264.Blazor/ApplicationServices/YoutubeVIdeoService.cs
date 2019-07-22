using Portal264.Blazor.Domain;
using Portal264.Blazor.YouTube;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Portal264.Blazor.ApplicationServices
{
    public class YouTubeVideoService : IYouTubeVideoService
    {
        public async Task<List<YouTubeVideo>> GetVideosAsync()
        {
            var apiKey = "<your-api-key>";
            IYouTubePlaylistReader youtubePlaylistReader = new YouTubePlaylistReader(apiKey, new HttpClient())
            {
                PlaylistId = "UUASYHw_S6bt_7bUhyWWu61Q",
                MaxResults = 50
            };

            var youtubeObject = await youtubePlaylistReader.GetAsync();
            var list = new List<YouTubeVideo>();
            foreach (var item in youtubeObject.items)
            {
                var youtubeVideo = new YouTubeVideo(item.snippet.resourceId.videoId, item.snippet.title, item.snippet.publishedAt);
                list.Add(youtubeVideo);
            }
            return list;
        }
    }
}
