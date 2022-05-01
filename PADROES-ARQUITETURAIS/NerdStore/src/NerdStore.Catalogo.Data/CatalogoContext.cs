using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NerdStore.Catalogo.Domain;
using NerdStore.Core.Data;

namespace NerdStore.Catalogo.Data
{
    public class CatalogoContext : DbContext, IUnitOfWork
    {

        public CatalogoContext(DbContextOptions<CatalogoContext> options) :
            base(options) { }

        public DbSet<Produto> Produto { get; set; }
        public DbSet<Categoria> Categoria { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public Task<bool> Commit()
        {
            throw new NotImplementedException();
        }

    }
}
