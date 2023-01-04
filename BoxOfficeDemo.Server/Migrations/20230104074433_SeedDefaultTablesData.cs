using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoxOfficeDemo.Server.Migrations
{
    public partial class SeedDefaultTablesData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "32ecd8d0-3110-40a1-beae-04d1a43aca34", "a02163e2-3d2e-4e29-af45-6373e8b188d1", "Visitor", "VISITOR" },
                    { "e532da13-62c4-4582-9d7a-834b080b2ac1", "6f07c8ee-a5d5-41e3-82e4-075dc9916971", "Administrator", "ADMINISTRATOR" },
                    { "f58b5d1d-9cbd-4fd8-aa12-5ecd0c48b56a", "2ea7171e-721f-4594-91c1-98a3f84e9b5b", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "b6c9180a-621c-4d6c-9827-6a8a1174fd81", 0, "e4f27ea7-5a93-4587-9d41-0d6f752c466c", "user@identity.com", false, "System", "User", false, null, "USER@IDENTITY.COM", "USER", "AQAAAAEAACcQAAAAEJByo52H0I2V3v+gyAUy75twzn0aTHAyMlJ+sIUAYarX8h8vJdIDvQYBAatpAaHxAQ==", null, false, null, null, "225ea77e-d8a0-4dfe-ad8d-858a3cb1cedf", false, "user" },
                    { "cb5b3ced-a42a-413c-92f6-d18a242c2a5a", 0, "1c92e25f-98de-4635-bd1e-07942b5a7ccb", "admin@identity.com", false, "System", "Admin", false, null, "ADMIN@IDENTITY.COM", "ADMIN", "AQAAAAEAACcQAAAAEPlHiMccQ73M3/2GklzjNTTx6mVQCoQAgkUV2nQgYVWlh+mKwfbpjnmoZHQrUenvmQ==", null, false, null, null, "43afd52c-1d69-4d4c-9e8f-95e379bf8cab", false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieID", "Description", "Director", "Genere", "Image", "Length", "MovieName", "ParentalGuide", "Rate", "ReleasedDate", "Stars", "Writer" },
                values: new object[,]
                {
                    { 0.00000001m, "A young woman is courted and swept off her feet, only to realize a gothic conspiracy is afoot.", "Jessica M. Thompson", "Horror", "/images/TheInvitation.jpg", new TimeSpan(0, 1, 45, 0, 0), "The Invitation", 13, 5.3m, new DateTime(2022, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nathalie Emmanuel,Thomas Doherty,Stephanie Corneliussen", "Blair Butler" },
                    { 0.00000002m, "Five assassins aboard a fast moving bullet train find out their missions have something in common.", "David Leitch", "Action", "/images/BulletTrain.jpg", new TimeSpan(0, 2, 7, 0, 0), "Bullet Train", 15, 7.5m, new DateTime(2022, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brad PittJoey, KingAaron, Taylor-Johnson", "Zak Olkewicz" },
                    { 0.00000003m, "A father and his two teenage daughters find themselves hunted by a massive rogue lion intent on proving that the Savanna has but one apex predator.", "Baltasar Kormákur", "Drama", "/images/Beast.jpg", new TimeSpan(0, 1, 33, 0, 0), "Beast", 16, 5.9m, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Liyabuya Gongo, Martin Munro, Daniel Hadebe", "Ryan Engle" },
                    { 0.00000004m, "After more than thirty years of service as one of the Navy's top aviators, Pete Mitchell is where he belongs, pushing the envelope as a courageous test pilot and dodging the advancement in rank that would ground him.", "Joseph Kosinski", "Action", "/images/TopGunMaverick.jpg", new TimeSpan(0, 1, 33, 0, 0), "Top Gun: Maverick", 13, 8.5m, new DateTime(2022, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tom Cruise, Val Kilmer, Miles Teller", "Jim Cash" },
                    { 0.00000005m, "The Red Ribbon Army from Goku's past has returned with two new androids to challenge him and his friends.", "Tetsuro Kodama", "Animation", "/images/DragonBallSuperSuperHero.jpg", new TimeSpan(0, 1, 40, 0, 0), "Dragon Ball Super: Super Hero", 13, 7.3m, new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masako Nozawa, Toshio Furukawa, Yûko Minaguchi", "Akira Toriyama" },
                    { 0.00000006m, "Krypto the Super-Dog and Superman are inseparable best friends, sharing the same superpowers and fighting crime side by side in Metropolis. However, Krypto must master his own powers for a rescue mission when Superman is kidnapped.", "Jared Stern", "Animation", "/images/DCLeagueofSuperPets.jpg/", new TimeSpan(0, 1, 45, 0, 0), "DC League of Super-Pets", 7, 7.6m, new DateTime(2022, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dwayne Johnson, Dwayne Johnson, Kate McKinnon", "John Whittington" },
                    { 0.00000007m, "A lonely scholar, on a trip to Istanbul, discovers a Djinn who offers her three wishes in exchange for his freedom.", "George Miller", "Drama", "/images/ThreeThousandYearsofLonging.jpg", new TimeSpan(0, 1, 48, 0, 0), "Three Thousand Years of Longing", 15, 6.9m, new DateTime(2022, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tilda Swinton, Idris Elba, Pia Thunderbolt", "Augusta Gore" },
                    { 0.00000008m, "The untold story of one twelve-year-old's dream to become the world's greatest supervillain.", "Kyle Balda", "Animation", "/images/MinionsTheRiseofGru.jpg", new TimeSpan(0, 1, 27, 0, 0), "Minions: The Rise of Gru", 7, 6.6m, new DateTime(2022, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Steve Carell, Pierre Coffin, Alan Arkin", "Matthew Fogel" },
                    { 0.00000009m, "Thor enlists the help of Valkyrie, Korg and ex-girlfriend Jane Foster to fight Gorr the God Butcher, who intends to make the gods extinct.", "Taika Waititi", "Action", "/images/ThorLoveandThunder.jpg", new TimeSpan(0, 1, 58, 0, 0), "Thor: Love and Thunder", 13, 6.7m, new DateTime(2022, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chris Hemsworth, Natalie Portman, Christian Bale", "Jennifer Kaytin Robinson" },
                    { 0.00000010m, "A woman who raised herself in the marshes of the deep South becomes a suspect in the murder of a man she was once involved with.", "Olivia Newman", "Drama", "/images/WheretheCrawdadsSing.jpg", new TimeSpan(0, 2, 5, 0, 0), "Where the Crawdads Sing", 13, 7.1m, new DateTime(2022, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daisy Edgar-Jones, Taylor John Smith, Harris Dickinson", "Delia Owens" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f58b5d1d-9cbd-4fd8-aa12-5ecd0c48b56a", "b6c9180a-621c-4d6c-9827-6a8a1174fd81" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e532da13-62c4-4582-9d7a-834b080b2ac1", "cb5b3ced-a42a-413c-92f6-d18a242c2a5a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32ecd8d0-3110-40a1-beae-04d1a43aca34");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f58b5d1d-9cbd-4fd8-aa12-5ecd0c48b56a", "b6c9180a-621c-4d6c-9827-6a8a1174fd81" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e532da13-62c4-4582-9d7a-834b080b2ac1", "cb5b3ced-a42a-413c-92f6-d18a242c2a5a" });

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 0.00000001m);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 0.00000002m);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 0.00000003m);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 0.00000004m);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 0.00000005m);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 0.00000006m);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 0.00000007m);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 0.00000008m);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 0.00000009m);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 0.00000010m);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e532da13-62c4-4582-9d7a-834b080b2ac1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f58b5d1d-9cbd-4fd8-aa12-5ecd0c48b56a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6c9180a-621c-4d6c-9827-6a8a1174fd81");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cb5b3ced-a42a-413c-92f6-d18a242c2a5a");
        }
    }
}
