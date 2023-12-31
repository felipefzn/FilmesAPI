using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models
{
    public class Filme
    {
        [Required(ErrorMessage = "O Titulo do filme é obrigatório!")]
        [MaxLength(100, ErrorMessage = "O tamanho máximo do titulo é de 100 caracteres!")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O genero do filme é obrigatório!")]
        [MaxLength(50, ErrorMessage = "O tamanho do genero nao pode exceder 50 caracteres!")]
        public string Genero { get; set; }

        [Required]
        [Range(70, 400, ErrorMessage = "A duracao deve ser entre 70 e 400 minutos")]
        public int Duracao { get; set; }
    }
}
