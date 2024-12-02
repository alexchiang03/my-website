using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    // DbSets met meervoudige naamgeving
    public DbSet<Klant> Klanten { get; set; }
    public DbSet<Abonnement> Abonnementen { get; set; }
    public DbSet<Medewerker> Medewerkers { get; set; }
    public DbSet<Huurder> Huurders { get; set; }
    public DbSet<HuurAanvraag> HuurAanvragen { get; set; }
    public DbSet<Voertuig> Voertuigen { get; set; }
    public DbSet<Schade> Schades { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configureren van relaties met expliciete vreemde sleutels en navigatie-eigenschappen

        modelBuilder.Entity<Abonnement>()
            .HasMany(a => a.Medewerkers)
            .WithOne(m => m.Abonnement)
            .HasForeignKey(m => m.AbonnementId)
            .OnDelete(DeleteBehavior.Cascade); // Voeg cascade delete toe, indien gewenst

        modelBuilder.Entity<HuurAanvraag>()
            .HasOne(h => h.Huurder)
            .WithMany(h => h.HuurAanvragen)
            .HasForeignKey(h => h.HuurderId)
            .OnDelete(DeleteBehavior.Cascade); // Voeg cascade delete toe, indien gewenst

        modelBuilder.Entity<HuurAanvraag>()
            .HasOne(h => h.Voertuig)
            .WithMany()
            .HasForeignKey(h => h.VoertuigId)
            .OnDelete(DeleteBehavior.Cascade); // Voeg cascade delete toe, indien gewenst

        modelBuilder.Entity<Voertuig>()
            .HasMany(v => v.Schades)
            .WithOne(s => s.Voertuig)
            .HasForeignKey(s => s.VoertuigId)
            .OnDelete(DeleteBehavior.Cascade); // Voeg cascade delete toe, indien gewenst

        // Configureren van de tabelnaam (optioneel, afhankelijk van je conventies)
        modelBuilder.Entity<Klant>().ToTable("Klanten");
        modelBuilder.Entity<Abonnement>().ToTable("Abonnementen");
        modelBuilder.Entity<Medewerker>().ToTable("Medewerkers");
        modelBuilder.Entity<Huurder>().ToTable("Huurders");
        modelBuilder.Entity<HuurAanvraag>().ToTable("HuurAanvragen");
        modelBuilder.Entity<Voertuig>().ToTable("Voertuigen");
        modelBuilder.Entity<Schade>().ToTable("Schades");
    }
}
