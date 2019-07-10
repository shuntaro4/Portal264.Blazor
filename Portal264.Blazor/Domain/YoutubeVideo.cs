﻿using System;

namespace Portal264.Blazor.Domain
{
    public class YoutubeVideo
    {
        public string Id { get; private set; }

        public string Title { get; private set; }

        private DateTime _publishedAt;

        public string DisplayDatePublishedAt => _publishedAt.ToString("yyyy-MM-dd(ddd)");

        public string Url => "https://www.youtube.com/watch?v=" + Id;

        public string ThumbnailUrl => "https://img.youtube.com/vi/" + Id + "/mqdefault.jpg";

        public YoutubeVideo(string id, string title, DateTime publishedAt)
        {
            Id = id;
            Title = title;
            _publishedAt = publishedAt;
        }
    }
}