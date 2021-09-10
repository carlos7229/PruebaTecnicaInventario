using PruebaTecnicaInventario.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaInventario.Core.Interfaces
{
    public interface IProductService
    {
        Task<Product> GetProduct(int Id);
        IEnumerable<Product> GetProducts();
        Task InsertProduct(Product product);
        Task<bool> UpdateProduct(Product product);
        Task<bool> DeleteProduct(int Id);
    }
}
