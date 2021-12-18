using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace gtauto_api.Entities
{
    public class Veiculo
    {
        [Key]
        public int IdVeiculo { get; set; }
        public string Placa { get; set; }
        public string Ano { get; set; }
        public string Modelo { get; set; }
        public string Categoria { get; set; }
        public int IdFilial { get; set; }
        public Filial Filial { get; set; }
        public ICollection<Aluguel> Alugueis { get; set; }

        public Veiculo()
        {
            Alugueis = new List<Aluguel>();
        }
    }
}