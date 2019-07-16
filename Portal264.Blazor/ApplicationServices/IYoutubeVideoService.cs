using Portal264.Blazor.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Portal264.Blazor.ApplicationServices
{
    public interface IYouTubeVideoService
    {
        Task<List<YouTubeVideo>> GetVideosAsync();
    }
}