﻿namespace Model
{
    public class Book
    {
        public int Id { get; }
        public string Title { get; }
        public string Author { get; }

        public Book(int id, string title, string author)
        {
            Id = id;
            Title = title;
            Author = author;
        }

        public override string ToString()
        {
            return $"[Book] id: {Id} | Author: {Author} | Title: {Title}";
        }
    }
}
