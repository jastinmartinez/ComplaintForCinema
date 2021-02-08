using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaComplaint.BLL.Service.Interface
{
    public interface IGenericService<T> where T : class
    {
        IEnumerable<T> GetAll();

        long Insert(T obj);

        bool Update(T obj);

        bool Delete(T obj);
    }
}
