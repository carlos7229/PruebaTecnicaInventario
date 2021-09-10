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
    public class SaleRepository : BaseRepository<Sale>, ISaleRepository
    {
        PruebaTecnicaInventarioContext _context;

        public SaleRepository(PruebaTecnicaInventarioContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<object> GetSales()
        {
            var sales = (from s in _context.Sales
                         join p in _context.Products                         
                         on s.ProductId equals p.Id
                         join c in _context.Clients
                         on s.ClientId equals c.Id
                         select new { id = s.Id,
                                      code = p.Code,
                                      product = p.Desciption,
                                      quantity = s.SaleQuantity,
                                      saleValue = s.SaleQuantity * p.Value,
                                      saleDate = s.SaleDate
                                    }).ToList();

            return sales;
        }

       
    }
}
