using System;
using System.Collections.Generic;
using gtauto_api.InputModel;
using gtauto_api.ViewModel;

namespace gtauto_api.Repositories
{
    public interface IClienteRepository : IDisposable
    {
        ClienteView AddCliente(ClienteInput clienteInputData);
        List<EnderecoView> AddEndereco(int idCliente , EnderecoInput enderecoInputData);
        List<TelefoneView> AddTelefone(int idCliente , TelefoneInput telefoneInputData);
        List<ClienteBasicView> GetClientes(int page, int count);
        List<EnderecoView> GetEnderecos(int idCliente);
        List<TelefoneView> GetTelefones(int idCliente);
        List<VeiculoView> GetVeiculosAlugados(int idCliente, int page, int count);
        List<VeiculoView> GetVeiculosDevolvidos(int idCliente, int page, int count);
        ClienteBasicView GetCliente(int idCliente);
    }
}