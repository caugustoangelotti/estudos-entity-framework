using System.ComponentModel.DataAnnotations;

namespace gtauto_api.Entities
{
    public class Endereco
    {
        [Key]
        public int IdEndereco { get; set; }
        public string Uf { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Cep { get; set; }
        public string Referencia { get; set; }
        public string Complemento { get; set; }
        public int? IdCliente { get; set; }
        public Cliente Cliente { get; set; }
        public int? IdFuncionario { get; set; }
        public Funcionario Funcionario { get; set; }
        public int? IdFilial { get; set; }
        public Filial Filial { get; set; }
    }
}