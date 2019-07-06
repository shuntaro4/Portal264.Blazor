using System;

namespace Portal264.Blazor.Domain
{
    public class ConcertSummary
    {
        public string Title { get; private set; }

        private DateTime _openAt;

        public string DisplayDateOpenAt => _openAt.ToString("yyyy-MM-dd(ddd)");

        public string DisplayTimeOpenAt => _openAt.ToString("HH:mm");

        private DateTime _startAt;

        public string DisplayDateStartAt => _startAt.ToString("yyyy-MM-dd(ddd)");

        public string DisplayTimeStartAt => _startAt.ToString("HH:mm");

        public bool Active { get; private set; }

        public string Place { get; private set; }

        public ConcertSummary(string title, DateTime openAt, DateTime startAt, bool active, string place)
        {
            Title = title;
            _openAt = openAt;
            _startAt = startAt;
            Active = active;
            Place = place;
        }
    }
}
