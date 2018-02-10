using System.ComponentModel.DataAnnotations;

namespace modulo3.Models
{
    public class Produto
    {
        [Required(ErrorMessage = "Campo é obrigatório")]
        [Range(1, 10, ErrorMessage = "O valor do {0} tem que estar entre {1} e {2}.")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo é obrigatório")]
        [MinLength(3, ErrorMessage = "O valor do {0} tem que ser maior que  {1}")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo é obrigatório")]
        [Range(20, 50, ErrorMessage = "O valor do {0} tem que estar entre {1} e {2}.")]
        public int Preco { get; set; }
    }
}
