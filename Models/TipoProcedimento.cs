using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinalAna.Models
{
    [Table("TipoProcedimento")]
    public class TipoProcedimento
    {
        [Column("Id")]
        [Display(Name = "Código do Tipo de Procedimento")]
        public int Id { get; set; }

        [Column("TipoProcedimentoNome")]
        [Display(Name = "Nome")]
        public string TipoProcedimentoNome { get; set; }= string.Empty;
    }
}
