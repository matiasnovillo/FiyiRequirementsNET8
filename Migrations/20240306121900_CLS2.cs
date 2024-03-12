using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FiyiRequirements.Migrations
{
    /// <inheritdoc />
    public partial class CLS2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MarketPlacePostServiceComment");

            migrationBuilder.DropTable(
                name: "TituloYSubtituloParaTemasDeInteres");

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 22);

            migrationBuilder.DropColumn(
                name: "MainZone",
                table: "MarketPlacePostService");

            migrationBuilder.RenameColumn(
                name: "Zone",
                table: "MarketPlacePostService",
                newName: "Telefono");

            migrationBuilder.RenameColumn(
                name: "MainCategory",
                table: "MarketPlacePostService",
                newName: "Referido3Celular");

            migrationBuilder.RenameColumn(
                name: "Category",
                table: "MarketPlacePostService",
                newName: "Referido2Celular");

            migrationBuilder.AddColumn<string>(
                name: "BusinessName",
                table: "UserProfile",
                type: "varchar(1000)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FacebookURL",
                table: "UserProfile",
                type: "varchar(8000)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InstagramURL",
                table: "UserProfile",
                type: "varchar(8000)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CUIT",
                table: "MarketPlacePostService",
                type: "varchar(1000)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DomicilioComercial",
                table: "MarketPlacePostService",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DomicilioParticular",
                table: "MarketPlacePostService",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LinkDelServicio",
                table: "MarketPlacePostService",
                type: "varchar(8000)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LinkFacebook",
                table: "MarketPlacePostService",
                type: "varchar(8000)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LinkInstagram",
                table: "MarketPlacePostService",
                type: "varchar(8000)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Mail",
                table: "MarketPlacePostService",
                type: "varchar(400)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NombreComercial",
                table: "MarketPlacePostService",
                type: "varchar(800)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfVisits",
                table: "MarketPlacePostService",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Referido1Barrio",
                table: "MarketPlacePostService",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Referido1Celular",
                table: "MarketPlacePostService",
                type: "varchar(500)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Referido1Mail",
                table: "MarketPlacePostService",
                type: "varchar(400)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Referido2Barrio",
                table: "MarketPlacePostService",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Referido2Mail",
                table: "MarketPlacePostService",
                type: "varchar(400)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Referido3Barrio",
                table: "MarketPlacePostService",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Referido3Mail",
                table: "MarketPlacePostService",
                type: "varchar(400)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Agenda",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EventType",
                table: "Agenda",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LogoPatrocinador",
                table: "Agenda",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Agenda",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubEventType",
                table: "Agenda",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MarketPlacePostServiceComments",
                columns: table => new
                {
                    MarketPlacePostServiceCommentsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<byte>(type: "tinyint", nullable: false),
                    DateTimeCreation = table.Column<DateTime>(type: "datetime", nullable: false),
                    DateTimeLastModification = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserCreationId = table.Column<int>(type: "int", nullable: false),
                    UserLastModificationId = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    MarketPlacePostServiceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarketPlacePostServiceComments", x => x.MarketPlacePostServiceCommentsId);
                });

            migrationBuilder.CreateTable(
                name: "MarketPlacePostServiceMainCategory",
                columns: table => new
                {
                    MarketPlacePostServiceMainCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<byte>(type: "tinyint", nullable: false),
                    DateTimeCreation = table.Column<DateTime>(type: "datetime", nullable: false),
                    DateTimeLastModification = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserCreationId = table.Column<int>(type: "int", nullable: false),
                    UserLastModificationId = table.Column<int>(type: "int", nullable: false),
                    MainCategoryName = table.Column<string>(type: "varchar(8000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarketPlacePostServiceMainCategory", x => x.MarketPlacePostServiceMainCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "MarketPlacePostServiceMainZone",
                columns: table => new
                {
                    MarketPlacePostServiceMainZoneId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<byte>(type: "tinyint", nullable: false),
                    DateTimeCreation = table.Column<DateTime>(type: "datetime", nullable: false),
                    DateTimeLastModification = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserCreationId = table.Column<int>(type: "int", nullable: false),
                    UserLastModificationId = table.Column<int>(type: "int", nullable: false),
                    MainZoneName = table.Column<string>(type: "varchar(8000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarketPlacePostServiceMainZone", x => x.MarketPlacePostServiceMainZoneId);
                });

            migrationBuilder.CreateTable(
                name: "MarketPlacePostServiceSubCategory",
                columns: table => new
                {
                    MarketPlacePostServiceSubCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<byte>(type: "tinyint", nullable: false),
                    DateTimeCreation = table.Column<DateTime>(type: "datetime", nullable: false),
                    DateTimeLastModification = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserCreationId = table.Column<int>(type: "int", nullable: false),
                    UserLastModificationId = table.Column<int>(type: "int", nullable: false),
                    SubCategoryName = table.Column<string>(type: "varchar(8000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarketPlacePostServiceSubCategory", x => x.MarketPlacePostServiceSubCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "MarketPlacePostServiceSubZone",
                columns: table => new
                {
                    MarketPlacePostServiceSubZoneId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<byte>(type: "tinyint", nullable: false),
                    DateTimeCreation = table.Column<DateTime>(type: "datetime", nullable: false),
                    DateTimeLastModification = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserCreationId = table.Column<int>(type: "int", nullable: false),
                    UserLastModificationId = table.Column<int>(type: "int", nullable: false),
                    SubZoneName = table.Column<string>(type: "varchar(8000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarketPlacePostServiceSubZone", x => x.MarketPlacePostServiceSubZoneId);
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 1,
                columns: new[] { "DateTimeCreation", "DateTimeLastModification" },
                values: new object[] { new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8420), new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8421) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 2,
                columns: new[] { "DateTimeCreation", "DateTimeLastModification" },
                values: new object[] { new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8437), new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8438) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 3,
                columns: new[] { "DateTimeCreation", "DateTimeLastModification" },
                values: new object[] { new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8452), new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8453) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 4,
                columns: new[] { "DateTimeCreation", "DateTimeLastModification" },
                values: new object[] { new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8466), new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8466) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 5,
                columns: new[] { "DateTimeCreation", "DateTimeLastModification" },
                values: new object[] { new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8480), new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8481) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 6,
                columns: new[] { "DateTimeCreation", "DateTimeLastModification" },
                values: new object[] { new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8494), new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8495) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 7,
                columns: new[] { "DateTimeCreation", "DateTimeLastModification" },
                values: new object[] { new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8509), new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8509) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 8,
                columns: new[] { "DateTimeCreation", "DateTimeLastModification" },
                values: new object[] { new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8522), new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8523) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 9,
                columns: new[] { "DateTimeCreation", "DateTimeLastModification" },
                values: new object[] { new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8536), new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8537) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 10,
                columns: new[] { "DateTimeCreation", "DateTimeLastModification" },
                values: new object[] { new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8551), new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8552) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 11,
                columns: new[] { "DateTimeCreation", "DateTimeLastModification" },
                values: new object[] { new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8564), new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8565) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 12,
                columns: new[] { "DateTimeCreation", "DateTimeLastModification" },
                values: new object[] { new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8578), new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8579) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 13,
                columns: new[] { "DateTimeCreation", "DateTimeLastModification" },
                values: new object[] { new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8592), new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8593) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 14,
                columns: new[] { "DateTimeCreation", "DateTimeLastModification" },
                values: new object[] { new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8606), new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8606) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 15,
                columns: new[] { "DateTimeCreation", "DateTimeLastModification" },
                values: new object[] { new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8663), new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8663) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 16,
                columns: new[] { "DateTimeCreation", "DateTimeLastModification" },
                values: new object[] { new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8681), new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8682) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 17,
                columns: new[] { "DateTimeCreation", "DateTimeLastModification" },
                values: new object[] { new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8695), new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8696) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 18,
                columns: new[] { "DateTimeCreation", "DateTimeLastModification" },
                values: new object[] { new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8710), new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8711) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 19,
                columns: new[] { "DateTimeCreation", "DateTimeLastModification", "Name", "URLPath" },
                values: new object[] { new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8724), new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8724), "CarouselTemasDeInteres", "/FiyiRequirements/CarouselTemasDeInteresPage" });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 20,
                columns: new[] { "DateTimeCreation", "DateTimeLastModification", "Name", "URLPath" },
                values: new object[] { new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8738), new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8739), "MarketplaceServices", "/FiyiRequirements/MarketplacePostServicePage" });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 21,
                columns: new[] { "DateTimeCreation", "DateTimeLastModification", "Name", "URLPath" },
                values: new object[] { new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8753), new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8753), "Estadisticas", "/Estadisticas" });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: 1,
                columns: new[] { "DateTimeCreation", "DateTimeLastModification" },
                values: new object[] { new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8366), new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8367) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: 2,
                columns: new[] { "DateTimeCreation", "DateTimeLastModification" },
                values: new object[] { new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8388), new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8389) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: 3,
                columns: new[] { "DateTimeCreation", "DateTimeLastModification" },
                values: new object[] { new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8403), new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8404) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "DateTimeCreation", "DateTimeLastModification" },
                values: new object[] { new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8203), new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8217) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "DateTimeCreation", "DateTimeLastModification" },
                values: new object[] { new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8248), new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8249) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "DateTimeCreation", "DateTimeLastModification" },
                values: new object[] { new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8266), new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8267) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "DateTimeCreation", "DateTimeLastModification" },
                values: new object[] { new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8282), new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8283) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "DateTimeCreation", "DateTimeLastModification" },
                values: new object[] { new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8298), new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8299) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "DateTimeCreation", "DateTimeLastModification" },
                values: new object[] { new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8315), new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8315) });

            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "UserProfileId",
                keyValue: 1,
                columns: new[] { "BirthDate", "BusinessName", "DateTimeCreation", "DateTimeLastModification", "FacebookURL", "InstagramURL" },
                values: new object[] { new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8339), null, new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8336), new DateTime(2024, 3, 6, 9, 19, 0, 30, DateTimeKind.Local).AddTicks(8337), null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MarketPlacePostServiceComments");

            migrationBuilder.DropTable(
                name: "MarketPlacePostServiceMainCategory");

            migrationBuilder.DropTable(
                name: "MarketPlacePostServiceMainZone");

            migrationBuilder.DropTable(
                name: "MarketPlacePostServiceSubCategory");

            migrationBuilder.DropTable(
                name: "MarketPlacePostServiceSubZone");

            migrationBuilder.DropColumn(
                name: "BusinessName",
                table: "UserProfile");

            migrationBuilder.DropColumn(
                name: "FacebookURL",
                table: "UserProfile");

            migrationBuilder.DropColumn(
                name: "InstagramURL",
                table: "UserProfile");

            migrationBuilder.DropColumn(
                name: "CUIT",
                table: "MarketPlacePostService");

            migrationBuilder.DropColumn(
                name: "DomicilioComercial",
                table: "MarketPlacePostService");

            migrationBuilder.DropColumn(
                name: "DomicilioParticular",
                table: "MarketPlacePostService");

            migrationBuilder.DropColumn(
                name: "LinkDelServicio",
                table: "MarketPlacePostService");

            migrationBuilder.DropColumn(
                name: "LinkFacebook",
                table: "MarketPlacePostService");

            migrationBuilder.DropColumn(
                name: "LinkInstagram",
                table: "MarketPlacePostService");

            migrationBuilder.DropColumn(
                name: "Mail",
                table: "MarketPlacePostService");

            migrationBuilder.DropColumn(
                name: "NombreComercial",
                table: "MarketPlacePostService");

            migrationBuilder.DropColumn(
                name: "NumberOfVisits",
                table: "MarketPlacePostService");

            migrationBuilder.DropColumn(
                name: "Referido1Barrio",
                table: "MarketPlacePostService");

            migrationBuilder.DropColumn(
                name: "Referido1Celular",
                table: "MarketPlacePostService");

            migrationBuilder.DropColumn(
                name: "Referido1Mail",
                table: "MarketPlacePostService");

            migrationBuilder.DropColumn(
                name: "Referido2Barrio",
                table: "MarketPlacePostService");

            migrationBuilder.DropColumn(
                name: "Referido2Mail",
                table: "MarketPlacePostService");

            migrationBuilder.DropColumn(
                name: "Referido3Barrio",
                table: "MarketPlacePostService");

            migrationBuilder.DropColumn(
                name: "Referido3Mail",
                table: "MarketPlacePostService");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Agenda");

            migrationBuilder.DropColumn(
                name: "EventType",
                table: "Agenda");

            migrationBuilder.DropColumn(
                name: "LogoPatrocinador",
                table: "Agenda");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Agenda");

            migrationBuilder.DropColumn(
                name: "SubEventType",
                table: "Agenda");

            migrationBuilder.RenameColumn(
                name: "Telefono",
                table: "MarketPlacePostService",
                newName: "Zone");

            migrationBuilder.RenameColumn(
                name: "Referido3Celular",
                table: "MarketPlacePostService",
                newName: "MainCategory");

            migrationBuilder.RenameColumn(
                name: "Referido2Celular",
                table: "MarketPlacePostService",
                newName: "Category");

            migrationBuilder.AddColumn<string>(
                name: "MainZone",
                table: "MarketPlacePostService",
                type: "varchar(500)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "MarketPlacePostServiceComment",
                columns: table => new
                {
                    MarketPlacePostServiceCommentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<byte>(type: "tinyint", nullable: false),
                    Comment = table.Column<string>(type: "text", nullable: true),
                    DateTimeCreation = table.Column<DateTime>(type: "datetime", nullable: false),
                    DateTimeLastModification = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserCreationId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserLastModificationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarketPlacePostServiceComment", x => x.MarketPlacePostServiceCommentId);
                });

            migrationBuilder.CreateTable(
                name: "TituloYSubtituloParaTemasDeInteres",
                columns: table => new
                {
                    TituloYSubtituloParaTemasDeInteresId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<byte>(type: "tinyint", nullable: false),
                    DateTimeCreation = table.Column<DateTime>(type: "datetime", nullable: false),
                    DateTimeLastModification = table.Column<DateTime>(type: "datetime", nullable: false),
                    MainTopic = table.Column<string>(type: "varchar(200)", nullable: false),
                    Subtitle = table.Column<string>(type: "varchar(3000)", nullable: false),
                    Title = table.Column<string>(type: "varchar(200)", nullable: false),
                    Topic = table.Column<string>(type: "varchar(200)", nullable: false),
                    UserCreationId = table.Column<int>(type: "int", nullable: false),
                    UserLastModificationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TituloYSubtituloParaTemasDeInteres", x => x.TituloYSubtituloParaTemasDeInteresId);
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 1,
                columns: new[] { "DateTimeCreation", "DateTimeLastModification" },
                values: new object[] { new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8553), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8554) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 2,
                columns: new[] { "DateTimeCreation", "DateTimeLastModification" },
                values: new object[] { new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8571), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8572) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 3,
                columns: new[] { "DateTimeCreation", "DateTimeLastModification" },
                values: new object[] { new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8585), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8585) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 4,
                columns: new[] { "DateTimeCreation", "DateTimeLastModification" },
                values: new object[] { new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8598), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8598) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 5,
                columns: new[] { "DateTimeCreation", "DateTimeLastModification" },
                values: new object[] { new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8611), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8612) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 6,
                columns: new[] { "DateTimeCreation", "DateTimeLastModification" },
                values: new object[] { new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8625), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8626) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 7,
                columns: new[] { "DateTimeCreation", "DateTimeLastModification" },
                values: new object[] { new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8639), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8640) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 8,
                columns: new[] { "DateTimeCreation", "DateTimeLastModification" },
                values: new object[] { new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8652), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8653) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 9,
                columns: new[] { "DateTimeCreation", "DateTimeLastModification" },
                values: new object[] { new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8665), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8666) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 10,
                columns: new[] { "DateTimeCreation", "DateTimeLastModification" },
                values: new object[] { new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8680), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8681) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 11,
                columns: new[] { "DateTimeCreation", "DateTimeLastModification" },
                values: new object[] { new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8693), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8694) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 12,
                columns: new[] { "DateTimeCreation", "DateTimeLastModification" },
                values: new object[] { new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8706), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8707) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 13,
                columns: new[] { "DateTimeCreation", "DateTimeLastModification" },
                values: new object[] { new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8719), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8720) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 14,
                columns: new[] { "DateTimeCreation", "DateTimeLastModification" },
                values: new object[] { new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8732), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8733) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 15,
                columns: new[] { "DateTimeCreation", "DateTimeLastModification" },
                values: new object[] { new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8745), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8746) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 16,
                columns: new[] { "DateTimeCreation", "DateTimeLastModification" },
                values: new object[] { new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8758), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8759) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 17,
                columns: new[] { "DateTimeCreation", "DateTimeLastModification" },
                values: new object[] { new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8772), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8772) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 18,
                columns: new[] { "DateTimeCreation", "DateTimeLastModification" },
                values: new object[] { new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8814), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8814) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 19,
                columns: new[] { "DateTimeCreation", "DateTimeLastModification", "Name", "URLPath" },
                values: new object[] { new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8827), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8827), "TitulosYSubtitulos", "/FiyiRequirements/TituloYSubtituloParaTemasDeInteresPage" });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 20,
                columns: new[] { "DateTimeCreation", "DateTimeLastModification", "Name", "URLPath" },
                values: new object[] { new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8840), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8840), "CarouselTemasDeInteres", "/FiyiRequirements/CarouselTemasDeInteresPage" });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuId",
                keyValue: 21,
                columns: new[] { "DateTimeCreation", "DateTimeLastModification", "Name", "URLPath" },
                values: new object[] { new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8853), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8853), "MarketplaceServices", "/FiyiRequirements/MarketplacePostServicePage" });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "MenuId", "Active", "DateTimeCreation", "DateTimeLastModification", "IconURLPath", "MenuFatherId", "Name", "Order", "URLPath", "UserCreationId", "UserLastModificationId" },
                values: new object[] { 22, (byte)1, new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8867), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8867), "", 15, "Estadisticas", 0, "/Estadisticas", 1, 1 });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: 1,
                columns: new[] { "DateTimeCreation", "DateTimeLastModification" },
                values: new object[] { new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8441), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8441) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: 2,
                columns: new[] { "DateTimeCreation", "DateTimeLastModification" },
                values: new object[] { new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8457), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8458) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: 3,
                columns: new[] { "DateTimeCreation", "DateTimeLastModification" },
                values: new object[] { new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8535), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8536) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "DateTimeCreation", "DateTimeLastModification" },
                values: new object[] { new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8267), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8277) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "DateTimeCreation", "DateTimeLastModification" },
                values: new object[] { new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8305), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8306) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "DateTimeCreation", "DateTimeLastModification" },
                values: new object[] { new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8348), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8349) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "DateTimeCreation", "DateTimeLastModification" },
                values: new object[] { new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8364), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8364) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "DateTimeCreation", "DateTimeLastModification" },
                values: new object[] { new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8378), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8378) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "DateTimeCreation", "DateTimeLastModification" },
                values: new object[] { new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8394), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8395) });

            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "UserProfileId",
                keyValue: 1,
                columns: new[] { "BirthDate", "DateTimeCreation", "DateTimeLastModification" },
                values: new object[] { new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8417), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8414), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8415) });
        }
    }
}
