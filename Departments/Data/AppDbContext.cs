using Departments.Domain;
using Microsoft.EntityFrameworkCore;

namespace Departments.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Departments.Domain.CatalogСхемаПредприятия> CatalogСхемаПредприятия { get; set; } = default!;
        public DbSet<Departments.Domain.CatalogПользователи> CatalogПользователи { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CatalogСхемаПредприятия>().ToTable("Catalog_СхемаПредприятия").HasKey(e => e.Ref_Key);
            modelBuilder.Entity<CatalogПользователи>().ToTable("Catalog_Пользователи").HasKey(e => e.Ref_Key);
        }
    }
}
