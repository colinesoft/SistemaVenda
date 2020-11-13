using Microsoft.EntityFrameworkCore;
using SistemaVenda.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVenda.DAL
{
    public class AppDbContext : DbContext
    {
        //Construtor Padrão para DBCONTEXT
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt) { }

        //Cria uma Context para cada tabela
        public DbSet<Categorias> Categorias { get; set; }
        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Vendas> Vendas { get; set; }
        public DbSet<VendaProdutos> VendaProdutos { get; set; }

        //Caso especial para a VendaProdutos
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Executa o metodo original
            base.OnModelCreating(modelBuilder);

            #region VendasProdutos

                            //Aqui vem a implementação do metodo
                            //Por se tratar de um chave primária dupla, deve ser feita assim. Informa que deve criar as duas chaves
                            modelBuilder.Entity<VendaProdutos>().HasKey(item => new { item.VendaId, item.ProdutoId });

                            //VENDA Importante -> VendaProdutos possi 1 Venda com muitos Produtos
                            modelBuilder.Entity<VendaProdutos>()
                                .HasOne(v => v.Venda) //VendasProdutos PossuiUma(HasOne) Venda
                                .WithMany(item => item.VendaProdutos) //ComMuitos(WithMany) VendaProdutos -- Itens
                                .HasForeignKey(c => c.VendaId); //ComChaveEstrangeira(HasForegnKey) da Venda            

                            //PRODUTO Importante
                            modelBuilder.Entity<VendaProdutos>()
                                .HasOne(p => p.Produto) //Um Produto
                                .WithMany(v => v.VendaProdutos) //Com muitas Vendas
                                .HasForeignKey(c => c.ProdutoId); //Com chave estrangeira ProdutoId

            #endregion
        }
    }
}
