using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinalAna.Models
{
    [Table("Estado")]
    public class Estado
    {
        [Column("Id")]
        [Display(Name = "Código do Estado")]
        public int Id { get; set; }

        [Column("EstadoNome")]
        [Display(Name = "Nome")]
        public string EstadoNome { get; set; } = string.Empty;
    }
}
