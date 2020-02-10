using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using AppEstudo.Domain.Enums;

namespace AppEstudo.Domain.Models
{
    public class Ticket
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        public string Title { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        public virtual TicketCategoryEnum Category { get; set; }
        public string Comment { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        public virtual TicketPriorityEnum Priority { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        public int TimeExpent { get; set; }
        public bool Status { get; set; }
        public DateTime Created { get; set; }
        public int CreatedById { get; set; }
        public DateTime Modified { get; set; }
        public int ModifiedById { get; set; }
    }
}
