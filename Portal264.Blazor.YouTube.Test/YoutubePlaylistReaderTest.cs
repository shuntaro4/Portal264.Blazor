using RichardSzalay.MockHttp;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Portal264.Blazor.YouTube.Test
{
    public class YoutubePlaylistReaderTest
    {
        [Fact(DisplayName = "Success to get the youtube playlist.")]
        [Trait("YouTubePlaylistReader", "GetAsync")]
        public async Task GetAsyncTrue1()
        {
            var apiKey = "hoge";
            var playlistId = "fuga";
            var maxResults = 50;

            using (var mockHttpClient = new MockHttpMessageHandler())
            {
                var urlBuilder = new StringBuilder();
                urlBuilder.Append("https://www.googleapis.com/youtube/v3/playlistItems");
                urlBuilder.Append("?part=snippet");
                urlBuilder.Append("&playlistId=" + playlistId);
                urlBuilder.Append("&maxResults=" + maxResults);
                urlBuilder.Append("&key=" + apiKey);

                var json = ReadJsonFile("playlist.json");
                mockHttpClient.When(urlBuilder.ToString()).Respond("application/json", json);

                var target = new YouTubePlaylistReader(apiKey, mockHttpClient.ToHttpClient())
                {
                    PlaylistId = playlistId,
                    MaxResults = maxResults
                };

                var actual = await target.GetAsync();

                Assert.NotNull(actual);
                Assert.Equal(11, actual.items.Count);

                var snipet = actual.items[0].snippet;
                Assert.NotNull(snipet);

                Assert.Equal("Song forÅc(HY cover)", snipet.title);
                Assert.Equal(DateTime.Parse("2018-05-06T13:50:34.000Z").ToUniversalTime(), snipet.publishedAt.ToUniversalTime());
                Assert.NotNull(snipet.resourceId);
                Assert.Equal("JGBLgWBXn_A", snipet.resourceId.videoId);
            }
        }

        private string ReadJsonFile(string fileName)
        {
            var path = @$"{Environment.CurrentDirectory}\TestResources\Json\{fileName}";
            using (var stream = new FileStream(path, FileMode.Open))
            using (var reader = new StreamReader(stream, Encoding.UTF8))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
