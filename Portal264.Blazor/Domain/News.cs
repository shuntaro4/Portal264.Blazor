using System;

namespace Portal264.Blazor.Domain
{
    public class News
    {
        public string Title { get; private set; }

        private DateTime _startAt;

        public string DisplayStartAt => _startAt.ToString("yyyy-MM-dd");

        private DateTime _createdAt;

        public string DisplayCreatedAt => _createdAt.ToString("yyyy-MM-dd");

        public News(string title, DateTime startAt, DateTime createdAt)
        {
            Title = title;
            _startAt = startAt;
            _createdAt = createdAt;
        }
    }
}
