using System.ComponentModel.DataAnnotations;

namespace Spedizioni.Models
{
    public class Cliente
    {
        public enum Tipo { Privato, Azienda }
        [Key]
        public int Id { get; set; }
        [Required]
        public string Identificativo { get; set; }
        [Required]
        public string Nome { get; set; }

    }
}
