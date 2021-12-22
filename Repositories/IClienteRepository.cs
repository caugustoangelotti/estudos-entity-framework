using System;
using gtauto_api.InputModel;
using gtauto_api.ViewModel;

namespace gtauto_api.Repositories
{
    public interface IClienteRepository : IDisposable
    {
        ClienteView AddCliente(ClienteInput clienteInputData);
    }
}