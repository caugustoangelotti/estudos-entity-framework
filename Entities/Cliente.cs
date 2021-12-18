using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace gtauto_api.Entities
{
    public class Cliente
    {   
        [Key]
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public ICollection<Endereco> Enderecos { get; set; }
        public ICollection<Telefone> Telefones { get; set; }
        public ICollection<Aluguel> Alugueis { get; set; }
        
        public Cliente()
        {
            Enderecos = new List<Endereco>();
            Telefones = new List<Telefone>();
            Alugueis = new List<Aluguel>();
        }
    }
}