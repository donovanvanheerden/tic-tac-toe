﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TicTacToe.Infrastructure;

namespace TicTacToe.Infrastructure.Migrations
{
    [DbContext(typeof(DomainDbContext))]
    [Migration("20210429075939_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("TicTacToe.Core.Domain.Entities.Game", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasColumnName("id");

                    b.Property<string>("Cell1")
                        .HasColumnType("TEXT")
                        .HasColumnName("cell_1");

                    b.Property<string>("Cell2")
                        .HasColumnType("TEXT")
                        .HasColumnName("cell_2");

                    b.Property<string>("Cell3")
                        .HasColumnType("TEXT")
                        .HasColumnName("cell_3");

                    b.Property<string>("Cell4")
                        .HasColumnType("TEXT")
                        .HasColumnName("cell_4");

                    b.Property<string>("Cell5")
                        .HasColumnType("TEXT")
                        .HasColumnName("cell_5");

                    b.Property<string>("Cell6")
                        .HasColumnType("TEXT")
                        .HasColumnName("cell_6");

                    b.Property<string>("Cell7")
                        .HasColumnType("TEXT")
                        .HasColumnName("cell_7");

                    b.Property<string>("Cell8")
                        .HasColumnType("TEXT")
                        .HasColumnName("cell_8");

                    b.Property<string>("Cell9")
                        .HasColumnType("TEXT")
                        .HasColumnName("cell_9");

                    b.Property<string>("Player1Name")
                        .HasColumnType("TEXT")
                        .HasColumnName("player_1_name");

                    b.Property<string>("Player2Name")
                        .HasColumnType("TEXT")
                        .HasColumnName("player_2_name");

                    b.HasKey("Id");

                    b.ToTable("games");
                });
#pragma warning restore 612, 618
        }
    }
}