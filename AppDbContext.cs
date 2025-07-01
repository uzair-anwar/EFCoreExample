using Microsoft.EntityFrameworkCore;
namespace EFCoreExample {
    public class AppDbContext: DbContext {
        public DbSet<Student> Students {get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EFCoreExample;Trusted_connection=true;");
        }
    }
}