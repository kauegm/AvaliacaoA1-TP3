namespace Aplicacao_A1.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Categoria
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nome { get; set; }

        public virtual ICollection<Produto> Produtos { get; set; } = new List<Produto>();
    }
}
