using Aplication.Models;
using Microsoft.EntityFrameworkCore;

namespace Salvation.Data
{
    //classe responsável pelo contexto da base de dados e mapeamento das entidades (tabelas)
    public class SalvationDbContext : DbContext
    {
        //construtor 
        public SalvationDbContext(DbContextOptions<SalvationDbContext> options) : base(options)
        {
        }

        //propriedades DbSet representam nossas tabelas
        public DbSet<Classificacao> Classificacoes { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<TipoUsuario> TipoUsuarios { get; set; }
        public DbSet<Usuario>  Usuarios { get; set; }

        //metodo opcional, deve ser usado para configurar o modelo
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Usuario>().Property(u=>u.Ativo).HasDefaultValue(true);
        }
    }
}
