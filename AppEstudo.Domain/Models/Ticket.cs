using System;
using System.Collections.Generic;
using System.Text;

namespace AppEstudo.Domain.Models
{
    public class Ticket
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Comment { get; set; }
        public int Priority { get; set; }
        public int TimeExpent { get; set; }
        public bool Status { get; set; }
        public DateTime Created { get; set; }
        public int CreatedById { get; set; }
        public DateTime Modified { get; set; }
        public int ModifiedById { get; set; }
    }
}
