using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace BoxOfficeDemo.Server.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
            new IdentityRole
            {
                Id = "32ecd8d0-3110-40a1-beae-04d1a43aca34",
                Name = "Visitor",
                NormalizedName = "VISITOR"
            },
            new IdentityRole
            {
                Id= "e532da13-62c4-4582-9d7a-834b080b2ac1",
                Name = "Administrator",
                NormalizedName = "ADMINISTRATOR"
            },
            new IdentityRole
            {
                Id= "f58b5d1d-9cbd-4fd8-aa12-5ecd0c48b56a",
                Name = "User",
                NormalizedName = "USER"
            });;;
        }
    }
}
