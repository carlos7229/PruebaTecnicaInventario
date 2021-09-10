using PruebaTecnicaInventario.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaInventario.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Client> ClentRepository { get; }
        IRepository<Product> ProductRepository { get; }
        ISaleRepository SaleRepository { get; }
        IStockRepository StockRepository { get; }

        void SaveChanges();
        Task SaveChangesAsync();
    }
}
