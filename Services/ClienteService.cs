using System.Collections.Generic;
using System.Linq;
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

        public List<EnderecoView> GetEnderecos(int idCliente)
        {
            List<EnderecoView> listaEnderecos = _clienteRepository.GetEnderecos(idCliente);

            if (listaEnderecos == null)
                return null;

            return listaEnderecos;
        }

        public List<TelefoneView> GetTelefones(int idCliente)
        {
            List<TelefoneView> listaTelefones = _clienteRepository.GetTelefones(idCliente);

            if (listaTelefones == null || !listaTelefones.Any())
                return null;

            return listaTelefones;
        }

        public ClienteBasicView GetCliente(int idCliente)
        {
            ClienteBasicView clienteData = _clienteRepository.GetCliente(idCliente);
            if (clienteData == null)
                return null;
            return clienteData;
        }

        public List<VeiculoView> GetVeiculosAlugados(int idCliente, int page, int count)
        {
            List<VeiculoView> listaVeiculos = _clienteRepository.GetVeiculosAlugados(idCliente, page, count);
            return listaVeiculos;
        }

        public void Dispose()
        {
            _clienteRepository.Dispose();
        }
    }
}