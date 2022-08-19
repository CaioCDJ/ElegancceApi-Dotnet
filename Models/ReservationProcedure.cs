using System;
using System.Collections.Generic;

namespace ApiSalao.Models
{
    public partial class ReservationProcedure
    {
        public ReservationProcedure()
        {
            Reservations = new HashSet<Reservation>();
        }

        public int Id { get; set; }
        public int? ProcedureId { get; set; }

        public virtual Procedure? Procedure { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
