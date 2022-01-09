using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using gtauto_api.Entities;
using gtauto_api.InputModel;
using gtauto_api.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace gtauto_api.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly GtAutoEfDbContext _clienteContext;
        private readonly IMapper _mapper;
        
        public ClienteRepository(GtAutoEfDbContext clienteContext, IMapper mapper)
        {
            _clienteContext = clienteContext;
            _mapper = mapper;
        }

        public ClienteView AddCliente(ClienteInput clienteInputData)
        {

            Cliente clienteData = _mapper.Map<Cliente>(clienteInputData);
            Endereco enderecoCliente = _mapper.Map<Endereco>(clienteInputData);
            Telefone telefoneCliente = _mapper.Map<Telefone>(clienteInputData);
            
            clienteData.Enderecos.Add(enderecoCliente);
            clienteData.Telefones.Add(telefoneCliente);

            var cliente = _clienteContext.Add(clienteData);
            _clienteContext.SaveChanges();

            ClienteView clienteViewData = _mapper.Map<ClienteView>(cliente.Entity);

            return clienteViewData;
        }

        public List<ClienteBasicView> GetClientes(int page, int count)
        {
            var query = _clienteContext.Clientes
                        .AsNoTracking()
                        .Skip((page - 1) * count)
                        .Take(count)
                        .ToList();

            List<ClienteBasicView> listaClientes = _mapper
                                    .Map<List<Cliente>,List<ClienteBasicView>>(query);

            return listaClientes;
        }

        public List<EnderecoView> GetEnderecos(int idCliente)
        {
            var query = _clienteContext.Enderecos
                        .AsNoTracking()
                        .Where(id => id.IdCliente == idCliente)
                        .ToList();
            
            List<EnderecoView> enderecos = _mapper.Map<List<Endereco>, List<EnderecoView>>(query);

            return enderecos;
        }

        public List<TelefoneView> GetTelefones(int idCliente)
        {
            var query = _clienteContext.Telefones
                        .AsNoTracking()
                        .Where(id => id.IdCliente == idCliente)
                        .ToList();

            List<TelefoneView> telefones = _mapper.Map<List<Telefone>, List<TelefoneView>>(query);

            return telefones;
        }

        public ClienteBasicView GetCliente(int idCliente)
        {
            Cliente cliente = _clienteContext.Clientes
                            .SingleOrDefault(id => id.IdCliente == idCliente);
            
            if (cliente == null)
                return null;
            
            ClienteBasicView clienteView = _mapper.Map<Cliente, ClienteBasicView>(cliente);

            return clienteView;
        }
        
        public List<VeiculoView> GetVeiculosAlugados(int idCliente, int page, int count)
        {
            var queryVeiculos = (from veiculo in _clienteContext.Veiculos
                                where veiculo.Alugueis.Any(q => q.IdCliente == idCliente)
                                select veiculo)
                                .AsNoTracking()
                                .Skip((page - 1) * count)
                                .Take(count)
                                .ToList();

            List<VeiculoView> listaVeiculos = _mapper.Map<List<Veiculo>, List<VeiculoView>>(queryVeiculos);

            return listaVeiculos;
        }

        public List<VeiculoView> GetVeiculosDevolvidos(int idCliente, int page, int count)
        {

            var queryVeiculos = (from veiculo in _clienteContext.Veiculos
                                where veiculo.Devolucoes.Any(q => q.IdCliente == idCliente)
                                select veiculo)
                                .AsNoTracking()
                                .Skip((page - 1) * count)
                                .Take(count)
                                .ToList();

            List<VeiculoView> listaVeiculos = _mapper.Map<List<Veiculo>, List<VeiculoView>>(queryVeiculos);

            return listaVeiculos;    
        }

        public List<EnderecoView> AddEndereco(int idCliente , EnderecoInput enderecoInputData)
        {
            Cliente cliente = _clienteContext.Clientes
                            .SingleOrDefault(id => id.IdCliente == idCliente);
            
            if (cliente == null)
                return null;
            
            Endereco enderecoDaoData = _mapper.Map<EnderecoInput, Endereco>(enderecoInputData);
            enderecoDaoData.IdCliente = cliente.IdCliente;

            cliente.Enderecos.Add(enderecoDaoData);
            _clienteContext.SaveChanges();

            var query = _clienteContext.Enderecos
                        .AsNoTracking()
                        .Where(id => id.IdCliente == idCliente)
                        .ToList();
            
            List<EnderecoView> enderecos = _mapper.Map<List<Endereco>, List<EnderecoView>>(query);

            return enderecos;

        }

        public List<TelefoneView> AddTelefone(int idCliente, TelefoneInput telefoneInputData)
        {
            Cliente cliente = _clienteContext.Clientes
                            .SingleOrDefault(id => id.IdCliente == idCliente);
            
            if (cliente == null)
                return null;
            
            Telefone telefoneDaoData = _mapper.Map<TelefoneInput, Telefone>(telefoneInputData);
            telefoneDaoData.IdCliente = cliente.IdCliente;

            cliente.Telefones.Add(telefoneDaoData);
            _clienteContext.SaveChanges();

            var query = _clienteContext.Telefones
                        .AsNoTracking()
                        .Where(id => id.IdCliente == idCliente)
                        .ToList();
            
            List<TelefoneView> telefones = _mapper.Map<List<Telefone>, List<TelefoneView>>(query);

            return telefones;

        }

        public void Dispose()
        {
            _clienteContext.Dispose();
        }
    }
}