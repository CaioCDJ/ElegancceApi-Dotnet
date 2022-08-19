using System;
using System.Collections.Generic;

namespace ApiSalao.Models
{
    public partial class Reservation
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public int? UserId { get; set; }
        public int? ReservationProcedureId { get; set; }

        public virtual ReservationProcedure? ReservationProcedure { get; set; }
        public virtual User? User { get; set; }
    }
}
