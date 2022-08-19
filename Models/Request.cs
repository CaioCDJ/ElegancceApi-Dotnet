using System;
using System.Collections.Generic;

namespace ApiSalao.Models
{
    public partial class Request
    {
        public Request()
        {
            Buys = new HashSet<Buy>();
        }

        public int Id { get; set; }
        public int? RequestProductId { get; set; }
        public int? UserId { get; set; }

        public virtual RequestProduct? RequestProduct { get; set; }
        public virtual User? User { get; set; }
        public virtual ICollection<Buy> Buys { get; set; }
    }
}
