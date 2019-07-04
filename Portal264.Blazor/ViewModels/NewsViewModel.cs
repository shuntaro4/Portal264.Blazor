using Portal264.Blazor.Domain;
using System;
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
            News = new ObservableCollection<News>()
            {
                new News("テスト１", new DateTime(2000,12,1), DateTime.Now),
                new News("テスト２", new DateTime(2012,12,12), DateTime.Now.AddDays(-1))
            };
        }
    }
}
