using Portal264.Blazor.Domain;
using System.Collections.ObjectModel;

namespace Portal264.Blazor.ViewModels
{
    public class NewsViewModel : INewsViewModel
    {
        private ObservableCollection<News> _news;

        public ObservableCollection<News> News
        {
            get => _news;
            set => _news = value;
        }

        public NewsViewModel()
        {
            News = new ObservableCollection<News>();
        }
    }
}
