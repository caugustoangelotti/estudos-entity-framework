using System;
using System.Collections.Generic;

namespace gtauto_api.ViewModel
{
    public class ClienteView
    {
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public ICollection<EnderecoView> Enderecos { get; set; }
        public ICollection<TelefoneView> Telefones { get; set; }

        public ClienteView()
        {
            Enderecos = new List<EnderecoView>();
            Telefones = new List<TelefoneView>();
        }
    }
}