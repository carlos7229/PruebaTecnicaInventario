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
    public class StockRepository : BaseRepository<Stock>, IStockRepository
    {
        PruebaTecnicaInventarioContext _context;

        public StockRepository(PruebaTecnicaInventarioContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<object> GetAllStock()
        {
            var stock = (from s in _context.Stocks
                         join p in _context.Products
                         on s.ProductId equals p.Id
                         select new { id = s.Id,
                                      productId = p.Id,
                                      code = p.Code,
                                      product = p.Desciption,
                                      quantity = s.Quantity
                                    }).ToList();

            return stock;
        }
    }
}
