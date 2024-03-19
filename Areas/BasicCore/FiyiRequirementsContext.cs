﻿using Microsoft.EntityFrameworkCore;
using FiyiRequirements.Areas.CMSCore.Entities;
using FiyiRequirements.Areas.CMSCore.Entities.EntitiesConfiguration;
using FiyiRequirements.Areas.BasicCore.Entities.EntitiesConfiguration;
using FiyiRequirements.Areas.FiyiRequirements.Entities;
using FiyiRequirements.Areas.FiyiRequirements.Entities.EntitiesConfiguration;
using FiyiRequirements.Areas.BasicCore.Entities;

namespace FiyiRequirements.Areas.BasicCore
{
    public class FiyiRequirementsContext : DbContext
    {
        protected IConfiguration _configuration { get; }

        public DbSet<User> User { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<RoleMenu> RoleMenu { get; set; }
        public DbSet<Failure> Failure { get; set; }
        public DbSet<Parameter> Parameter { get; set; }

        //FiyiRequirements
        public DbSet<Requirement> Requirement { get; set; }
        public DbSet<RequirementChangehistory> RequirementChangehistory { get; set; }
        public DbSet<RequirementFile> RequirementFile { get; set; }
        public DbSet<RequirementNote> RequirementNote { get; set; }
        public DbSet<RequirementPriority> RequirementPriority { get; set; }
        public DbSet<RequirementState> RequirementState { get; set; }

        public FiyiRequirementsContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try
            {
                string ConnectionStringDevelopment = "data source =.; " +
                    "initial catalog = FiyiRequirements; " +
                    "Integrated Security = SSPI;" +
                    " MultipleActiveResultSets=True;" +
                    "Pooling=false;" +
                    "Persist Security Info=True;" +
                    "App=EntityFramework;" +
                    "TrustServerCertificate=True;";

                string IP = "192.168.28.14";
                string Server = "www4.baehost.com";

                string ConnectionStringProduction = "Password=5wn9IyD)t3ZL-4;" +
                    "Persist Security Info=True;" +
                    "User ID=fiyista1_Admin;" +
                    "Initial Catalog=fiyista1_FiyiRequirements;" +
                    "Data Source=www4.baehost.com;" +
                    "TrustServerCertificate=True";

                optionsBuilder
                    .UseSqlServer(ConnectionStringDevelopment);
            }
            catch (Exception) { throw; }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            try
            {
                modelBuilder.ApplyConfiguration(new UserConfiguration());
                modelBuilder.ApplyConfiguration(new RoleConfiguration());
                modelBuilder.ApplyConfiguration(new MenuConfiguration());
                modelBuilder.ApplyConfiguration(new RoleMenuConfiguration());
                modelBuilder.ApplyConfiguration(new FailureConfiguration());
                modelBuilder.ApplyConfiguration(new ParameterConfiguration());

                //FiyiRequirements
                modelBuilder.ApplyConfiguration(new RequirementConfiguration());
                modelBuilder.ApplyConfiguration(new RequirementChangehistoryConfiguration());
                modelBuilder.ApplyConfiguration(new RequirementFileConfiguration());
                modelBuilder.ApplyConfiguration(new RequirementNoteConfiguration());
                modelBuilder.ApplyConfiguration(new RequirementPriorityConfiguration());
                modelBuilder.ApplyConfiguration(new RequirementStateConfiguration());

                #region User
                modelBuilder.Entity<User>().HasData(new User
                {
                    UserId = 1,
                    Email = "novillo.matias1@gmail.com",
                    Password = "Pq5FM4q7dDtlZBGcn0w8P0XjnEPDlTCcLUY5/bWVcuVJ4/kXRyHp62hPgry0R/ur+kEspHc+HK6XqqvA8OLXLw==",
                    RoleId = 1,
                    Active = true,
                    DateTimeCreation = DateTime.Now,
                    DateTimeLastModification = DateTime.Now,
                    UserCreationId = 1,
                    UserLastModificationId = 1
                });

                modelBuilder.Entity<User>().HasData(new User
                {
                    UserId = 2,
                    Email = "kalebem83@gmail.com",
                    Password = "Pq5FM4q7dDtlZBGcn0w8P0XjnEPDlTCcLUY5/bWVcuVJ4/kXRyHp62hPgry0R/ur+kEspHc+HK6XqqvA8OLXLw==",
                    RoleId = 2,
                    Active = true,
                    DateTimeCreation = DateTime.Now,
                    DateTimeLastModification = DateTime.Now,
                    UserCreationId = 1,
                    UserLastModificationId = 1
                });

                modelBuilder.Entity<User>().HasData(new User
                {
                    UserId = 3,
                    Email = "carlos.e.gariglio@gmail.com",
                    Password = "Pq5FM4q7dDtlZBGcn0w8P0XjnEPDlTCcLUY5/bWVcuVJ4/kXRyHp62hPgry0R/ur+kEspHc+HK6XqqvA8OLXLw==",
                    RoleId = 2,
                    Active = true,
                    DateTimeCreation = DateTime.Now,
                    DateTimeLastModification = DateTime.Now,
                    UserCreationId = 1,
                    UserLastModificationId = 1
                });

                modelBuilder.Entity<User>().HasData(new User
                {
                    UserId = 4,
                    Email = "martinlermer@hotmail.com",
                    Password = "Pq5FM4q7dDtlZBGcn0w8P0XjnEPDlTCcLUY5/bWVcuVJ4/kXRyHp62hPgry0R/ur+kEspHc+HK6XqqvA8OLXLw==",
                    RoleId = 2,
                    Active = true,
                    DateTimeCreation = DateTime.Now,
                    DateTimeLastModification = DateTime.Now,
                    UserCreationId = 1,
                    UserLastModificationId = 1
                });

                modelBuilder.Entity<User>().HasData(new User
                {
                    UserId = 5,
                    Email = "paolalocucion@yahoo.com.ar",
                    Password = "Pq5FM4q7dDtlZBGcn0w8P0XjnEPDlTCcLUY5/bWVcuVJ4/kXRyHp62hPgry0R/ur+kEspHc+HK6XqqvA8OLXLw==",
                    RoleId = 2,
                    Active = true,
                    DateTimeCreation = DateTime.Now,
                    DateTimeLastModification = DateTime.Now,
                    UserCreationId = 1,
                    UserLastModificationId = 1
                });

                modelBuilder.Entity<User>().HasData(new User
                {
                    UserId = 6,
                    Email = "sinapsiscom@gmail.com",
                    Password = "Pq5FM4q7dDtlZBGcn0w8P0XjnEPDlTCcLUY5/bWVcuVJ4/kXRyHp62hPgry0R/ur+kEspHc+HK6XqqvA8OLXLw==",
                    RoleId = 2,
                    Active = true,
                    DateTimeCreation = DateTime.Now,
                    DateTimeLastModification = DateTime.Now,
                    UserCreationId = 1,
                    UserLastModificationId = 1
                });
                #endregion

                modelBuilder.Entity<Role>().HasData(new Role
                {
                    RoleId = 1,
                    Name = "Root",
                    Active = true,
                    DateTimeCreation = DateTime.Now,
                    DateTimeLastModification = DateTime.Now,
                    UserCreationId = 1,
                    UserLastModificationId = 1
                });

                modelBuilder.Entity<Role>().HasData(new Role
                {
                    RoleId = 2,
                    Name = "Administrator",
                    Active = true,
                    DateTimeCreation = DateTime.Now,
                    DateTimeLastModification = DateTime.Now,
                    UserCreationId = 1,
                    UserLastModificationId = 1
                });

                modelBuilder.Entity<Role>().HasData(new Role
                {
                    RoleId = 3,
                    Name = "Client",
                    Active = true,
                    DateTimeCreation = DateTime.Now,
                    DateTimeLastModification = DateTime.Now,
                    UserCreationId = 1,
                    UserLastModificationId = 1
                });

                #region Menu
                modelBuilder.Entity<Menu>().HasData(new Menu
                {
                    MenuId = 1,
                    Name = "BasicCore",
                    MenuFatherId = 0,
                    Order = 100,
                    URLPath = "",
                    IconURLPath = "",
                    Active = true,
                    DateTimeCreation = DateTime.Now,
                    DateTimeLastModification = DateTime.Now,
                    UserCreationId = 1,
                    UserLastModificationId = 1
                });

                modelBuilder.Entity<Menu>().HasData(new Menu
                {
                    MenuId = 2,
                    Name = "Failure",
                    MenuFatherId = 1,
                    Order = 0,
                    URLPath = "/BasicCore/FailurePage",
                    IconURLPath = "",
                    Active = true,
                    DateTimeCreation = DateTime.Now,
                    DateTimeLastModification = DateTime.Now,
                    UserCreationId = 1,
                    UserLastModificationId = 1
                });

                modelBuilder.Entity<Menu>().HasData(new Menu
                {
                    MenuId = 3,
                    Name = "Parameter",
                    MenuFatherId = 1,
                    Order = 0,
                    URLPath = "/BasicCore/ParameterPage",
                    IconURLPath = "",
                    Active = true,
                    DateTimeCreation = DateTime.Now,
                    DateTimeLastModification = DateTime.Now,
                    UserCreationId = 1,
                    UserLastModificationId = 1
                });

                modelBuilder.Entity<Menu>().HasData(new Menu
                {
                    MenuId = 4,
                    Name = "BasicCulture",
                    MenuFatherId = 0,
                    Order = 200,
                    URLPath = "",
                    IconURLPath = "",
                    Active = true,
                    DateTimeCreation = DateTime.Now,
                    DateTimeLastModification = DateTime.Now,
                    UserCreationId = 1,
                    UserLastModificationId = 1
                });

                modelBuilder.Entity<Menu>().HasData(new Menu
                {
                    MenuId = 5,
                    Name = "City",
                    MenuFatherId = 4,
                    Order = 0,
                    URLPath = "/BasicCulture/CityPage",
                    IconURLPath = "",
                    Active = true,
                    DateTimeCreation = DateTime.Now,
                    DateTimeLastModification = DateTime.Now,
                    UserCreationId = 1,
                    UserLastModificationId = 1
                });

                modelBuilder.Entity<Menu>().HasData(new Menu
                {
                    MenuId = 6,
                    Name = "State",
                    MenuFatherId = 4,
                    Order = 0,
                    URLPath = "/BasicCulture/StatePage",
                    IconURLPath = "",
                    Active = true,
                    DateTimeCreation = DateTime.Now,
                    DateTimeLastModification = DateTime.Now,
                    UserCreationId = 1,
                    UserLastModificationId = 1
                });

                modelBuilder.Entity<Menu>().HasData(new Menu
                {
                    MenuId = 7,
                    Name = "Country",
                    MenuFatherId = 4,
                    Order = 0,
                    URLPath = "/BasicCulture/CountryPage",
                    IconURLPath = "",
                    Active = true,
                    DateTimeCreation = DateTime.Now,
                    DateTimeLastModification = DateTime.Now,
                    UserCreationId = 1,
                    UserLastModificationId = 1
                });

                modelBuilder.Entity<Menu>().HasData(new Menu
                {
                    MenuId = 8,
                    Name = "Planet",
                    MenuFatherId = 4,
                    Order = 0,
                    URLPath = "/BasicCulture/PlanetPage",
                    IconURLPath = "",
                    Active = true,
                    DateTimeCreation = DateTime.Now,
                    DateTimeLastModification = DateTime.Now,
                    UserCreationId = 1,
                    UserLastModificationId = 1
                });

                modelBuilder.Entity<Menu>().HasData(new Menu
                {
                    MenuId = 9,
                    Name = "Sex",
                    MenuFatherId = 4,
                    Order = 0,
                    URLPath = "/BasicCulture/SexPage",
                    IconURLPath = "",
                    Active = true,
                    DateTimeCreation = DateTime.Now,
                    DateTimeLastModification = DateTime.Now,
                    UserCreationId = 1,
                    UserLastModificationId = 1
                });

                modelBuilder.Entity<Menu>().HasData(new Menu
                {
                    MenuId = 10,
                    Name = "CMSCore",
                    MenuFatherId = 0,
                    Order = 300,
                    URLPath = "",
                    IconURLPath = "",
                    Active = true,
                    DateTimeCreation = DateTime.Now,
                    DateTimeLastModification = DateTime.Now,
                    UserCreationId = 1,
                    UserLastModificationId = 1
                });

                modelBuilder.Entity<Menu>().HasData(new Menu
                {
                    MenuId = 11,
                    Name = "User",
                    MenuFatherId = 10,
                    Order = 0,
                    URLPath = "/CMSCore/UserPage",
                    IconURLPath = "",
                    Active = true,
                    DateTimeCreation = DateTime.Now,
                    DateTimeLastModification = DateTime.Now,
                    UserCreationId = 1,
                    UserLastModificationId = 1
                });

                modelBuilder.Entity<Menu>().HasData(new Menu
                {
                    MenuId = 12,
                    Name = "Role",
                    MenuFatherId = 10,
                    Order = 0,
                    URLPath = "/CMSCore/RolePage",
                    IconURLPath = "",
                    Active = true,
                    DateTimeCreation = DateTime.Now,
                    DateTimeLastModification = DateTime.Now,
                    UserCreationId = 1,
                    UserLastModificationId = 1
                });

                modelBuilder.Entity<Menu>().HasData(new Menu
                {
                    MenuId = 13,
                    Name = "Menu",
                    MenuFatherId = 10,
                    Order = 0,
                    URLPath = "/CMSCore/MenuPage",
                    IconURLPath = "",
                    Active = true,
                    DateTimeCreation = DateTime.Now,
                    DateTimeLastModification = DateTime.Now,
                    UserCreationId = 1,
                    UserLastModificationId = 1
                });

                modelBuilder.Entity<Menu>().HasData(new Menu
                {
                    MenuId = 14,
                    Name = "Permission",
                    MenuFatherId = 10,
                    Order = 0,
                    URLPath = "/CMSCore/Permission",
                    IconURLPath = "",
                    Active = true,
                    DateTimeCreation = DateTime.Now,
                    DateTimeLastModification = DateTime.Now,
                    UserCreationId = 1,
                    UserLastModificationId = 1
                });

                modelBuilder.Entity<Menu>().HasData(new Menu
                {
                    MenuId = 15,
                    Name = "FiyiRequirements",
                    MenuFatherId = 0,
                    Order = 0,
                    URLPath = "",
                    IconURLPath = "",
                    Active = true,
                    DateTimeCreation = DateTime.Now,
                    DateTimeLastModification = DateTime.Now,
                    UserCreationId = 1,
                    UserLastModificationId = 1
                });

                modelBuilder.Entity<Menu>().HasData(new Menu
                {
                    MenuId = 16,
                    Name = "BlogPost",
                    MenuFatherId = 15,
                    Order = 0,
                    URLPath = "/FiyiRequirements/BlogPostPage",
                    IconURLPath = "",
                    Active = true,
                    DateTimeCreation = DateTime.Now,
                    DateTimeLastModification = DateTime.Now,
                    UserCreationId = 1,
                    UserLastModificationId = 1
                });

                modelBuilder.Entity<Menu>().HasData(new Menu
                {
                    MenuId = 17,
                    Name = "Perfil",
                    MenuFatherId = 15,
                    Order = 0,
                    URLPath = "/FiyiRequirements/UserProfilePage",
                    IconURLPath = "",
                    Active = true,
                    DateTimeCreation = DateTime.Now,
                    DateTimeLastModification = DateTime.Now,
                    UserCreationId = 1,
                    UserLastModificationId = 1
                });

                modelBuilder.Entity<Menu>().HasData(new Menu
                {
                    MenuId = 18,
                    Name = "Agenda",
                    MenuFatherId = 15,
                    Order = 0,
                    URLPath = "/FiyiRequirements/AgendaPage",
                    IconURLPath = "",
                    Active = true,
                    DateTimeCreation = DateTime.Now,
                    DateTimeLastModification = DateTime.Now,
                    UserCreationId = 1,
                    UserLastModificationId = 1
                });

                modelBuilder.Entity<Menu>().HasData(new Menu
                {
                    MenuId = 19,
                    Name = "CarouselTemasDeInteres",
                    MenuFatherId = 15,
                    Order = 0,
                    URLPath = "/FiyiRequirements/CarouselTemasDeInteresPage",
                    IconURLPath = "",
                    Active = true,
                    DateTimeCreation = DateTime.Now,
                    DateTimeLastModification = DateTime.Now,
                    UserCreationId = 1,
                    UserLastModificationId = 1
                });

                modelBuilder.Entity<Menu>().HasData(new Menu
                {
                    MenuId = 20,
                    Name = "MarketplaceServices",
                    MenuFatherId = 15,
                    Order = 0,
                    URLPath = "/FiyiRequirements/MarketplacePostServicePage",
                    IconURLPath = "",
                    Active = true,
                    DateTimeCreation = DateTime.Now,
                    DateTimeLastModification = DateTime.Now,
                    UserCreationId = 1,
                    UserLastModificationId = 1
                });

                modelBuilder.Entity<Menu>().HasData(new Menu
                {
                    MenuId = 21,
                    Name = "Estadisticas",
                    MenuFatherId = 15,
                    Order = 0,
                    URLPath = "/Estadisticas",
                    IconURLPath = "",
                    Active = true,
                    DateTimeCreation = DateTime.Now,
                    DateTimeLastModification = DateTime.Now,
                    UserCreationId = 1,
                    UserLastModificationId = 1
                });
                #endregion

                #region RoleMenu (Permission)
                modelBuilder.Entity<RoleMenu>().HasData(new RoleMenu
                {
                    RoleMenuId = 1,
                    RoleId = 1,
                    MenuId = 10
                });

                modelBuilder.Entity<RoleMenu>().HasData(new RoleMenu
                {
                    RoleMenuId = 2,
                    RoleId = 1,
                    MenuId = 14
                });
                #endregion
            }
            catch (Exception) { throw; }
        }
    }
}
