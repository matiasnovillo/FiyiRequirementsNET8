using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FiyiRequirements.Migrations
{
    /// <inheritdoc />
    public partial class CLS1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agenda",
                columns: table => new
                {
                    AgendaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    DateTimeCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateTimeLastModification = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserCreationId = table.Column<int>(type: "int", nullable: false),
                    UserLastModificationId = table.Column<int>(type: "int", nullable: false),
                    EventName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTimeOfEvent = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddressEvent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventImage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agenda", x => x.AgendaId);
                });

            migrationBuilder.CreateTable(
                name: "BlogPost",
                columns: table => new
                {
                    BlogPostId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<byte>(type: "tinyint", nullable: false),
                    DateTimeCreation = table.Column<DateTime>(type: "datetime", nullable: false),
                    DateTimeLastModification = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserCreationId = table.Column<int>(type: "int", nullable: false),
                    UserLastModificationId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "varchar(200)", nullable: false),
                    Subtitle = table.Column<string>(type: "varchar(200)", nullable: false),
                    ImageURL = table.Column<string>(type: "varchar(MAX)", nullable: false),
                    NumberOfLikes = table.Column<int>(type: "int", nullable: false),
                    NumberOfComments = table.Column<int>(type: "int", nullable: false),
                    Tags = table.Column<string>(type: "varchar(8000)", nullable: false),
                    MainTopic = table.Column<string>(type: "varchar(200)", nullable: false),
                    Topic = table.Column<string>(type: "varchar(200)", nullable: false),
                    Body = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPost", x => x.BlogPostId);
                });

            migrationBuilder.CreateTable(
                name: "CarouselTemasDeInteres",
                columns: table => new
                {
                    CarouselTemasDeInteresId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<byte>(type: "tinyint", nullable: false),
                    DateTimeCreation = table.Column<DateTime>(type: "datetime", nullable: false),
                    DateTimeLastModification = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserCreationId = table.Column<int>(type: "int", nullable: false),
                    UserLastModificationId = table.Column<int>(type: "int", nullable: false),
                    ImageSlide1 = table.Column<string>(type: "varchar(MAX)", nullable: false),
                    LinkSlide1 = table.Column<string>(type: "varchar(8000)", nullable: false),
                    ImageSlide2 = table.Column<string>(type: "varchar(MAX)", nullable: false),
                    LinkSlide2 = table.Column<string>(type: "varchar(8000)", nullable: false),
                    ImageSlide3 = table.Column<string>(type: "varchar(MAX)", nullable: false),
                    LinkSlide3 = table.Column<string>(type: "varchar(8000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarouselTemasDeInteres", x => x.CarouselTemasDeInteresId);
                });

            migrationBuilder.CreateTable(
                name: "EstadisticaPaginasMasVisitadas",
                columns: table => new
                {
                    EstadisticaPaginasMasVisitadasId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<byte>(type: "tinyint", nullable: false),
                    DateTimeCreation = table.Column<DateTime>(type: "datetime", nullable: false),
                    DateTimeLastModification = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserCreationId = table.Column<int>(type: "int", nullable: false),
                    UserLastModificationId = table.Column<int>(type: "int", nullable: false),
                    PageName = table.Column<string>(type: "varchar(500)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadisticaPaginasMasVisitadas", x => x.EstadisticaPaginasMasVisitadasId);
                });

            migrationBuilder.CreateTable(
                name: "EstadisticaPostsMasVisitados",
                columns: table => new
                {
                    EstadisticaPostsMasVisitadosId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<byte>(type: "tinyint", nullable: false),
                    DateTimeCreation = table.Column<DateTime>(type: "datetime", nullable: false),
                    DateTimeLastModification = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserCreationId = table.Column<int>(type: "int", nullable: false),
                    UserLastModificationId = table.Column<int>(type: "int", nullable: false),
                    BlogPostId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadisticaPostsMasVisitados", x => x.EstadisticaPostsMasVisitadosId);
                });

            migrationBuilder.CreateTable(
                name: "EstadisticaServiciosMasVisitados",
                columns: table => new
                {
                    EstadisticaServiciosMasVisitadosId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<byte>(type: "tinyint", nullable: false),
                    DateTimeCreation = table.Column<DateTime>(type: "datetime", nullable: false),
                    DateTimeLastModification = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserCreationId = table.Column<int>(type: "int", nullable: false),
                    UserLastModificationId = table.Column<int>(type: "int", nullable: false),
                    MarketPlacePostServiceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadisticaServiciosMasVisitados", x => x.EstadisticaServiciosMasVisitadosId);
                });

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
                name: "MarketPlacePostService",
                columns: table => new
                {
                    MarketPlacePostServiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<byte>(type: "tinyint", nullable: false),
                    DateTimeCreation = table.Column<DateTime>(type: "datetime", nullable: false),
                    DateTimeLastModification = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserCreationId = table.Column<int>(type: "int", nullable: false),
                    UserLastModificationId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "varchar(250)", nullable: false),
                    Price = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    ServiceDescription = table.Column<string>(type: "text", nullable: true),
                    MainZone = table.Column<string>(type: "varchar(500)", nullable: false),
                    Zone = table.Column<string>(type: "varchar(500)", nullable: true),
                    MainCategory = table.Column<string>(type: "varchar(500)", nullable: true),
                    Category = table.Column<string>(type: "varchar(500)", nullable: true),
                    PointOfServicePositive = table.Column<int>(type: "int", nullable: false),
                    PointOfServiceNegative = table.Column<int>(type: "int", nullable: false),
                    NumberOfLikes = table.Column<int>(type: "int", nullable: false),
                    NumberOfComments = table.Column<int>(type: "int", nullable: false),
                    ImageURL = table.Column<string>(type: "varchar(MAX)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarketPlacePostService", x => x.MarketPlacePostServiceId);
                });

            migrationBuilder.CreateTable(
                name: "MarketPlacePostServiceComment",
                columns: table => new
                {
                    MarketPlacePostServiceCommentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<byte>(type: "tinyint", nullable: false),
                    DateTimeCreation = table.Column<DateTime>(type: "datetime", nullable: false),
                    DateTimeLastModification = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserCreationId = table.Column<int>(type: "int", nullable: false),
                    UserLastModificationId = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarketPlacePostServiceComment", x => x.MarketPlacePostServiceCommentId);
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
                name: "PostThumbsUpAndDown",
                columns: table => new
                {
                    PostThumbsUpAndDownId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<byte>(type: "tinyint", nullable: false),
                    DateTimeCreation = table.Column<DateTime>(type: "datetime", nullable: false),
                    DateTimeLastModification = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserCreationId = table.Column<int>(type: "int", nullable: false),
                    UserLastModificationId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    MarketplacePostServiceId = table.Column<int>(type: "int", nullable: false),
                    ThumbsUpOrDown = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostThumbsUpAndDown", x => x.PostThumbsUpAndDownId);
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
                name: "TituloYSubtituloParaTemasDeInteres",
                columns: table => new
                {
                    TituloYSubtituloParaTemasDeInteresId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<byte>(type: "tinyint", nullable: false),
                    DateTimeCreation = table.Column<DateTime>(type: "datetime", nullable: false),
                    DateTimeLastModification = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserCreationId = table.Column<int>(type: "int", nullable: false),
                    UserLastModificationId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "varchar(200)", nullable: false),
                    Subtitle = table.Column<string>(type: "varchar(3000)", nullable: false),
                    MainTopic = table.Column<string>(type: "varchar(200)", nullable: false),
                    Topic = table.Column<string>(type: "varchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TituloYSubtituloParaTemasDeInteres", x => x.TituloYSubtituloParaTemasDeInteresId);
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

            migrationBuilder.CreateTable(
                name: "UserProfile",
                columns: table => new
                {
                    UserProfileId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<byte>(type: "tinyint", nullable: false),
                    DateTimeCreation = table.Column<DateTime>(type: "datetime", nullable: false),
                    DateTimeLastModification = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserCreationId = table.Column<int>(type: "int", nullable: false),
                    UserLastModificationId = table.Column<int>(type: "int", nullable: false),
                    FullName = table.Column<string>(type: "varchar(500)", nullable: true),
                    Sex = table.Column<int>(type: "int", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    City = table.Column<string>(type: "varchar(800)", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "varchar(200)", nullable: true),
                    ProfileInformation = table.Column<string>(type: "text", nullable: true),
                    IsSubscriptedToMensualNews = table.Column<byte>(type: "tinyint", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    JobTitle = table.Column<string>(type: "varchar(100)", nullable: true),
                    ProfileImage = table.Column<string>(type: "varchar(MAX)", nullable: false),
                    PointTrustService = table.Column<int>(type: "int", nullable: false),
                    PointProfileCompletion = table.Column<int>(type: "int", nullable: false),
                    MainZone = table.Column<string>(type: "varchar(500)", nullable: true),
                    Zone = table.Column<string>(type: "varchar(500)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfile", x => x.UserProfileId);
                });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "MenuId", "Active", "DateTimeCreation", "DateTimeLastModification", "IconURLPath", "MenuFatherId", "Name", "Order", "URLPath", "UserCreationId", "UserLastModificationId" },
                values: new object[,]
                {
                    { 1, (byte)1, new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8553), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8554), "", 0, "BasicCore", 100, "", 1, 1 },
                    { 2, (byte)1, new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8571), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8572), "", 1, "Failure", 0, "/BasicCore/FailurePage", 1, 1 },
                    { 3, (byte)1, new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8585), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8585), "", 1, "Parameter", 0, "/BasicCore/ParameterPage", 1, 1 },
                    { 4, (byte)1, new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8598), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8598), "", 0, "BasicCulture", 200, "", 1, 1 },
                    { 5, (byte)1, new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8611), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8612), "", 4, "City", 0, "/BasicCulture/CityPage", 1, 1 },
                    { 6, (byte)1, new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8625), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8626), "", 4, "State", 0, "/BasicCulture/StatePage", 1, 1 },
                    { 7, (byte)1, new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8639), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8640), "", 4, "Country", 0, "/BasicCulture/CountryPage", 1, 1 },
                    { 8, (byte)1, new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8652), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8653), "", 4, "Planet", 0, "/BasicCulture/PlanetPage", 1, 1 },
                    { 9, (byte)1, new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8665), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8666), "", 4, "Sex", 0, "/BasicCulture/SexPage", 1, 1 },
                    { 10, (byte)1, new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8680), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8681), "", 0, "CMSCore", 300, "", 1, 1 },
                    { 11, (byte)1, new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8693), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8694), "", 10, "User", 0, "/CMSCore/UserPage", 1, 1 },
                    { 12, (byte)1, new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8706), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8707), "", 10, "Role", 0, "/CMSCore/RolePage", 1, 1 },
                    { 13, (byte)1, new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8719), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8720), "", 10, "Menu", 0, "/CMSCore/MenuPage", 1, 1 },
                    { 14, (byte)1, new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8732), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8733), "", 10, "Permission", 0, "/CMSCore/Permission", 1, 1 },
                    { 15, (byte)1, new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8745), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8746), "", 0, "FiyiRequirements", 0, "", 1, 1 },
                    { 16, (byte)1, new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8758), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8759), "", 15, "BlogPost", 0, "/FiyiRequirements/BlogPostPage", 1, 1 },
                    { 17, (byte)1, new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8772), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8772), "", 15, "Perfil", 0, "/FiyiRequirements/UserProfilePage", 1, 1 },
                    { 18, (byte)1, new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8814), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8814), "", 15, "Agenda", 0, "/FiyiRequirements/AgendaPage", 1, 1 },
                    { 19, (byte)1, new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8827), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8827), "", 15, "TitulosYSubtitulos", 0, "/FiyiRequirements/TituloYSubtituloParaTemasDeInteresPage", 1, 1 },
                    { 20, (byte)1, new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8840), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8840), "", 15, "CarouselTemasDeInteres", 0, "/FiyiRequirements/CarouselTemasDeInteresPage", 1, 1 },
                    { 21, (byte)1, new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8853), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8853), "", 15, "MarketplaceServices", 0, "/FiyiRequirements/MarketplacePostServicePage", 1, 1 },
                    { 22, (byte)1, new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8867), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8867), "", 15, "Estadisticas", 0, "/Estadisticas", 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "RoleId", "Active", "DateTimeCreation", "DateTimeLastModification", "Name", "UserCreationId", "UserLastModificationId" },
                values: new object[,]
                {
                    { 1, (byte)1, new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8441), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8441), "Root", 1, 1 },
                    { 2, (byte)1, new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8457), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8458), "Administrator", 1, 1 },
                    { 3, (byte)1, new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8535), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8536), "Client", 1, 1 }
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
                    { 1, (byte)1, new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8267), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8277), "novillo.matias1@gmail.com", "Pq5FM4q7dDtlZBGcn0w8P0XjnEPDlTCcLUY5/bWVcuVJ4/kXRyHp62hPgry0R/ur+kEspHc+HK6XqqvA8OLXLw==", 1, 1, 1 },
                    { 2, (byte)1, new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8305), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8306), "kalebem83@gmail.com", "Pq5FM4q7dDtlZBGcn0w8P0XjnEPDlTCcLUY5/bWVcuVJ4/kXRyHp62hPgry0R/ur+kEspHc+HK6XqqvA8OLXLw==", 2, 1, 1 },
                    { 3, (byte)1, new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8348), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8349), "carlos.e.gariglio@gmail.com", "Pq5FM4q7dDtlZBGcn0w8P0XjnEPDlTCcLUY5/bWVcuVJ4/kXRyHp62hPgry0R/ur+kEspHc+HK6XqqvA8OLXLw==", 2, 1, 1 },
                    { 4, (byte)1, new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8364), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8364), "martinlermer@hotmail.com", "Pq5FM4q7dDtlZBGcn0w8P0XjnEPDlTCcLUY5/bWVcuVJ4/kXRyHp62hPgry0R/ur+kEspHc+HK6XqqvA8OLXLw==", 2, 1, 1 },
                    { 5, (byte)1, new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8378), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8378), "paolalocucion@yahoo.com.ar", "Pq5FM4q7dDtlZBGcn0w8P0XjnEPDlTCcLUY5/bWVcuVJ4/kXRyHp62hPgry0R/ur+kEspHc+HK6XqqvA8OLXLw==", 2, 1, 1 },
                    { 6, (byte)1, new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8394), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8395), "sinapsiscom@gmail.com", "Pq5FM4q7dDtlZBGcn0w8P0XjnEPDlTCcLUY5/bWVcuVJ4/kXRyHp62hPgry0R/ur+kEspHc+HK6XqqvA8OLXLw==", 2, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "UserProfile",
                columns: new[] { "UserProfileId", "Active", "Address", "BirthDate", "City", "DateTimeCreation", "DateTimeLastModification", "FullName", "IsSubscriptedToMensualNews", "JobTitle", "MainZone", "PhoneNumber", "PointProfileCompletion", "PointTrustService", "ProfileImage", "ProfileInformation", "Sex", "UserCreationId", "UserId", "UserLastModificationId", "Zone" },
                values: new object[] { 1, (byte)1, "Natania 19. Manzana 126. Casa 1", new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8417), "Cordoba Capital", new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8414), new DateTime(2024, 1, 28, 22, 50, 9, 995, DateTimeKind.Local).AddTicks(8415), "Matias Alejandro Novillo", (byte)1, "Desarrollador web", null, "+543512329541", 15, 50, "Uploads/FiyiRequirements/UserProfile/1.png", "Hola, soy Matias", 1, 1, 1, 1, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agenda");

            migrationBuilder.DropTable(
                name: "BlogPost");

            migrationBuilder.DropTable(
                name: "CarouselTemasDeInteres");

            migrationBuilder.DropTable(
                name: "EstadisticaPaginasMasVisitadas");

            migrationBuilder.DropTable(
                name: "EstadisticaPostsMasVisitados");

            migrationBuilder.DropTable(
                name: "EstadisticaServiciosMasVisitados");

            migrationBuilder.DropTable(
                name: "Failure");

            migrationBuilder.DropTable(
                name: "MarketPlacePostService");

            migrationBuilder.DropTable(
                name: "MarketPlacePostServiceComment");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "Parameter");

            migrationBuilder.DropTable(
                name: "PostThumbsUpAndDown");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "RoleMenu");

            migrationBuilder.DropTable(
                name: "TituloYSubtituloParaTemasDeInteres");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "UserProfile");
        }
    }
}
