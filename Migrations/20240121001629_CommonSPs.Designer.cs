﻿// <auto-generated />
using System;
using FiyiRequirements.Areas.BasicCore.Entities.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FiyiRequirements.Migrations
{
    [DbContext(typeof(EFCoreContext))]
    [Migration("20240121001629_CommonSPs")]
    partial class CommonSPs
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FiyiRequirements.Areas.BasicCore.Entities.Failure", b =>
                {
                    b.Property<int>("FailureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FailureId"));

                    b.Property<byte>("Active")
                        .HasColumnType("tinyint");

                    b.Property<string>("Comment")
                        .HasColumnType("text");

                    b.Property<DateTime>("DateTimeCreation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateTimeLastModification")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmergencyLevel")
                        .HasColumnType("int");

                    b.Property<string>("Message")
                        .HasColumnType("text");

                    b.Property<string>("Source")
                        .HasColumnType("text");

                    b.Property<string>("StackTrace")
                        .HasColumnType("text");

                    b.Property<int>("UserCreationId")
                        .HasColumnType("int");

                    b.Property<int>("UserLastModificationId")
                        .HasColumnType("int");

                    b.HasKey("FailureId");

                    b.ToTable("Failure");
                });

            modelBuilder.Entity("FiyiRequirements.Areas.BasicCore.Entities.Parameter", b =>
                {
                    b.Property<int>("ParameterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ParameterId"));

                    b.Property<byte>("Active")
                        .HasColumnType("tinyint");

                    b.Property<DateTime>("DateTimeCreation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateTimeLastModification")
                        .HasColumnType("datetime2");

                    b.Property<byte>("IsPrivate")
                        .HasColumnType("tinyint");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(200)");

                    b.Property<int>("UserCreationId")
                        .HasColumnType("int");

                    b.Property<int>("UserLastModificationId")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("ParameterId");

                    b.ToTable("Parameter");
                });

            modelBuilder.Entity("FiyiRequirements.Areas.CMSCore.Entities.Menu", b =>
                {
                    b.Property<int>("MenuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MenuId"));

                    b.Property<byte>("Active")
                        .HasColumnType("tinyint");

                    b.Property<DateTime>("DateTimeCreation")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("DateTimeLastModification")
                        .HasColumnType("datetime");

                    b.Property<string>("IconURLPath")
                        .HasColumnType("varchar(8000)");

                    b.Property<int>("MenuFatherId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(200)");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<string>("URLPath")
                        .HasColumnType("varchar(8000)");

                    b.Property<int>("UserCreationId")
                        .HasColumnType("int");

                    b.Property<int>("UserLastModificationId")
                        .HasColumnType("int");

                    b.HasKey("MenuId");

                    b.ToTable("Menu");

                    b.HasData(
                        new
                        {
                            MenuId = 1,
                            Active = (byte)1,
                            DateTimeCreation = new DateTime(2024, 1, 20, 21, 16, 29, 13, DateTimeKind.Local).AddTicks(7339),
                            DateTimeLastModification = new DateTime(2024, 1, 20, 21, 16, 29, 13, DateTimeKind.Local).AddTicks(7339),
                            IconURLPath = "",
                            MenuFatherId = 0,
                            Name = "BasicCore",
                            Order = 100,
                            URLPath = "",
                            UserCreationId = 1,
                            UserLastModificationId = 1
                        },
                        new
                        {
                            MenuId = 2,
                            Active = (byte)1,
                            DateTimeCreation = new DateTime(2024, 1, 20, 21, 16, 29, 13, DateTimeKind.Local).AddTicks(7356),
                            DateTimeLastModification = new DateTime(2024, 1, 20, 21, 16, 29, 13, DateTimeKind.Local).AddTicks(7356),
                            IconURLPath = "",
                            MenuFatherId = 1,
                            Name = "Failure",
                            Order = 0,
                            URLPath = "/BasicCore/FailurePage",
                            UserCreationId = 1,
                            UserLastModificationId = 1
                        },
                        new
                        {
                            MenuId = 3,
                            Active = (byte)1,
                            DateTimeCreation = new DateTime(2024, 1, 20, 21, 16, 29, 13, DateTimeKind.Local).AddTicks(7371),
                            DateTimeLastModification = new DateTime(2024, 1, 20, 21, 16, 29, 13, DateTimeKind.Local).AddTicks(7371),
                            IconURLPath = "",
                            MenuFatherId = 1,
                            Name = "Parameter",
                            Order = 0,
                            URLPath = "/BasicCore/ParameterPage",
                            UserCreationId = 1,
                            UserLastModificationId = 1
                        },
                        new
                        {
                            MenuId = 4,
                            Active = (byte)1,
                            DateTimeCreation = new DateTime(2024, 1, 20, 21, 16, 29, 13, DateTimeKind.Local).AddTicks(7385),
                            DateTimeLastModification = new DateTime(2024, 1, 20, 21, 16, 29, 13, DateTimeKind.Local).AddTicks(7386),
                            IconURLPath = "",
                            MenuFatherId = 0,
                            Name = "BasicCulture",
                            Order = 200,
                            URLPath = "",
                            UserCreationId = 1,
                            UserLastModificationId = 1
                        },
                        new
                        {
                            MenuId = 5,
                            Active = (byte)1,
                            DateTimeCreation = new DateTime(2024, 1, 20, 21, 16, 29, 13, DateTimeKind.Local).AddTicks(7399),
                            DateTimeLastModification = new DateTime(2024, 1, 20, 21, 16, 29, 13, DateTimeKind.Local).AddTicks(7399),
                            IconURLPath = "",
                            MenuFatherId = 4,
                            Name = "City",
                            Order = 0,
                            URLPath = "/BasicCulture/CityPage",
                            UserCreationId = 1,
                            UserLastModificationId = 1
                        },
                        new
                        {
                            MenuId = 6,
                            Active = (byte)1,
                            DateTimeCreation = new DateTime(2024, 1, 20, 21, 16, 29, 13, DateTimeKind.Local).AddTicks(7445),
                            DateTimeLastModification = new DateTime(2024, 1, 20, 21, 16, 29, 13, DateTimeKind.Local).AddTicks(7445),
                            IconURLPath = "",
                            MenuFatherId = 4,
                            Name = "State",
                            Order = 0,
                            URLPath = "/BasicCulture/StatePage",
                            UserCreationId = 1,
                            UserLastModificationId = 1
                        },
                        new
                        {
                            MenuId = 7,
                            Active = (byte)1,
                            DateTimeCreation = new DateTime(2024, 1, 20, 21, 16, 29, 13, DateTimeKind.Local).AddTicks(7461),
                            DateTimeLastModification = new DateTime(2024, 1, 20, 21, 16, 29, 13, DateTimeKind.Local).AddTicks(7462),
                            IconURLPath = "",
                            MenuFatherId = 4,
                            Name = "Country",
                            Order = 0,
                            URLPath = "/BasicCulture/CountryPage",
                            UserCreationId = 1,
                            UserLastModificationId = 1
                        },
                        new
                        {
                            MenuId = 8,
                            Active = (byte)1,
                            DateTimeCreation = new DateTime(2024, 1, 20, 21, 16, 29, 13, DateTimeKind.Local).AddTicks(7474),
                            DateTimeLastModification = new DateTime(2024, 1, 20, 21, 16, 29, 13, DateTimeKind.Local).AddTicks(7475),
                            IconURLPath = "",
                            MenuFatherId = 4,
                            Name = "Planet",
                            Order = 0,
                            URLPath = "/BasicCulture/PlanetPage",
                            UserCreationId = 1,
                            UserLastModificationId = 1
                        },
                        new
                        {
                            MenuId = 9,
                            Active = (byte)1,
                            DateTimeCreation = new DateTime(2024, 1, 20, 21, 16, 29, 13, DateTimeKind.Local).AddTicks(7488),
                            DateTimeLastModification = new DateTime(2024, 1, 20, 21, 16, 29, 13, DateTimeKind.Local).AddTicks(7488),
                            IconURLPath = "",
                            MenuFatherId = 4,
                            Name = "Sex",
                            Order = 0,
                            URLPath = "/BasicCulture/SexPage",
                            UserCreationId = 1,
                            UserLastModificationId = 1
                        },
                        new
                        {
                            MenuId = 10,
                            Active = (byte)1,
                            DateTimeCreation = new DateTime(2024, 1, 20, 21, 16, 29, 13, DateTimeKind.Local).AddTicks(7504),
                            DateTimeLastModification = new DateTime(2024, 1, 20, 21, 16, 29, 13, DateTimeKind.Local).AddTicks(7504),
                            IconURLPath = "",
                            MenuFatherId = 0,
                            Name = "CMSCore",
                            Order = 300,
                            URLPath = "",
                            UserCreationId = 1,
                            UserLastModificationId = 1
                        },
                        new
                        {
                            MenuId = 11,
                            Active = (byte)1,
                            DateTimeCreation = new DateTime(2024, 1, 20, 21, 16, 29, 13, DateTimeKind.Local).AddTicks(7517),
                            DateTimeLastModification = new DateTime(2024, 1, 20, 21, 16, 29, 13, DateTimeKind.Local).AddTicks(7518),
                            IconURLPath = "",
                            MenuFatherId = 10,
                            Name = "User",
                            Order = 0,
                            URLPath = "/CMSCore/UserPage",
                            UserCreationId = 1,
                            UserLastModificationId = 1
                        },
                        new
                        {
                            MenuId = 12,
                            Active = (byte)1,
                            DateTimeCreation = new DateTime(2024, 1, 20, 21, 16, 29, 13, DateTimeKind.Local).AddTicks(7531),
                            DateTimeLastModification = new DateTime(2024, 1, 20, 21, 16, 29, 13, DateTimeKind.Local).AddTicks(7531),
                            IconURLPath = "",
                            MenuFatherId = 10,
                            Name = "Role",
                            Order = 0,
                            URLPath = "/CMSCore/RolePage",
                            UserCreationId = 1,
                            UserLastModificationId = 1
                        },
                        new
                        {
                            MenuId = 13,
                            Active = (byte)1,
                            DateTimeCreation = new DateTime(2024, 1, 20, 21, 16, 29, 13, DateTimeKind.Local).AddTicks(7544),
                            DateTimeLastModification = new DateTime(2024, 1, 20, 21, 16, 29, 13, DateTimeKind.Local).AddTicks(7544),
                            IconURLPath = "",
                            MenuFatherId = 10,
                            Name = "Menu",
                            Order = 0,
                            URLPath = "/CMSCore/MenuPage",
                            UserCreationId = 1,
                            UserLastModificationId = 1
                        },
                        new
                        {
                            MenuId = 14,
                            Active = (byte)1,
                            DateTimeCreation = new DateTime(2024, 1, 20, 21, 16, 29, 13, DateTimeKind.Local).AddTicks(7558),
                            DateTimeLastModification = new DateTime(2024, 1, 20, 21, 16, 29, 13, DateTimeKind.Local).AddTicks(7558),
                            IconURLPath = "",
                            MenuFatherId = 10,
                            Name = "Permission",
                            Order = 0,
                            URLPath = "/CMSCore/Permission",
                            UserCreationId = 1,
                            UserLastModificationId = 1
                        },
                        new
                        {
                            MenuId = 15,
                            Active = (byte)1,
                            DateTimeCreation = new DateTime(2024, 1, 20, 21, 16, 29, 13, DateTimeKind.Local).AddTicks(7571),
                            DateTimeLastModification = new DateTime(2024, 1, 20, 21, 16, 29, 13, DateTimeKind.Local).AddTicks(7572),
                            IconURLPath = "",
                            MenuFatherId = 0,
                            Name = "FiyiRequirements",
                            Order = 0,
                            URLPath = "",
                            UserCreationId = 1,
                            UserLastModificationId = 1
                        },
                        new
                        {
                            MenuId = 16,
                            Active = (byte)1,
                            DateTimeCreation = new DateTime(2024, 1, 20, 21, 16, 29, 13, DateTimeKind.Local).AddTicks(7585),
                            DateTimeLastModification = new DateTime(2024, 1, 20, 21, 16, 29, 13, DateTimeKind.Local).AddTicks(7585),
                            IconURLPath = "",
                            MenuFatherId = 15,
                            Name = "BlogPost",
                            Order = 0,
                            URLPath = "/FiyiRequirements/BlogPostPage",
                            UserCreationId = 1,
                            UserLastModificationId = 1
                        },
                        new
                        {
                            MenuId = 17,
                            Active = (byte)1,
                            DateTimeCreation = new DateTime(2024, 1, 20, 21, 16, 29, 13, DateTimeKind.Local).AddTicks(7598),
                            DateTimeLastModification = new DateTime(2024, 1, 20, 21, 16, 29, 13, DateTimeKind.Local).AddTicks(7598),
                            IconURLPath = "",
                            MenuFatherId = 15,
                            Name = "Perfil",
                            Order = 0,
                            URLPath = "/FiyiRequirements/UserProfilePage",
                            UserCreationId = 1,
                            UserLastModificationId = 1
                        },
                        new
                        {
                            MenuId = 18,
                            Active = (byte)1,
                            DateTimeCreation = new DateTime(2024, 1, 20, 21, 16, 29, 13, DateTimeKind.Local).AddTicks(7613),
                            DateTimeLastModification = new DateTime(2024, 1, 20, 21, 16, 29, 13, DateTimeKind.Local).AddTicks(7613),
                            IconURLPath = "",
                            MenuFatherId = 15,
                            Name = "Agenda",
                            Order = 0,
                            URLPath = "/FiyiRequirements/AgendaPage",
                            UserCreationId = 1,
                            UserLastModificationId = 1
                        },
                        new
                        {
                            MenuId = 19,
                            Active = (byte)1,
                            DateTimeCreation = new DateTime(2024, 1, 20, 21, 16, 29, 13, DateTimeKind.Local).AddTicks(7626),
                            DateTimeLastModification = new DateTime(2024, 1, 20, 21, 16, 29, 13, DateTimeKind.Local).AddTicks(7627),
                            IconURLPath = "",
                            MenuFatherId = 15,
                            Name = "TitulosYSubtitulos",
                            Order = 0,
                            URLPath = "/FiyiRequirements/TituloYSubtituloParaTemasDeInteresPage",
                            UserCreationId = 1,
                            UserLastModificationId = 1
                        });
                });

            modelBuilder.Entity("FiyiRequirements.Areas.CMSCore.Entities.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"));

                    b.Property<byte>("Active")
                        .HasColumnType("tinyint");

                    b.Property<DateTime>("DateTimeCreation")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("DateTimeLastModification")
                        .HasColumnType("datetime");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(100)");

                    b.Property<int>("UserCreationId")
                        .HasColumnType("int");

                    b.Property<int>("UserLastModificationId")
                        .HasColumnType("int");

                    b.HasKey("RoleId");

                    b.ToTable("Role");

                    b.HasData(
                        new
                        {
                            RoleId = 1,
                            Active = (byte)1,
                            DateTimeCreation = new DateTime(2024, 1, 20, 21, 16, 29, 13, DateTimeKind.Local).AddTicks(7294),
                            DateTimeLastModification = new DateTime(2024, 1, 20, 21, 16, 29, 13, DateTimeKind.Local).AddTicks(7294),
                            Name = "Root",
                            UserCreationId = 1,
                            UserLastModificationId = 1
                        },
                        new
                        {
                            RoleId = 2,
                            Active = (byte)1,
                            DateTimeCreation = new DateTime(2024, 1, 20, 21, 16, 29, 13, DateTimeKind.Local).AddTicks(7309),
                            DateTimeLastModification = new DateTime(2024, 1, 20, 21, 16, 29, 13, DateTimeKind.Local).AddTicks(7310),
                            Name = "Administrator",
                            UserCreationId = 1,
                            UserLastModificationId = 1
                        },
                        new
                        {
                            RoleId = 3,
                            Active = (byte)1,
                            DateTimeCreation = new DateTime(2024, 1, 20, 21, 16, 29, 13, DateTimeKind.Local).AddTicks(7322),
                            DateTimeLastModification = new DateTime(2024, 1, 20, 21, 16, 29, 13, DateTimeKind.Local).AddTicks(7322),
                            Name = "Client",
                            UserCreationId = 1,
                            UserLastModificationId = 1
                        });
                });

            modelBuilder.Entity("FiyiRequirements.Areas.CMSCore.Entities.RoleMenu", b =>
                {
                    b.Property<int>("RoleMenuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleMenuId"));

                    b.Property<int>("MenuId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("RoleMenuId");

                    b.ToTable("RoleMenu");

                    b.HasData(
                        new
                        {
                            RoleMenuId = 1,
                            MenuId = 10,
                            RoleId = 1
                        },
                        new
                        {
                            RoleMenuId = 2,
                            MenuId = 14,
                            RoleId = 1
                        });
                });

            modelBuilder.Entity("FiyiRequirements.Areas.CMSCore.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<byte>("Active")
                        .HasColumnType("tinyint");

                    b.Property<DateTime>("DateTimeCreation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateTimeLastModification")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(380)");

                    b.Property<string>("Password")
                        .HasColumnType("varchar(8000)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UserCreationId")
                        .HasColumnType("int");

                    b.Property<int>("UserLastModificationId")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Active = (byte)1,
                            DateTimeCreation = new DateTime(2024, 1, 20, 21, 16, 29, 13, DateTimeKind.Local).AddTicks(7145),
                            DateTimeLastModification = new DateTime(2024, 1, 20, 21, 16, 29, 13, DateTimeKind.Local).AddTicks(7155),
                            Email = "novillo.matias1@gmail.com",
                            Password = "Pq5FM4q7dDtlZBGcn0w8P0XjnEPDlTCcLUY5/bWVcuVJ4/kXRyHp62hPgry0R/ur+kEspHc+HK6XqqvA8OLXLw==",
                            RoleId = 1,
                            UserCreationId = 1,
                            UserLastModificationId = 1
                        });
                });

            modelBuilder.Entity("FiyiRequirements.Areas.FiyiRequirements.Entities.Agenda", b =>
                {
                    b.Property<int>("AgendaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AgendaId"));

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("AddressEvent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateTimeCreation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateTimeLastModification")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateTimeOfEvent")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EventImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EventName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserCreationId")
                        .HasColumnType("int");

                    b.Property<int>("UserLastModificationId")
                        .HasColumnType("int");

                    b.HasKey("AgendaId");

                    b.ToTable("Agenda");
                });

            modelBuilder.Entity("FiyiRequirements.Areas.FiyiRequirements.Entities.BlogPost", b =>
                {
                    b.Property<int>("BlogPostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BlogPostId"));

                    b.Property<byte>("Active")
                        .HasColumnType("tinyint");

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("DateTimeCreation")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("DateTimeLastModification")
                        .HasColumnType("datetime");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("varchar(MAX)");

                    b.Property<string>("MainTopic")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<int>("NumberOfComments")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfLikes")
                        .HasColumnType("int");

                    b.Property<string>("Subtitle")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Tags")
                        .IsRequired()
                        .HasColumnType("varchar(8000)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Topic")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<int>("UserCreationId")
                        .HasColumnType("int");

                    b.Property<int>("UserLastModificationId")
                        .HasColumnType("int");

                    b.HasKey("BlogPostId");

                    b.ToTable("BlogPost");
                });

            modelBuilder.Entity("FiyiRequirements.Areas.FiyiRequirements.Entities.TituloYSubtituloParaTemasDeInteres", b =>
                {
                    b.Property<int>("TituloYSubtituloParaTemasDeInteresId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TituloYSubtituloParaTemasDeInteresId"));

                    b.Property<byte>("Active")
                        .HasColumnType("tinyint");

                    b.Property<DateTime>("DateTimeCreation")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("DateTimeLastModification")
                        .HasColumnType("datetime");

                    b.Property<string>("MainTopic")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Subtitle")
                        .IsRequired()
                        .HasColumnType("varchar(3000)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Topic")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<int>("UserCreationId")
                        .HasColumnType("int");

                    b.Property<int>("UserLastModificationId")
                        .HasColumnType("int");

                    b.HasKey("TituloYSubtituloParaTemasDeInteresId");

                    b.ToTable("TituloYSubtituloParaTemasDeInteres");
                });

            modelBuilder.Entity("FiyiRequirements.Areas.FiyiRequirements.Entities.UserProfile", b =>
                {
                    b.Property<int>("UserProfileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserProfileId"));

                    b.Property<byte>("Active")
                        .HasColumnType("tinyint");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("varchar(800)");

                    b.Property<DateTime>("DateTimeCreation")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("DateTimeLastModification")
                        .HasColumnType("datetime");

                    b.Property<string>("FullName")
                        .HasColumnType("varchar(500)");

                    b.Property<byte>("IsSubscriptedToMensualNews")
                        .HasColumnType("tinyint");

                    b.Property<string>("JobTitle")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("varchar(200)");

                    b.Property<int>("PointProfileCompletion")
                        .HasColumnType("int");

                    b.Property<int>("PointTrustService")
                        .HasColumnType("int");

                    b.Property<string>("ProfileImage")
                        .IsRequired()
                        .HasColumnType("varchar(MAX)");

                    b.Property<string>("ProfileInformation")
                        .HasColumnType("text");

                    b.Property<int>("Sex")
                        .HasColumnType("int");

                    b.Property<int>("UserCreationId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("UserLastModificationId")
                        .HasColumnType("int");

                    b.HasKey("UserProfileId");

                    b.ToTable("UserProfile");

                    b.HasData(
                        new
                        {
                            UserProfileId = 1,
                            Active = (byte)1,
                            Address = "Natania 19. Manzana 126. Casa 1",
                            BirthDate = new DateTime(2024, 1, 20, 21, 16, 29, 13, DateTimeKind.Local).AddTicks(7272),
                            City = "Cordoba Capital",
                            DateTimeCreation = new DateTime(2024, 1, 20, 21, 16, 29, 13, DateTimeKind.Local).AddTicks(7269),
                            DateTimeLastModification = new DateTime(2024, 1, 20, 21, 16, 29, 13, DateTimeKind.Local).AddTicks(7270),
                            FullName = "Matias Alejandro Novillo",
                            IsSubscriptedToMensualNews = (byte)1,
                            JobTitle = "Desarrollador web",
                            PhoneNumber = "+543512329541",
                            PointProfileCompletion = 15,
                            PointTrustService = 50,
                            ProfileImage = "Uploads/FiyiRequirements/UserProfile/1.png",
                            ProfileInformation = "Hola, soy Matias",
                            Sex = 1,
                            UserCreationId = 1,
                            UserId = 1,
                            UserLastModificationId = 1
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
