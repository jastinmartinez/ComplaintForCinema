using System;
using Dapper.Contrib.Extensions;

namespace ComplaintForCinema.DAL.Model
{
    [Table("ComplaintJobHistory")]
    public class ComplaintJobHistory
    {
        [ExplicitKey]
        public Guid ComplaintJobHistoryID { get; set; }
        public Guid Complaint { get; set; }
        public string ComplaintJobHistoryDescription { get; set; }
        public DateTime ComplaintJobHistoryDate { get; set; }
        public string UserID { get; set; }
    }
}
