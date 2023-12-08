using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinalAna.Models
{
    [Table("Colaborador")]
    public class Colaborador
    {
        [Column("Id")]
        [Display(Name = "Código do Colaborador")]
        public int Id { get; set; }

        [Column("ColaboradorNome")]
        [Display(Name = "Nome")]
        public string ColaboradorNome { get; set; } = string.Empty;

        [Column("ColaboradorCpf")]
        [Display(Name = "CPF")]
        public string ColaboradorCpf { get; set; } = string.Empty;

        [Column("ColaboradorSexo")]
        [Display(Name = "Sexo")]
        public string ColaboradorSexo { get; set; } = string.Empty;

        [Column("ColaboradorTelefone")]
        [Display(Name = "Telefone")]
        public string ColaboradorTelefone { get; set; } = string.Empty;

        [ForeignKey("CidadeId")]
        [Display(Name = "Cidade")]
        public int CidadeId { get; set; }
        public Cidade? Cidade { get; set; }

        [ForeignKey("TipoColaboradorId")]
        [Display(Name = "Tipo de Colaborador")]
        public int TipoColaboradorId { get; set; }
        [Display(Name = "Tipo de Colaborador")]
        public TipoColaborador? TipoColaborador { get; set; }
    }
}
