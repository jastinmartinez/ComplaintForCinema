using System;
using System.Collections.Generic;

namespace DAL.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();

        long Insert(T obj);

        bool Update(T obj);

        bool Delete(T obj);

    }
}
