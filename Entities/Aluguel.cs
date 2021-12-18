using System;
using System.ComponentModel.DataAnnotations;

namespace gtauto_api.Entities
{
    public class Aluguel
    {
        [Key]
        public int IdAluguel { get; set; }
        public DateTime DataAluguel { get; set; }
        public int IdVeiculo { get; set; }
        public Veiculo Veiculo { get; set; }
        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; }
        public int IdFuncionario { get; set; }
        public Funcionario Funcionario { get; set; }
        public int IdFilial { get; set; }
        public Filial Filial { get; set; }
        public Devolucao Devolucao { get; set; }
    }
}