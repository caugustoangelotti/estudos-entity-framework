using System;
using System.Collections.Generic;
using gtauto_api.InputModel;
using gtauto_api.ViewModel;

namespace gtauto_api.Services
{
    public interface IClienteService : IDisposable
    {
         ClienteView AddCliente(ClienteInput clienteInputData);
         List<ClienteBasicView> GetClientes(int page, int count);
         List<EnderecoView> GetEnderecos(int idCliente);
         ClienteBasicView GetCliente(int idCliente);
    }
}