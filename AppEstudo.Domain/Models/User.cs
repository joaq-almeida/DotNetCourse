using System;
using System.Collections.Generic;
using System.Text;

namespace AppEstudo.Domain.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
