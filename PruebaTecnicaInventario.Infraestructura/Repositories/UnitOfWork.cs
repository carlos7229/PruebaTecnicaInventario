using PruebaTecnicaInventario.Core.Interfaces;
using PruebaTecnicaInventario.Core.Models;
using PruebaTecnicaInventario.Infraestructura.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaInventario.Infraestructura.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PruebaTecnicaInventarioContext _context;
        private readonly IRepository<Client> _clientServRepository;
        private readonly IRepository<Product> _productServRepository;
        private readonly ISaleRepository _saleServRepository;
        private readonly IStockRepository _stocktRepRepository;

        public UnitOfWork(PruebaTecnicaInventarioContext context)
        {
            _context = context;
        }


        public IRepository<Client> ClentRepository => _clientServRepository ?? new BaseRepository<Client>(_context);

        public IRepository<Product> ProductRepository => _productServRepository ?? new BaseRepository<Product>(_context);

        public ISaleRepository SaleRepository => _saleServRepository ?? new SaleRepository(_context);

        public IStockRepository StockRepository => _stocktRepRepository ?? new StockRepository(_context);

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
