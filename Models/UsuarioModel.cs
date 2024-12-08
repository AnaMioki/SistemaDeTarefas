using System.ComponentModel.DataAnnotations;

namespace SistemaDeTarefas.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        public bool Email { get; set; }
    }
}
