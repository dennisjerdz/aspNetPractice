using PracticeStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticeStore.RepositoryClasses
{
    public interface IPostRepository
    {
        List<Post> getPosts();
        List<Post> getPosts(int Limit);
    }

    public class PostRepository : IPostRepository
    {
        ApplicationDbContext db = new ApplicationDbContext();

        public List<Post> getPosts()
        {
            return db.Posts.ToList();
        }

        public List<Post> getPosts(int limit)
        {
            if (limit <= 0)
            {
                return db.Posts.ToList();
            }
            else
            {
                return db.Posts.Take(limit).ToList();
            }
        }
    }
}