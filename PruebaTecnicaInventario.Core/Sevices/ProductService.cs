using PruebaTecnicaInventario.Core.Interfaces;
using PruebaTecnicaInventario.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaInventario.Core.Sevices
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> DeleteProduct(int Id)
        {
            await _unitOfWork.ProductRepository.Delete(Id);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }

        public async Task<Product> GetProduct(int Id)
        {
            return await _unitOfWork.ProductRepository.GetById(Id);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _unitOfWork.ProductRepository.GetAll();
        }

        public async Task InsertProduct(Product product)
        {
            await _unitOfWork.ProductRepository.Add(product);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<bool> UpdateProduct(Product product)
        {
            _unitOfWork.ProductRepository.Update(product);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }
    }
}
