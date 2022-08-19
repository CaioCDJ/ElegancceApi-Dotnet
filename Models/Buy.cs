using System;
using System.Collections.Generic;

namespace ApiSalao.Models
{
    public partial class Buy
    {
        public int Id { get; set; }
        public double? Value { get; set; }
        public int? RequestId { get; set; }

        public virtual Request? Request { get; set; }
    }
}

