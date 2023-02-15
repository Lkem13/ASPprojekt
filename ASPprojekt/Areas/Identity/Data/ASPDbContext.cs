using ASPprojekt.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASPprojekt.Areas.Identity.Data;

public class ASPDbContext : IdentityDbContext<ASPprojektUser>
{
    public DbSet<ASPprojektUser> Users { get; set; }
    public DbSet<LocationModel> Locations { get; set; }
    public DbSet<PositionModel> Positions { get; set; }
    public DbSet<StatusModel> Statuses { get; set; }

    public ASPDbContext(DbContextOptions<ASPDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
        builder.Entity<StatusModel>()
            .Property(s => s.statusType)
            .HasConversion<string>();

        builder.Entity<PositionModel>().HasData(new PositionModel { PositionName = "Brak" });
        builder.Entity<PositionModel>().HasData(new PositionModel { PositionName = "Front Desk" });
        builder.Entity<PositionModel>().HasData(new PositionModel { PositionName = "Chef" });
        builder.Entity<PositionModel>().HasData(new PositionModel { PositionName = "Cook" });
        builder.Entity<PositionModel>().HasData(new PositionModel { PositionName = "Hotel Manager" });
        builder.Entity<PositionModel>().HasData(new PositionModel { PositionName = "Maid" });
        builder.Entity<PositionModel>().HasData(new PositionModel { PositionName = "Barista" });
        builder.Entity<PositionModel>().HasData(new PositionModel { PositionName = "Waiter" });

        builder.Entity<LocationModel>().HasData(new LocationModel { LocationId = 1, Town = "Cracow", Street = "Wielicka 13/5A", ZipCode = "31-271" });
        builder.Entity<LocationModel>().HasData(new LocationModel { LocationId = 2, Town = "Warsaw", Street = "Zielona 11", ZipCode = "44-223" });
    }

    private class ASPprojektUserEntityConfiguration : IEntityTypeConfiguration<ASPprojektUser>
    {
        public void Configure(EntityTypeBuilder<ASPprojektUser> builder)
        {
            builder.Property(x => x.FirstName).HasMaxLength(255);
            builder.Property(x => x.LastName).HasMaxLength(255);

            builder.Property(d => d.Type).HasDefaultValue("User");

            builder.Property(s => s.Status).HasDefaultValue("Pending");

        }
    }
}
