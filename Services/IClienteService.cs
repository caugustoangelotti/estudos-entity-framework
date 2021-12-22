using System;
using gtauto_api.InputModel;
using gtauto_api.ViewModel;

namespace gtauto_api.Services
{
    public interface IClienteService : IDisposable
    {
         ClienteView AddCliente(ClienteInput clienteInputData);
    }
}