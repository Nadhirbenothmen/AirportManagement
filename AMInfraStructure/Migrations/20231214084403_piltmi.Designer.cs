﻿// <auto-generated />
using System;
using AMInfraStructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AMInfraStructure.Migrations
{
    [DbContext(typeof(AMContext))]
    [Migration("20231214084403_piltmi")]
    partial class piltmi
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AM.ApplicationCore.domain.Flight", b =>
                {
                    b.Property<int>("FlightId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FlightId"));

                    b.Property<string>("Airline")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Departure")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EffectiveArrival")
                        .HasColumnType("date");

                    b.Property<int>("EstimatedDuration")
                        .HasColumnType("int");

                    b.Property<DateTime>("FlightDate")
                        .HasColumnType("date");

                    b.Property<string>("Pilot")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Planefk")
                        .HasColumnType("int");

                    b.HasKey("FlightId");

                    b.HasIndex("Planefk");

                    b.ToTable("Flights");
                });

            modelBuilder.Entity("AM.ApplicationCore.domain.Passenger", b =>
                {
                    b.Property<string>("PassportNumber")
                        .HasMaxLength(7)
                        .HasColumnType("nvarchar(7)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("date");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PassportNumber");

                    b.ToTable("Passengers");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("AM.ApplicationCore.domain.Plane", b =>
                {
                    b.Property<int>("PlaneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlaneId"));

                    b.Property<int>("Capacity")
                        .HasColumnType("int")
                        .HasColumnName("PlaneCapacity");

                    b.Property<DateTime>("ManufactureDate")
                        .HasColumnType("date");

                    b.Property<int>("PlaneType")
                        .HasColumnType("int");

                    b.HasKey("PlaneId");

                    b.ToTable("Myplanes", (string)null);
                });

            modelBuilder.Entity("AM.ApplicationCore.domain.Ticket", b =>
                {
                    b.Property<int>("FlightFK")
                        .HasColumnType("int");

                    b.Property<string>("PassengerFK")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MyPassengerPassportNumber")
                        .HasColumnType("nvarchar(7)");

                    b.Property<double>("Prix")
                        .HasColumnType("float");

                    b.Property<int>("Siege")
                        .HasColumnType("int");

                    b.Property<bool>("VIP")
                        .HasColumnType("bit");

                    b.HasKey("FlightFK", "PassengerFK");

                    b.HasIndex("MyPassengerPassportNumber");

                    b.ToTable("Ticket");
                });

            modelBuilder.Entity("AM.ApplicationCore.domain.Staff", b =>
                {
                    b.HasBaseType("AM.ApplicationCore.domain.Passenger");

                    b.Property<DateTime>("EmployementDate")
                        .HasColumnType("date");

                    b.Property<string>("Function")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.ToTable("Staffs", (string)null);
                });

            modelBuilder.Entity("AM.ApplicationCore.domain.Traveller", b =>
                {
                    b.HasBaseType("AM.ApplicationCore.domain.Passenger");

                    b.Property<string>("Healthlnformation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Travellers", (string)null);
                });

            modelBuilder.Entity("AM.ApplicationCore.domain.Flight", b =>
                {
                    b.HasOne("AM.ApplicationCore.domain.Plane", "MyPlane")
                        .WithMany("ListFlight")
                        .HasForeignKey("Planefk")
                        .IsRequired();

                    b.Navigation("MyPlane");
                });

            modelBuilder.Entity("AM.ApplicationCore.domain.Passenger", b =>
                {
                    b.OwnsOne("AM.ApplicationCore.domain.FullName", "FullName", b1 =>
                        {
                            b1.Property<string>("PassengerPassportNumber")
                                .HasColumnType("nvarchar(7)");

                            b1.Property<string>("FirstName")
                                .IsRequired()
                                .HasMaxLength(30)
                                .HasColumnType("nvarchar(30)")
                                .HasColumnName("PassFirstName");

                            b1.Property<string>("LastName")
                                .IsRequired()
                                .HasMaxLength(30)
                                .HasColumnType("nvarchar(30)")
                                .HasColumnName("PassLastName");

                            b1.HasKey("PassengerPassportNumber");

                            b1.ToTable("Passengers");

                            b1.WithOwner()
                                .HasForeignKey("PassengerPassportNumber");
                        });

                    b.Navigation("FullName")
                        .IsRequired();
                });

            modelBuilder.Entity("AM.ApplicationCore.domain.Ticket", b =>
                {
                    b.HasOne("AM.ApplicationCore.domain.Flight", "MyFlight")
                        .WithMany("ListTicket")
                        .HasForeignKey("FlightFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AM.ApplicationCore.domain.Passenger", "MyPassenger")
                        .WithMany("ListTicket")
                        .HasForeignKey("MyPassengerPassportNumber");

                    b.Navigation("MyFlight");

                    b.Navigation("MyPassenger");
                });

            modelBuilder.Entity("AM.ApplicationCore.domain.Staff", b =>
                {
                    b.HasOne("AM.ApplicationCore.domain.Passenger", null)
                        .WithOne()
                        .HasForeignKey("AM.ApplicationCore.domain.Staff", "PassportNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AM.ApplicationCore.domain.Traveller", b =>
                {
                    b.HasOne("AM.ApplicationCore.domain.Passenger", null)
                        .WithOne()
                        .HasForeignKey("AM.ApplicationCore.domain.Traveller", "PassportNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AM.ApplicationCore.domain.Flight", b =>
                {
                    b.Navigation("ListTicket");
                });

            modelBuilder.Entity("AM.ApplicationCore.domain.Passenger", b =>
                {
                    b.Navigation("ListTicket");
                });

            modelBuilder.Entity("AM.ApplicationCore.domain.Plane", b =>
                {
                    b.Navigation("ListFlight");
                });
#pragma warning restore 612, 618
        }
    }
}
