using Microsoft.EntityFrameworkCore;

namespace gtauto_api.Entities
{
    public class GtAutoEfDbContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Filial> Filiais { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Telefone> Telefones { get; set; }
        public DbSet<Aluguel> Alugueis { get; set; }
        public DbSet<Devolucao> Devolucoes { get; set; }

        public GtAutoEfDbContext(DbContextOptions<GtAutoEfDbContext> options)
            :base(options) { }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            #region Data Seeding
                 
            var seedData = new DataSeeding();

            modelBuilder.Entity<Cliente>().HasData(seedData.Clientes);
            modelBuilder.Entity<Filial>().HasData(seedData.Filiais);
            modelBuilder.Entity<Funcionario>().HasData(seedData.Funcionarios);
            modelBuilder.Entity<Telefone>().HasData(seedData.Telefones);
            modelBuilder.Entity<Endereco>().HasData(seedData.Enderecos);
            modelBuilder.Entity<Veiculo>().HasData(seedData.Veiculos);
            modelBuilder.Entity<Aluguel>().HasData(seedData.Alugueis);
            modelBuilder.Entity<Devolucao>().HasData(seedData.Devolucoes);

            #endregion

            #region Endereco Relations
                 
            modelBuilder.Entity<Telefone>()
                .HasOne(c => c.Cliente)
                .WithMany(t => t.Telefones)
                .HasForeignKey(c => c.IdCliente)
                .OnDelete(DeleteBehavior.NoAction);

             modelBuilder.Entity<Telefone>()
                .HasOne(f => f.Funcionario)
                .WithMany(t => t.Telefones)
                .HasForeignKey(f => f.IdFuncionario)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Telefone>()
                .HasOne(f => f.Filial)
                .WithMany(t => t.Telefones)
                .HasForeignKey(f => f.IdFilial)
                .OnDelete(DeleteBehavior.NoAction);

            #endregion

            #region Telefone Relations
                 
            modelBuilder.Entity<Endereco>()
                .HasOne(c => c.Cliente)
                .WithMany(e => e.Enderecos)
                .HasForeignKey(c => c.IdCliente)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Endereco>()
                .HasOne(f => f.Funcionario)
                .WithMany(e => e.Enderecos)
                .HasForeignKey(f => f.IdFuncionario)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Endereco>()
                .HasOne(f => f.Filial)
                .WithMany(e => e.Enderecos)
                .HasForeignKey(f => f.IdFilial)
                .OnDelete(DeleteBehavior.NoAction);

            #endregion

            #region Veiculo Relations
                 
            modelBuilder.Entity<Veiculo>()
                .HasOne(f => f.Filial)
                .WithMany(v => v.Veiculos)
                .HasForeignKey(f => f.IdFilial)
                .OnDelete(DeleteBehavior.NoAction);

            #endregion

            #region Alugueis Relations
                
            modelBuilder.Entity<Aluguel>()
                .HasOne(c => c.Cliente)
                .WithMany(a => a.Alugueis)
                .HasForeignKey(c => c.IdCliente)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Aluguel>()
                .HasOne(v => v.Veiculo)
                .WithMany(a => a.Alugueis)
                .HasForeignKey(v => v.IdVeiculo)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Aluguel>()
                .HasOne(f => f.Funcionario)
                .WithMany(a => a.Alugueis)
                .HasForeignKey(f => f.IdFuncionario)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Aluguel>()
                .HasOne(f => f.Filial)
                .WithMany(a => a.Alugueis)
                .HasForeignKey(f => f.IdFilial)
                .OnDelete(DeleteBehavior.NoAction);     
            
            #endregion

            #region Devolucao Relations
            
            modelBuilder.Entity<Devolucao>()
                .HasOne(f => f.Funcionario)
                .WithMany(d => d.Devolucoes)
                .HasForeignKey(f => f.IdFuncionario)
                .OnDelete(DeleteBehavior.NoAction);
                    
            modelBuilder.Entity<Devolucao>()
                .HasOne(f => f.Filial)
                .WithMany(d => d.Devolucoes)
                .HasForeignKey(f => f.IdFilial)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Devolucao>()
                .HasOne(c => c.Cliente)
                .WithMany(d => d.Devolucoes)
                .HasForeignKey(f => f.IdCliente)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Devolucao>()
                .HasOne(v => v.Veiculo)
                .WithMany(d => d.Devolucoes)
                .HasForeignKey(f => f.IdVeiculo)
                .OnDelete(DeleteBehavior.NoAction);

            #endregion

            #region Funcionario Relations

            modelBuilder.Entity<Funcionario>()
                .HasOne(f => f.Filial)
                .WithMany(f => f.Funcionarios)
                .HasForeignKey(f => f.IdFilial)
                .OnDelete(DeleteBehavior.NoAction);
                 
            #endregion
        }
    }
}