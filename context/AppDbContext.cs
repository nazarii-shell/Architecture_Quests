using Microsoft.EntityFrameworkCore;

namespace lab4.data;

public class AppDbContext : DbContext
{
    public DbSet<Quest> Quest { get; set; }
    public DbSet<Availability> Availability { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = "Server=localhost;Database=quest_rooms;Uid=root;Pwd=Informatica_60";
        optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
    }
}