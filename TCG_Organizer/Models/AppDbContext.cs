using Microsoft.EntityFrameworkCore;

namespace TCG_Organizer.Models;

public class AppDbContext : DbContext
{

    public DbSet<Card> Cards { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Deck> Decks { get; set; }


    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }



    protected override void OnModelCreating(ModelBuilder modelBuilder) { }


}
