using System;
using System.Collections.Generic;

#nullable disable

namespace PruebaTecnicaInventario.Core.Models
{
    public partial class Sale : BaseModel
    {
        public int ProductId { get; set; }
        public int ClientId { get; set; }
        public int SaleQuantity { get; set; }
        public DateTime SaleDate { get; set; }
    }
}
