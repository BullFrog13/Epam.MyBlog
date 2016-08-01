using System.Collections.Generic;
using System.Linq;
using DAL.Interfaces;
using DAL.Content;
using System.Data.Entity;

namespace DAL.Repository_CRUD
{
    public class Post_Data_Operations : IRepository<Post>
    {
        BlogContext db;

        public Post_Data_Operations()
        {
            this.db = new BlogContext();
        }


        //IRepository realisation


        public List<Post> GetAll()
        {
            return db.Posts.ToList();
        }

        public Post Find(int id)
        {
            return db.Posts.Find(id);
        }

        public void Create(Post post)
        {
            db.Posts.Add(post);
            db.SaveChanges();
        }

        public void Edit(Post post)
        {
            db.Entry(post).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            db.Posts.Remove(db.Posts.Find(id));
            db.SaveChanges();
        }
    }
}
