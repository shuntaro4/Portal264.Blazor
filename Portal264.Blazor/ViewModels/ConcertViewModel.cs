using Portal264.Blazor.Domain;
using System;

namespace Portal264.Blazor.ViewModels
{
    public class ConcertViewModel : IConcertViewModel
    {
        private ConcertDetail _concert;

        public ConcertDetail Concert
        {
            get => _concert;
            set => _concert = value;
        }

        public ConcertViewModel(int id)
        {
            Concert = new ConcertDetail(
                            id,
                            "テスト１",
                            new DateTime(2000, 12, 1, 10, 0, 0),
                            new DateTime(2000, 12, 12, 9, 30, 0).AddSeconds(30),
                            false,
                            "テスト市民会館",
                            "テスト県テスト市",
                            0,
                            0,
                            "あいうえお\r\nあいうえお");
        }
    }
}
