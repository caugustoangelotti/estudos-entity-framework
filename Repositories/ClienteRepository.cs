using gtauto_api.Entities;

namespace gtauto_api.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly GtAutoEfDbContext _clienteContext;
        
        public ClienteRepository(GtAutoEfDbContext clienteContext)
        {
            _clienteContext = clienteContext;
        }


        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}