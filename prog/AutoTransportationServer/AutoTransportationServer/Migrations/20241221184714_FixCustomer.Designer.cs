﻿// <auto-generated />
using System;
using AutoTransportationServer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AutoTransportationServer.Migrations
{
    [DbContext(typeof(TransportationDbContext))]
    [Migration("20241221184714_FixCustomer")]
    partial class FixCustomer
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("AutoTransportationServer.Models.Admin", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("PersonId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Admins");

                    b.HasData(
                        new
                        {
                            Id = new Guid("541c91a0-de54-45e8-a1f0-12c7ceb4796a"),
                            PersonId = new Guid("00000000-0000-0000-0000-000000000001")
                        });
                });

            modelBuilder.Entity("AutoTransportationServer.Models.Auto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("MaxFuel")
                        .HasColumnType("double");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Autos");
                });

            modelBuilder.Entity("AutoTransportationServer.Models.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("PersonId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("AutoTransportationServer.Models.Driver", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid>("AutoId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("AutoId");

                    b.ToTable("Drivers");
                });

            modelBuilder.Entity("AutoTransportationServer.Models.Fuel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Fuel");
                });

            modelBuilder.Entity("AutoTransportationServer.Models.Person", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Persons");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000001"),
                            Address = "",
                            Email = "",
                            Login = "admin",
                            Name = "Admin",
                            Password = "admin",
                            Phone = "",
                            Surname = "Admin"
                        });
                });

            modelBuilder.Entity("AutoTransportationServer.Models.Transportation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("char(36)");

                    b.Property<int>("Distance")
                        .HasColumnType("int");

                    b.Property<Guid>("DriverId")
                        .HasColumnType("char(36)");

                    b.Property<string>("From")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid>("FuelId")
                        .HasColumnType("char(36)");

                    b.Property<double>("FuelVolume")
                        .HasColumnType("double");

                    b.Property<string>("To")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("DriverId");

                    b.HasIndex("FuelId");

                    b.ToTable("Transportations");
                });

            modelBuilder.Entity("AutoTransportationServer.Models.Admin", b =>
                {
                    b.HasOne("AutoTransportationServer.Models.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("AutoTransportationServer.Models.Customer", b =>
                {
                    b.HasOne("AutoTransportationServer.Models.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("AutoTransportationServer.Models.Driver", b =>
                {
                    b.HasOne("AutoTransportationServer.Models.Auto", "Auto")
                        .WithMany("Drivers")
                        .HasForeignKey("AutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Auto");
                });

            modelBuilder.Entity("AutoTransportationServer.Models.Transportation", b =>
                {
                    b.HasOne("AutoTransportationServer.Models.Customer", "Customer")
                        .WithMany("Transportations")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AutoTransportationServer.Models.Driver", "Driver")
                        .WithMany()
                        .HasForeignKey("DriverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AutoTransportationServer.Models.Fuel", "Fuel")
                        .WithMany()
                        .HasForeignKey("FuelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Driver");

                    b.Navigation("Fuel");
                });

            modelBuilder.Entity("AutoTransportationServer.Models.Auto", b =>
                {
                    b.Navigation("Drivers");
                });

            modelBuilder.Entity("AutoTransportationServer.Models.Customer", b =>
                {
                    b.Navigation("Transportations");
                });
#pragma warning restore 612, 618
        }
    }
}
