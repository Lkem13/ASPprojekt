using ASPprojekt.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASPprojekt.Areas.Identity.Data;

public class ASPDbContext : IdentityDbContext<ASPprojektUser>
{
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
