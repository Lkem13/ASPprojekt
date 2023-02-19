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
    public DbSet<PlanModel> PlanModels { get; set; }

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

            builder.Entity<PlanModel>()
                .HasKey(c => c.Id);

        builder.Entity<PositionModel>().HasData(
            new PositionModel {
                PositionId = 1,
                PositionName = "Brak" 
            },
            new PositionModel
            {
                PositionId = 2,
                PositionName = "Front Desk"
            },
            new PositionModel
            {
                PositionId = 3,
                PositionName = "Chef"
            },
            new PositionModel
            {
                PositionId = 4,
                PositionName = "Cook"
            },
            new PositionModel
            {
                PositionId = 5,
                PositionName = "Hotel Manager"
            },
            new PositionModel
            {
                PositionId = 6,
                PositionName = "Maid"
            },
            new PositionModel
            {
                PositionId = 7,
                PositionName = "Barista"
            },
            new PositionModel
            {
                PositionId = 8,
                PositionName = "Waiter"
            }
            );

        builder.Entity<LocationModel>().HasData(
            new LocationModel
            {
                LocationId = 1,
                Town = "Krakow",
                Street = "Karmelicka"
            },
            new LocationModel
            {
                LocationId = 2,
                Town = "Warszawa",
                Street = "Brzozowa"
            }
            );

        //Seed Roles
        builder.Entity<IdentityRole>().HasData(
           new IdentityRole
           {
               Id = "2c5e174e-3b0e-446f-86af-483d56fd7210",
               Name = "Admin",
               NormalizedName = "ADMIN"
           },
           new IdentityRole
           {
               Id = "2c5e174e-3b0e-446f-86af-483d56fd7211",
               Name = "User",
               NormalizedName = "USER"
           }
       );

        //Seed Admin and User
        var hasher = new PasswordHasher<ASPprojektUser>();
        builder.Entity<ASPprojektUser>().HasData(
            new ASPprojektUser
            {
                Id = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                UserName = "admin@admin.admin",
                NormalizedUserName = "ADMIN@ADMIN.ADMIN",
                PasswordHash = hasher.HashPassword(null, "admin"),
                Email = "admin@admin.admin",
                NormalizedEmail = "ADMIN@ADMIN.ADMIN",
                EmailConfirmed = true,
                FirstName = "Admin",
                LastName = "Admin",
                Pesel = "00000000000"
            },
            new ASPprojektUser
            {
                Id = "8e445865-a24d-4543-a6c6-9443d048cdb8",
                UserName = "user@user.user",
                NormalizedUserName = "USER@USER.USER",
                PasswordHash = hasher.HashPassword(null, "user"),
                Email = "user@user.user",
                NormalizedEmail = "USER@USER.USER",
                EmailConfirmed = true,
                FirstName = "User",
                LastName = "User",
                Pesel = "11111111111"
            },
            new ASPprojektUser
            {
                Id = "8e445865-a24d-4543-a6c6-9443d048cdb7",
                UserName = "user2@user.user",
                NormalizedUserName = "USER2@USER.USER",
                PasswordHash = hasher.HashPassword(null, "user"),
                Email = "user2@user.user",
                NormalizedEmail = "USER2@USER.USER",
                EmailConfirmed = true,
                FirstName = "User2",
                LastName = "User2",
                Pesel = "11111111112"
            },
            new ASPprojektUser
            {
                Id = "8e445865-a24d-4543-a6c6-9443d048cdb6",
                UserName = "user3@user.user",
                NormalizedUserName = "USER3@USER.USER",
                PasswordHash = hasher.HashPassword(null, "user"),
                Email = "user23user.user",
                NormalizedEmail = "USER3@USER.USER",
                EmailConfirmed = true,
                FirstName = "User3",
                LastName = "User3",
                Pesel = "11111111113"
            }
         );
        //Add roles for Admin and User
        builder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7210",
                UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9"
            },
            new IdentityUserRole<string>
            {
                RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7211",
                UserId = "8e445865-a24d-4543-a6c6-9443d048cdb8"
            }
        );
    }


    private class ASPprojektUserEntityConfiguration : IEntityTypeConfiguration<ASPprojektUser>
    {
        public void Configure(EntityTypeBuilder<ASPprojektUser> builder)
        {
            builder.Property(x => x.FirstName).HasMaxLength(255);
            builder.Property(x => x.LastName).HasMaxLength(255);

            builder.Property(s => s.Status).HasDefaultValue("Pending");

        }
    }
}
