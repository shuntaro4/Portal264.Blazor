using System;

namespace Portal264.Blazor.Domain
{
    public class News
    {
        public int ConcertId { get; private set; }

        public string Title { get; private set; }

        private DateTime _startAt;

        public string DisplayStartAt => _startAt.ToString("yyyy-MM-dd");

        private DateTime _createdAt;

        public string DisplayCreatedAt => _createdAt.ToString("yyyy-MM-dd");

        public News(int concertId, string title, DateTime startAt, DateTime createdAt)
        {
            ConcertId = concertId;
            Title = title;
            _startAt = startAt;
            _createdAt = createdAt;
        }
    }
}
