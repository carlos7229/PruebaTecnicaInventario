using PruebaTecnicaInventario.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaInventario.Core.Interfaces
{
    public interface IStockService
    {
        Task<Stock> GetStock(int Id);
        Task InsertStock(Stock stock);
        Task<bool> UpdateStock(Stock stock);
        Task<bool> DeleteStock(int Id);
        IEnumerable<object> GetAllStock();
    }
}
