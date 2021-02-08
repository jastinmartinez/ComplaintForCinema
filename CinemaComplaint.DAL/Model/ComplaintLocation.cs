using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace ComplaintForCinema.DAL.Model
{
    [Table("ComplaintLocation")]
    public class ComplaintLocation
    {
        [ExplicitKey]
        public Guid ComplaintLocationID { get; set; }
        public string ComplaintLocationDescription { get; set; }
        public bool ComplaintLocationIsActive { get; set; }
    }
}
