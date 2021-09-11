using Microsoft.EntityFrameworkCore;
using System;

namespace CursoAspnetMVC.Models
{
    public class Context : DbContext
    {
        public virtual DbSet<Categoria> Categorias { get; set;}
        public virtual DbSet<Produto> Produtos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=localhost; Database=Cursomvc; User=SA; Password=123456");
        }

        public virtual void SetModified(object entity)
        {
            Entry(entity).State = EntityState.Modified;
        }
    }
}
