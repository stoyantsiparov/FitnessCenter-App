using FitnessCenterApp.Data.Models;
using FitnessCenterApp.Data.Seeds;
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

        // Configure triggers for the main tables
        builder.Entity<SpaProcedure>()
            .ToTable(tb => tb.HasTrigger("TR_SpaProcedures_Log"));

        builder.Entity<FitnessClass>()
            .ToTable(tb => tb.HasTrigger("TR_FitnessClasses_Log"));

        builder.Entity<FitnessEvent>()
            .ToTable(tb => tb.HasTrigger("TR_FitnessEvents_Log"));

        builder.Entity<MembershipType>()
            .ToTable(tb => tb.HasTrigger("TR_MembershipTypes_Log"));

        // Configure triggers for the registration tables
        builder.Entity<SpaRegistration>()
            .ToTable(tb => tb.HasTrigger("TR_SpaRegistrations_Log"));

        builder.Entity<FitnessClassRegistration>()
            .ToTable(tb => tb.HasTrigger("TR_FitnessClassRegistrations_Log"));

        builder.Entity<FitnessEventRegistration>()
            .ToTable(tb => tb.HasTrigger("TR_FitnessEventRegistrations_Log"));

        builder.Entity<MembershipRegistration>()
            .ToTable(tb => tb.HasTrigger("TR_MembershipRegistrations_Log"));

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

        // Seed initial data
        FitnessClassesSeeder.Seed(builder);
        FitnessEventsSeeder.Seed(builder);
        InstructorsSeeder.Seed(builder);
        MembershipTypeSeeder.Seed(builder);
        SpaProceduresSeeder.Seed(builder);
    }
}