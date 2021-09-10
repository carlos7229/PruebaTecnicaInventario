using PruebaTecnicaInventario.Core.Interfaces;
using PruebaTecnicaInventario.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaInventario.Core.Sevices
{
    public class StockService : IStockService
    {
        private readonly IUnitOfWork _unitOfWork;
        public StockService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> DeleteStock(int Id)
        {
            await _unitOfWork.StockRepository.Delete(Id);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }

        public async Task<Stock> GetStock(int Id)
        {
            return await _unitOfWork.StockRepository.GetById(Id);
        }

        public  IEnumerable<object> GetAllStock()
        {
            return  _unitOfWork.StockRepository.GetAllStock();
        }

        public async Task InsertStock(Stock stock)
        {
            await _unitOfWork.StockRepository.Add(stock);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<bool> UpdateStock(Stock stock)
        {
            _unitOfWork.StockRepository.Update(stock);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }
    }
}
