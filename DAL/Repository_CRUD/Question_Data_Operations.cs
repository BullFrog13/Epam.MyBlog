using System.Collections.Generic;
using System.Linq;
using DAL.Interfaces;
using DAL.Content;
using System.Data.Entity;

namespace DAL.Repository_CRUD
{
    public class Question_Data_Operations : IRepository<Question>
    {
        BlogContext db;

        public Question_Data_Operations()
        {
            this.db = new BlogContext();
        }

        //IRepository realisation

        public List<Question> GetAll()
        {
            return db.Questions.Include(x => x.PossibleAnswer).ToList();
        }

        public Question Find(int id)
        {
            return db.Questions.Include(x => x.PossibleAnswer).ToList().First(x => x.ID.Equals(id));
        }

        public void Create(Question question)
        {
            db.Questions.Add(question);
            db.SaveChanges();
        }

        public void Edit(Question question)
        {
            db.Entry(question).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            db.Questions.Remove(db.Questions.Find(id));
            db.SaveChanges();
        }

        public void Vote()
        {
            Question.TotalAnswers++;
            db.SaveChanges();
        }
    }
}
