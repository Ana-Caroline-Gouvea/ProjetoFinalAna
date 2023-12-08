using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinalAna.Models
{
    [Table("LocalRealizacao")]
    public class LocalRealizacao
    {
        [Column("Id")]
        [Display(Name = "Código do Local da Realizção")]
        public int Id { get; set; }

        [Column("LocalNome")]
        [Display(Name = "Nome")]
        public string LocalNome { get; set;} = string.Empty;

        [ForeignKey("CidadeId")]
        [Display(Name = "Cidade")]
        public int CidadeId { get; set; }
        public Cidade? Cidade { get; set; }
    }
}
