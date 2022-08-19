using System;
using System.Collections.Generic;

namespace ApiSalao.Models
{
    public partial class Procedure
    {
        public Procedure()
        {
            ReservationProcedures = new HashSet<ReservationProcedure>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public double? Value { get; set; }
        public string? Categorie { get; set; }

        public virtual ICollection<ReservationProcedure> ReservationProcedures { get; set; }
    }
}
