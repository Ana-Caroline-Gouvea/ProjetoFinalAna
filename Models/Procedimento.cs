using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinalAna.Models
{
    [Table("Procedimento")]
    public class Procedimento
    {
        [Column("Id")]
        [Display(Name = "Código da Realizção do Procedimento")]
        public int Id { get; set; }

        [Column("ProcedimentoNome")]
        [Display(Name = "Nome")]
        public string ProcedimentoNome { get; set; } = string.Empty;

        [Column("ProcedimentoObservacao")]
        [Display(Name = "Observação")]
        public string ProcedimentoObservacao { get; set; } = string.Empty;

        [ForeignKey("TipoProcedimentoId")]
        [Display(Name = "Tipo do Procedimento")]
        public int TipoProcedimentoId { get; set; }
        [Display(Name = "Tipo do Procedimento")]
        public TipoProcedimento? TipoProcedimento { get; set; }

    }
}
