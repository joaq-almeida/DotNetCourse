using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace AppEstudo.Domain.Models
{
    public class Ticket
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        public string Title { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        public virtual TicketCategory Category { get; set; }
        public string Comment { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        public virtual TicketPriority Priority { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        public int TimeExpent { get; set; }
        public bool Status { get; set; }
        public DateTime Created { get; set; }
        public virtual User CreatedById { get; set; }
        public DateTime Modified { get; set; }
        public virtual User ModifiedById { get; set; }
    }
}
