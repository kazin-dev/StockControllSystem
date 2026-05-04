using Microsoft.EntityFrameworkCore;

namespace StockManagement.DbData
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product>? products { get; set; }

        public AppDbContext()
        {
            // Isso garante que o arquivo e as tabelas sejam criados na primeira vez
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Isso sobe 3 níveis de pasta a partir de onde o app roda para tentar chegar na raiz
            // Mas o jeito mais seguro para você agora é o caminho absoluto:
            var dbPath = @"C:\Users\kgs04\OneDrive\Documentos\StockControllSystem\Management.db";

            optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }
    }
}