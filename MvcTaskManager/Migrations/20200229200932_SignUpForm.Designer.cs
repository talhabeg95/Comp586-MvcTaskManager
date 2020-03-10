﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcTaskManager.Identity;

namespace MvcTaskManager.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200229200932_SignUpForm")]
    partial class SignUpForm
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityRole");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("MvcTaskManager.Identity.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<int>("CountryID");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<string>("Gender");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<bool>("ReceiveNewsLetters");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("MvcTaskManager.Models.ClientLocation", b =>
                {
                    b.Property<int>("ClientLocationID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClientLocationName");

                    b.HasKey("ClientLocationID");

                    b.ToTable("ClientLocations");

                    b.HasData(
                        new { ClientLocationID = 1, ClientLocationName = "Boston" },
                        new { ClientLocationID = 2, ClientLocationName = "New Delhi" },
                        new { ClientLocationID = 3, ClientLocationName = "New Jersy" },
                        new { ClientLocationID = 4, ClientLocationName = "New York" },
                        new { ClientLocationID = 5, ClientLocationName = "London" },
                        new { ClientLocationID = 6, ClientLocationName = "Tokyo" }
                    );
                });

            modelBuilder.Entity("MvcTaskManager.Models.Country", b =>
                {
                    b.Property<int>("CountryID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CountryName");

                    b.HasKey("CountryID");

                    b.ToTable("Countries");

                    b.HasData(
                        new { CountryID = 1, CountryName = "China" },
                        new { CountryID = 2, CountryName = "United States" },
                        new { CountryID = 3, CountryName = "Indonesia" },
                        new { CountryID = 4, CountryName = "Brazil" },
                        new { CountryID = 5, CountryName = "Pakistan" },
                        new { CountryID = 6, CountryName = "Nigeria" },
                        new { CountryID = 7, CountryName = "Bangladesh" },
                        new { CountryID = 8, CountryName = "Russia" },
                        new { CountryID = 9, CountryName = "Japan" },
                        new { CountryID = 10, CountryName = "Mexico" },
                        new { CountryID = 11, CountryName = "Philippines" },
                        new { CountryID = 12, CountryName = "Vietnam" },
                        new { CountryID = 13, CountryName = "Ethiopia" },
                        new { CountryID = 14, CountryName = "Egypt" },
                        new { CountryID = 15, CountryName = "Germany" },
                        new { CountryID = 16, CountryName = "Iran" },
                        new { CountryID = 17, CountryName = "Turkey" },
                        new { CountryID = 18, CountryName = "Democratic Republic of the Congo" },
                        new { CountryID = 19, CountryName = "Thailand" },
                        new { CountryID = 20, CountryName = "France" },
                        new { CountryID = 21, CountryName = "United Kingdom" },
                        new { CountryID = 22, CountryName = "Italy" },
                        new { CountryID = 23, CountryName = "South Africa" },
                        new { CountryID = 24, CountryName = "South Korea" },
                        new { CountryID = 25, CountryName = "Myanmar" },
                        new { CountryID = 26, CountryName = "Spain" },
                        new { CountryID = 27, CountryName = "Colombia" },
                        new { CountryID = 28, CountryName = "Ukraine" },
                        new { CountryID = 29, CountryName = "Tanzania" },
                        new { CountryID = 30, CountryName = "Argentina" },
                        new { CountryID = 31, CountryName = "Kenya" },
                        new { CountryID = 32, CountryName = "Poland" },
                        new { CountryID = 33, CountryName = "Algeria" },
                        new { CountryID = 34, CountryName = "Canada" },
                        new { CountryID = 35, CountryName = "Uganda" },
                        new { CountryID = 36, CountryName = "Iraq" },
                        new { CountryID = 37, CountryName = "Morocco" },
                        new { CountryID = 38, CountryName = "Sudan" },
                        new { CountryID = 39, CountryName = "Peru" },
                        new { CountryID = 40, CountryName = "Malaysia" },
                        new { CountryID = 41, CountryName = "Uzbekistan" },
                        new { CountryID = 42, CountryName = "Saudi Arabia" },
                        new { CountryID = 43, CountryName = "Venezuela" },
                        new { CountryID = 44, CountryName = "Nepal" },
                        new { CountryID = 45, CountryName = "Afghanistan" },
                        new { CountryID = 46, CountryName = "Ghana" },
                        new { CountryID = 47, CountryName = "Yemen" },
                        new { CountryID = 48, CountryName = "North Korea" },
                        new { CountryID = 49, CountryName = "Mozambique" },
                        new { CountryID = 50, CountryName = "Taiwan" },
                        new { CountryID = 51, CountryName = "Australia" },
                        new { CountryID = 52, CountryName = "Syria" },
                        new { CountryID = 53, CountryName = "Ivory Coast" },
                        new { CountryID = 54, CountryName = "Madagascar" },
                        new { CountryID = 55, CountryName = "Angola" },
                        new { CountryID = 56, CountryName = "Sri Lanka" },
                        new { CountryID = 57, CountryName = "Cameroon" },
                        new { CountryID = 58, CountryName = "Romania" },
                        new { CountryID = 59, CountryName = "Kazakhstan" },
                        new { CountryID = 60, CountryName = "Netherlands" },
                        new { CountryID = 61, CountryName = "Chile" },
                        new { CountryID = 62, CountryName = "Niger" },
                        new { CountryID = 63, CountryName = "Burkina Faso" },
                        new { CountryID = 64, CountryName = "Ecuador" },
                        new { CountryID = 65, CountryName = "Guatemala" },
                        new { CountryID = 66, CountryName = "Mali" },
                        new { CountryID = 67, CountryName = "Malawi" },
                        new { CountryID = 68, CountryName = "Senegal" },
                        new { CountryID = 69, CountryName = "Cambodia" },
                        new { CountryID = 70, CountryName = "Zambia" },
                        new { CountryID = 71, CountryName = "Zimbabwe" },
                        new { CountryID = 72, CountryName = "Chad" },
                        new { CountryID = 73, CountryName = "Cuba" },
                        new { CountryID = 74, CountryName = "Belgium" },
                        new { CountryID = 75, CountryName = "Guinea" },
                        new { CountryID = 76, CountryName = "Greece" },
                        new { CountryID = 77, CountryName = "Tunisia" },
                        new { CountryID = 78, CountryName = "Portugal" },
                        new { CountryID = 79, CountryName = "Rwanda" },
                        new { CountryID = 80, CountryName = "Czech Republic" },
                        new { CountryID = 81, CountryName = "Haiti" },
                        new { CountryID = 82, CountryName = "Bolivia" },
                        new { CountryID = 83, CountryName = "Somalia" },
                        new { CountryID = 84, CountryName = "Hungary" },
                        new { CountryID = 85, CountryName = "Benin" },
                        new { CountryID = 86, CountryName = "Sweden" },
                        new { CountryID = 87, CountryName = "Belarus" },
                        new { CountryID = 88, CountryName = "Dominican Republic" },
                        new { CountryID = 89, CountryName = "Azerbaijan" },
                        new { CountryID = 90, CountryName = "Austria" },
                        new { CountryID = 91, CountryName = "Honduras" },
                        new { CountryID = 92, CountryName = "United Arab Emirates" },
                        new { CountryID = 93, CountryName = "South Sudan" },
                        new { CountryID = 94, CountryName = "Burundi" },
                        new { CountryID = 95, CountryName = "Switzerland" },
                        new { CountryID = 96, CountryName = "Israel" },
                        new { CountryID = 97, CountryName = "Tajikistan" },
                        new { CountryID = 98, CountryName = "Bulgaria" },
                        new { CountryID = 99, CountryName = "Serbia" },
                        new { CountryID = 100, CountryName = "Papua New Guinea" },
                        new { CountryID = 101, CountryName = "Paraguay" },
                        new { CountryID = 102, CountryName = "Laos" },
                        new { CountryID = 103, CountryName = "Libya" },
                        new { CountryID = 104, CountryName = "Jordan" },
                        new { CountryID = 105, CountryName = "Sierra Leone" },
                        new { CountryID = 106, CountryName = "Togo" },
                        new { CountryID = 107, CountryName = "El Salvador" },
                        new { CountryID = 108, CountryName = "Nicaragua" },
                        new { CountryID = 109, CountryName = "Eritrea" },
                        new { CountryID = 110, CountryName = "Denmark" },
                        new { CountryID = 111, CountryName = "Kyrgyzstan" },
                        new { CountryID = 112, CountryName = "Slovakia" },
                        new { CountryID = 113, CountryName = "Finland" },
                        new { CountryID = 114, CountryName = "Singapore" },
                        new { CountryID = 115, CountryName = "Turkmenistan" },
                        new { CountryID = 116, CountryName = "Norway" },
                        new { CountryID = 117, CountryName = "Costa Rica" },
                        new { CountryID = 118, CountryName = "Central African Republic" },
                        new { CountryID = 119, CountryName = "Ireland" },
                        new { CountryID = 120, CountryName = "Georgia" },
                        new { CountryID = 121, CountryName = "New Zealand" },
                        new { CountryID = 122, CountryName = "Republic of the Congo" },
                        new { CountryID = 123, CountryName = "Lebanon" },
                        new { CountryID = 124, CountryName = "Palestine" },
                        new { CountryID = 125, CountryName = "Croatia" },
                        new { CountryID = 126, CountryName = "Bosnia and Herzegovina" },
                        new { CountryID = 127, CountryName = "Kuwait" },
                        new { CountryID = 128, CountryName = "Moldova" },
                        new { CountryID = 129, CountryName = "Liberia" },
                        new { CountryID = 130, CountryName = "Mauritania" },
                        new { CountryID = 131, CountryName = "Panama" },
                        new { CountryID = 132, CountryName = "Uruguay" },
                        new { CountryID = 133, CountryName = "Armenia" },
                        new { CountryID = 134, CountryName = "Lithuania" },
                        new { CountryID = 135, CountryName = "Albania" },
                        new { CountryID = 136, CountryName = "Oman" },
                        new { CountryID = 137, CountryName = "Mongolia" },
                        new { CountryID = 138, CountryName = "Jamaica" },
                        new { CountryID = 139, CountryName = "Lesotho" },
                        new { CountryID = 140, CountryName = "Namibia" },
                        new { CountryID = 141, CountryName = "Macedonia" },
                        new { CountryID = 142, CountryName = "Slovenia" },
                        new { CountryID = 143, CountryName = "Latvia" },
                        new { CountryID = 144, CountryName = "Botswana" },
                        new { CountryID = 145, CountryName = "Qatar" },
                        new { CountryID = 146, CountryName = "Gambia" },
                        new { CountryID = 147, CountryName = "Gabon" },
                        new { CountryID = 148, CountryName = "Guinea-Bissau" },
                        new { CountryID = 149, CountryName = "Trinidad and Tobago" },
                        new { CountryID = 150, CountryName = "Estonia" },
                        new { CountryID = 151, CountryName = "Mauritius" },
                        new { CountryID = 152, CountryName = "Swaziland" },
                        new { CountryID = 153, CountryName = "Bahrain" },
                        new { CountryID = 154, CountryName = "Timor-Leste" },
                        new { CountryID = 155, CountryName = "Cyprus" },
                        new { CountryID = 156, CountryName = "Fiji" },
                        new { CountryID = 157, CountryName = "Djibouti" },
                        new { CountryID = 158, CountryName = "Guyana" },
                        new { CountryID = 159, CountryName = "Equatorial Guinea" },
                        new { CountryID = 160, CountryName = "Bhutan" },
                        new { CountryID = 161, CountryName = "Comoros" },
                        new { CountryID = 162, CountryName = "Montenegro" },
                        new { CountryID = 163, CountryName = "Western Sahara" },
                        new { CountryID = 164, CountryName = "Suriname" },
                        new { CountryID = 165, CountryName = "Luxembourg" },
                        new { CountryID = 166, CountryName = "Solomon Islands" },
                        new { CountryID = 167, CountryName = "Cape Verde" },
                        new { CountryID = 168, CountryName = "Malta" },
                        new { CountryID = 169, CountryName = "Brunei" },
                        new { CountryID = 170, CountryName = "Bahamas" },
                        new { CountryID = 171, CountryName = "Maldives" },
                        new { CountryID = 172, CountryName = "Iceland" },
                        new { CountryID = 173, CountryName = "Belize" },
                        new { CountryID = 174, CountryName = "Barbados" },
                        new { CountryID = 175, CountryName = "Vanuatu" },
                        new { CountryID = 176, CountryName = "Samoa" },
                        new { CountryID = 177, CountryName = "Saint Lucia" },
                        new { CountryID = 178, CountryName = "Kiribati" },
                        new { CountryID = 179, CountryName = "Grenada" },
                        new { CountryID = 180, CountryName = "Tonga" },
                        new { CountryID = 181, CountryName = "Federated States of Micronesia" },
                        new { CountryID = 182, CountryName = "Saint Vincent and the Grenadines" },
                        new { CountryID = 183, CountryName = "Seychelles" },
                        new { CountryID = 184, CountryName = "Antigua and Barbuda" },
                        new { CountryID = 185, CountryName = "Andorra" },
                        new { CountryID = 186, CountryName = "Dominica" },
                        new { CountryID = 187, CountryName = "Liechtenstein" },
                        new { CountryID = 188, CountryName = "Monaco" },
                        new { CountryID = 189, CountryName = "San Marino" },
                        new { CountryID = 190, CountryName = "Palau" },
                        new { CountryID = 191, CountryName = "Tuvalu" },
                        new { CountryID = 192, CountryName = "Nauru" },
                        new { CountryID = 193, CountryName = "Vatican City" }
                    );
                });

            modelBuilder.Entity("MvcTaskManager.Models.Project", b =>
                {
                    b.Property<int>("ProjectID");

                    b.Property<bool>("Active");

                    b.Property<int>("ClientLocationID");

                    b.Property<DateTime>("DateOfStart");

                    b.Property<string>("ProjectName");

                    b.Property<string>("Status");

                    b.Property<int?>("TeamSize");

                    b.HasKey("ProjectID");

                    b.HasIndex("ClientLocationID");

                    b.ToTable("Projects");

                    b.HasData(
                        new { ProjectID = 1, Active = true, ClientLocationID = 2, DateOfStart = new DateTime(2017, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ProjectName = "Hospital Management System", Status = "In Force", TeamSize = 14 },
                        new { ProjectID = 2, Active = true, ClientLocationID = 1, DateOfStart = new DateTime(2018, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), ProjectName = "Reporting Tool", Status = "Support", TeamSize = 81 }
                    );
                });

            modelBuilder.Entity("MvcTaskManager.Models.Skill", b =>
                {
                    b.Property<int>("SkillID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Id");

                    b.Property<string>("SkillLevel");

                    b.Property<string>("SkillName");

                    b.HasKey("SkillID");

                    b.HasIndex("Id");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("MvcTaskManager.Identity.ApplicationRole", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityRole");


                    b.ToTable("ApplicationRole");

                    b.HasDiscriminator().HasValue("ApplicationRole");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("MvcTaskManager.Identity.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("MvcTaskManager.Identity.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MvcTaskManager.Identity.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("MvcTaskManager.Identity.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MvcTaskManager.Models.Project", b =>
                {
                    b.HasOne("MvcTaskManager.Models.ClientLocation", "ClientLocation")
                        .WithMany()
                        .HasForeignKey("ClientLocationID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MvcTaskManager.Models.Skill", b =>
                {
                    b.HasOne("MvcTaskManager.Identity.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("Id");
                });
#pragma warning restore 612, 618
        }
    }
}
