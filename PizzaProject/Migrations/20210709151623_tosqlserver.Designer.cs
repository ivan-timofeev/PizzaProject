﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PizzaProject.Data;

namespace PizzaProject.Migrations
{
    [DbContext(typeof(PizzaContext))]
    [Migration("20210709151623_tosqlserver")]
    partial class tosqlserver
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PizzaProject.Models.Pizza", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PictureUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,4)");

                    b.HasKey("Id");

                    b.ToTable("PizzaList");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Большая пицца Барбекю, 35см, 630г.",
                            Name = "Пицца Барбекю",
                            PictureUrl = "/img/1.jpeg",
                            Price = 750m
                        },
                        new
                        {
                            Id = 2,
                            Description = "Большая пицца Сырная, 35см, 540г.",
                            Name = "Пицца Сырная",
                            PictureUrl = "/img/2.jpeg",
                            Price = 410m
                        },
                        new
                        {
                            Id = 3,
                            Description = "Большая пицца Пеперони, 35см, 570г.",
                            Name = "Пицца Пеперони",
                            PictureUrl = "/img/3.jpeg",
                            Price = 500m
                        },
                        new
                        {
                            Id = 4,
                            Description = "Большая пицца Ветчина и сыр, 35см, 570г.",
                            Name = "Пицца Ветчина и сыр",
                            PictureUrl = "/img/4.jpeg",
                            Price = 500m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}