using BoxOfficeDemo.Server.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BoxOfficeDemo.Server.Configurations
{
    public class DefaultUsersConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            var hasher = new PasswordHasher<User>();

            builder.HasData(
                new User
                {
                    Id = "cb5b3ced-a42a-413c-92f6-d18a242c2a5a",
                    Email = "admin@identity.com",
                    NormalizedEmail = "ADMIN@IDENTITY.COM",
                    UserName = "admin",
                    NormalizedUserName = "ADMIN",
                    FirstName = "System",
                    LastName = "Admin",
                    PasswordHash = hasher.HashPassword(null, "@Dmin123")
                },
                new User
                {
                    Id = "b6c9180a-621c-4d6c-9827-6a8a1174fd81",
                    Email = "user@identity.com",
                    NormalizedEmail = "USER@IDENTITY.COM",
                    UserName = "user",
                    NormalizedUserName = "USER",
                    FirstName = "System",
                    LastName = "User",
                    PasswordHash = hasher.HashPassword(null, "U$er000")
                });
        }
    }
}
