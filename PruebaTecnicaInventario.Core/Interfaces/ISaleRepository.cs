using PruebaTecnicaInventario.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaInventario.Core.Interfaces
{
    public interface ISaleRepository : IRepository<Sale>
    {
        IEnumerable<object> GetSales();
    }
}
