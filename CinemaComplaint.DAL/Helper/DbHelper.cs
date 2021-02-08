using System;
using System.Data;
using System.Data.SqlClient;

namespace ComplaintForCinema.DAL.Helper
{
    public class DbHelper
    {
        private static readonly IDbConnection _dbConnection = null;

        public static IDbConnection GetInstance
        {
            get
            {
                if (_dbConnection is null)
                    return new SqlConnection("Server=.;Database=CinemaComplaint;User Id=sa; Password=Admin00v@*; MultipleActiveResultSets=True");

                return _dbConnection;
            }
        }
    }
}