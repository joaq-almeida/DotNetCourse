using System;
using System.Collections.Generic;
using System.Text;
using AppEstudo.Domain.Models;

namespace AppEstudo.Domain.ViewModels
{
    public class TicketViewModel
    {
        public int ID { get; set; }
        public ICollection<Status> Statuses { get; set; }
        public ICollection<Priority> Priorities { get; set; }
        public ICollection<Category> Categories { get; set; }
    }
}
