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
            var clientesList = _clienteContext.Clientes
                            .AsNoTracking()
                            .Skip((page - 1) * count)
                            .Take(count)
                            .ToList();
            
            var clientesView = new List<ClienteBasicView>();

            foreach (Cliente cliente in clientesList)
            {
                var clienteView = new ClienteBasicView{
                    IdCliente = cliente.IdCliente,
                    Nome = cliente.Nome,
                    Sobrenome = cliente.Sobrenome,
                    DataNascimento = cliente.DataNascimento,
                    Cpf = cliente.Cpf,
                    Email = cliente.Email
                };
                
                clientesView.Add(clienteView);
            }

            return clientesView;
        }

        public List<EnderecoView> GetEnderecos(int idCliente)
        {
            var query = _clienteContext.Enderecos
                        .AsNoTracking()
                        .Where(id => id.IdCliente == idCliente)
                        .ToList();
                
            var listaEnderecos = new List<EnderecoView>();

            foreach (Endereco endereco in query)
            {
                var viewEndereco = new EnderecoView{
                    Uf = endereco.Uf,
                    Cidade = endereco.Cidade,
                    Bairro = endereco.Bairro,
                    Rua = endereco.Rua,
                    Numero = endereco.Numero,
                    Cep = endereco.Cep,
                    Referencia = endereco.Referencia,
                    Complemento = endereco.Complemento
                };

                listaEnderecos.Add(viewEndereco);
            }

            return listaEnderecos;
        }

        public List<TelefoneView> GetTelefones(int idCliente)
        {
            var query = _clienteContext.Telefones
                        .AsNoTracking()
                        .Where(id => id.IdCliente == idCliente)
                        .ToList();
                
            var listaTelefones = new List<TelefoneView>();

            foreach (Telefone telefone in query)
            {
                var viewTelefone = new TelefoneView{
                    NumeroTelefone = telefone.NumeroTelefone,
                    CodigoPais = telefone.CodigoPais
                };

                listaTelefones.Add(viewTelefone);
            }

            return listaTelefones;
        }

        public ClienteBasicView GetCliente(int idCliente)
        {
            Cliente cliente = _clienteContext.Clientes
                    .SingleOrDefault(id => id.IdCliente == idCliente);
            
            if ( cliente == null )
                return null;

            var clienteView = new ClienteBasicView{
                IdCliente = cliente.IdCliente,
                Nome = cliente.Nome,
                Sobrenome = cliente.Sobrenome,
                DataNascimento = cliente.DataNascimento,
                Cpf = cliente.Cpf,
                Email = cliente.Email
            };

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
            
            var listaVeiculos = new List<VeiculoView>();

            foreach (Veiculo veiculo in queryVeiculos)
            {
                var veiculoView = new VeiculoView{
                    IdVeiculo = veiculo.IdVeiculo,
                    Placa = veiculo.Placa,
                    Ano = veiculo.Ano,
                    Modelo = veiculo.Modelo,
                    Categoria = veiculo.Categoria
                };
                listaVeiculos.Add(veiculoView);
            }
            
            return listaVeiculos;
        }

        public List<VeiculoView> GetVeiculosDevolvidos(int idCliente, int page, int count)
        {

            var queryVeiculos = (from veiculo in _clienteContext.Veiculos
                                where veiculo.Devolucoes.Any(c => c.IdCliente == idCliente)
                                select veiculo)
                                .AsNoTracking()
                                .Skip((page - 1) * count)
                                .Take(count)
                                .ToList();

            var listaVeiculos = new List<VeiculoView>();

            foreach (Veiculo veiculo in queryVeiculos)
            {
                var veiculoView = new VeiculoView{
                    IdVeiculo = veiculo.IdVeiculo,
                    Placa = veiculo.Placa,
                    Ano = veiculo.Ano,
                    Modelo = veiculo.Modelo,
                    Categoria = veiculo.Categoria
                };
                listaVeiculos.Add(veiculoView);
            }
            
            return listaVeiculos;
        }

        public void Dispose()
        {
            _clienteContext.Dispose();
        }
    }
}