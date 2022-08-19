using System;
using System.Collections.Generic;

namespace ApiSalao.Models
{
    public partial class Product
    {
        public Product()
        {
            RequestProducts = new HashSet<RequestProduct>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public double? Value { get; set; }
        public string? Description { get; set; }
        public int? Qt { get; set; }

        public virtual ICollection<RequestProduct> RequestProducts { get; set; }
    }
}
