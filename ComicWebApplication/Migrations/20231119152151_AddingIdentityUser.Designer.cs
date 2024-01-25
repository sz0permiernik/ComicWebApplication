﻿// <auto-generated />
using System;
using ComicWebApplication.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ComicWebApplication.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231119152151_AddingIdentityUser")]
    partial class AddingIdentityUser
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ComicWebApplication.Models.Achievement", b =>
                {
                    b.Property<int>("AchievementID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AchievementID"));

                    b.Property<string>("AchievementName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.HasKey("AchievementID");

                    b.HasIndex("UserID");

                    b.ToTable("Achievements");
                });

            modelBuilder.Entity("ComicWebApplication.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("ComicWebApplication.Models.Character", b =>
                {
                    b.Property<int>("CharacterID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CharacterID"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Superpower")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CharacterID");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("ComicWebApplication.Models.CharacterComic", b =>
                {
                    b.Property<int>("CharacterComicID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CharacterComicID"));

                    b.Property<int?>("CharacterID")
                        .HasColumnType("int");

                    b.Property<int?>("ComicID")
                        .HasColumnType("int");

                    b.HasKey("CharacterComicID");

                    b.HasIndex("CharacterID");

                    b.HasIndex("ComicID");

                    b.ToTable("CharacterComics");
                });

            modelBuilder.Entity("ComicWebApplication.Models.CharacterMovie", b =>
                {
                    b.Property<int>("CharacterMovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CharacterMovieID"));

                    b.Property<int?>("CharacterID")
                        .HasColumnType("int");

                    b.Property<int?>("MovieID")
                        .HasColumnType("int");

                    b.HasKey("CharacterMovieID");

                    b.HasIndex("CharacterID");

                    b.HasIndex("MovieID");

                    b.ToTable("CharacterMovies");
                });

            modelBuilder.Entity("ComicWebApplication.Models.CharacterReview", b =>
                {
                    b.Property<int>("ReviewID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReviewID"));

                    b.Property<int?>("CharacterID")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Rating")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ReviewDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ReviewID");

                    b.HasIndex("CharacterID");

                    b.HasIndex("UserID");

                    b.ToTable("CharacterReviews");
                });

            modelBuilder.Entity("ComicWebApplication.Models.CharacterWorld", b =>
                {
                    b.Property<int>("CharacterWorldID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CharacterWorldID"));

                    b.Property<int?>("CharacterID")
                        .HasColumnType("int");

                    b.Property<int?>("WorldID")
                        .HasColumnType("int");

                    b.HasKey("CharacterWorldID");

                    b.HasIndex("CharacterID");

                    b.HasIndex("WorldID");

                    b.ToTable("CharacterWorlds");
                });

            modelBuilder.Entity("ComicWebApplication.Models.Comic", b =>
                {
                    b.Property<int>("ComicID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ComicID"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Number")
                        .HasColumnType("int");

                    b.Property<int?>("ReleaseYear")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ComicID");

                    b.ToTable("Comics");
                });

            modelBuilder.Entity("ComicWebApplication.Models.ComicMovie", b =>
                {
                    b.Property<int>("ComicMovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ComicMovieID"));

                    b.Property<int?>("ComicID")
                        .HasColumnType("int");

                    b.Property<int?>("MovieID")
                        .HasColumnType("int");

                    b.HasKey("ComicMovieID");

                    b.HasIndex("ComicID");

                    b.HasIndex("MovieID");

                    b.ToTable("ComicMovies");
                });

            modelBuilder.Entity("ComicWebApplication.Models.ComicReview", b =>
                {
                    b.Property<int>("ReviewID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReviewID"));

                    b.Property<int?>("ComicID")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Rating")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ReviewDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ReviewID");

                    b.HasIndex("ComicID");

                    b.HasIndex("UserID");

                    b.ToTable("ComicReviews");
                });

            modelBuilder.Entity("ComicWebApplication.Models.ComicWorld", b =>
                {
                    b.Property<int>("ComicWorldID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ComicWorldID"));

                    b.Property<int?>("ComicID")
                        .HasColumnType("int");

                    b.Property<int?>("WorldID")
                        .HasColumnType("int");

                    b.HasKey("ComicWorldID");

                    b.HasIndex("ComicID");

                    b.HasIndex("WorldID");

                    b.ToTable("ComicWorlds");
                });

            modelBuilder.Entity("ComicWebApplication.Models.Movie", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MovieID"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Director")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ReleaseYear")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MovieID");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("ComicWebApplication.Models.MovieReview", b =>
                {
                    b.Property<int>("ReviewID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReviewID"));

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MovieID")
                        .HasColumnType("int");

                    b.Property<int?>("Rating")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ReviewDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ReviewID");

                    b.HasIndex("MovieID");

                    b.HasIndex("UserID");

                    b.ToTable("MovieReviews");
                });

            modelBuilder.Entity("ComicWebApplication.Models.MovieWorld", b =>
                {
                    b.Property<int>("MovieWorldID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MovieWorldID"));

                    b.Property<int?>("MovieID")
                        .HasColumnType("int");

                    b.Property<int?>("WorldID")
                        .HasColumnType("int");

                    b.HasKey("MovieWorldID");

                    b.HasIndex("MovieID");

                    b.HasIndex("WorldID");

                    b.ToTable("MovieWorlds");
                });

            modelBuilder.Entity("ComicWebApplication.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ComicWebApplication.Models.World", b =>
                {
                    b.Property<int>("WorldID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WorldID"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WorldID");

                    b.ToTable("Worlds");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ComicWebApplication.Models.Achievement", b =>
                {
                    b.HasOne("ComicWebApplication.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ComicWebApplication.Models.CharacterComic", b =>
                {
                    b.HasOne("ComicWebApplication.Models.Character", "Character")
                        .WithMany("CharacterComics")
                        .HasForeignKey("CharacterID");

                    b.HasOne("ComicWebApplication.Models.Comic", "Comic")
                        .WithMany("CharacterComics")
                        .HasForeignKey("ComicID");

                    b.Navigation("Character");

                    b.Navigation("Comic");
                });

            modelBuilder.Entity("ComicWebApplication.Models.CharacterMovie", b =>
                {
                    b.HasOne("ComicWebApplication.Models.Character", "Character")
                        .WithMany("CharacterMovies")
                        .HasForeignKey("CharacterID");

                    b.HasOne("ComicWebApplication.Models.Movie", "Movie")
                        .WithMany("CharacterMovies")
                        .HasForeignKey("MovieID");

                    b.Navigation("Character");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("ComicWebApplication.Models.CharacterReview", b =>
                {
                    b.HasOne("ComicWebApplication.Models.Character", "Character")
                        .WithMany()
                        .HasForeignKey("CharacterID");

                    b.HasOne("ComicWebApplication.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID");

                    b.Navigation("Character");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ComicWebApplication.Models.CharacterWorld", b =>
                {
                    b.HasOne("ComicWebApplication.Models.Character", "Character")
                        .WithMany("CharacterWorlds")
                        .HasForeignKey("CharacterID");

                    b.HasOne("ComicWebApplication.Models.World", "World")
                        .WithMany("CharacterWorlds")
                        .HasForeignKey("WorldID");

                    b.Navigation("Character");

                    b.Navigation("World");
                });

            modelBuilder.Entity("ComicWebApplication.Models.ComicMovie", b =>
                {
                    b.HasOne("ComicWebApplication.Models.Comic", "Comic")
                        .WithMany("ComicMovies")
                        .HasForeignKey("ComicID");

                    b.HasOne("ComicWebApplication.Models.Movie", "Movie")
                        .WithMany("ComicMovies")
                        .HasForeignKey("MovieID");

                    b.Navigation("Comic");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("ComicWebApplication.Models.ComicReview", b =>
                {
                    b.HasOne("ComicWebApplication.Models.Comic", "Comic")
                        .WithMany()
                        .HasForeignKey("ComicID");

                    b.HasOne("ComicWebApplication.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID");

                    b.Navigation("Comic");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ComicWebApplication.Models.ComicWorld", b =>
                {
                    b.HasOne("ComicWebApplication.Models.Comic", "Comic")
                        .WithMany("ComicWorlds")
                        .HasForeignKey("ComicID");

                    b.HasOne("ComicWebApplication.Models.World", "World")
                        .WithMany("ComicWorlds")
                        .HasForeignKey("WorldID");

                    b.Navigation("Comic");

                    b.Navigation("World");
                });

            modelBuilder.Entity("ComicWebApplication.Models.MovieReview", b =>
                {
                    b.HasOne("ComicWebApplication.Models.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieID");

                    b.HasOne("ComicWebApplication.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID");

                    b.Navigation("Movie");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ComicWebApplication.Models.MovieWorld", b =>
                {
                    b.HasOne("ComicWebApplication.Models.Movie", "Movie")
                        .WithMany("MovieWordls")
                        .HasForeignKey("MovieID");

                    b.HasOne("ComicWebApplication.Models.World", "World")
                        .WithMany("MovieWorlds")
                        .HasForeignKey("WorldID");

                    b.Navigation("Movie");

                    b.Navigation("World");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ComicWebApplication.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ComicWebApplication.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ComicWebApplication.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ComicWebApplication.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ComicWebApplication.Models.Character", b =>
                {
                    b.Navigation("CharacterComics");

                    b.Navigation("CharacterMovies");

                    b.Navigation("CharacterWorlds");
                });

            modelBuilder.Entity("ComicWebApplication.Models.Comic", b =>
                {
                    b.Navigation("CharacterComics");

                    b.Navigation("ComicMovies");

                    b.Navigation("ComicWorlds");
                });

            modelBuilder.Entity("ComicWebApplication.Models.Movie", b =>
                {
                    b.Navigation("CharacterMovies");

                    b.Navigation("ComicMovies");

                    b.Navigation("MovieWordls");
                });

            modelBuilder.Entity("ComicWebApplication.Models.World", b =>
                {
                    b.Navigation("CharacterWorlds");

                    b.Navigation("ComicWorlds");

                    b.Navigation("MovieWorlds");
                });
#pragma warning restore 612, 618
        }
    }
}
