﻿namespace db_app3.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        
        public int UserId { get; set; }
        public User User { get; set; }
    }
}