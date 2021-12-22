using System.Collections.Generic;
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
            ClienteView cliente = _clienteRepository.AddCliente(clienteInputData);
            return cliente;
        }

        public List<ClienteBasicView> GetClientes(int page, int count)
        {
            List<ClienteBasicView> listaClientes = _clienteRepository.GetClientes(page,count);
            return listaClientes;
        }

        public void Dispose()
        {
            _clienteRepository.Dispose();
        }
    }
}