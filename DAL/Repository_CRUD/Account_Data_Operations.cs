using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using DAL.Interfaces;
using DAL.Content;

namespace DAL.Repository_CRUD
{
    public class Account_Data_Operations : IRepository<Account>
    {
        BlogContext db;

        public Account_Data_Operations()
        {
            this.db = new BlogContext(); 
        }

        //IRepository realisation

        public List<Account> GetAll()
        {
            return db.Accounts.ToList();
        }

        public Account Find (int id)
        {
            return db.Accounts.Find(id);
        }

        public void Create (Account account)
        {
            db.Accounts.Add(account);
            db.SaveChanges();
        }

        public void Edit(Account account)
        {
            db.Entry(account).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            db.Accounts.Remove(db.Accounts.Find(id));
            db.SaveChanges();
        }
    }
}
