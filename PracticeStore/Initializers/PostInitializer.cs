using PracticeStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PracticeStore.Initializers
{
    public class PostInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext db)
        {
            base.Seed(db);

            var posts = new List<Post>
            {
                new Post()
                {
                    Content = "TestA"
                },
                new Post()
                {
                    Content = "TestB"
                }
            };

            posts.ForEach(p => db.Posts.Add(p));
            db.SaveChanges();
        }
    }
}