﻿// <auto-generated />
using GameX.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace GameX.Migrations
{
    [DbContext(typeof(StoreContext))]
    [Migration("20180615181242_discipline")]
    partial class discipline
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GameX.Models.Disciplines", b =>
                {
                    b.Property<int>("DieciplineId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("DieciplineId");

                    b.ToTable("Disciplines");
                });

            modelBuilder.Entity("GameX.Models.EventAdress", b =>
                {
                    b.Property<int>("EventAdressId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<string>("HouseNumber")
                        .IsRequired();

                    b.Property<double>("Lat");

                    b.Property<double>("Lng");

                    b.Property<string>("PostCode")
                        .IsRequired();

                    b.Property<string>("Street")
                        .IsRequired();

                    b.HasKey("EventAdressId");

                    b.ToTable("EventAdress");
                });

            modelBuilder.Entity("GameX.Models.EventParticipants", b =>
                {
                    b.Property<int>("EventParticipantsID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EventID");

                    b.Property<int>("UserID");

                    b.HasKey("EventParticipantsID");

                    b.HasIndex("EventID");

                    b.HasIndex("UserID");

                    b.ToTable("EventParticipants");
                });

            modelBuilder.Entity("GameX.Models.Events", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Coords");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description");

                    b.Property<int>("DisciplineId");

                    b.Property<int>("EventAdressId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("EventId");

                    b.HasIndex("EventAdressId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("GameX.Models.Users", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("Surname")
                        .IsRequired();

                    b.Property<string>("Username")
                        .IsRequired();

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("GameX.Models.EventParticipants", b =>
                {
                    b.HasOne("GameX.Models.Events", "Events")
                        .WithMany()
                        .HasForeignKey("EventID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GameX.Models.Users", "Users")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GameX.Models.Events", b =>
                {
                    b.HasOne("GameX.Models.EventAdress", "EventAdress")
                        .WithMany()
                        .HasForeignKey("EventAdressId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
