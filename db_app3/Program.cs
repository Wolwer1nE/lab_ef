using System;
using System.Collections.Generic;
using System.Linq;
using db_app3.Models;
using Microsoft.EntityFrameworkCore;

namespace db_app3
{
    class Program
    {
        static void Main(string[] args)
        {
            InitialSetup();
            using var dbContext = new ApplicationContext();
            var users = dbContext.Users.ToList();
            foreach (var user in users)
            {
                Console.WriteLine($"{user.UserId} - {user.Name} - {user.Age}");
                if (user.Posts != null)
                {
                    foreach (var post in user.Posts)
                    {
                        Console.WriteLine($"{post.Title} - {post.Text}"); 
                    }
                }

            }
            var posts = dbContext.Posts.ToList();
            foreach (var post in posts)
            { 

                        Console.WriteLine($"{post.Title} - {post.Text} - {post.User.Name}"); 

            }
        }

        public static void InitialSetup()
        {
            using var dbContext = new ApplicationContext();
            var user1 = new User
            {
                Name = "A",
                Age = 20
            };
            var user2 = new User
            {
                Name = "B",
                Age = 30
            };



            dbContext.Users.AddRange(user1, user2);
            dbContext.SaveChanges();
            dbContext.Posts.Add(new Post()
            {
                Title = "Hi",
                Text = "Hello",
                User = user2
            });
            dbContext.SaveChanges();
        }
    }
}