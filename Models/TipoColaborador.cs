using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinalAna.Models
{
    [Table("TipoColaborador")]
    public class TipoColaborador
    {
        [Column("Id")]
        [Display(Name = "Código do Tipo de Colaborador")]
        public int Id { get; set; }

        [Column("TipoColaboradorNome")]
        [Display(Name = "Nome")]
        public string TipoColaboradorNome { get; set; } = string.Empty;


    }
}
