using System.Collections.Generic;
using System.Linq;
using DAL.Interfaces;
using DAL.Content;
using System.Data.Entity;

namespace DAL.Repository_CRUD
{
    public class Answer_Data_Operations : IRepository<Answer>
    {
        BlogContext db;

        public Answer_Data_Operations()
        {
            this.db = new BlogContext();
        }


        //IRepository realisation


        public List<Answer> GetAll()
        {
            return db.Answers.ToList();
        }

        public Answer Find(int id)
        {
            return db.Answers.Find(id);
        }

        public void Create(Answer answer)
        {
            db.Answers.Add(answer);
            db.SaveChanges();
        }

        public void Edit(Answer answer)
        {
            db.Entry(answer).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            db.Answers.Remove(db.Answers.Find(id));
            db.SaveChanges();
        }
    }
}
