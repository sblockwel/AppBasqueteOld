﻿// <auto-generated />
using AppBasquete.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AppBasquete.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8");

            modelBuilder.Entity("AppBasquete.Models.Jogo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("MaximoTemporada")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MinimoTemporada")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Placar")
                        .HasColumnType("INTEGER");

                    b.Property<int>("QuebraRecordeMaximo")
                        .HasColumnType("INTEGER");

                    b.Property<int>("QuebraRecordeMinimo")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Jogos");
                });
#pragma warning restore 612, 618
        }
    }
}
