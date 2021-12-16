using gtauto_api.Repositories;

namespace gtauto_api.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        
        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}