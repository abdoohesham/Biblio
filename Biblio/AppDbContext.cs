using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(
                "Server=ABDO_HESHAM\\SQLSERVER2022 ;Database=Biblio ;Trusted_Connection=True ;TrustServerCertificate=True ;");
        }
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // User => Borrowing (1-to-many)
        modelBuilder.Entity<Borrowing>()
            .HasOne(b => b.User)
            .WithMany(u => u.Borrowings)
            .OnDelete(DeleteBehavior.Cascade);

        // User => Notification (1-to-many)
        //modelBuilder.Entity<Notification>()
        //    .HasOne(n => n.VisitorID)
        //    .WithMany(u => u.Notifications)
        //    .HasForeignKey(n => n.UserID)
        //    .OnDelete(DeleteBehavior.Cascade);

        base.OnModelCreating(modelBuilder);
    }
    public DbSet<User> Users { get; set; }
    public DbSet<Borrowing> Borrowings { get; set; }
    public DbSet<Notification> Notifications { get; set; }
}
