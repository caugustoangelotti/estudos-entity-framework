using System.ComponentModel.DataAnnotations;

namespace gtauto_api.Entities
{
    public class Telefone
    {
        [Key]
        public int IdTelefone { get; set; }
        public string NumeroTelefone { get; set; }
        public string CodigoPais { get; set; }
        public int? IdCliente { get; set; }
        public Cliente Cliente { get; set; }
        public int? IdFuncionario { get; set; }
        public Funcionario Funcionario { get; set; }
        public int? IdFilial { get; set; } 
        public Filial Filial { get; set; }
    }
}