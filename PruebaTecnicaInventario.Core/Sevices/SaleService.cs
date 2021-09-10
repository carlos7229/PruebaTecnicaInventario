using PruebaTecnicaInventario.Core.Interfaces;
using PruebaTecnicaInventario.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaInventario.Core.Sevices
{
    public class SaleService : ISaleService
    {
        private readonly IUnitOfWork _unitOfWork;
        public SaleService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> DeleteSale(int Id)
        {
            await _unitOfWork.SaleRepository.Delete(Id);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }

        public async Task<Sale> GetSale(int Id)
        {
            return await _unitOfWork.SaleRepository.GetById(Id);
        }

        public  IEnumerable<object> GetSales()
        {
            return _unitOfWork.SaleRepository.GetSales();
        }

        public async Task InsertSale(Sale shopping)
        {
            await _unitOfWork.SaleRepository.Add(shopping);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<bool> UpdateSale(Sale shopping)
        {
            _unitOfWork.SaleRepository.Update(shopping);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }
    }
}
