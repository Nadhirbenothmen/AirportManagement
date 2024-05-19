using AM.ApplicationCore.domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMInfraStructure.Configuration
{
    public class FlightConfiguration : IEntityTypeConfiguration<Flight>
    {
        public void Configure(EntityTypeBuilder<Flight> builder)

        {
            //question 5-1:
            //builder.HasMany(f => f.ListPassenger)
            //    .WithMany(p => p.ListFlight)
            //    .UsingEntity(t => t.ToTable("MyReservations")); // configuration many to many bin flight w passenger  w ki tebda many to many nhotou usingEntity

            //question 5-2:
            builder.HasOne(f => f.MyPlane)
                .WithMany(p => p.ListFlight)
                .HasForeignKey(f => f.Planefk)
                .OnDelete(DeleteBehavior.ClientSetNull); // point de cascade besh nfasakh avion yetfaskhou les flight te7a l kol 
        }
    }
}
