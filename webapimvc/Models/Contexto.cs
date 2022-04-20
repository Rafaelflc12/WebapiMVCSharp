
using Microsoft.EntityFrameworkCore;

namespace webapimvc.Models
{
    public class Contexto : DbContext
    {


        public Contexto(DbContextOptions<Contexto> options):base(options)
        {

        }

        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Transportadora> Transportadoras { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Telefone> Telefones { get; set; }
        public DbSet<Email> Emails { get; set; }


    }
}
