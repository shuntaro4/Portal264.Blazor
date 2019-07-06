using Portal264.Blazor.Domain;
using System;
using System.Collections.ObjectModel;

namespace Portal264.Blazor.ViewModels
{
    public class ConcertsViewModel : IConcertsViewModel
    {
        private ObservableCollection<Concert> _concerts;

        public ObservableCollection<Concert> Concerts
        {
            get => _concerts;
            set => _concerts = value;
        }

        public ConcertsViewModel()
        {
            Concerts = new ObservableCollection<Concert>()
            {
                new Concert("テスト１", new DateTime(2000,12,1, 10, 0, 0), new DateTime(2000,12,12, 9, 30, 0).AddSeconds(30), false, "テスト市民会館"),
                new Concert("テスト２", new DateTime(2012,12,12, 9, 30, 0), new DateTime(2012,12,12, 9, 30, 0).AddSeconds(30), true, "テストライブハウス"),
                new Concert("テスト２", new DateTime(2013,1,13, 20, 0, 0), new DateTime(2013,12,12, 9, 30, 0).AddSeconds(30), true, "テストホール")
            };
        }
    }
}
