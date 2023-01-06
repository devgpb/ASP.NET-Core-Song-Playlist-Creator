﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MusicPlaylist.Data;

#nullable disable

namespace MusicPlaylist.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MusicPlaylist.Models.Genero", b =>
                {
                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Nome");

                    b.ToTable("Generos");
                });

            modelBuilder.Entity("MusicPlaylist.Models.Mood", b =>
                {
                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Nome");

                    b.ToTable("Moods");
                });

            modelBuilder.Entity("MusicPlaylist.Models.Musica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Autor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GeneroNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MoodNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GeneroNome");

                    b.HasIndex("MoodNome");

                    b.ToTable("Musicas");
                });

            modelBuilder.Entity("MusicPlaylist.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MusicPlaylist.Models.Musica", b =>
                {
                    b.HasOne("MusicPlaylist.Models.Genero", "Genero")
                        .WithMany("Generos")
                        .HasForeignKey("GeneroNome")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MusicPlaylist.Models.Mood", "mood")
                        .WithMany("Generos")
                        .HasForeignKey("MoodNome")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genero");

                    b.Navigation("mood");
                });

            modelBuilder.Entity("MusicPlaylist.Models.Genero", b =>
                {
                    b.Navigation("Generos");
                });

            modelBuilder.Entity("MusicPlaylist.Models.Mood", b =>
                {
                    b.Navigation("Generos");
                });
#pragma warning restore 612, 618
        }
    }
}
