using System.ComponentModel.DataAnnotations;

namespace Aplicacao_A1.Models
{
    public class Estoque
    {
        public int Id { get; set; }

        [Required]
        public int ProdutoId { get; set; }

        public Produto? Produto { get; set; }

        public int Quantidade { get; set; } // Quantidade disponível no estoque
    }

}
