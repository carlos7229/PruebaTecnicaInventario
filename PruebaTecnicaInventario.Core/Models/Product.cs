using System;
using System.Collections.Generic;

#nullable disable

namespace PruebaTecnicaInventario.Core.Models
{
    public partial class Product : BaseModel
    {
        public string Code { get; set; }
        public string Desciption { get; set; }
        public double Value { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
