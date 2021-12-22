using gtauto_api.Entities;
using gtauto_api.InputModel;
using gtauto_api.ViewModel;

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
                enderecoCliente.Complemento = endereco.Rua;
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

        public void Dispose()
        {
            _clienteContext.Dispose();
        }
    }
}