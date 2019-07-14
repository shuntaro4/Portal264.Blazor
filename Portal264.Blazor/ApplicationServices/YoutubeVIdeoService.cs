using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Portal264.Blazor.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Portal264.Blazor.ApplicationServices
{
    public class YoutubeVideoService : IYoutubeVideoService
    {
        private readonly YouTubeService _youtubeService;

        public YoutubeVideoService()
        {
            _youtubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                ApiKey = "<your-api-key>"
            });
        }

        public async Task<List<YoutubeVideo>> GetVideosAsync()
        {
            var playlistRequest = _youtubeService.PlaylistItems.List("snippet");

            playlistRequest.PlaylistId = "UUASYHw_S6bt_7bUhyWWu61Q";
            playlistRequest.MaxResults = 50;

            // todo do not work... :(
            var playlistResponse = await playlistRequest.ExecuteAsync();

            var list = new List<YoutubeVideo>();
            foreach (var video in playlistResponse.Items)
            {
                Console.WriteLine(video.Id);
                list.Add(new YoutubeVideo(video.Id, video.Snippet.Title, video.ContentDetails.VideoPublishedAt));
            }
            return list;
        }
    }
}
