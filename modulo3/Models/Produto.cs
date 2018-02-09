using System.ComponentModel.DataAnnotations;

namespace modulo3.Models
{
    public class Produto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public int Preco { get; set; }
    }
}
