using System;
using System.Collections.Generic;
using System.Data;
using ComplaintForCinema.DAL.Helper;
using ComplaintForCinema.DAL.Model;
using DAL.Repository;
using Dapper.Contrib.Extensions;

namespace ComplaintForCinema.DAL.Repository.Method
{
    public class ComplaintCategoryRepository : IGenericRepository<ComplaintCategory>
    {
        private readonly IDbConnection dbConnector = DbHelper.GetInstance;

        public long Insert(ComplaintCategory obj)
        {
            return dbConnector.Insert(new ComplaintCategory
            {
                ComplaintCategoryID = obj.ComplaintCategoryID,
                ComplaintCategoryDescription = obj.ComplaintCategoryDescription,
                ComplaintCategoryIsActive = obj.ComplaintCategoryIsActive
            });
        }

        public IEnumerable<ComplaintCategory> GetAll()
        {
            return dbConnector.GetAll<ComplaintCategory>();
        }

        public bool Delete(ComplaintCategory obj)
        {
            return dbConnector.Delete(new ComplaintCategory { ComplaintCategoryID = obj.ComplaintCategoryID});
        }

        public bool Update(ComplaintCategory obj)
        {
            return dbConnector.Update(new ComplaintCategory { ComplaintCategoryID = obj.ComplaintCategoryID, ComplaintCategoryDescription = obj.ComplaintCategoryDescription, ComplaintCategoryIsActive = obj.ComplaintCategoryIsActive });
        }
    }
}
