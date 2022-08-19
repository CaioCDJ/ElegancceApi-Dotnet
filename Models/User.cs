using System;
using System.Collections.Generic;

namespace ApiSalao.Models
{
    public partial class User
    {
        public User()
        {
            Discounts = new HashSet<Discount>();
            Requests = new HashSet<Request>();
            Reservations = new HashSet<Reservation>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public int? Phone { get; set; }

        public virtual ICollection<Discount> Discounts { get; set; }
        public virtual ICollection<Request> Requests { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
