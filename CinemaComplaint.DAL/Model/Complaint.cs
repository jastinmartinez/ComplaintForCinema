using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace ComplaintForCinema.DAL.Model
{
    [Table("Complaint")]
    public class Complaint
    {
        [ExplicitKey]
        public Guid ComplaintID { get; set; }

        public string ComplaintTitile { get; set; }

        public Guid UserID { get; set; }

        public Guid ComplaintCategoryID { get; set; }

        public Guid ComplaintStatusID { get; set; }

        public Guid ComplaintLocationID { get; set; }

        public DateTime ComplaintDate { get; set; }

        public string ComplaintComments { get; set; }

    }
}
