﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplaintForCinema.BLL.Service.Interface
{
    public interface IGenericRepositoryService<T> where T : class
    {
        IEnumerable<T> GetAll();

        long Insert(T obj);

        bool Update(T obj);

        bool Delete(T obj);

        T Get(T obj);
    }
}
