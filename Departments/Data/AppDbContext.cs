using Departments.Domain;
using Microsoft.EntityFrameworkCore;

namespace Departments.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<CatalogСхемаПредприятия> CatalogСхемаПредприятия { get; set; } = default!;
        public DbSet<CatalogПользователи> CatalogПользователи { get; set; } = default!;
        public DbSet<ПользователиСхемаПредприятия> ПользователиСхемаПредприятия { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CatalogСхемаПредприятия>().ToTable("Catalog_СхемаПредприятия").HasKey(e => e.Ref_Key);
            modelBuilder.Entity<CatalogПользователи>().ToTable("Catalog_Пользователи").HasKey(e => e.Ref_Key);
            modelBuilder.Entity<ПользователиСхемаПредприятия>().ToTable("Пользователи_СхемаПредприятия").HasKey(e => e.Ref_Key);
        }
    }
}
