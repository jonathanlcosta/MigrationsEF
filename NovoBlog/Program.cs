using System;
using NovoBlog.Models;
using NovoBlog.Models.Data;

namespace NovoBlog
{
    class Program
    {
        static void Main(string [] args)
        {
            var user = new User
            {
                Bio = "a",
                Email = "a@a.com",
                GitHub = "jonathancosta",
                Image = "https://",
                Name = "Jonathan Costa",
                PasswordHash = "1235",
                Slug = "jonthan-costa",
            };

            using var context = new BlogDataContext();
            context.Users.Add(user);
            context.SaveChanges();
        }
    }
}

