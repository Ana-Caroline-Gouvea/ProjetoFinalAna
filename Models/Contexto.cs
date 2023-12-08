using Microsoft.EntityFrameworkCore;
using ProjetoFinalAna.Models;

namespace ProjetoFinalAna.Models
{
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        public DbSet<ProjetoFinalAna.Models.Cidade>? Cidade { get; set; }
        public DbSet<ProjetoFinalAna.Models.Cliente>? Cliente { get; set; }
        public DbSet<ProjetoFinalAna.Models.Colaborador>? Colaborador { get; set; }
        public DbSet<ProjetoFinalAna.Models.Estado>? Estado { get; set; }
        public DbSet<ProjetoFinalAna.Models.LocalRealizacao>? LocalRealizacao { get; set; }
        public DbSet<ProjetoFinalAna.Models.Procedimento>? Procedimento { get; set; }
        public DbSet<ProjetoFinalAna.Models.ProcedimentoRealizado>? ProcedimentoRealizado { get; set; }
        public DbSet<ProjetoFinalAna.Models.TipoColaborador>? TipoColaborador { get; set; }
        public DbSet<ProjetoFinalAna.Models.TipoProcedimento>? TipoProcedimento { get; set; }
        public DbSet<ProjetoFinalAna.Models.Usuario>? Usuario { get; set; }

    }
}
