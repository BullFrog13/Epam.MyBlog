using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    //Realisation of a repository pattern (Ask for using abstract classes with realisation)
    public interface IRepository<T> where T : class
    {
        //Get all instances from table
        List<T> GetAll();

        //Find via id
        T Find(int id);

        //Create new object in DB
        void Create(T item);

        //EDit object in DB
        void Edit(T item);

        //DElete object from DB
        void Delete(int id);
    }
}
