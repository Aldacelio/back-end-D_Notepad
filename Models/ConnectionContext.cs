using Microsoft.EntityFrameworkCore;

namespace D_Notepad_back.Models
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Pensamento> Pensamentos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql(
                "Server=localhost;" +
                "Port=5432;Database=dNotepad;" +
                "User Id=postgres;" +
                "Password=081501;"
            );

    }
}
