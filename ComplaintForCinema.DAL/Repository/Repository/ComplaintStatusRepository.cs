using System;
using System.Collections.Generic;
using System.Data;
using ComplaintForCinema.DAL.Helper;
using ComplaintForCinema.DAL.Model;
using DAL.Repository;
using Dapper.Contrib.Extensions;

namespace ComplaintForCinema.DAL.Repository.Method
{
    public class ComplaintStatusRepository : IGenericRepository<ComplaintStatus>
    {
        private readonly IDbConnection dbConnection = DbHelper.GetInstance;

        public bool Delete(ComplaintStatus obj)
        {
            return dbConnection.Delete(new ComplaintStatus { ComplaintStatusID = obj.ComplaintStatusID, ComplaintStatusDescription = obj.ComplaintStatusDescription, ComplaintStatusIsActive = obj.ComplaintStatusIsActive });
        }

        public IEnumerable<ComplaintStatus> GetAll()
        {
            return dbConnection.GetAll<ComplaintStatus>();
        }

        public long Insert(ComplaintStatus obj)
        {
            return dbConnection.Insert(new ComplaintStatus { ComplaintStatusID = obj.ComplaintStatusID, ComplaintStatusDescription = obj.ComplaintStatusDescription, ComplaintStatusIsActive = obj.ComplaintStatusIsActive });
        }

        public bool Update(ComplaintStatus obj)
        {
            return dbConnection.Update(new ComplaintStatus { ComplaintStatusID = obj.ComplaintStatusID, ComplaintStatusDescription = obj.ComplaintStatusDescription, ComplaintStatusIsActive = obj.ComplaintStatusIsActive });
        }
    }
}
