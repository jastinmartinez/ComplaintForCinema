using System;
using System.Collections.Generic;
using System.Data;
using ComplaintForCinema.DAL.Helper;
using ComplaintForCinema.DAL.Model;
using DAL.Repository;
using Dapper.Contrib.Extensions;

namespace ComplaintForCinema.DAL.Repository.Repository
{
    public class ComplaintLocationRepository : IGenericRepository<ComplaintLocation>
    {
        private readonly IDbConnection dbConnection = DbHelper.GetInstance;
        public bool Delete(ComplaintLocation obj)
        {
            return dbConnection.Delete(new ComplaintLocation { ComplaintLocationID = obj.ComplaintLocationID });
        }

        public IEnumerable<ComplaintLocation> GetAll()
        {
            return dbConnection.GetAll<ComplaintLocation>();
        }

        public long Insert(ComplaintLocation obj)
        {
            return dbConnection.Insert(new ComplaintLocation { ComplaintLocationID = obj.ComplaintLocationID, ComplaintLocationDescription = obj.ComplaintLocationDescription, ComplaintLocationIsActive = obj.ComplaintLocationIsActive });
        }

        public bool Update(ComplaintLocation obj)
        {
            return dbConnection.Update(new ComplaintLocation { ComplaintLocationID = obj.ComplaintLocationID, ComplaintLocationDescription = obj.ComplaintLocationDescription, ComplaintLocationIsActive = obj.ComplaintLocationIsActive });
        }
    }
}
