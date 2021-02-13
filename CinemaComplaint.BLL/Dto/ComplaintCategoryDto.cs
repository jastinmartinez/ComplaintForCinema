using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplaintForCinema.BLL.Dto
{
    public class ComplaintCategoryDto
    {
        public Guid? ID { get; set; }

        [DisplayName("Descripcion")]
        public string Description { get; set; }
        [DisplayName("Estado")]
        public bool Status { get; set; }

    }
}
