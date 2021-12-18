using System;
using System.ComponentModel.DataAnnotations;

namespace gtauto_api.Entities
{
    public class Devolucao
    {
        [Key]
        public int IdDevolucao { get; set; }
        public DateTime DataDevolucao { get; set; }
        public int IdAluguel { get; set; }
        public Aluguel Aluguel { get; set; }
        public int IdFuncionario { get; set; }
        public Funcionario Funcionario { get; set; }
        public int IdFilial { get; set; }
        public Filial Filial { get; set; }
    }
}