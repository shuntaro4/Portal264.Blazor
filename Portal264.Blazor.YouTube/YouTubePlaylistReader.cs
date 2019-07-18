using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Portal264.Blazor.YouTube
{
    public class YouTubePlaylistReader : IYouTubePlaylistReader
    {
        internal string ApiKey { get; private set; }

        public string PlaylistId { get; set; }

        public int MaxResults { get; set; }

        public YouTubePlaylistReader(string apiKey)
        {
            ApiKey = apiKey;
        }

        public async Task<YouTubeJsonObject> GetAsync()
        {
            if (string.IsNullOrEmpty(ApiKey) || string.IsNullOrEmpty(PlaylistId))
            {
                return new YouTubeJsonObject();
            }

            var urlBuilder = new StringBuilder();
            urlBuilder.Append("https://www.googleapis.com/youtube/v3/playlistItems");
            urlBuilder.Append("?part=snippet");
            urlBuilder.Append("&playlistId=" + PlaylistId);
            urlBuilder.Append("&maxResults=" + MaxResults);
            urlBuilder.Append("&key=" + ApiKey);
            using (var httpClient = new HttpClient())
            {
                var json = await httpClient.GetStringAsync(urlBuilder.ToString());
                return JsonConvert.DeserializeObject<YouTubeJsonObject>(json);
            }
        }
    }
}
