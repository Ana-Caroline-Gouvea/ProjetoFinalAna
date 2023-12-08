using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinalAna.Models
{
    [Table("ProcedimentoRealizado")]
    public class ProcedimentoRealizado
    {
        [Column("Id")]
        [Display(Name = "Código da Realizção do Procedimento")]
        public int Id { get; set; }

        [ForeignKey("ClienteId")]
        [Display(Name = "Cliente")]
        public int? ClienteId { get; set; }
        public Cliente? Cliente { get; set; }

        [ForeignKey("ProcedimentoId")]
        [Display(Name = "Procedimento")]
        public int? ProcedimentoId { get; set; }
        public Procedimento? Procedimento { get; set; }

        [ForeignKey("ColaboradorId")]
        [Display(Name = "Colaborador")]
        public int? ColaboradorId { get; set; }
        public Colaborador? Colaborador { get; set; }

        [ForeignKey("LocalRealizacaoId")]
        [Display(Name = "Local")]
        public int? LocalRealizacaoId { get; set; }
        [Display(Name = "Local")]
        public LocalRealizacao? LocalRealizacao { get; set; }

        [Column("DataRealizacao")]
        [Display(Name = "Data")]
        public DateTime DataRealizacao { get; set; }

        [Column("ObservacaoRealizacao")]
        [Display(Name = "Observação")]
        public string ObservacaoRealizacao { get; set; } = string.Empty;


    }
}
