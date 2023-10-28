﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ServerAPI.DbContext;

#nullable disable

namespace ServerAPI.Migrations
{
    [DbContext(typeof(PostgresContext))]
    partial class PostgresContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ServerAPI.ModelDB.Lobby", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("LobbyVisibilityId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("LobbyVisibilityId");

                    b.ToTable("Lobbies");
                });

            modelBuilder.Entity("ServerAPI.ModelDB.LobbyStaff", b =>
                {
                    b.Property<int>("LobbyId")
                        .HasColumnType("integer");

                    b.Property<int>("PlayerId")
                        .HasColumnType("integer");

                    b.HasKey("LobbyId", "PlayerId");

                    b.HasIndex("PlayerId");

                    b.ToTable("LobbyStaves");
                });

            modelBuilder.Entity("ServerAPI.ModelDB.LobbyVisibility", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("LobbyVisibilities");
                });

            modelBuilder.Entity("ServerAPI.ModelDB.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<char>("PlayerRoleId")
                        .HasColumnType("character(1)");

                    b.Property<char>("RoleId")
                        .HasColumnType("character(1)");

                    b.HasKey("Id");

                    b.HasIndex("PlayerRoleId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("ServerAPI.ModelDB.PlayerRole", b =>
                {
                    b.Property<char>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("character(1)");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<char>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("PlayerRoles");

                    b.HasData(
                        new
                        {
                            Id = 'A',
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 'H',
                            Name = "Helper"
                        },
                        new
                        {
                            Id = 'P',
                            Name = "Player"
                        });
                });

            modelBuilder.Entity("ServerAPI.ModelDB.Lobby", b =>
                {
                    b.HasOne("ServerAPI.ModelDB.LobbyVisibility", "LobbyStatus")
                        .WithMany()
                        .HasForeignKey("LobbyVisibilityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LobbyStatus");
                });

            modelBuilder.Entity("ServerAPI.ModelDB.LobbyStaff", b =>
                {
                    b.HasOne("ServerAPI.ModelDB.Lobby", "Lobby")
                        .WithMany()
                        .HasForeignKey("LobbyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ServerAPI.ModelDB.Player", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lobby");

                    b.Navigation("Player");
                });

            modelBuilder.Entity("ServerAPI.ModelDB.Player", b =>
                {
                    b.HasOne("ServerAPI.ModelDB.PlayerRole", "PlayerRole")
                        .WithMany()
                        .HasForeignKey("PlayerRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PlayerRole");
                });
#pragma warning restore 612, 618
        }
    }
}
