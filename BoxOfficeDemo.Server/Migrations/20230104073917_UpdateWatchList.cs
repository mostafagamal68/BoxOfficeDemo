using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoxOfficeDemo.Server.Migrations
{
    public partial class UpdateWatchList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WatchList_AspNetUsers_UserID",
                table: "WatchList");

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

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "WatchList",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Id",
                table: "WatchList",
                type: "decimal(28,8)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "AddedDate",
                table: "WatchList",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Rate",
                table: "Movies",
                type: "decimal(3,1)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(8,2)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_WatchList",
                table: "WatchList",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WatchList_AspNetUsers_UserID",
                table: "WatchList",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WatchList_AspNetUsers_UserID",
                table: "WatchList");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WatchList",
                table: "WatchList");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "WatchList");

            migrationBuilder.DropColumn(
                name: "AddedDate",
                table: "WatchList");

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "WatchList",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Rate",
                table: "Movies",
                type: "decimal(8,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(3,1)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "32ecd8d0-3110-40a1-beae-04d1a43aca34", "0cb45bf7-525c-47d6-8c53-98ada210d8c7", "Visitor", "VISITOR" },
                    { "e532da13-62c4-4582-9d7a-834b080b2ac1", "94134a8a-fc7f-4b8c-a5a2-f127107ae26e", "Administrator", "ADMINISTRATOR" },
                    { "f58b5d1d-9cbd-4fd8-aa12-5ecd0c48b56a", "55ee84c6-f136-480b-83e3-127347ad2e04", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "b6c9180a-621c-4d6c-9827-6a8a1174fd81", 0, "3c8ad968-8dfe-4613-84f9-85f9d72fc2bf", "user@identity.com", false, "System", "User", false, null, "USER@IDENTITY.COM", "USER", "AQAAAAEAACcQAAAAEKcKP48uv4m6+Zvuw15O5yZMhYjYoj1qhkNv5mPJtDx4whPNouRmkyn7PKxGNa2loA==", null, false, null, null, "2b6a2e2b-f113-4aac-b258-98139a028147", false, "user" },
                    { "cb5b3ced-a42a-413c-92f6-d18a242c2a5a", 0, "7da74241-3349-47b9-abbc-f33fd5d4b951", "admin@identity.com", false, "System", "Admin", false, null, "ADMIN@IDENTITY.COM", "ADMIN", "AQAAAAEAACcQAAAAEDmvUYOadxBA0HP7MZtNoqW9C/tkbckUFd8W5uccfjCx/Q1mTDrI08mp6KBwXUiwjw==", null, false, null, null, "3fc8a36c-1a47-42cf-bf36-036fd67c0c8e", false, "admin" }
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

            migrationBuilder.AddForeignKey(
                name: "FK_WatchList_AspNetUsers_UserID",
                table: "WatchList",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
