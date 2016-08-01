using System.Collections.Generic;
using System.Linq;
using DAL.Interfaces;
using DAL.Content;
using System.Data.Entity;

namespace DAL.Repository_CRUD
{
    public class Review_Data_Operations : IRepository<Review>
    {
        BlogContext db;

        public Review_Data_Operations()
        {
            this.db = new BlogContext();
        }


        //IRepository realisation


        public List<Review> GetAll()
        {
            return db.Reviews.ToList();
        }

        public Review Find(int id)
        {
            return db.Reviews.Find(id);
        }

        public void Create(Review review)
        {
            db.Reviews.Add(review);
            db.SaveChanges();
        }

        public void Edit(Review review)
        {
            db.Entry(review).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            db.Reviews.Remove(db.Reviews.Find(id));
            db.SaveChanges();
        }
    }
}
