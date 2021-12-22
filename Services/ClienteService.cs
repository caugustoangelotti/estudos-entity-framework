using gtauto_api.Entities;
using gtauto_api.InputModel;
using gtauto_api.Repositories;
using gtauto_api.ViewModel;

namespace gtauto_api.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public ClienteView AddCliente(ClienteInput clienteInputData)
        {
            var cliente = _clienteRepository.AddCliente(clienteInputData);
            return cliente;
        }

        public void Dispose()
        {
            _clienteRepository.Dispose();
        }
    }
}