using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace ComplaintForCinema.DAL.Model
{
    [Table("ComplaintStatus")]
    public class ComplaintStatus
    {
        [ExplicitKey]
        public Guid ComplaintStatusID { get; set; }
        public string ComplaintStatusDescription { get; set; }
        public bool ComplaintStatusIsActive { get; set; }
    }
}
