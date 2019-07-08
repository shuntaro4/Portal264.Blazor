using System;

namespace Portal264.Blazor.Domain
{
    public class ConcertDetail
    {
        public int Id { get; private set; }

        public string Title { get; private set; }

        private DateTime _openAt;

        public string DisplayDateOpenAt => _openAt.ToString("yyyy-MM-dd(ddd)");

        public string DisplayTimeOpenAt => _openAt.ToString("HH:mm");

        private DateTime _startAt;

        public string DisplayDateStartAt => _startAt.ToString("yyyy-MM-dd(ddd)");

        public string DisplayTimeStartAt => _startAt.ToString("HH:mm");

        public bool Active { get; private set; }

        public Place Place { get; private set; }

        private string _note;

        public string DisplayNote => _note; // todo: Replace CRLF or LF to <br> tag.

        public ConcertDetail(int id, string title, DateTime openAt, DateTime startAt, bool active, string place, string address, float latitude, float longitude, string note)
        {
            Id = id;
            Title = title;
            _openAt = openAt;
            _startAt = startAt;
            Active = active;
            Place = new Place(place, address, latitude, longitude);
            _note = note;
        }
    }
}
