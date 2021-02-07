using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace ComplaintForCinema.DAL.Model
{
    [Table("dbo.ComplaintCategory")]
    public class ComplaintCategory
    {
        [ExplicitKey]
        public Guid ComplaintCategoryID { get; set; }
        public string ComplaintCategoryDescription { get; set; }
        public bool ComplaintCategoryIsActive { get; set; }
    }
}
