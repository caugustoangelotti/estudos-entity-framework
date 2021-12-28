using System.Collections.Generic;
using System.Linq;
using gtauto_api.Entities;
using gtauto_api.InputModel;
using gtauto_api.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace gtauto_api.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly GtAutoEfDbContext _clienteContext;
        
        public ClienteRepository(GtAutoEfDbContext clienteContext)
        {
            _clienteContext = clienteContext;
        }

        public ClienteView AddCliente(ClienteInput clienteInputData)
        {
            var clienteEndereco = new Endereco{
                Uf = clienteInputData.Uf,
                Cidade = clienteInputData.Cidade,
                Bairro = clienteInputData.Bairro,
                Rua = clienteInputData.Rua,
                Numero = clienteInputData.Numero,
                Cep = clienteInputData.Cep,
                Referencia = clienteInputData.Referencia,
                Complemento = clienteInputData.Complemento
            };

            var telefoneCliente = new Telefone{
                NumeroTelefone = clienteInputData.NumeroTelefone,        
                CodigoPais = clienteInputData.CodigoPais
            };

            var clienteData = new Cliente{
                Nome = clienteInputData.Nome,
                Sobrenome = clienteInputData.Sobrenome,
                DataNascimento = clienteInputData.DataNascimento,
                Cpf = clienteInputData.Cpf,
                Email = clienteInputData.Email,
                Enderecos = {clienteEndereco},
                Telefones = {telefoneCliente}
            };

            var cliente = _clienteContext.Add(clienteData);
            _clienteContext.SaveChanges();
            
            var clienteViewData = new ClienteView{
                IdCliente = cliente.Entity.IdCliente,
                Nome = cliente.Entity.Nome,
                Sobrenome = cliente.Entity.Sobrenome,
                DataNascimento = cliente.Entity.DataNascimento,
                Cpf = cliente.Entity.Cpf,
                Email = cliente.Entity.Email
            };

            foreach (Endereco endereco in cliente.Entity.Enderecos)
            {
                var enderecoCliente = new EnderecoView();
                enderecoCliente.Uf = endereco.Uf;
                enderecoCliente.Cidade = endereco.Cidade;
                enderecoCliente.Bairro = endereco.Bairro;
                enderecoCliente.Rua = endereco.Rua;
                enderecoCliente.Numero = endereco.Numero;
                enderecoCliente.Cep = endereco.Cep;
                enderecoCliente.Referencia = endereco.Referencia;
                enderecoCliente.Complemento = endereco.Complemento;
                clienteViewData.Enderecos.Add(enderecoCliente);
            }

            foreach (Telefone telefone in cliente.Entity.Telefones)
            {
                var clienteTelefone = new TelefoneView();
                clienteTelefone.CodigoPais = telefone.CodigoPais;
                clienteTelefone.NumeroTelefone = telefone.NumeroTelefone;
                clienteViewData.Telefones.Add(clienteTelefone);
            }

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

        public void Dispose()
        {
            _clienteContext.Dispose();
        }
    }
}