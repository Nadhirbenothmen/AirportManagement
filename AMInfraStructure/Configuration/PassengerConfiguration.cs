using AM.ApplicationCore.domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMInfraStructure.Configuration
{
    public class PassengerConfiguration : IEntityTypeConfiguration<Passenger>
    {
        public void Configure(EntityTypeBuilder<Passenger> builder)
        {
            builder.OwnsOne(p => p.FullName, f =>
            {
                f.Property(full => full.FirstName).HasMaxLength(30).HasColumnName("PassFirstName");
                f.Property(full => full.LastName).HasMaxLength(30).HasColumnName("PassLastName");
                //configuration de la 1ère propriété 
            }
            );
            //fullname est une entité de type detenue et le proprietaire te3o est le classe 
            
            
    // tp5 question 1
            //builder.HasDiscriminator<string>("IsTraveller")
            //    .HasValue<Traveller>("1")
            //    .HasValue<Staff>("2")
            //    .HasValue<Passenger>("0");

            
        }
    }
}
