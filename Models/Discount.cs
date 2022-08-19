using System;
using System.Collections.Generic;

namespace ApiSalao.Models
{
    public partial class Discount
    {
        public int Id { get; set; }
        public int? Discount1 { get; set; }
        public int? UserId { get; set; }

        public virtual User? User { get; set; }
    }
}
