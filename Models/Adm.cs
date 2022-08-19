using System;
using System.Collections.Generic;

namespace ApiSalao.Models
{
    public partial class Adm
    {
        public int Id { get; set; }
        public string? Email { get; set; }
        public string? Name { get; set; }
        public string? Password { get; set; }
    }
}
