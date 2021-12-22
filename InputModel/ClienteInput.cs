using System;

namespace gtauto_api.InputModel
{
    public class ClienteInput
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Uf { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Cep { get; set; }
        public string Referencia { get; set; }
        public string Complemento { get; set; }
        public string NumeroTelefone { get; set; }
        public string CodigoPais { get; set; }
    }
}