using System;
using System.Collections.Generic;

namespace ApiSalao.Models
{
    public partial class RequestProduct
    {
        public RequestProduct()
        {
            Requests = new HashSet<Request>();
        }

        public int Id { get; set; }
        public int? QtProduct { get; set; }
        public int? ProductId { get; set; }

        public virtual Product? Product { get; set; }
        public virtual ICollection<Request> Requests { get; set; }
    }
}
