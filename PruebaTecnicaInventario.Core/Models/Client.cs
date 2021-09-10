using System;
using System.Collections.Generic;

#nullable disable

namespace PruebaTecnicaInventario.Core.Models
{
    public partial class Client :BaseModel
    {
        public string FullName { get; set; }
        public string IdentificationNumber { get; set; }
        public int Age { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
