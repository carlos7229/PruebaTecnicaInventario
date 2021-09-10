using System;
using System.Collections.Generic;

#nullable disable

namespace PruebaTecnicaInventario.Core.Models
{
    public partial class Stock : BaseModel
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
