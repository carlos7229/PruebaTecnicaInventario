using PruebaTecnicaInventario.Core.Interfaces;
using PruebaTecnicaInventario.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaInventario.Core.Sevices
{
    public class ClientService : IClientService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ClientService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> DeleteClient(int Id)
        {
            await _unitOfWork.ClentRepository.Delete(Id);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }

        public async Task<Client> GetClient(int Id)
        {
            return await _unitOfWork.ClentRepository.GetById(Id);
        }

        public async Task InsertClient(Client client)
        {
            await _unitOfWork.ClentRepository.Add(client);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<bool> UpdateClient(Client client)
        {
            _unitOfWork.ClentRepository.Update(client);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }

        public IEnumerable<Client> GetClients()
        {
            return _unitOfWork.ClentRepository.GetAll();
        }
    }
}
