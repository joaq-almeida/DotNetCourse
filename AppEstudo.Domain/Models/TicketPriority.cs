using System;
using System.Collections.Generic;
using System.Text;

namespace AppEstudo.Domain.Models
{
    public class TicketPriority
    {
        public int ID { get; set; }
        public string Priority { get; set; }
        public virtual User CreatedById { get; set; }
        public DateTime Created { get; set; }
        public virtual User ModifiedById { get; set; }
        public DateTime Modified { get; set; }
    }
}
