using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BoxOfficeDemo.Server.Configurations
{
    public class UsersRolesConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "e532da13-62c4-4582-9d7a-834b080b2ac1",
                    UserId = "cb5b3ced-a42a-413c-92f6-d18a242c2a5a"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "f58b5d1d-9cbd-4fd8-aa12-5ecd0c48b56a",
                    UserId = "b6c9180a-621c-4d6c-9827-6a8a1174fd81"
                });
        }
    }
}
