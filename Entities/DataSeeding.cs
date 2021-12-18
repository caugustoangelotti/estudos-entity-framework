using System;
using System.Collections.Generic;

namespace gtauto_api.Entities
{
    public class DataSeeding
    {
        public List<Cliente> Clientes { get; set; }
        public List<Veiculo> Veiculos { get; set; }
        public List<Endereco> Enderecos { get; set; }
        public List<Telefone> Telefones { get; set; }
        public List<Funcionario> Funcionarios { get; set; }
        public List<Filial> Filiais { get; set; }
        public List<Aluguel> Alugueis { get; set; }
        public List<Devolucao> Devolucoes { get; set; }

        public DataSeeding()
        {
            Clientes = CreateClienteData();
            Filiais = CreateFilialData();
            Funcionarios = CreateFuncionarioData();
            Telefones = CreateTelefoneData();
            Enderecos = CreateEnderecoData();
            Veiculos = CreateVehicleData();
            Alugueis = CreateAluguelData();
            Devolucoes = CreateDevolucaoData();
        }

        public List<Cliente> CreateClienteData()
        {
            var c1 = new Cliente{
                IdCliente = 1, 
                Nome = "Garry", 
                Sobrenome = "Kasparov", 
                DataNascimento = new DateTime(1965,01,10), 
                Cpf = "09758123784", 
                Email = "garry@mail.com"
            };
            var c2 = new Cliente{
                IdCliente = 2, 
                Nome = "Anatoly", 
                Sobrenome = "Karpov", 
                DataNascimento = new DateTime(1960,05,21), 
                Cpf = "79857403185", 
                Email = "karpov@mail.com"
            };

            var listaClientes = new List<Cliente>();

            listaClientes.Add(c1);
            listaClientes.Add(c2);

            return listaClientes;
        }

        public List<Filial> CreateFilialData()
        {
            var listaFiliais = new List<Filial>();

            var f1 = new Filial{
                IdFilial = 1,
                NomeFantasia = "GtAuto Varzea Grande",
                Cnpj = "70603205000147"        
            };

            var f2 = new Filial{
                IdFilial = 2,
                NomeFantasia = "GtAuto Cuiaba",
                Cnpj = "70170979000121"        
            };

            listaFiliais.Add(f1);
            listaFiliais.Add(f2);

            return listaFiliais;
        }

        public List<Funcionario> CreateFuncionarioData()
        {
            var listaFuncionarios = new List<Funcionario>();

            var f1 = new Funcionario{
                IdFuncionario = 1,
                Nome = "Mikhail",        
                Sobrenome = "Tal",
                DataNascimento = new DateTime(1997,12,05),
                Cpf = "65412387621",
                Email = "tal@mail.com",
                IdFilial = 2
            };

            var f2 = new Funcionario{
                IdFuncionario = 2,
                Nome = "Vasyl",        
                Sobrenome = "Ivanchuck",
                DataNascimento = new DateTime(1968,03,10),
                Cpf = "97834268712",
                Email = "ivanchuck@mail.com",
                IdFilial = 1
            };

            listaFuncionarios.Add(f1);
            listaFuncionarios.Add(f2);

            return listaFuncionarios;
        }

        public List<Telefone> CreateTelefoneData()
        {
            var listaTelefones = new List<Telefone>();

            var tel1 = new Telefone{
                IdTelefone = 1,
                CodigoPais = "15",
                NumeroTelefone = "65981549785",
                IdCliente = 1
            };

            var tel2 = new Telefone{
                IdTelefone = 2,
                CodigoPais = "15",
                NumeroTelefone = "65981473274",
                IdCliente = 2
            };

            var tel3 = new Telefone{
                IdTelefone = 3,
                CodigoPais = "15",
                NumeroTelefone = "65978413025",
                IdFuncionario = 1
            };

            var tel4 = new Telefone{
                IdTelefone = 4,
                CodigoPais = "15",
                NumeroTelefone = "65978452136",
                IdFuncionario = 2
            };

            var tel5 = new Telefone{
                IdTelefone = 5,
                CodigoPais = "15",
                NumeroTelefone = "6537458974",
                IdFilial = 1
            };

            var tel6 = new Telefone{
                IdTelefone = 6,
                CodigoPais = "15",
                NumeroTelefone = "6538741897",
                IdFilial = 2
            };

            
            listaTelefones.Add(tel1);
            listaTelefones.Add(tel2);
            listaTelefones.Add(tel3);
            listaTelefones.Add(tel4);
            listaTelefones.Add(tel5);
            listaTelefones.Add(tel6);
        

            return listaTelefones;
        }

        public List<Endereco> CreateEnderecoData()
        {
            var listaEnderecos = new List<Endereco>();
    
            var end1 = new Endereco{
                IdEndereco = 1,
                Uf = "MT",
                Cidade = "Varzea Grande",
                Bairro = "Centro",
                Rua = "Av. Central",
                Numero = "S/N",
                Cep = "78118182",
                Referencia = "Proximo escola",
                Complemento = "Entrada pela parte de tras",
                IdFilial = 1
            };

            var end2 = new Endereco{
                IdEndereco = 2,
                Uf = "MT",
                Cidade = "Cuiaba",
                Bairro = "Boa Esperanca",
                Rua = "Av. Moinho",
                Numero = "1312",
                Cep = "78068300",
                Referencia = "Proximo escola",
                Complemento = "",
                IdFilial = 2
            };

            var end3 = new Endereco{
                IdEndereco = 3,
                Uf = "SP",
                Cidade = "Sao Paulo",
                Bairro = "Ermelino Matarazzo",
                Rua = "RUA 16",
                Numero = "12",
                Cep = "698754320",
                Referencia = "Proximo shopping",
                Complemento = "",
                IdCliente = 1
            };

            var end4 = new Endereco{
                IdEndereco = 4,
                Uf = "MT",
                Cidade = "Sinop",
                Bairro = "Central",
                Rua = "Av. Doze",
                Numero = "315",
                Cep = "74520197",
                Referencia = "Proximo casas bahia",
                Complemento = "",
                IdCliente = 1
            };

            var end5 = new Endereco{
                IdEndereco = 5,
                Uf = "PR",
                Cidade = "Umuarama",
                Bairro = "Perimetral",
                Rua = "121",
                Numero = "5564",
                Cep = "36874987",
                Referencia = "",
                Complemento = "",
                IdCliente = 2
            };

            var end6 = new Endereco{
                IdEndereco = 6,
                Uf = "MS",
                Cidade = "Campo Grande",
                Bairro = "Grande Terceiro",
                Rua = "12",
                Numero = "5",
                Cep = "32587410",
                Referencia = "",
                Complemento = "",
                IdFuncionario = 1
            };

            var end7 = new Endereco{
                IdEndereco = 7,
                Uf = "MT",
                Cidade = "Varzea Grande",
                Bairro = "Cristo Rei",
                Rua = "rua 9",
                Numero = "12",
                Cep = "78118218",
                Referencia = "",
                Complemento = "",
                IdFuncionario = 2
            };
            
            listaEnderecos.Add(end1);
            listaEnderecos.Add(end2);
            listaEnderecos.Add(end3);
            listaEnderecos.Add(end4);
            listaEnderecos.Add(end5);
            listaEnderecos.Add(end6);
            listaEnderecos.Add(end7);

            return listaEnderecos;
        }

        public List<Veiculo> CreateVehicleData()
        {
            var listaVeiculos = new List<Veiculo>();

            var v1 = new Veiculo{
                IdVeiculo = 1,
                Placa = "OBJ1231",
                Ano = "2020/21",
                Modelo = "VW Golf Gti",
                Categoria = "Luxo",
                IdFilial = 1
            };

            var v2 = new Veiculo{
                IdVeiculo = 2,
                Placa = "HVH1010",
                Ano = "2020/21",
                Modelo = "Fiat Estrada",
                Categoria = "Utilitario",
                IdFilial = 2
            };

            var v3 = new Veiculo{
                IdVeiculo = 3,
                Placa = "NGJ1231",
                Ano = "2020/21",
                Modelo = "Fiat Toro",
                Categoria = "Luxo/Utilitario",
                IdFilial = 1
            };

            var v4 = new Veiculo{
                IdVeiculo = 4,
                Placa = "NBM1290",
                Ano = "2020/21",
                Modelo = "Land Rover Evoque",
                Categoria = "Luxo",
                IdFilial = 2
            };

            var v5 = new Veiculo{
                IdVeiculo = 5,
                Placa = "PIY7689",
                Ano = "2021/22",
                Modelo = "Fait Uno",
                Categoria = "Popular",
                IdFilial = 1
            };

            var v6 = new Veiculo{
                IdVeiculo = 6,
                Placa = "GRU3412",
                Ano = "2010/11",
                Modelo = "VW Up",
                Categoria = "Popular",
                IdFilial = 1
            };

            listaVeiculos.Add(v1);
            listaVeiculos.Add(v2);
            listaVeiculos.Add(v3);
            listaVeiculos.Add(v4);
            listaVeiculos.Add(v5);
            listaVeiculos.Add(v6);

            return listaVeiculos;
        }

        public List<Aluguel> CreateAluguelData()
        {
            var listaAlugueis = new List<Aluguel>();

            var a1 = new Aluguel{
                IdAluguel = 1,
                DataAluguel = DateTime.Now,
                IdVeiculo = 6,
                IdCliente = 1,
                IdFilial = 1,
                IdFuncionario = 2
            };

            var a2 = new Aluguel{
                IdAluguel = 2,
                DataAluguel = DateTime.Now,
                IdVeiculo = 3,
                IdCliente = 1,
                IdFilial = 2,
                IdFuncionario = 1
            };

            var a3 = new Aluguel{
                IdAluguel = 3,
                DataAluguel = DateTime.Now,
                IdVeiculo = 4,
                IdCliente = 1,
                IdFilial = 2,
                IdFuncionario = 1
            };

            listaAlugueis.Add(a1);
            listaAlugueis.Add(a2);
            listaAlugueis.Add(a3);

            return listaAlugueis;
        }

        public List<Devolucao> CreateDevolucaoData()
        {
            var listaDevolucoes = new List<Devolucao>();

            var d1 = new Devolucao{
                IdDevolucao = 1,
                DataDevolucao = DateTime.Now,
                IdAluguel = 2,
                IdFuncionario = 2,
                IdFilial = 1
            };

            var d2 = new Devolucao{
                IdDevolucao = 1,
                DataDevolucao = DateTime.Now,
                IdAluguel = 3,
                IdFuncionario = 1,
                IdFilial = 2
            };

            listaDevolucoes.Add(d1);
            listaDevolucoes.Add(d2);
            
            return listaDevolucoes;
        }
    }

}