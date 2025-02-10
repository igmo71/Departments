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
        public DbSet<ПользовательСхемаПредприятия> ПользователиСхемаПредприятия { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CatalogСхемаПредприятия>().ToTable("Catalog_СхемаПредприятия").HasKey(e => e.Ref_Key);

            modelBuilder.Entity<CatalogПользователи>().ToTable("Catalog_Пользователи").HasKey(e => e.Ref_Key);

            modelBuilder.Entity<ПользовательСхемаПредприятия>().ToTable("Пользователь_СхемаПредприятия").HasKey(e => e.Пользователь_Key);
            modelBuilder.Entity<ПользовательСхемаПредприятия>()
                .HasOne(e => e.Пользователь)
                .WithOne()
                .HasForeignKey<ПользовательСхемаПредприятия>(e => e.Пользователь_Key)
                .HasPrincipalKey<CatalogПользователи>(e => e.Ref_Key);
            modelBuilder.Entity<ПользовательСхемаПредприятия>()
                .HasOne(e => e.СхемаПредприятия)
                .WithOne()
                .HasForeignKey<ПользовательСхемаПредприятия>(e => e.СхемаПредприятия_Key)
                .HasPrincipalKey<CatalogСхемаПредприятия>(e => e.Ref_Key);

        }
    }
}
