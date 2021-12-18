using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace gtauto_api.Entities
{
    public class Filial
    {
        [Key]
        public int IdFilial { get; set; }
        public string NomeFantasia { get; set; }
        public string Cnpj { get; set; }
        public ICollection<Funcionario> Funcionarios { get; set; }
        public ICollection<Endereco> Enderecos { get; set; }
        public ICollection<Telefone> Telefones { get; set; }
        public ICollection<Veiculo> Veiculos { get; set; }
        public ICollection<Aluguel> Alugueis { get; set; }
        public ICollection<Devolucao> Devolucoes { get; set; }
        
        public Filial()
        {
            Funcionarios = new List<Funcionario>();
            Enderecos = new List<Endereco>();
            Telefones = new List<Telefone>();
            Alugueis = new List<Aluguel>();
            Devolucoes = new List<Devolucao>();
        }
    }
}