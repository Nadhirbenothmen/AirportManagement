using AM.ApplicationCore.domain;
using AMInfraStructure.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMInfraStructure
{
    public class AMContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
            Initial Catalog=BenothmenNadhirDB;Integrated Security=true");
            base.OnConfiguring(optionsBuilder);
        }
     //Les TABLES // 
        public DbSet<Flight> Flights { get; set; }
     //dbset kif collection
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Plane> Planes { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Traveller> Travelers { get; set; }

    //question 6 tp4:
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PlaneConfiguration());

            //modelBuilder.Entity<Plane>().HasKey(p => p.PlaneId);
            //modelBuilder.Entity<Plane>().ToTable("MyPlanes");

            modelBuilder.ApplyConfiguration(new FlightConfiguration());
            modelBuilder.ApplyConfiguration(new PassengerConfiguration());

            modelBuilder.ApplyConfiguration(new TicketConfiguration());

    //tp5 question 2
            modelBuilder.Entity<Staff>().ToTable("Staffs");
            modelBuilder.Entity<Traveller>().ToTable("Travellers"); //mapper une entité a une table 

        }
        //Préconvention:
    //question 8 : 
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<DateTime>().HaveColumnType("date"); //kol colone DateTime type au niveu DB ywali date         }
            //configurationBuilder.Properties<String>().HaveMaxLength(20);
        }
    }
}
