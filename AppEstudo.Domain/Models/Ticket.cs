using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace AppEstudo.Domain.Models
{
    public class Ticket
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public virtual Category Category { get; set; }
        public string Description { get; set; }
        public virtual Priority Priority { get; set; }
        public virtual Status Status { get; set; }
        public DateTime Created { get; set; }
        public virtual User CreatedById { get; set; }
        public DateTime Modified { get; set; }
        public virtual User ModifiedById { get; set; }
    }
}
