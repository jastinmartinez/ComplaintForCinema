using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaComplaint.BLL.Dto
{
    public class ComplaintStatusDto
    {
        public Guid ID { get; set; }

        public string Description { get; set; }

        public bool Status { get; set; }
    }
}
