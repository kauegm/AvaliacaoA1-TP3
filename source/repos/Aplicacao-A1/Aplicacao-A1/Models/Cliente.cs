namespace Aplicacao_A1.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Cliente
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string Telefone { get; set; }

        [StringLength(200)]
        public string Endereco { get; set; }
    }

}
