using PruebaTecnicaInventario.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaInventario.Core.Interfaces
{
    public interface ISaleService
    {
        Task<Sale> GetSale(int Id);
        Task InsertSale(Sale sale);
        Task<bool> UpdateSale(Sale sale);
        Task<bool> DeleteSale(int Id);
        IEnumerable<object> GetSales();
    }
}
