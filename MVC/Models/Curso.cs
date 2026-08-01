using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class Curso
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;

        [Range(1, int.MaxValue, ErrorMessage = "A carga horária deve ser maior que zero.")]
        public int CargaHoraria { get; set; }
    }
}