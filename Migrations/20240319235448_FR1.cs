using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FiyiRequirements.Migrations
{
    /// <inheritdoc />
    public partial class FR1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Failure",
                columns: table => new
                {
                    FailureId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<byte>(type: "tinyint", nullable: false),
                    DateTimeCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateTimeLastModification = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserCreationId = table.Column<int>(type: "int", nullable: false),
                    UserLastModificationId = table.Column<int>(type: "int", nullable: false),
                    Message = table.Column<string>(type: "text", nullable: true),
                    EmergencyLevel = table.Column<int>(type: "int", nullable: false),
                    StackTrace = table.Column<string>(type: "text", nullable: true),
                    Source = table.Column<string>(type: "text", nullable: true),
                    Comment = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Failure", x => x.FailureId);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    MenuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<byte>(type: "tinyint", nullable: false),
                    DateTimeCreation = table.Column<DateTime>(type: "datetime", nullable: false),
                    DateTimeLastModification = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserCreationId = table.Column<int>(type: "int", nullable: false),
                    UserLastModificationId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    MenuFatherId = table.Column<int>(type: "int", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    URLPath = table.Column<string>(type: "varchar(8000)", nullable: true),
                    IconURLPath = table.Column<string>(type: "varchar(8000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.MenuId);
                });

            migrationBuilder.CreateTable(
                name: "Parameter",
                columns: table => new
                {
                    ParameterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<byte>(type: "tinyint", nullable: false),
                    DateTimeCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateTimeLastModification = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserCreationId = table.Column<int>(type: "int", nullable: false),
                    UserLastModificationId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Value = table.Column<string>(type: "text", nullable: true),
                    IsPrivate = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parameter", x => x.ParameterId);
                });

            migrationBuilder.CreateTable(
                name: "Requirement",
                columns: table => new
                {
                    RequirementId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<byte>(type: "tinyint", nullable: false),
                    DateTimeCreation = table.Column<DateTime>(type: "datetime", nullable: false),
                    DateTimeLastModification = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserCreationId = table.Column<int>(type: "int", nullable: false),
                    UserLastModificationId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "varchar(500)", nullable: false),
                    Body = table.Column<string>(type: "text", nullable: true),
                    RequirementStateId = table.Column<int>(type: "int", nullable: false),
                    RequirementPriorityId = table.Column<int>(type: "int", nullable: false),
                    UserEmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requirement", x => x.RequirementId);
                });

            migrationBuilder.CreateTable(
                name: "RequirementChangehistory",
                columns: table => new
                {
                    RequirementChangehistoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<byte>(type: "tinyint", nullable: false),
                    DateTimeCreation = table.Column<DateTime>(type: "datetime", nullable: false),
                    DateTimeLastModification = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserCreationId = table.Column<int>(type: "int", nullable: false),
                    UserLastModificationId = table.Column<int>(type: "int", nullable: false),
                    RequirementId = table.Column<int>(type: "int", nullable: false),
                    RequirementStateId = table.Column<int>(type: "int", nullable: false),
                    RequirementPriorityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequirementChangehistory", x => x.RequirementChangehistoryId);
                });

            migrationBuilder.CreateTable(
                name: "RequirementFile",
                columns: table => new
                {
                    RequirementFileId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<byte>(type: "tinyint", nullable: false),
                    DateTimeCreation = table.Column<DateTime>(type: "datetime", nullable: false),
                    DateTimeLastModification = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserCreationId = table.Column<int>(type: "int", nullable: false),
                    UserLastModificationId = table.Column<int>(type: "int", nullable: false),
                    RequirementId = table.Column<int>(type: "int", nullable: false),
                    FilePath = table.Column<string>(type: "varchar(MAX)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequirementFile", x => x.RequirementFileId);
                });

            migrationBuilder.CreateTable(
                name: "RequirementNote",
                columns: table => new
                {
                    RequirementNoteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<byte>(type: "tinyint", nullable: false),
                    DateTimeCreation = table.Column<DateTime>(type: "datetime", nullable: false),
                    DateTimeLastModification = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserCreationId = table.Column<int>(type: "int", nullable: false),
                    UserLastModificationId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "varchar(500)", nullable: false),
                    Body = table.Column<string>(type: "text", nullable: true),
                    RequirementId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequirementNote", x => x.RequirementNoteId);
                });

            migrationBuilder.CreateTable(
                name: "RequirementPriority",
                columns: table => new
                {
                    RequirementPriorityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<byte>(type: "tinyint", nullable: false),
                    DateTimeCreation = table.Column<DateTime>(type: "datetime", nullable: false),
                    DateTimeLastModification = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserCreationId = table.Column<int>(type: "int", nullable: false),
                    UserLastModificationId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(300)", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequirementPriority", x => x.RequirementPriorityId);
                });

            migrationBuilder.CreateTable(
                name: "RequirementState",
                columns: table => new
                {
                    RequirementStateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<byte>(type: "tinyint", nullable: false),
                    DateTimeCreation = table.Column<DateTime>(type: "datetime", nullable: false),
                    DateTimeLastModification = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserCreationId = table.Column<int>(type: "int", nullable: false),
                    UserLastModificationId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(300)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequirementState", x => x.RequirementStateId);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<byte>(type: "tinyint", nullable: false),
                    DateTimeCreation = table.Column<DateTime>(type: "datetime", nullable: false),
                    DateTimeLastModification = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserCreationId = table.Column<int>(type: "int", nullable: false),
                    UserLastModificationId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "RoleMenu",
                columns: table => new
                {
                    RoleMenuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleMenu", x => x.RoleMenuId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<byte>(type: "tinyint", nullable: false),
                    DateTimeCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateTimeLastModification = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserCreationId = table.Column<int>(type: "int", nullable: false),
                    UserLastModificationId = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "varchar(380)", nullable: true),
                    Password = table.Column<string>(type: "varchar(8000)", nullable: true),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "MenuId", "Active", "DateTimeCreation", "DateTimeLastModification", "IconURLPath", "MenuFatherId", "Name", "Order", "URLPath", "UserCreationId", "UserLastModificationId" },
                values: new object[,]
                {
                    { 1, (byte)1, new DateTime(2024, 3, 19, 20, 54, 47, 731, DateTimeKind.Local).AddTicks(9597), new DateTime(2024, 3, 19, 20, 54, 47, 731, DateTimeKind.Local).AddTicks(9598), "", 0, "BasicCore", 100, "", 1, 1 },
                    { 2, (byte)1, new DateTime(2024, 3, 19, 20, 54, 47, 731, DateTimeKind.Local).AddTicks(9615), new DateTime(2024, 3, 19, 20, 54, 47, 731, DateTimeKind.Local).AddTicks(9616), "", 1, "Failure", 0, "/BasicCore/FailurePage", 1, 1 },
                    { 3, (byte)1, new DateTime(2024, 3, 19, 20, 54, 47, 731, DateTimeKind.Local).AddTicks(9632), new DateTime(2024, 3, 19, 20, 54, 47, 731, DateTimeKind.Local).AddTicks(9632), "", 1, "Parameter", 0, "/BasicCore/ParameterPage", 1, 1 },
                    { 4, (byte)1, new DateTime(2024, 3, 19, 20, 54, 47, 731, DateTimeKind.Local).AddTicks(9647), new DateTime(2024, 3, 19, 20, 54, 47, 731, DateTimeKind.Local).AddTicks(9647), "", 0, "BasicCulture", 200, "", 1, 1 },
                    { 5, (byte)1, new DateTime(2024, 3, 19, 20, 54, 47, 731, DateTimeKind.Local).AddTicks(9662), new DateTime(2024, 3, 19, 20, 54, 47, 731, DateTimeKind.Local).AddTicks(9662), "", 4, "City", 0, "/BasicCulture/CityPage", 1, 1 },
                    { 6, (byte)1, new DateTime(2024, 3, 19, 20, 54, 47, 731, DateTimeKind.Local).AddTicks(9678), new DateTime(2024, 3, 19, 20, 54, 47, 731, DateTimeKind.Local).AddTicks(9679), "", 4, "State", 0, "/BasicCulture/StatePage", 1, 1 },
                    { 7, (byte)1, new DateTime(2024, 3, 19, 20, 54, 47, 731, DateTimeKind.Local).AddTicks(9692), new DateTime(2024, 3, 19, 20, 54, 47, 731, DateTimeKind.Local).AddTicks(9693), "", 4, "Country", 0, "/BasicCulture/CountryPage", 1, 1 },
                    { 8, (byte)1, new DateTime(2024, 3, 19, 20, 54, 47, 731, DateTimeKind.Local).AddTicks(9707), new DateTime(2024, 3, 19, 20, 54, 47, 731, DateTimeKind.Local).AddTicks(9708), "", 4, "Planet", 0, "/BasicCulture/PlanetPage", 1, 1 },
                    { 9, (byte)1, new DateTime(2024, 3, 19, 20, 54, 47, 731, DateTimeKind.Local).AddTicks(9722), new DateTime(2024, 3, 19, 20, 54, 47, 731, DateTimeKind.Local).AddTicks(9722), "", 4, "Sex", 0, "/BasicCulture/SexPage", 1, 1 },
                    { 10, (byte)1, new DateTime(2024, 3, 19, 20, 54, 47, 731, DateTimeKind.Local).AddTicks(9738), new DateTime(2024, 3, 19, 20, 54, 47, 731, DateTimeKind.Local).AddTicks(9738), "", 0, "CMSCore", 300, "", 1, 1 },
                    { 11, (byte)1, new DateTime(2024, 3, 19, 20, 54, 47, 731, DateTimeKind.Local).AddTicks(9752), new DateTime(2024, 3, 19, 20, 54, 47, 731, DateTimeKind.Local).AddTicks(9753), "", 10, "User", 0, "/CMSCore/UserPage", 1, 1 },
                    { 12, (byte)1, new DateTime(2024, 3, 19, 20, 54, 47, 731, DateTimeKind.Local).AddTicks(9767), new DateTime(2024, 3, 19, 20, 54, 47, 731, DateTimeKind.Local).AddTicks(9768), "", 10, "Role", 0, "/CMSCore/RolePage", 1, 1 },
                    { 13, (byte)1, new DateTime(2024, 3, 19, 20, 54, 47, 731, DateTimeKind.Local).AddTicks(9781), new DateTime(2024, 3, 19, 20, 54, 47, 731, DateTimeKind.Local).AddTicks(9782), "", 10, "Menu", 0, "/CMSCore/MenuPage", 1, 1 },
                    { 14, (byte)1, new DateTime(2024, 3, 19, 20, 54, 47, 731, DateTimeKind.Local).AddTicks(9796), new DateTime(2024, 3, 19, 20, 54, 47, 731, DateTimeKind.Local).AddTicks(9797), "", 10, "Permission", 0, "/CMSCore/Permission", 1, 1 },
                    { 15, (byte)1, new DateTime(2024, 3, 19, 20, 54, 47, 731, DateTimeKind.Local).AddTicks(9812), new DateTime(2024, 3, 19, 20, 54, 47, 731, DateTimeKind.Local).AddTicks(9812), "", 0, "FiyiRequirements", 0, "", 1, 1 },
                    { 16, (byte)1, new DateTime(2024, 3, 19, 20, 54, 47, 731, DateTimeKind.Local).AddTicks(9826), new DateTime(2024, 3, 19, 20, 54, 47, 731, DateTimeKind.Local).AddTicks(9826), "", 15, "BlogPost", 0, "/FiyiRequirements/BlogPostPage", 1, 1 },
                    { 17, (byte)1, new DateTime(2024, 3, 19, 20, 54, 47, 731, DateTimeKind.Local).AddTicks(9840), new DateTime(2024, 3, 19, 20, 54, 47, 731, DateTimeKind.Local).AddTicks(9840), "", 15, "Perfil", 0, "/FiyiRequirements/UserProfilePage", 1, 1 },
                    { 18, (byte)1, new DateTime(2024, 3, 19, 20, 54, 47, 731, DateTimeKind.Local).AddTicks(9855), new DateTime(2024, 3, 19, 20, 54, 47, 731, DateTimeKind.Local).AddTicks(9856), "", 15, "Agenda", 0, "/FiyiRequirements/AgendaPage", 1, 1 },
                    { 19, (byte)1, new DateTime(2024, 3, 19, 20, 54, 47, 731, DateTimeKind.Local).AddTicks(9870), new DateTime(2024, 3, 19, 20, 54, 47, 731, DateTimeKind.Local).AddTicks(9870), "", 15, "CarouselTemasDeInteres", 0, "/FiyiRequirements/CarouselTemasDeInteresPage", 1, 1 },
                    { 20, (byte)1, new DateTime(2024, 3, 19, 20, 54, 47, 731, DateTimeKind.Local).AddTicks(9884), new DateTime(2024, 3, 19, 20, 54, 47, 731, DateTimeKind.Local).AddTicks(9885), "", 15, "MarketplaceServices", 0, "/FiyiRequirements/MarketplacePostServicePage", 1, 1 },
                    { 21, (byte)1, new DateTime(2024, 3, 19, 20, 54, 47, 731, DateTimeKind.Local).AddTicks(9899), new DateTime(2024, 3, 19, 20, 54, 47, 731, DateTimeKind.Local).AddTicks(9900), "", 15, "Estadisticas", 0, "/Estadisticas", 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "RoleId", "Active", "DateTimeCreation", "DateTimeLastModification", "Name", "UserCreationId", "UserLastModificationId" },
                values: new object[,]
                {
                    { 1, (byte)1, new DateTime(2024, 3, 19, 20, 54, 47, 731, DateTimeKind.Local).AddTicks(9520), new DateTime(2024, 3, 19, 20, 54, 47, 731, DateTimeKind.Local).AddTicks(9521), "Root", 1, 1 },
                    { 2, (byte)1, new DateTime(2024, 3, 19, 20, 54, 47, 731, DateTimeKind.Local).AddTicks(9565), new DateTime(2024, 3, 19, 20, 54, 47, 731, DateTimeKind.Local).AddTicks(9566), "Administrator", 1, 1 },
                    { 3, (byte)1, new DateTime(2024, 3, 19, 20, 54, 47, 731, DateTimeKind.Local).AddTicks(9580), new DateTime(2024, 3, 19, 20, 54, 47, 731, DateTimeKind.Local).AddTicks(9580), "Client", 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "RoleMenu",
                columns: new[] { "RoleMenuId", "MenuId", "RoleId" },
                values: new object[,]
                {
                    { 1, 10, 1 },
                    { 2, 14, 1 }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "Active", "DateTimeCreation", "DateTimeLastModification", "Email", "Password", "RoleId", "UserCreationId", "UserLastModificationId" },
                values: new object[,]
                {
                    { 1, (byte)1, new DateTime(2024, 3, 19, 20, 54, 47, 731, DateTimeKind.Local).AddTicks(9394), new DateTime(2024, 3, 19, 20, 54, 47, 731, DateTimeKind.Local).AddTicks(9405), "novillo.matias1@gmail.com", "Pq5FM4q7dDtlZBGcn0w8P0XjnEPDlTCcLUY5/bWVcuVJ4/kXRyHp62hPgry0R/ur+kEspHc+HK6XqqvA8OLXLw==", 1, 1, 1 },
                    { 2, (byte)1, new DateTime(2024, 3, 19, 20, 54, 47, 731, DateTimeKind.Local).AddTicks(9436), new DateTime(2024, 3, 19, 20, 54, 47, 731, DateTimeKind.Local).AddTicks(9437), "kalebem83@gmail.com", "Pq5FM4q7dDtlZBGcn0w8P0XjnEPDlTCcLUY5/bWVcuVJ4/kXRyHp62hPgry0R/ur+kEspHc+HK6XqqvA8OLXLw==", 2, 1, 1 },
                    { 3, (byte)1, new DateTime(2024, 3, 19, 20, 54, 47, 731, DateTimeKind.Local).AddTicks(9454), new DateTime(2024, 3, 19, 20, 54, 47, 731, DateTimeKind.Local).AddTicks(9454), "carlos.e.gariglio@gmail.com", "Pq5FM4q7dDtlZBGcn0w8P0XjnEPDlTCcLUY5/bWVcuVJ4/kXRyHp62hPgry0R/ur+kEspHc+HK6XqqvA8OLXLw==", 2, 1, 1 },
                    { 4, (byte)1, new DateTime(2024, 3, 19, 20, 54, 47, 731, DateTimeKind.Local).AddTicks(9471), new DateTime(2024, 3, 19, 20, 54, 47, 731, DateTimeKind.Local).AddTicks(9471), "martinlermer@hotmail.com", "Pq5FM4q7dDtlZBGcn0w8P0XjnEPDlTCcLUY5/bWVcuVJ4/kXRyHp62hPgry0R/ur+kEspHc+HK6XqqvA8OLXLw==", 2, 1, 1 },
                    { 5, (byte)1, new DateTime(2024, 3, 19, 20, 54, 47, 731, DateTimeKind.Local).AddTicks(9487), new DateTime(2024, 3, 19, 20, 54, 47, 731, DateTimeKind.Local).AddTicks(9487), "paolalocucion@yahoo.com.ar", "Pq5FM4q7dDtlZBGcn0w8P0XjnEPDlTCcLUY5/bWVcuVJ4/kXRyHp62hPgry0R/ur+kEspHc+HK6XqqvA8OLXLw==", 2, 1, 1 },
                    { 6, (byte)1, new DateTime(2024, 3, 19, 20, 54, 47, 731, DateTimeKind.Local).AddTicks(9504), new DateTime(2024, 3, 19, 20, 54, 47, 731, DateTimeKind.Local).AddTicks(9505), "sinapsiscom@gmail.com", "Pq5FM4q7dDtlZBGcn0w8P0XjnEPDlTCcLUY5/bWVcuVJ4/kXRyHp62hPgry0R/ur+kEspHc+HK6XqqvA8OLXLw==", 2, 1, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Failure");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "Parameter");

            migrationBuilder.DropTable(
                name: "Requirement");

            migrationBuilder.DropTable(
                name: "RequirementChangehistory");

            migrationBuilder.DropTable(
                name: "RequirementFile");

            migrationBuilder.DropTable(
                name: "RequirementNote");

            migrationBuilder.DropTable(
                name: "RequirementPriority");

            migrationBuilder.DropTable(
                name: "RequirementState");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "RoleMenu");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
