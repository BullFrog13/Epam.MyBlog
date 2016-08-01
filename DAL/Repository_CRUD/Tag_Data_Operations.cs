using System.Collections.Generic;
using System.Linq;
using DAL.Interfaces;
using DAL.Content;
using System.Data.Entity;

namespace DAL.Repository_CRUD
{
    public class Tag_Data_Operations : IRepository<Tag>
    {

            BlogContext db;

            public Tag_Data_Operations()
            {
                this.db = new BlogContext();
            }


            //IRepository realisation


            public List<Tag> GetAll()
            {
                return db.Tags.ToList();
            }

            public Tag Find(int id)
            {
                return db.Tags.Find(id);
            }

            public void Create(Tag tag)
            {
                db.Tags.Add(tag);
                db.SaveChanges();
            }

            public void Edit(Tag tag)
            {
                db.Entry(tag).State = EntityState.Modified;
                db.SaveChanges();
            }

            public void Delete(int id)
            {
                db.Tags.Remove(db.Tags.Find(id));
                db.SaveChanges();
            }

        public Tag FindByText(string text)
        {
            Tag resTag = db.Tags
                         .Where(b => b.Text == text)
                         .FirstOrDefault();
            return resTag;
        }        
    }
}
