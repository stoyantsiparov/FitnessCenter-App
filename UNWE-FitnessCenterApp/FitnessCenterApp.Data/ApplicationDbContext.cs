using FitnessCenterApp.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FitnessCenterApp.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<MembershipType> MembershipTypes { get; set; } = null!;
    public virtual DbSet<MembershipRegistration> MembershipRegistrations { get; set; } = null!;
    public virtual DbSet<FitnessEvent> FitnessEvents { get; set; } = null!;
    public virtual DbSet<FitnessEventRegistration> FitnessEventRegistrations { get; set; } = null!;
    public virtual DbSet<FitnessClass> FitnessClasses { get; set; } = null!;
    public virtual DbSet<FitnessClassRegistration> FitnessClassRegistrations { get; set; } = null!;
    public virtual DbSet<Instructor> Instructors { get; set; } = null!;
    public virtual DbSet<SpaProcedure> SpaProcedures { get; set; } = null!;
    public virtual DbSet<SpaRegistration> SpaRegistrations { get; set; } = null!;
    public virtual DbSet<Log_22180022> Logs_22180022 { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // Set the default schema for all tables to "22180022"
        builder.HasDefaultSchema("22180022");

        // Precision settings for prices
        builder.Entity<MembershipType>()
            .Property(mt => mt.Price)
            .HasPrecision(18, 2);

        builder.Entity<SpaProcedure>()
            .Property(sp => sp.Price)
            .HasPrecision(18, 2);

        builder.Entity<FitnessClass>()
            .Property(fc => fc.Price)
            .HasPrecision(18, 2);
    }
}