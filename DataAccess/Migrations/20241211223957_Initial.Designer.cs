﻿// <auto-generated />

using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess
{
    [DbContext(typeof(FifaContext))]
    [Migration("20241211223957_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("FifaCards.Models.FifaCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("FifaCards.Models.Skills", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CardId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Defence")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Dribling")
                        .HasColumnType("INTEGER");

                    b.Property<int>("HeadGame")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Overall")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Pace")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Pas")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Shoot")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CardId")
                        .IsUnique();

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("FifaCards.Models.Skills", b =>
                {
                    b.HasOne("FifaCards.Models.FifaCard", "Card")
                        .WithOne("Skills")
                        .HasForeignKey("FifaCards.Models.Skills", "CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Card");
                });

            modelBuilder.Entity("FifaCards.Models.FifaCard", b =>
                {
                    b.Navigation("Skills");
                });
#pragma warning restore 612, 618
        }
    }
}
