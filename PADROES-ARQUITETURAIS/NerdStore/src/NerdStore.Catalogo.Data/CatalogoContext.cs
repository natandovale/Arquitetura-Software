using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
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
            foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(
                  e => e.GetProperties().Where(p => p.ClrType == typeof(string))))
                property.Relational().ColumnType = "varchar(100)";

            base.OnModelCreating(modelBuilder);
        }

        public Task<bool> Commit()
        {
            throw new NotImplementedException();
        }

    }
}
